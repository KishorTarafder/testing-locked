using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;

namespace C_PROJECT
{ 
    internal class DBConnection
    {


        
        private static string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBLOGIN;Integrated Security=True;";

        public static string ConnectionString 
        { 
            get { return connectionString; } 
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
