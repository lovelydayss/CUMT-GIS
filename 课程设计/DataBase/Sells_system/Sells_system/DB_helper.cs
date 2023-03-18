using System.Data;
using System.Data.SqlClient;

namespace Sells_system
{
    public class DB_helper
    {
        private string connectionString = @"Data Source=.;Initial Catalog=sellsystem;User Id=sell; Pwd=sell123";
        private SqlConnection connection;

        //数据库连接

        public SqlConnection Connection 
        {
            get
            {
                if(connection==null)
                {
                    connection = new SqlConnection(connectionString);
                }
                return connection;
            }
        }

        //打开数据库

        public void OpenConnection()
        {
            if(Connection.State==ConnectionState.Closed)
            {
                Connection.Open();
            }
            else if(Connection.State==ConnectionState.Broken)
            {
                Connection.Close();
                Connection.Open();
            }
        }

        //关闭数据库

        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open|| Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
            }
        }
    }
}
