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
using System.Data.SqlClient;





namespace C_PROJECT
{
    public partial class signup_form : Form
    {
        public signup_form()
        {
            InitializeComponent();
        }

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

            if (!TXTEMAIL.Text.Contains("@"))
            {
                MessageBox.Show("EMAIL must contain '@'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(TXTUSERNAME.Text) ||
                string.IsNullOrEmpty(TXTPASSWORD.Text) ||
                string.IsNullOrEmpty(comboBox1.Text) ||
                string.IsNullOrEmpty(TXTEMAIL.Text) ||
                string.IsNullOrEmpty(TXTCONFIRMPASS.Text))
            {
                MessageBox.Show("Please fill all fields!", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TXTPASSWORD.Text != TXTCONFIRMPASS.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match!", "Password Mismatch",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CRUD db = new CRUD();

            string checkQuery = "SELECT COUNT(*) FROM signup_info WHERE Username = '" + TXTUSERNAME.Text + "'";
            DataTable dt = db.Select(checkQuery);

            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                MessageBox.Show("Username '" + TXTUSERNAME.Text + "' already exists! Please choose a different username.",
                    "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO signup_info (Username, Password, UserType, Status, Balance, Email) VALUES ('" +
                           TXTUSERNAME.Text + "','" +
                           TXTPASSWORD.Text + "','" +
                           comboBox1.Text + "', '1', 1000, '" +
                           TXTEMAIL.Text + "')";

            int result = db.Insert(query);

            if (result > 0)
            {
                MessageBox.Show("Signup successful! You now have 1000 points to start with!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void signup_form_Load(object sender, EventArgs e)
        {

        }
    }
}
