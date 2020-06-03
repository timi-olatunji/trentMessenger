using System.Data.SqlClient;

namespace Trentmessenger
{
    class Connection
    {
        //specifying the connection string to Amazon Web Services Relational Database Instance
        public static SqlConnection sqlConnection = new SqlConnection("Data Source=trentmessenger.cr02x0gbm6yi.us-east-2.rds.amazonaws.com;User ID=trentMessenger;Password=England123#;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public static SqlCommand sqlCommand = new SqlCommand() { Connection = sqlConnection };

        //Openning SQL Connection
        public static void OpenConnection()
        {
            if (sqlConnection.State != System.Data.ConnectionState.Open)
                sqlConnection.Open();
        }

        //Closing SQL Connection
        public static void CloseConnection()
        {
            if (sqlConnection.State != System.Data.ConnectionState.Closed)
                sqlConnection.Close();
        }

        //Taking a Query
        public static int IssueQuery(string queryDB)
        {
            int rowDB = 0;
            sqlCommand.CommandText = queryDB;

            OpenConnection();
            rowDB = sqlCommand.ExecuteNonQuery();
            CloseConnection();

            return rowDB;
        }

        //Fetching Data
        public static SqlDataReader FetchReader(string queryDB)
        {
            sqlCommand.CommandText = queryDB;

            OpenConnection();
            return sqlCommand.ExecuteReader();
        }


        public static object ReturnScalar(string queryDB)
        {
            sqlCommand.CommandText = queryDB;

            OpenConnection();
            return sqlCommand.ExecuteScalar();
        }
    }
}
