using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PROJECT
{
    public partial class admin_control_form : Form
    {
        public admin_control_form()
        {
            InitializeComponent();
        }

        private void BTNSHOWALL_Click(object sender, EventArgs e)
        {

            // Define the SQL query
            string query = "SELECT * FROM signup_info";

            // Create a SqlConnection instance using DBConnection helper
            SqlConnection con = DBConnection.GetConnection();

            // Create a SqlDataAdapter with the query and the connection
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            // Create a DataTable to hold the data from the database
            DataTable dt = new DataTable();

            // Fill the DataTable using the SqlDataAdapter
            sda.Fill(dt);

            // Bind the DataTable to the DataGridView
            GRIDVIEWSHOWALL.DataSource = dt;
        }


        

        private void GRIDVIEWSHOWALL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TXTSEARCH_TextChanged(object sender, EventArgs e)
        {

            string query = "SELECT * FROM signup_info WHERE Username LIKE '%" + TXTSEARCH.Text + "%'";

            // Create a SqlConnection instance using DBConnection helper
            SqlConnection con = DBConnection.GetConnection();

            // Create a SqlDataAdapter with the query and the connection
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            // Create a DataTable to hold the data from the database
            DataTable dt = new DataTable();

            // Fill the DataTable using the SqlDataAdapter
            sda.Fill(dt);

            // Bind the DataTable to the DataGridView to show filtered results
            GRIDVIEWSHOWALL.DataSource = dt;


        }

        private void GRIDVIEWSHOWALL_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
            // Ensure a valid row is selected (not header row)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = GRIDVIEWSHOWALL.Rows[e.RowIndex];

                // Populate the textboxes with the selected row values
                TXTID.Text = selectedRow.Cells["ID"].Value.ToString();
                TXTUSERNAME.Text = selectedRow.Cells["Username"].Value.ToString();
                TXTPASSWORD.Text = selectedRow.Cells["Password"].Value.ToString();
                TXTUSERTYPE.Text = selectedRow.Cells["UserType"].Value.ToString();
                TXTSTATUS.Text = selectedRow.Cells["Status"].Value.ToString();
            }
        }








        

        private void TXTID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTUSERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTPASSWORD_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTUSERTYPE_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTSTATUS_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNSEARCH_Click(object sender, EventArgs e)
        {

        }

        private void BTNUPDATE_Click(object sender, EventArgs e)
        {

            CRUD db = new CRUD();

            // Construct the SQL update query
            string updateQuery = "UPDATE signup_info SET Username = '" + TXTUSERNAME.Text + "', Password = '" + TXTPASSWORD.Text + "', UserType = '" + TXTUSERTYPE.Text + "', Status = '" + TXTSTATUS.Text + "' WHERE ID = " + TXTID.Text;

            // Call the Insert method from CRUD class for update query
            int result = db.Update(updateQuery);  // Use Update method from CRUD to execute query

            // Check if the update was successful
            if (result > 0)
            {
                MessageBox.Show("Record updated successfully!");
                BTNSHOWALL_Click(null, null); // Refresh the DataGridView after the update
            }
            else
            {
                MessageBox.Show("Update failed. Please try again.");
            }



        }

        private void BTNADD_Click(object sender, EventArgs e)
        {

            // Check if all required fields are filled
            if (string.IsNullOrEmpty(TXTUSERNAME.Text) ||
                string.IsNullOrEmpty(TXTPASSWORD.Text) ||
                string.IsNullOrEmpty(TXTUSERTYPE.Text) ||
                string.IsNullOrEmpty(TXTSTATUS.Text))
            {
                MessageBox.Show("Please fill all fields!", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CRUD db = new CRUD();

            // Check if username already exists
            string checkQuery = "SELECT COUNT(*) FROM signup_info WHERE Username = '" + TXTUSERNAME.Text + "'";
            DataTable dt = db.Select(checkQuery);

            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                MessageBox.Show("Username '" + TXTUSERNAME.Text + "' already exists! Please choose a different username.",
                    "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert new user with default balance of 1000
            string insertQuery = "INSERT INTO signup_info (Username, Password, UserType, Status, Balance) VALUES ('" +
                                TXTUSERNAME.Text + "', '" +
                                TXTPASSWORD.Text + "', '" +
                                TXTUSERTYPE.Text + "', '" +
                                TXTSTATUS.Text + "', 1000)";

            try
            {
                int result = db.Insert(insertQuery);

                if (result > 0)
                {
                    MessageBox.Show("User added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the textboxes after successful addition
                    TXTID.Text = "";
                    TXTUSERNAME.Text = "";
                    TXTPASSWORD.Text = "";
                    TXTUSERTYPE.Text = "";
                    TXTSTATUS.Text = "";

                    // Refresh the DataGridView to show the new user
                    BTNSHOWALL_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Failed to add user. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNBACK_Click(object sender, EventArgs e)
        {
            LOGINFORM loginForm = new LOGINFORM();
            this.Hide(); // Hide the current form
            loginForm.Show(); // Show the login form
        }
    }
        //{
        //    // Check if all required fields are filled
        //    if (string.IsNullOrEmpty(TXTUSERNAME.Text) ||
        //        string.IsNullOrEmpty(TXTPASSWORD.Text) ||
        //        string.IsNullOrEmpty(TXTUSERTYPE.Text) ||
        //        string.IsNullOrEmpty(TXTSTATUS.Text))
        //    {
        //        MessageBox.Show("Please fill all fields!", "Missing Information",
        //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    // Create CRUD instance
        //    CRUD db = new CRUD();

        //    // Insert new user with default balance of 1000
        //    string insertQuery = "INSERT INTO signup_info (Username, Password, UserType, Status, Balance) VALUES ('" +
        //                        TXTUSERNAME.Text + "', '" +
        //                        TXTPASSWORD.Text + "', '" +
        //                        TXTUSERTYPE.Text + "', '" +
        //                        TXTSTATUS.Text + "', 1000)";

        //    try
        //    {
        //        int result = db.Insert(insertQuery);

        //        if (result > 0)
        //        {
        //            MessageBox.Show("User added successfully!", "Success",
        //                MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            // Clear the textboxes after successful addition
        //            TXTID.Text = "";
        //            TXTUSERNAME.Text = "";
        //            TXTPASSWORD.Text = "";
        //            TXTUSERTYPE.Text = "";
        //            TXTSTATUS.Text = "";

        //            // Refresh the DataGridView to show the new user
        //            BTNSHOWALL_Click(null, null);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Failed to add user. Please try again.", "Error",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Database Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

    }

