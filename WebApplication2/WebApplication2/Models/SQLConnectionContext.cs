using System.Data.SqlClient;

namespace WebApplication2.Models
{
	public class SQLConnectionContext
	{
		private string SqlConnectionString = "Data Source=DESKTOP-IGPNK2V\\SQLEXPRESS;Initial Catalog=LittleChefDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

		public SqlConnection GetOpenDatabaseConnection()
		{
			SqlConnection conn = new SqlConnection(SqlConnectionString);
			conn.Open();
			return conn;
		}
	}
}