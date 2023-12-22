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
	public partial class adminFrom : Form
	{
		private OracleDBA _oracleDBA;
		private DataColumnCollection _dataColumns;

		public adminFrom()
		{
			InitializeComponent();
			_oracleDBA = new OracleDBA();

			comboBox1.Items.Clear();
			var dt = _oracleDBA.ExecuteQuery("SELECT table_name FROM user_tables");
			for(int i=0; i<dt.Rows.Count; i++)
			{
				comboBox1.Items.Add(dt.Rows[i]["TABLE_NAME"]);
			}
			comboBox1.SelectedIndex = 1;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectTable = comboBox1.SelectedItem.ToString();
			updateDataGrid($"SELECT * FROM {selectTable}");
		}

		public void updateDataGrid(string selectQuery)
		{
			
			try
			{
				var dt = _oracleDBA.ExecuteQuery(selectQuery);
				dataGridView.DataSource = dt;
				this._dataColumns = dt.Columns;
				comboBox2.Items.Clear();
				// DataTable의 각 컬럼명을 반복하여 출력
				foreach (DataColumn column in dt.Columns)
					comboBox2.Items.Add(column.ColumnName);
				comboBox2.SelectedIndex = 0;
				textBox1.Text = "";
			}catch (Exception ex)
			{
				if(ex.Message.Contains("ORA-00932"))
				{
					MessageBox.Show("메모의 타입이 CLOB임으로 내용을 검색하는 기능은 지원하지 않습니다.");
				}
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string selectTable = comboBox1.SelectedItem.ToString();
			if (comboBox2.Text.Equals("")){
				MessageBox.Show("검색 조건을 확인하세요.");
				return;
			}
			string query;
			if (textBox1.Text.Equals("")) query = $"SELECT * FROM {selectTable}";
			else query = $"SELECT * FROM {selectTable} WHERE {comboBox2.Text}='{textBox1.Text}'";
			updateDataGrid(query);
		}

		private void btn_Insert_Click(object sender, EventArgs e)
		{
			string selectTable = comboBox1.Text;
			if (selectTable.Equals("USER_MEMO"))
			{
				MessageBox.Show("USER_MEMO 테이블의 Insert 기능은 금지되어있습니다.");
				return;
			}
			string primaryKeyColumn = _oracleDBA.GetPrimaryKeyColumn(selectTable);
			DBIUFrom _dbiuForm = new DBIUFrom(this, "INSERT", selectTable, _dataColumns, primaryKeyColumn);
			_dbiuForm.ShowDialog();
		}

		private void btn_Update_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 0)
			{
				MessageBox.Show("행을 선택하세요.");
				return;
			}

			var selectedRow = dataGridView.SelectedRows[0];
			var rowData = new Dictionary<string, string>();

			foreach (DataGridViewColumn column in dataGridView.Columns)
			{
				string columnName = column.Name;
				string cellValue = selectedRow.Cells[columnName].Value?.ToString() ?? "";
				rowData[columnName] = cellValue;
			}

			string selectTable = comboBox1.Text;
			if (selectTable.Equals("USER_MEMO"))
			{
				MessageBox.Show("USER_MEMO 테이블의 Update 기능은 금지되어있습니다.");
				return;
			}
			string primaryKeyColumn = _oracleDBA.GetPrimaryKeyColumn(selectTable);
			DBIUFrom _dbiuForm = new DBIUFrom(this, "UPDATE", selectTable, _dataColumns, primaryKeyColumn, rowData);
			_dbiuForm.ShowDialog();
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 0)
			{
				MessageBox.Show("행을 선택하세요.");
				return;
			}

			var selectedRow = dataGridView.SelectedRows[0];
			string selectTable = comboBox1.Text;
			string primaryKeyColumn = _oracleDBA.GetPrimaryKeyColumn(selectTable);
			string primaryKeyValue = selectedRow.Cells[primaryKeyColumn].Value?.ToString() ?? "";

			if (string.IsNullOrEmpty(primaryKeyValue))
			{
				MessageBox.Show("선택된 행의 기본 키 값을 찾을 수 없습니다.");
				return;
			}

			var confirmResult = MessageBox.Show("정말로 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo);
			if (confirmResult == DialogResult.Yes)
			{
				try
				{
					string deleteQuery;
					int rowsAffected = 0;
					if (selectTable == "USER_MEMO")
					{
						object timestampObj = selectedRow.Cells["MEMO_FIRSTDATE"].Value;
						DateTime timestamp;
						if(DateTime.TryParse(timestampObj.ToString(), out timestamp))
						{
							string oracleDateFormat = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
							deleteQuery = $"DELETE FROM {selectTable} WHERE USER_ID = '{selectedRow.Cells["USER_ID"].Value}' AND MEMO_FIRSTDATE = TO_DATE('{oracleDateFormat}', 'YYYY-MM-DD HH24:MI:SS')";
							rowsAffected = _oracleDBA.ExecuteNonQuery(deleteQuery);
						}
						else
						{
							MessageBox.Show("심각한 문제가 발생했습니다.");
							return;
						}
					}
					else
					{
						deleteQuery = $"DELETE FROM {selectTable} WHERE {primaryKeyColumn} = '{primaryKeyValue}'";
						rowsAffected = _oracleDBA.ExecuteNonQuery(deleteQuery);

					}

					if (rowsAffected > 0)
					{
						MessageBox.Show("삭제되었습니다.");
						updateDataGrid($"SELECT * FROM {selectTable}"); // 데이터 그리드 뷰 갱신
					}
				}
				catch (Oracle.ManagedDataAccess.Client.OracleException ex)
				{
					if (ex.Message.Contains("ORA-02292"))
					{
						MessageBox.Show("삭제할 수 없습니다. 이 레코드는 다른 레코드와 연관되어 있습니다.\r\n레코드 문제를 해결 후 삭제해주세요", "삭제 오류");
					}
					else
					{
						MessageBox.Show("데이터베이스 오류: " + ex.Message, "삭제 오류");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("오류: " + ex.Message, "삭제 오류");
				}
			}
		}

		private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.Value is DateTime)
				e.Value = ((DateTime)e.Value).ToString("yyyy-MM-dd HH:mm:ss");
			
		}
	}
}
