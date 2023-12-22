using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oms_d
{
	public partial class ShareMemo : Form
	{
		private OracleDBA _oracleDBA;
		private DataRow _memoDataRow;

		public ShareMemo(DataRow memoDataRow)
		{
			InitializeComponent();
			_oracleDBA = new OracleDBA();
			_memoDataRow = memoDataRow;
		}

		private void ShareMemo_Load(object sender, EventArgs e)
		{
			updateShareMemo();
		}

		private void btnUserAdd_Click(object sender, EventArgs e)
		{
			insertShareMemo();
		}

		private void btnUserRemove_Click(object sender, EventArgs e)
		{
			removeShareMemo();
		}

		private void listUserID_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtUserID.Text = listUserID.Text.ToString();
		}

		private void updateShareMemo()
		{
			listUserID.Items.Clear();
			string formattedTimestamp = Convert.ToDateTime(_memoDataRow["MEMO_FIRSTDATE"]).ToString("yyyy-MM-dd HH:mm:ss");

			string query = $"SELECT * FROM SHARE_MEMO WHERE USER_ID='{_memoDataRow["USER_ID"]}' AND MEMO_FIRSTDATE=TO_DATE('{formattedTimestamp}', 'YYYY-MM-DD HH24:MI:SS')";
			
			var dt = _oracleDBA.ExecuteQuery(query);
			if (dt != null)
			{
				for(int i = 0; i < dt.Rows.Count; i++)
				{
					listUserID.Items.Add(dt.Rows[i]["SHARE_ID"].ToString());
				}
			}
		}
		private void insertShareMemo()
		{
			if (txtUserID.Text.Length > 0)
			{
				try
				{
					string formattedTimestamp = Convert.ToDateTime(_memoDataRow["MEMO_FIRSTDATE"]).ToString("yyyy-MM-dd HH:mm:ss");

					string query = $"INSERT INTO SHARE_MEMO (USER_ID, MEMO_FIRSTDATE, SHARE_ID) VALUES ('{_memoDataRow["USER_ID"]}', TO_DATE('{formattedTimestamp}', 'YYYY-MM-DD HH24:MI:SS'), '{txtUserID.Text}')";
					int result = _oracleDBA.ExecuteNonQuery(query);
					if (result != 0) updateShareMemo();
					else MessageBox.Show("추가 실패");
					txtUserID.Text = "";
				}
				catch (Oracle.ManagedDataAccess.Client.OracleException ex)
				{
					if (ex.Number == 2291)
						MessageBox.Show("존재하지 않는 ID입니다.");
					if (ex.Number == 0001)
						MessageBox.Show("이미 공유중인 사용자입니다.");
					else
					{
						MessageBox.Show($"데이터베이스 오류: {ex.Message}");
					}
				}
			}
			else MessageBox.Show("추가하실 사용지의 아이디를 입력해주세요.");
		}
		private void removeShareMemo()
		{
			if (txtUserID.Text.Length > 0)
			{
				string formattedTimestamp = Convert.ToDateTime(_memoDataRow["MEMO_FIRSTDATE"]).ToString("yyyy-MM-dd HH:mm:ss");

				string query = $"DELETE FROM SHARE_MEMO WHERE USER_ID='{_memoDataRow["USER_ID"]}' AND MEMO_FIRSTDATE=TO_DATE('{formattedTimestamp}', 'YYYY-MM-DD HH24:MI:SS') AND SHARE_ID='{txtUserID.Text}'";
				int result = _oracleDBA.ExecuteNonQuery(query);
				if (result != 0) updateShareMemo();
				else MessageBox.Show("제외 실패");
				txtUserID.Text = "";
			}
			else MessageBox.Show("공유 목록에서 제외하실 아이디를 입력해주세요.");
		}
	}
}
