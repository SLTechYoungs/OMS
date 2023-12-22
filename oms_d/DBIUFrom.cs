using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace oms_d
{
	public partial class DBIUFrom : Form
	{
		private DataColumnCollection _dataColums;
		private OracleDBA _oracleDBA;
		private List<TextBox> _TextBox;
		private string _tableName;
		private string _primaryKeyColumn;
		private Dictionary<string, string> _rowData;

		public DBIUFrom(adminFrom af, string querySet, string _tableName, DataColumnCollection _dataColums, string primaryKeyColumn, Dictionary<string, string> rowData = null)
		{
			InitializeComponent();
			this._oracleDBA = new OracleDBA();
			this._dataColums = _dataColums;
			this._tableName = _tableName;
			this._TextBox = new List<TextBox>();
			this._primaryKeyColumn = primaryKeyColumn;
			this._rowData = rowData;

			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			int formHeight = 50; // 폼의 초기 높이 설정

			foreach (DataColumn dataColumn in _dataColums)
			{
				Label _label = new Label();
				_label.Name = $"label{dataColumn.ColumnName}";
				_label.Text = dataColumn.ColumnName;
				_label.Margin = new Padding(3, 3, 3, -10); // 마진 설정

				TextBox _textbox = new TextBox();
				_textbox.Name = $"text{dataColumn.ColumnName}";
				if (_rowData != null && _rowData.ContainsKey(dataColumn.ColumnName))
				{
					_textbox.Text = _rowData[dataColumn.ColumnName];
				}
				_textbox.Margin = new Padding(3, 0, 3, 10); // 마진 설정
				_textbox.Size = new Size(200, 35);
				this._TextBox.Add(_textbox);

				flowLayoutPanel1.Controls.Add(_label);
				flowLayoutPanel1.Controls.Add(_textbox);
				formHeight += _label.Height + _textbox.Height + 20;
			}


			Button _BtnOk = new Button();
			_BtnOk.Name = "BtnOk";
			_BtnOk.Text = "완료";

			if (querySet.Equals("INSERT"))
			{
				_BtnOk.Click += (sender, e) =>
				{
					string paramsKey = "";
					string paramsValue = "";

					foreach (DataColumn dataColumn in _dataColums)
						paramsKey += $"{dataColumn.ColumnName},";

					foreach (TextBox textBox in _TextBox)
						paramsValue += $"'{textBox.Text}',";

					paramsKey = paramsKey.TrimEnd(',');
					paramsValue = paramsValue.TrimEnd(',');
					int rowsAffected = _oracleDBA.ExecuteNonQuery($"INSERT INTO {_tableName} ({paramsKey}) VALUES ({paramsValue})");
					if (rowsAffected > 0)
					{
						af.updateDataGrid($"SELECT * FROM {_tableName}");
						this.Close();
					}
					else return;
				};
			}
			else  if (querySet.Equals("UPDATE"))
			{
				_BtnOk.Click += (sender, e) =>
				{
					// 업데이트 로직 구현
					string updateSet = "";
					string primaryKeyValue = "";

					foreach (var textBox in _TextBox)
					{
						string columnName = textBox.Name.Substring(4); // "text" 접두어 제거
						if (columnName == _primaryKeyColumn)
						{
							primaryKeyValue = textBox.Text;
							continue;
						}
						updateSet += $"{columnName} = '{textBox.Text}',";
					}

					updateSet = updateSet.TrimEnd(',');
					int rowsAffected = _oracleDBA.ExecuteNonQuery($"UPDATE {_tableName} SET {updateSet} WHERE {_primaryKeyColumn} = '{primaryKeyValue}'");

					if (rowsAffected > 0)
					{
						// 성공 메시지 및 기타 처리
						af.updateDataGrid($"SELECT * FROM {_tableName}");
						this.Close();
					}
					else
					{
						// 실패 메시지 및 기타 처리
						MessageBox.Show("실패");
					}
				};
			}

			_BtnOk.Size = new Size(200, 60);
			flowLayoutPanel1.Controls.Add(_BtnOk);
			formHeight += _BtnOk.Height + 10;
			this.Size = new Size(225, formHeight);
		}
	}
}
