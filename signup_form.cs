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

        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-HNPCF1F\\SQLEXPRESS;Initial Catalog=DBLOGIN;Integrated Security=True;");


        SqlConnection con = DBConnection.GetConnection();













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


            //////......................................................ADDED CRUD.CS INSTEAD OF THIS ..................................................

            //CRUD db = new CRUD();// OBJECT BANAISI NICHE CALL ER JONNO 


            //string query = "INSERT INTO signup_info VALUES ('" + TXTUSERNAME.Text + "','" + TXTPASSWORD.Text + "','" + comboBox1.Text + "', '0')";
            //int result = db.Insert(query);

            //if (result > 0)
            //    MessageBox.Show("Signup successful!");
            //else
            //    MessageBox.Show("Signup failed!");


            
            // Check if all fields are filled
            if (string.IsNullOrEmpty(TXTUSERNAME.Text) ||
                string.IsNullOrEmpty(TXTPASSWORD.Text) ||
                string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please fill all fields!", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CRUD db = new CRUD(); // Create CRUD object

            // Check if username already exists
            string checkQuery = "SELECT COUNT(*) FROM signup_info WHERE Username = '" + TXTUSERNAME.Text + "'";
            DataTable dt = db.Select(checkQuery);

            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                MessageBox.Show("Username '" + TXTUSERNAME.Text + "' already exists! Please choose a different username.",
                    "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If username is unique, proceed with signup
            string query = "INSERT INTO signup_info (Username, Password, UserType, Status, Balance) VALUES ('" +
                          TXTUSERNAME.Text + "','" +
                          TXTPASSWORD.Text + "','" +
                          comboBox1.Text + "', '1', 1000)";

            int result = db.Insert(query);

            if (result > 0)
            {
                MessageBox.Show("Signup successful! You now have 1000 points to start with!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form
                TXTUSERNAME.Text = "";
                TXTPASSWORD.Text = "";
                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Signup failed! Please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        



        private void LBLUSERNAME_Click(object sender, EventArgs e)
        {

        }

        private void BTNGOBACK_Click(object sender, EventArgs e)
        {
            Form lf = new LOGINFORM(); 
            this.Hide();
            lf.Show();
        }
    }
}
