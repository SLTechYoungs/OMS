namespace oms_d
{
	partial class memoWritingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memoWritingForm));
			this.textContent = new System.Windows.Forms.TextBox();
			this.textTitle = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolFontSize = new System.Windows.Forms.ToolStripTextBox();
			this.toolBold = new System.Windows.Forms.ToolStripButton();
			this.toolItalic = new System.Windows.Forms.ToolStripButton();
			this.toolStrikeout = new System.Windows.Forms.ToolStripButton();
			this.toolUnderLine = new System.Windows.Forms.ToolStripButton();
			this.toolShareMemo = new System.Windows.Forms.ToolStripButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolName = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolFirstDate = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolLastDate = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolShareRemove = new System.Windows.Forms.ToolStripButton();
			this.panel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textContent
			// 
			this.textContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textContent.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textContent.Location = new System.Drawing.Point(0, 0);
			this.textContent.Margin = new System.Windows.Forms.Padding(2);
			this.textContent.Multiline = true;
			this.textContent.Name = "textContent";
			this.textContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textContent.Size = new System.Drawing.Size(631, 256);
			this.textContent.TabIndex = 0;
			// 
			// textTitle
			// 
			this.textTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textTitle.Location = new System.Drawing.Point(0, 0);
			this.textTitle.Margin = new System.Windows.Forms.Padding(2);
			this.textTitle.Multiline = true;
			this.textTitle.Name = "textTitle";
			this.textTitle.Size = new System.Drawing.Size(594, 22);
			this.textTitle.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.toolStrip1);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(631, 50);
			this.panel1.TabIndex = 2;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolFontSize,
            this.toolBold,
            this.toolItalic,
            this.toolStrikeout,
            this.toolUnderLine,
            this.toolShareRemove,
            this.toolShareMemo});
			this.toolStrip1.Location = new System.Drawing.Point(0, 22);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(631, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
			this.toolStripLabel1.Text = "FontSize:";
			// 
			// toolFontSize
			// 
			this.toolFontSize.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.toolFontSize.Name = "toolFontSize";
			this.toolFontSize.Size = new System.Drawing.Size(100, 25);
			this.toolFontSize.TextChanged += new System.EventHandler(this.toolFontSize_TextChanged);
			// 
			// toolBold
			// 
			this.toolBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolBold.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.toolBold.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolBold.Name = "toolBold";
			this.toolBold.Size = new System.Drawing.Size(23, 22);
			this.toolBold.Text = "A";
			this.toolBold.CheckedChanged += new System.EventHandler(this.toolBold_CheckedChanged);
			this.toolBold.Click += new System.EventHandler(this.toolBold_Click);
			// 
			// toolItalic
			// 
			this.toolItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolItalic.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.toolItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolItalic.Name = "toolItalic";
			this.toolItalic.Size = new System.Drawing.Size(23, 22);
			this.toolItalic.Text = "A";
			this.toolItalic.CheckedChanged += new System.EventHandler(this.toolItalic_CheckedChanged);
			this.toolItalic.Click += new System.EventHandler(this.toolItalic_Click);
			// 
			// toolStrikeout
			// 
			this.toolStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStrikeout.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.toolStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStrikeout.Name = "toolStrikeout";
			this.toolStrikeout.Size = new System.Drawing.Size(23, 22);
			this.toolStrikeout.Text = "A";
			this.toolStrikeout.CheckedChanged += new System.EventHandler(this.toolStrikeout_CheckedChanged);
			this.toolStrikeout.Click += new System.EventHandler(this.toolStrikeout_Click);
			// 
			// toolUnderLine
			// 
			this.toolUnderLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolUnderLine.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.toolUnderLine.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolUnderLine.Name = "toolUnderLine";
			this.toolUnderLine.Size = new System.Drawing.Size(23, 22);
			this.toolUnderLine.Text = "A";
			this.toolUnderLine.CheckedChanged += new System.EventHandler(this.toolUnderLine_CheckedChanged);
			this.toolUnderLine.Click += new System.EventHandler(this.toolUnderLine_Click);
			// 
			// toolShareMemo
			// 
			this.toolShareMemo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolShareMemo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolShareMemo.Image = ((System.Drawing.Image)(resources.GetObject("toolShareMemo.Image")));
			this.toolShareMemo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolShareMemo.Name = "toolShareMemo";
			this.toolShareMemo.Size = new System.Drawing.Size(59, 22);
			this.toolShareMemo.Text = "공유하기";
			this.toolShareMemo.Click += new System.EventHandler(this.toolShareMemo_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(631, 22);
			this.panel3.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.textTitle);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(37, 0);
			this.panel5.Margin = new System.Windows.Forms.Padding(2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(594, 22);
			this.panel5.TabIndex = 4;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Margin = new System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(37, 22);
			this.panel4.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 22);
			this.label1.TabIndex = 2;
			this.label1.Text = "Title:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.statusStrip1);
			this.panel2.Controls.Add(this.textContent);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 50);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(631, 256);
			this.panel2.TabIndex = 3;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolName,
            this.toolStripStatusLabel3,
            this.toolFirstDate,
            this.toolStripStatusLabel5,
            this.toolLastDate});
			this.statusStrip1.Location = new System.Drawing.Point(0, 234);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(631, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(46, 17);
			this.toolStripStatusLabel1.Text = "작성자:";
			// 
			// toolName
			// 
			this.toolName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.toolName.Name = "toolName";
			this.toolName.Size = new System.Drawing.Size(25, 17);
			this.toolName.Text = "xxx";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(74, 17);
			this.toolStripStatusLabel3.Text = "최초 작성일:";
			// 
			// toolFirstDate
			// 
			this.toolFirstDate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.toolFirstDate.Name = "toolFirstDate";
			this.toolFirstDate.Size = new System.Drawing.Size(121, 17);
			this.toolFirstDate.Text = "1111.11.11 11:11:11";
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(74, 17);
			this.toolStripStatusLabel5.Text = "최종 수정일:";
			// 
			// toolLastDate
			// 
			this.toolLastDate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.toolLastDate.Name = "toolLastDate";
			this.toolLastDate.Size = new System.Drawing.Size(121, 17);
			this.toolLastDate.Text = "1111.11.11 11:11:11";
			// 
			// toolShareRemove
			// 
			this.toolShareRemove.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolShareRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolShareRemove.Image = ((System.Drawing.Image)(resources.GetObject("toolShareRemove.Image")));
			this.toolShareRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolShareRemove.Name = "toolShareRemove";
			this.toolShareRemove.Size = new System.Drawing.Size(59, 22);
			this.toolShareRemove.Text = "공유취소";
			this.toolShareRemove.Click += new System.EventHandler(this.toolShareRemove_Click);
			// 
			// memoWritingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 306);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "memoWritingForm";
			this.Text = "memoWritingForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.memoWritingForm_FormClosing);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textContent;
		private System.Windows.Forms.TextBox textTitle;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolBold;
		private System.Windows.Forms.ToolStripButton toolItalic;
		private System.Windows.Forms.ToolStripButton toolStrikeout;
		private System.Windows.Forms.ToolStripButton toolUnderLine;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox toolFontSize;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolName;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolFirstDate;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
		private System.Windows.Forms.ToolStripStatusLabel toolLastDate;
		private System.Windows.Forms.ToolStripButton toolShareMemo;
		private System.Windows.Forms.ToolStripButton toolShareRemove;
	}
}