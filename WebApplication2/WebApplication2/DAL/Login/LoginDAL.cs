using System.Data;
using System.Data.SqlClient;
using WebApplication2.Models;

namespace WebApplication2.DAL.Login
{
	public class LoginDAL
	{
		private SQLConnectionContext context = new SQLConnectionContext();

		public bool VerifyCredentials(string username, string password)
		{
			using (SqlConnection conn = context.GetOpenDatabaseConnection())
			{
				SqlCommand cmd = new SqlCommand("dbo.VerifyCredentials", conn);
				cmd.Parameters.AddWithValue("@username", username);
				cmd.Parameters.AddWithValue("@password", password);
				cmd.CommandType = CommandType.StoredProcedure;

				int numUsers = (int)cmd.ExecuteScalar();

				return numUsers > 0;
			}
		}

		public void RegisterUser(string firstName, string lastName, string username, string password)
		{
			using (SqlConnection conn = context.GetOpenDatabaseConnection())
			{
				SqlCommand cmd = new SqlCommand("dbo.RegisterUser", conn);
				cmd.Parameters.AddWithValue("@firstName", firstName);
				cmd.Parameters.AddWithValue("@lastName", lastName);
				cmd.Parameters.AddWithValue("@username", username);
				cmd.Parameters.AddWithValue("@password", password);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.ExecuteNonQuery();
			}
		}
	}
}