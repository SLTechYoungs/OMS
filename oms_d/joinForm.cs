using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace oms_d
{
	public partial class joinForm : Form
	{
		private OracleDBA oracleDBA;

		public joinForm()
		{
			InitializeComponent();
			oracleDBA = new OracleDBA();
			textID.KeyPress += (sender, e) => { if (e.KeyChar == (char)Keys.Enter) join(); };
			textPasswd.KeyPress += (sender, e) => { if (e.KeyChar == (char)Keys.Enter) join(); };
			textPasswdCH.KeyPress += (sender, e) => { if (e.KeyChar == (char)Keys.Enter) join(); };
			textName.KeyPress += (sender, e) => { if (e.KeyChar == (char)Keys.Enter) join(); };
			textPhone.KeyPress += (sender, e) => { if (e.KeyChar == (char)Keys.Enter) join(); };
		}

		private void button1_Click(object sender, EventArgs e)
		{
			join();
		}

		private void textID_Click(object sender, EventArgs e) => textID.Text = "";
		private void textPasswd_Click(object sender, EventArgs e) => textPasswd.Text = "";
		private void textPasswdCH_Click(object sender, EventArgs e) => textPasswdCH.Text = "";
		private void textName_Click(object sender, EventArgs e) => textName.Text = "";
		private void textPhone_Click(object sender, EventArgs e) => textPhone.Text = "";

		private void join()
		{
			String userID = textID.Text;
			String userPasswd = textPasswd.Text;
			String userPasswdCH = textPasswdCH.Text;
			String userName = textName.Text;
			String userPhone = textPhone.Text;

			if (String.IsNullOrEmpty(userID) || String.IsNullOrEmpty(userPasswd) || String.IsNullOrEmpty(userPasswdCH) || String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(userPhone))
			{
				MessageBox.Show("전부 입력해주세요");
				return;
			}

			if (!userPasswd.Equals(userPasswdCH))
			{
				MessageBox.Show("비밀번호가 일치하지 않습니다.");
				return;
			}

			var dt = oracleDBA.ExecuteQuery($"SELECT * FROM USER_INFO WHERE USER_ID='{userID}'");
			if (dt.Rows.Count > 0)
			{
				MessageBox.Show("이미 존재하는 사용자 ID입니다.");
				return;
			}

			int rowsAffected = oracleDBA.ExecuteNonQuery($"INSERT INTO OMS_DEV.USER_INFO (USER_ID, USER_PW, USER_NAME, USER_PHONE) VALUES ('{userID}', '{userPasswd}', '{userName}', '{userPhone}')");

			if (rowsAffected > 0)
			{
				MessageBox.Show("회원 가입 성공!");
				this.Close();
			}
			else
			{
				MessageBox.Show("회원 가입 실패.");
			}
		}
	}
}
