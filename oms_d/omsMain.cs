using System;
using System.Drawing;
using System.Windows.Forms;

namespace oms_d
{
	public partial class omsMain : Form
	{
		private userProfile _userProfile;
		private OracleDBA oracleDBA;
		private memoList newML;
		private omsMain oms;
		private loginForm _loginForm;

		public omsMain(userProfile up, loginForm loginForm)
		{
			InitializeComponent();
			_loginForm = loginForm;
			_userProfile = up;
			oms = this;
			labelUserName.Text = _userProfile.UserName + "님";
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

			oracleDBA = new OracleDBA();
			string query = $"SELECT ADMIN FROM USER_INFO WHERE USER_ID='{_userProfile.UserID}'";
			var dt = oracleDBA.ExecuteQuery(query);

			if ((dt.Rows[0]["ADMIN"].ToString()).Equals("Y"))
				btnAdmin.Visible = true;
			else btnAdmin.Visible = false;


			memoListUpdate();

			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.WrapContents = false;
			flowLayoutPanel1.AutoScroll = true;
			AdjustFlowLayoutPanelPadding();
		}
		private void AdjustFlowLayoutPanelPadding()
		{
			// 스크롤 바의 대략적인 너비를 고려하여 오른쪽 패딩을 추가합니다.
			int scrollBarWidth = SystemInformation.VerticalScrollBarWidth;
			flowLayoutPanel1.ClientSize = new Size(flowLayoutPanel1.Width - scrollBarWidth, flowLayoutPanel1.ClientSize.Height);
		}


		public void memoListUpdate()
		{
			flowLayoutPanel1.Controls.Clear();
			string query = $"SELECT * FROM (SELECT * FROM USER_MEMO WHERE USER_ID = '{_userProfile.UserID}' UNION ALL SELECT um.* FROM SHARE_MEMO sm JOIN USER_MEMO um ON sm.USER_ID = um.USER_ID AND sm.MEMO_FIRSTDATE = um.MEMO_FIRSTDATE WHERE sm.SHARE_ID = '{_userProfile.UserID}') ORDER BY MEMO_LASTDATE DESC";
			var dt = oracleDBA.ExecuteQuery(query);
			if (dt.Rows.Count > 0)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					newML = new memoList(oms , dt.Rows[i], _userProfile);
					flowLayoutPanel1.Controls.Add(newML);
				}
			}
			else
			{
				string newUserMessage = $"{_userProfile.UserID}님 환영합니다. 저를 눌러주세요\r\n\r\n온라인 메모 시스템(OMS) 사용법\r\n기존에 있는 메모를 누를 시 메모를 수정할 수 있습니다.\r\n내용을 수정 후 창을 닫으면 자동으로 저장이됩니다.\r\n내용이 비어있다면 메모는 자동으로 삭제됩니다.\r\n";
				int rowAffected = oracleDBA.ExecuteNonQuery($"INSERT INTO USER_MEMO (USER_ID, MEMO_FIRSTDATE, MEMO_TITLE, MEMO_CONTENT, MEMO_FONTSIZE, MEMO_LASTDATE) VALUES ('{_userProfile.UserID}', SYSDATE, 'OMS이용안내','{newUserMessage}', '10', SYSDATE)");
				memoListUpdate();
			}
			AdjustFlowLayoutPanelPadding();
		}

		public void searchMemo()
		{
			flowLayoutPanel1.Controls.Clear();
			var dt = oracleDBA.ExecuteQuery($"SELECT * FROM USER_MEMO WHERE USER_ID = '{_userProfile.UserID}' AND MEMO_TITLE LIKE '%{String.Join("%", textBox1.Text.ToCharArray())}%' ORDER BY MEMO_LASTDATE DESC");
			for(int i = 0; i < dt.Rows.Count;i++)
			{
				newML = new memoList(oms, dt.Rows[i], _userProfile);
				flowLayoutPanel1.Controls.Add(newML);
			}
			AdjustFlowLayoutPanelPadding();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			memoWritingForm mwf = new memoWritingForm(oms, null, _userProfile);
			mwf.ShowDialog();
			//memoWritingForm.ShowDialog();
		}

		private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
		{
			int controlWidth = flowLayoutPanel1.Width - flowLayoutPanel1.Margin.Horizontal - e.Control.Margin.Horizontal;

			// 컨트롤의 너비를 조정합니다.
			e.Control.Width = controlWidth;
		}

		private void flowLayoutPanel1_Resize(object sender, EventArgs e)
		{
			foreach (Control control in flowLayoutPanel1.Controls)
			{
				int controlWidth = flowLayoutPanel1.Width - flowLayoutPanel1.Margin.Horizontal - control.Margin.Horizontal;
				control.Width = controlWidth;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void omsMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			_loginForm.Show();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if(textBox1.Text.Length > 0) searchMemo();
			else memoListUpdate();
		}

		private void omsMain_SizeChanged(object sender, EventArgs e)
		{

			AdjustFlowLayoutPanelPadding();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if(textBox1.Text == "")
				memoListUpdate();
		}

		private void btnAdmin_Click(object sender, EventArgs e)
		{
			adminFrom af = new adminFrom();
			af.Show();
		}
	}
}
