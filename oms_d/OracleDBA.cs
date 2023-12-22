using Oracle.ManagedDataAccess.Client; // Oracle.ManagedDataAccess 네임스페이스 사용
using System.Data;

namespace oms_d
{
	public class OracleDBA
	{
		private string _connectionString;

		public OracleDBA()
		{
			_connectionString = "User Id=oms_dev; Password=bc_oms_2023; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 211.226.15.157)(PORT = 15217)) (CONNECT_DATA = (SERVER = DEDICATED)(SID = XE)));";
		}

		public DataTable ExecuteQuery(string query)
		{
			using (OracleConnection conn = new OracleConnection(_connectionString))
			{
				conn.Open();
				using (OracleCommand cmd = new OracleCommand(query, conn))
				{
					using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
					{
						DataTable dt = new DataTable();
						adapter.Fill(dt);
						return dt;
					}
				}
			}
		}

		public int ExecuteNonQuery(string query, OracleParameter[] parameters = null)
		{
			using (OracleConnection conn = new OracleConnection(_connectionString))
			{
				conn.Open();
				using (OracleCommand cmd = new OracleCommand(query, conn))
				{
					// 파라미터가 제공된 경우, 이들을 커맨드에 추가합니다.
					if (parameters != null)
					{
						foreach (var param in parameters)
						{
							cmd.Parameters.Add(param);
						}
					}

					return cmd.ExecuteNonQuery();
				}
			}
		}


		public string GetPrimaryKeyColumn(string tableName)
		{
			var dt = ExecuteQuery($@"
        SELECT col.column_name
        FROM user_constraints con, user_cons_columns col
        WHERE con.constraint_name = col.constraint_name
        AND con.constraint_type = 'P'
        AND con.table_name = '{tableName.ToUpper()}'");

			if (dt.Rows.Count > 0)
			{
				return dt.Rows[0]["COLUMN_NAME"].ToString();
			}

			return null;
		}

	}
}
