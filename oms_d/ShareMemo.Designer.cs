namespace oms_d
{
	partial class ShareMemo
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.listUserID = new System.Windows.Forms.ListBox();
			this.btnUserAdd = new System.Windows.Forms.Button();
			this.btnUserRemove = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtUserID);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(288, 48);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(288, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "공유할 사용자 ID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// txtUserID
			// 
			this.txtUserID.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.txtUserID.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.txtUserID.Location = new System.Drawing.Point(0, 20);
			this.txtUserID.Multiline = true;
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Size = new System.Drawing.Size(288, 28);
			this.txtUserID.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.listUserID);
			this.panel2.Controls.Add(this.btnUserAdd);
			this.panel2.Controls.Add(this.btnUserRemove);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.panel2.Location = new System.Drawing.Point(0, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(288, 341);
			this.panel2.TabIndex = 1;
			// 
			// listUserID
			// 
			this.listUserID.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listUserID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.listUserID.FormattingEnabled = true;
			this.listUserID.ItemHeight = 20;
			this.listUserID.Location = new System.Drawing.Point(0, 0);
			this.listUserID.Name = "listUserID";
			this.listUserID.Size = new System.Drawing.Size(288, 295);
			this.listUserID.TabIndex = 0;
			this.listUserID.SelectedIndexChanged += new System.EventHandler(this.listUserID_SelectedIndexChanged);
			// 
			// btnUserAdd
			// 
			this.btnUserAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnUserAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnUserAdd.Location = new System.Drawing.Point(0, 295);
			this.btnUserAdd.Name = "btnUserAdd";
			this.btnUserAdd.Size = new System.Drawing.Size(288, 23);
			this.btnUserAdd.TabIndex = 3;
			this.btnUserAdd.Text = "추가";
			this.btnUserAdd.UseVisualStyleBackColor = true;
			this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
			// 
			// btnUserRemove
			// 
			this.btnUserRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnUserRemove.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnUserRemove.Location = new System.Drawing.Point(0, 318);
			this.btnUserRemove.Name = "btnUserRemove";
			this.btnUserRemove.Size = new System.Drawing.Size(288, 23);
			this.btnUserRemove.TabIndex = 2;
			this.btnUserRemove.Text = "제외";
			this.btnUserRemove.UseVisualStyleBackColor = true;
			this.btnUserRemove.Click += new System.EventHandler(this.btnUserRemove_Click);
			// 
			// ShareMemo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 389);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "ShareMemo";
			this.Text = "ShareMemo";
			this.Load += new System.EventHandler(this.ShareMemo_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtUserID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnUserAdd;
		private System.Windows.Forms.Button btnUserRemove;
		private System.Windows.Forms.ListBox listUserID;
	}
}