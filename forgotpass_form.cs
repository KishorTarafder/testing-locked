using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PROJECT
{
    public partial class forgotpass_form : Form
    {
        public forgotpass_form()
        {
            InitializeComponent();
        }

        private void LBLPASSWORD_Click(object sender, EventArgs e)
        {

        }

        private void TXTUSERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTOLDPASS_TextChanged(object sender, EventArgs e)
        {

        }

        private void NEWPASS_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNCHANGEPASS_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(TXTUSERNAME.Text))
            {
                MessageBox.Show("Please enter your username.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TXTEMAIL.Text))
            {
                MessageBox.Show("Please enter your email address.");
                return;
            }

            if (string.IsNullOrWhiteSpace(NEWPASS_CHANGE.Text))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }

            //if (NEWPASS_CHANGE.Text.Length < 4)
            //{
            //    MessageBox.Show("Password must be at least 4 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //try
            //{
                CRUD db = new CRUD();

                // First verify that the username and email combination exists
                string verifyQuery = "SELECT COUNT(*) FROM signup_info WHERE Username = '" + TXTUSERNAME.Text + "' AND Email = '" + TXTEMAIL.Text + "'";
                DataTable verifyResult = db.Select(verifyQuery);

                if (verifyResult.Rows.Count > 0)
                {
                    int matchCount = Convert.ToInt32(verifyResult.Rows[0][0]);
                    
                    if (matchCount > 0)
                    {
                        // Username and email match, proceed with password update
                        string updateQuery = "UPDATE signup_info SET Password = '" + NEWPASS_CHANGE.Text + "' WHERE Username = '" + TXTUSERNAME.Text + "' AND Email = '" + TXTEMAIL.Text + "'";
                        int updateResult = db.Update(updateQuery);

                        if (updateResult > 0)
                        {
                            MessageBox.Show("Password changed successfully! You can now login with your new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            // Clear the form fields
                            TXTUSERNAME.Clear();
                            TXTEMAIL.Clear();
                            NEWPASS_CHANGE.Clear();


                        LOGINFORM loginForm = new LOGINFORM();
                        this.Hide(); // Hide the current form
                        loginForm.Show();



                    }
                        else
                        {
                            MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username and email combination not found. Please check your credentials.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Error verifying credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        //}

        private void BTNBACK_Click(object sender, EventArgs e)
        {
            LOGINFORM loginForm = new LOGINFORM();
            this.Hide(); // Hide the current form
            loginForm.Show(); // Show the login form
        }

        private void LBLNEWPASS_Click(object sender, EventArgs e)
        {

        }
    }
}
