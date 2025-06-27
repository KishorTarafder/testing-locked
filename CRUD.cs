using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PROJECT
{
    internal class CRUD
    {
        public int Insert(string query)
        {
            SqlConnection con = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result;
            }
            return 0;
        }

        //public DataTable Select(string query)
        //{
        //    SqlConnection con = DBConnection.GetConnection();
        //    SqlDataAdapter da = new SqlDataAdapter(query, con);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}



        public DataTable Select(string query)
        {
            SqlConnection con = DBConnection.GetConnection();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public int Update(string query)
        {
            SqlConnection con = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            if (con.State == ConnectionState.Closed)
            { 
                con.Open();
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result;
            }
            return  0;
        }

        public int Delete(string query)
        {
            SqlConnection con = DBConnection.GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result;
            }
            return 0;
        }
    }
}
