using System;
using System.Windows.Forms;


namespace oms_d
{
	public partial class loginForm : Form
	{
		private OracleDBA oracleDBA;
		private string version = "1.0.5";

		public loginForm()
		{
			InitializeComponent();
			oracleDBA = new OracleDBA();

			textID.KeyPress += (sender, e) => { if (e.KeyChar == (char)Keys.Enter) login(); };
			textPasswd.KeyPress += (sender, e) => { if (e.KeyChar == (char)Keys.Enter) login(); };

			label2.Text = $"v.{version}";
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			joinForm joinForm = new joinForm();
			joinForm.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e) => login();

		public void login()
		{
			string userID = this.textID.Text;
			string userPasswd = this.textPasswd.Text;

			if (String.IsNullOrEmpty(userID) || String.IsNullOrEmpty(userPasswd))
			{
				MessageBox.Show("아이디 또는 비밀번호를 입력해주세요");
				return;
			}

			var dt = oracleDBA.ExecuteQuery($"SELECT * FROM USER_INFO WHERE USER_ID='{userID}'");
			if (dt.Rows.Count > 0)
			{
				string dtPasswd = dt.Rows[0]["USER_PW"].ToString();
				if (dtPasswd.Equals(userPasswd))
				{
					userProfile up = new userProfile(dt.Rows[0]["USER_ID"].ToString(), dt.Rows[0]["USER_NAME"].ToString());
					omsMain omsMain = new omsMain(up, this);
					omsMain.Show();
					this.Hide();
					return;
				}
				else
				{
					MessageBox.Show("비밀번호를 확인해주세요");
					return;
				}
			}
			//
			else
			{
				MessageBox.Show("존재하지 않는 아이디입니다.");
				return;
			}
		}

		private void loginForm_Load(object sender, EventArgs e)
		{
			// 프로그램 버전을 확인하는 로직
			var programInfoDT = oracleDBA.ExecuteQuery($"SELECT VER FROM PROGRAM_INFO");
			string serverVer = programInfoDT.Rows[0]["VER"].ToString();
			if (!serverVer.Equals(version))
			{
				MessageBox.Show($"최신버전: v{serverVer} 프로그램버전: {version}\r\n" +
					$"업데이트 버전이 존재합니다.\r\n업데이트 후 이용가능합니다");
				this.Close();
				return;
			}
		}
	}
}
