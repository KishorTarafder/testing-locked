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


        
        private static readonly string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBLOGIN;Integrated Security=True;";

        // Public property to access the connection string from other classes
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
