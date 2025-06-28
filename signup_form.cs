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

        // Using centralized DBConnection class
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
            // Check if all fields are filled
            if (string.IsNullOrEmpty(TXTUSERNAME.Text) ||
                string.IsNullOrEmpty(TXTPASSWORD.Text) ||
                string.IsNullOrEmpty(comboBox1.Text) ||
                string.IsNullOrEmpty(TXTEMAIL.Text) ||
                string.IsNullOrEmpty(TXTCONFIRMPASS.Text)) // <-- ADDED: check confirm password field
            {
                MessageBox.Show("Please fill all fields!", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Add this validation once you add TXTEMAIL textbox to your form
            // if (string.IsNullOrEmpty(TXTEMAIL.Text))
            // {
            //     MessageBox.Show("Please enter your email address!", "Missing Information",
            //         MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     return;
            // }

            // ADD: Check if Password and Confirm Password match
            if (TXTPASSWORD.Text != TXTCONFIRMPASS.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match!", "Password Mismatch",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: Add email validation once you add TXTEMAIL textbox
            // if (!TXTEMAIL.Text.Contains("@") || !TXTEMAIL.Text.Contains("."))
            // {
            //     MessageBox.Show("Please enter a valid email address!", "Invalid Email",
            //         MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     return;
            // }

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

            // TODO: Once you add Email column and TXTEMAIL textbox, replace this query:
            // Current query (without email):
            string query = "INSERT INTO signup_info (Username, Password, UserType, Status, Balance, Email) VALUES ('" +
                           TXTUSERNAME.Text + "','" +
                           TXTPASSWORD.Text + "','" +
                           comboBox1.Text + "', '1', 1000, '" +
                           TXTEMAIL.Text + "')";


            // TODO: Use this query once you add email:
            // string query = "INSERT INTO signup_info (Username, Email, Password, UserType, Status, Balance) VALUES ('" +
            //               TXTUSERNAME.Text + "','" +
            //               TXTEMAIL.Text + "','" +
            //               TXTPASSWORD.Text + "','" +
            //               comboBox1.Text + "', '1', 1000)";

            int result = db.Insert(query);

            if (result > 0)
            {
                MessageBox.Show("Signup successful! You now have 1000 points to start with!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form
                Form LOGIN_FORM = new LOGINFORM();
                this.Hide();
                LOGIN_FORM.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTCONFIRMPASS_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTPASSWORD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TXTEMAIL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
