namespace oms_d
{
	partial class joinForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textID = new System.Windows.Forms.TextBox();
			this.textPasswd = new System.Windows.Forms.TextBox();
			this.textPasswdCH = new System.Windows.Forms.TextBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.textPhone = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 72);
			this.label1.TabIndex = 1;
			this.label1.Text = "Join";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// textID
			// 
			this.textID.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textID.Location = new System.Drawing.Point(35, 93);
			this.textID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textID.Name = "textID";
			this.textID.Size = new System.Drawing.Size(168, 23);
			this.textID.TabIndex = 2;
			this.textID.Text = "아이디";
			this.textID.Click += new System.EventHandler(this.textID_Click);
			// 
			// textPasswd
			// 
			this.textPasswd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textPasswd.Location = new System.Drawing.Point(35, 142);
			this.textPasswd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textPasswd.Name = "textPasswd";
			this.textPasswd.PasswordChar = '*';
			this.textPasswd.Size = new System.Drawing.Size(168, 23);
			this.textPasswd.TabIndex = 3;
			this.textPasswd.Text = "비밀번호";
			this.textPasswd.Click += new System.EventHandler(this.textPasswd_Click);
			// 
			// textPasswdCH
			// 
			this.textPasswdCH.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textPasswdCH.Location = new System.Drawing.Point(35, 191);
			this.textPasswdCH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textPasswdCH.Name = "textPasswdCH";
			this.textPasswdCH.PasswordChar = '*';
			this.textPasswdCH.Size = new System.Drawing.Size(168, 23);
			this.textPasswdCH.TabIndex = 4;
			this.textPasswdCH.Text = "비밀번호확인";
			this.textPasswdCH.Click += new System.EventHandler(this.textPasswdCH_Click);
			// 
			// textName
			// 
			this.textName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textName.Location = new System.Drawing.Point(35, 240);
			this.textName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(168, 23);
			this.textName.TabIndex = 5;
			this.textName.Text = "이름";
			this.textName.Click += new System.EventHandler(this.textName_Click);
			// 
			// textPhone
			// 
			this.textPhone.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textPhone.Location = new System.Drawing.Point(35, 289);
			this.textPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textPhone.Name = "textPhone";
			this.textPhone.Size = new System.Drawing.Size(168, 23);
			this.textPhone.TabIndex = 6;
			this.textPhone.Text = "전화번호";
			this.textPhone.Click += new System.EventHandler(this.textPhone_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button1.Location = new System.Drawing.Point(36, 326);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 34);
			this.button1.TabIndex = 7;
			this.button1.Text = "가입하기";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "아이디";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 9;
			this.label3.Text = "비밀번호";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 177);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 12);
			this.label4.TabIndex = 10;
			this.label4.Text = "비밀번호 확인";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(34, 226);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 11;
			this.label5.Text = "이름";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 275);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 12);
			this.label6.TabIndex = 12;
			this.label6.Text = "전화번호";
			// 
			// joinForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(239, 382);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textPhone);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.textPasswdCH);
			this.Controls.Add(this.textPasswd);
			this.Controls.Add(this.textID);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "joinForm";
			this.Text = "joinForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textID;
		private System.Windows.Forms.TextBox textPasswd;
		private System.Windows.Forms.TextBox textPasswdCH;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textPhone;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}