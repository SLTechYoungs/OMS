using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace oms_d
{
	public partial class memoWritingForm : Form
	{
		private OracleDBA oracleDBA;
		private DataRow memoDataRow;
		private omsMain oms;
		private userProfile _profile;

		public memoWritingForm(omsMain oms, DataRow content, userProfile profile)
		{
			InitializeComponent();
			this.oms = oms;
			oracleDBA = new OracleDBA();
			memoDataRow = content;
			this._profile = profile;

			if (content != null)
			{
				toolName.Text = content["USER_ID"].ToString();
				textTitle.Text = content["MEMO_TITLE"].ToString();
				textContent.Text = content["MEMO_CONTENT"].ToString();

				string formattedFirstDate = Convert.ToDateTime(memoDataRow["MEMO_FIRSTDATE"]).ToString("yyyy-MM-dd HH:mm:ss");
				string formattedLastDate = Convert.ToDateTime(memoDataRow["MEMO_LASTDATE"]).ToString("yyyy-MM-dd HH:mm:ss");
				toolFirstDate.Text = formattedFirstDate;
				toolLastDate.Text = formattedLastDate;

				string fontSize = content["MEMO_FONTSIZE"].ToString();
				string fontStyleString = content["MEMO_STYLE"].ToString();

				toolFontSize.Text = fontSize;
				toolBold.Checked = fontStyleString.Contains("Bold");
				toolItalic.Checked = fontStyleString.Contains("Italic");
				toolStrikeout.Checked = fontStyleString.Contains("Strikeout");
				toolUnderLine.Checked = fontStyleString.Contains("Underline");

				if (profile.UserID.Equals(content["USER_ID"].ToString()))
				{
					toolShareMemo.Visible = true;
					toolShareRemove.Visible = false;
				}
				else
				{
					toolShareMemo.Visible = false;
					toolShareRemove.Visible = true;
				}
			}
			else
			{
				toolFontSize.Text = "10";
				toolName.Text = profile.UserID;
				toolFirstDate.Text = "YYYY-MM-DD HH:mm:ss";
				toolLastDate.Text = "YYYY-MM-DD HH:mm:ss";
				toolShareMemo.Visible = false;
				toolShareRemove.Visible = false;
			}
		}

		private void memoWritingForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			//_profile.UserID.Equals(memoDataRow["USER_ID"])
			if (memoDataRow != null)
			{
				if (textContent.Text != "" && _profile.UserID.Equals(memoDataRow["USER_ID"]))
				{
					string formattedTimestamp = Convert.ToDateTime(memoDataRow["MEMO_FIRSTDATE"]).ToString("yyyy-MM-dd HH:mm:ss");

					// 파라미터 생성
					OracleParameter[] parameters = new OracleParameter[]
					{
					new OracleParameter("title", OracleDbType.Varchar2) { Value = textTitle.Text },
					new OracleParameter("content", OracleDbType.Clob) { Value = textContent.Text },
					new OracleParameter("style", OracleDbType.Varchar2) { Value = textContent.Font.Style.ToString() },
					new OracleParameter("fontSize", OracleDbType.BinaryFloat) { Value = textContent.Font.Size },
					new OracleParameter("userId", OracleDbType.Varchar2) { Value = memoDataRow["USER_ID"].ToString() },
					new OracleParameter("firstDate", OracleDbType.TimeStamp) { Value = Convert.ToDateTime(formattedTimestamp) }
					};

					string query = "UPDATE USER_MEMO SET MEMO_TITLE = :title, MEMO_CONTENT = :content, MEMO_STYLE = :style, MEMO_FONTSIZE = :fontSize, MEMO_LASTDATE = SYSDATE WHERE USER_ID = :userId AND MEMO_FIRSTDATE = :firstDate";
					int rowsAffected = oracleDBA.ExecuteNonQuery(query, parameters);
					if (rowsAffected == 0)
					{
						MessageBox.Show("업데이트 실패!");
						return;
					}
				}
				else if(textContent.Text == "" && _profile.UserID.Equals(memoDataRow["USER_ID"]))
				{
					string formattedTimestamp = Convert.ToDateTime(memoDataRow["MEMO_FIRSTDATE"]).ToString("yyyy-MM-dd HH:mm:ss");

					int rowsAffected = oracleDBA.ExecuteNonQuery($"DELETE FROM USER_MEMO WHERE USER_ID='{memoDataRow["USER_ID"]}' AND MEMO_FIRSTDATE = TO_DATE('{formattedTimestamp}', 'YYYY-MM-DD HH24:MI:SS')");
					if (rowsAffected == 0)
					{
						MessageBox.Show("삭제 실패!");
						return;
					}
				}
			}
			else if (textContent.Text != "")
			{
				// 파라미터 생성
				OracleParameter[] parameters = new OracleParameter[]
				{
					new OracleParameter("userId", OracleDbType.Varchar2) { Value = _profile.UserID },
					new OracleParameter("content", OracleDbType.Clob) { Value = textContent.Text },
					new OracleParameter("title", OracleDbType.Varchar2) { Value = textTitle.Text },
					new OracleParameter("style", OracleDbType.Varchar2) { Value = textContent.Font.Style.ToString() },
					new OracleParameter("fontSize", OracleDbType.BinaryFloat) { Value = textContent.Font.Size }
				};

				string query = "INSERT INTO USER_MEMO (USER_ID, MEMO_FIRSTDATE, MEMO_CONTENT, MEMO_TITLE, MEMO_STYLE, MEMO_FONTSIZE, MEMO_LASTDATE) VALUES (:userId, SYSDATE, :content, :title, :style, :fontSize, SYSDATE)";
				int rowAffected = oracleDBA.ExecuteNonQuery(query, parameters);
				if (rowAffected == 0)
				{
					MessageBox.Show("새 글 작성 실패");
					return;
				}
			}
			oms.memoListUpdate();
		}
		private FontStyle style;
		private void toolBold_CheckedChanged(object sender, EventArgs e)
		{
			// 기존 폰트 스타일을 가져옵니다.
			style = textContent.Font.Style;

			// 체크박스가 체크되었으면 볼드 스타일을 추가하고, 아니면 제거합니다.
			if (toolBold.Checked)
				style |= FontStyle.Bold;
			else
				style &= ~FontStyle.Bold;

			// 새 폰트 객체를 생성하여 텍스트 박스의 폰트로 설정합니다.
			textContent.Font = new Font(textContent.Font, style);
		}

		private void toolItalic_CheckedChanged(object sender, EventArgs e)
		{
			// 기존 폰트 스타일을 가져옵니다.
			style = textContent.Font.Style;

			// 체크박스가 체크되었으면 볼드 스타일을 추가하고, 아니면 제거합니다.
			if (toolItalic.Checked)
				style |= FontStyle.Italic;
			else
				style &= ~FontStyle.Italic;

			// 새 폰트 객체를 생성하여 텍스트 박스의 폰트로 설정합니다.
			textContent.Font = new Font(textContent.Font, style);
		}

		private void toolUnderLine_CheckedChanged(object sender, EventArgs e)
		{
			// 기존 폰트 스타일을 가져옵니다.
			style = textContent.Font.Style;

			// 체크박스가 체크되었으면 볼드 스타일을 추가하고, 아니면 제거합니다.
			if (toolUnderLine.Checked)
				style |= FontStyle.Underline;
			else
				style &= ~FontStyle.Underline;

			// 새 폰트 객체를 생성하여 텍스트 박스의 폰트로 설정합니다.
			textContent.Font = new Font(textContent.Font, style);
		}

		private void toolStrikeout_CheckedChanged(object sender, EventArgs e)
		{
			// 기존 폰트 스타일을 가져옵니다.
			style = textContent.Font.Style;

			// 체크박스가 체크되었으면 볼드 스타일을 추가하고, 아니면 제거합니다.
			if (toolStrikeout.Checked)
				style |= FontStyle.Strikeout;
			else
				style &= ~FontStyle.Strikeout;

			// 새 폰트 객체를 생성하여 텍스트 박스의 폰트로 설정합니다.
			textContent.Font = new Font(textContent.Font, style);
		}

		private void toolBold_Click(object sender, EventArgs e) =>
			toolBold.Checked = toolBold.Checked ? false : true;

		private void toolItalic_Click(object sender, EventArgs e)
		{
			toolItalic.Checked = toolItalic.Checked ? false : true;
		}

		private void toolStrikeout_Click(object sender, EventArgs e)
		{
			toolStrikeout.Checked = toolStrikeout.Checked ? false : true;
		}

		private void toolUnderLine_Click(object sender, EventArgs e)
		{
			toolUnderLine.Checked = toolUnderLine.Checked ? false : true;
		}

		private void toolFontSize_TextChanged(object sender, EventArgs e)
		{
			if (float.TryParse(toolFontSize.Text, out float fontSize))
			{
				float FontSize = float.Parse(fontSize.ToString());
				textContent.Font = new Font(textContent.Font.FontFamily, FontSize, textContent.Font.Style);
			}
		}

		private void toolShareMemo_Click(object sender, EventArgs e)
		{
			ShareMemo SM = new ShareMemo(memoDataRow);
			SM.ShowDialog();
		}

		private void toolShareRemove_Click(object sender, EventArgs e)
		{
			string formattedTimestamp = Convert.ToDateTime(memoDataRow["MEMO_FIRSTDATE"]).ToString("yyyy-MM-dd HH:mm:ss");

			string query = $"DELETE FROM SHARE_MEMO WHERE USER_ID='{memoDataRow["USER_ID"]}' AND MEMO_FIRSTDATE=TO_DATE('{formattedTimestamp}', 'YYYY-MM-DD HH24:MI:SS') AND SHARE_ID='{_profile.UserID}'";
			int result = oracleDBA.ExecuteNonQuery(query);
			if (result == 0)
				MessageBox.Show("실패!");
			oms.memoListUpdate();
			this.Close();
		}
	}
}
