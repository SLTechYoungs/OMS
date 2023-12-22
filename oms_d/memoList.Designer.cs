namespace oms_d
{
	partial class memoList
	{
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelContent = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelContent
			// 
			this.labelContent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.labelContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelContent.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.labelContent.Location = new System.Drawing.Point(5, 5);
			this.labelContent.Margin = new System.Windows.Forms.Padding(0);
			this.labelContent.Name = "labelContent";
			this.labelContent.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
			this.labelContent.Size = new System.Drawing.Size(161, 55);
			this.labelContent.TabIndex = 0;
			this.labelContent.Text = "label1";
			this.labelContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelContent.Click += new System.EventHandler(this.labelContent_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(5, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "(Read Only)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// memoList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelContent);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "memoList";
			this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Size = new System.Drawing.Size(171, 65);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelContent;
		private System.Windows.Forms.Label label1;
	}
}
