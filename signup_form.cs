using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// pore maybe delete 


using System.Data.SqlClient;





namespace C_PROJECT
{
    public partial class signup_form : Form
    {
        public signup_form()
        {
            InitializeComponent();
        }

        // pore maybe delete 

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HNPCF1F\\SQLEXPRESS;Initial Catalog=DBLOGIN;Integrated Security=True;");















        private void TXTUSERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLLOGIN_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTNSIGNUP_Click(object sender, EventArgs e)
        {
            string insert_query = "insert into signup_info values ('"+TXTUSERNAME.Text+"','"+TXTPASSWORD.Text+"','"+comboBox1.Text+"','0')";

            SqlCommand cmd = new SqlCommand(insert_query, con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Signup successful!");
                }
                else
                {
                    MessageBox.Show("Signup failed. Please try again.");
                }
            }
            con.Close();
        }
        }
}
