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


        // Updated connection string to work on any PC with SQL Server Express
        private static readonly string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBLOGIN;Integrated Security=True;Connect Timeout=30;";


        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
