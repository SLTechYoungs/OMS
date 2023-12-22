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
	public partial class memoList : UserControl
	{
		private DataRow memoDataRow;
		private omsMain oms;
		private userProfile _profile;

		public memoList(omsMain oms, DataRow content, userProfile profile)
		{
			InitializeComponent();
			this.oms = oms;
			memoDataRow = content;
			labelContent.Text = content["MEMO_TITLE"].ToString();
			_profile = profile;
			if (profile.UserID.Equals(content["USER_ID"]))
			{
				labelContent.BackColor = SystemColors.Info;
				label1.Visible = false;
			}
			else
			{
				labelContent.BackColor = SystemColors.GradientInactiveCaption;
				label1.Text = $"{content["USER_ID"]} (Read Only)  ";
				label1.Visible = true;
			}
		}

		private void labelContent_Click(object sender, EventArgs e)
		{
			memoWritingForm newMWF = new memoWritingForm(oms, memoDataRow, _profile);
			newMWF.ShowDialog();
		}
	}
}
