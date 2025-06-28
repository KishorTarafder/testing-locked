using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace C_PROJECT
{
    public partial class showcourse_form : Form
    {
        // This stores all our course data so we can search through it
        private DataTable allCoursesData;
        
        public showcourse_form()
        {
            InitializeComponent();
        }

        // This happens when the form first opens
        private void showcourse_form_Load(object sender, EventArgs e)
        {
            // Change the window title
            this.Text = "Show All Courses";
            
            // Load all courses from database
            ShowAllCourses();
        }

        // This function gets all courses from database and puts them in the grid
        private void ShowAllCourses()
        {
            try
            {
                // Connect to database using your CRUD class
                CRUD db = new CRUD();
                
                // Get all courses from database
                string sql = "SELECT ID, TITLE, INSTRUCTOR, PRICE, YOUTUBEID, ADDEDBY FROM COURSES";
                allCoursesData = db.Select(sql);
                
                // Put the data in the grid so user can see it
                GRIDVIEWSHOWALL.DataSource = allCoursesData;
                
                // Make the grid look nice
                GRIDVIEWSHOWALL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                GRIDVIEWSHOWALL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                
                // Tell user how many courses we found
                MessageBox.Show("Found " + allCoursesData.Rows.Count + " courses", "Success");
            }
            catch (Exception ex)
            {
                // If something goes wrong, tell the user
                MessageBox.Show("Could not load courses. Error: " + ex.Message, "Error");
            }
        }

        // This happens when user types in the search box
        private void TXTSEARCH_TextChanged(object sender, EventArgs e)
        {
            // Get what the user typed
            string searchText = TXTSEARCH.Text;
            
            // If search box is empty, show all courses
            if (string.IsNullOrEmpty(searchText))
            {
                GRIDVIEWSHOWALL.DataSource = allCoursesData;
                return;
            }
            
            try
            {
                // Search in course title, instructor, and who added it
                string filter = "TITLE LIKE '%" + searchText + "%' OR INSTRUCTOR LIKE '%" + searchText + "%' OR ADDEDBY LIKE '%" + searchText + "%'";
                
                // Filter the data
                DataView filteredView = new DataView(allCoursesData);
                filteredView.RowFilter = filter;
                
                // Show filtered results in grid
                GRIDVIEWSHOWALL.DataSource = filteredView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message, "Error");
            }
        }

        // This happens when user clicks "SHOW COURSES" button
        private void BTNSHOWCOURSES_Click(object sender, EventArgs e)
        {
            // Reload all courses from database
            ShowAllCourses();
            
            // Clear the search box
            TXTSEARCH.Text = "";
            
            MessageBox.Show("Courses refreshed!", "Done");
        }

        // This happens when user clicks "UPDATE" button
        private void BTNUPDATE_Click(object sender, EventArgs e)
        {
            // Check if user selected a course
            if (GRIDVIEWSHOWALL.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please click on a course first!", "No Course Selected");
                return;
            }
            
            try
            {
                // Get the selected course
                DataGridViewRow selectedRow = GRIDVIEWSHOWALL.SelectedRows[0];
                int courseId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string currentTitle = selectedRow.Cells["TITLE"].Value.ToString();
                string currentPrice = selectedRow.Cells["PRICE"].Value.ToString();
                
                // Ask user for new title
                string newTitle = SimpleInputBox("Enter new course title:", currentTitle);
                if (string.IsNullOrEmpty(newTitle)) return; // User cancelled
                
                // Ask user for new price
                string newPrice = SimpleInputBox("Enter new price:", currentPrice);
                if (string.IsNullOrEmpty(newPrice)) return; // User cancelled
                
                // Check if price is a number
                int priceNumber;
                if (!int.TryParse(newPrice, out priceNumber))
                {
                    MessageBox.Show("Price must be a number!", "Invalid Price");
                    return;
                }
                
                // Update course in database
                SqlConnection conn = DBConnection.GetConnection();
                conn.Open();
                
                string sql = "UPDATE COURSES SET TITLE = @title, PRICE = @price WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@title", newTitle);
                cmd.Parameters.AddWithValue("@price", priceNumber);
                cmd.Parameters.AddWithValue("@id", courseId);
                
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                
                if (result > 0)
                {
                    MessageBox.Show("Course updated successfully!", "Success");
                    ShowAllCourses(); // Refresh the grid
                }
                else
                {
                    MessageBox.Show("Could not update course!", "Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message, "Error");
            }
        }

        // This happens when user clicks "DELETE" button
        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            // Check if user selected a course
            if (GRIDVIEWSHOWALL.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please click on a course first!", "No Course Selected");
                return;
            }
            
            try
            {
                // Get selected course
                DataGridViewRow selectedRow = GRIDVIEWSHOWALL.SelectedRows[0];
                int courseId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string courseTitle = selectedRow.Cells["TITLE"].Value.ToString();
                
                // Ask user if they are sure
                DialogResult result = MessageBox.Show("Are you sure you want to delete '" + courseTitle + "'?", "Delete Course", MessageBoxButtons.YesNo);
                
                // If user clicked No, stop here
                if (result == DialogResult.No)
                {
                    return;
                }
                
                // Delete course from database
                SqlConnection conn = DBConnection.GetConnection();
                conn.Open();
                
                string sql = "DELETE FROM COURSES WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", courseId);
                
                int deleteResult = cmd.ExecuteNonQuery();
                conn.Close();
                
                if (deleteResult > 0)
                {
                    MessageBox.Show("Course deleted successfully!", "Success");
                    ShowAllCourses(); // Refresh the grid
                }
                else
                {
                    MessageBox.Show("Could not delete course!", "Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message, "Error");
            }
        }

        // This happens when user clicks "BACK" button
        private void BTNBACK_Click(object sender, EventArgs e)
        {
            // Ask user if they want to go back
            DialogResult result = MessageBox.Show("Do you want to go back?", "Go Back", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                this.Close(); // Close this window
            }
        }

        // This happens when user clicks on the grid
        private void GRIDVIEWSHOWALL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // User clicked on a course - now they can update or delete it
        }

        // Simple function to ask user for input
        private string SimpleInputBox(string question, string defaultAnswer)
        {
            // Create a simple window to ask user for input
            Form inputForm = new Form();
            inputForm.Width = 400;
            inputForm.Height = 150;
            inputForm.Text = "Enter Information";
            inputForm.StartPosition = FormStartPosition.CenterParent;
            
            Label questionLabel = new Label();
            questionLabel.Left = 20;
            questionLabel.Top = 20;
            questionLabel.Text = question;
            questionLabel.Width = 350;
            
            TextBox answerBox = new TextBox();
            answerBox.Left = 20;
            answerBox.Top = 50;
            answerBox.Width = 250;
            answerBox.Text = defaultAnswer;
            
            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Left = 280;
            okButton.Top = 48;
            okButton.Width = 80;
            okButton.DialogResult = DialogResult.OK;
            
            Button cancelButton = new Button();
            cancelButton.Text = "Cancel";
            cancelButton.Left = 280;
            cancelButton.Top = 78;
            cancelButton.Width = 80;
            cancelButton.DialogResult = DialogResult.Cancel;
            
            inputForm.Controls.Add(questionLabel);
            inputForm.Controls.Add(answerBox);
            inputForm.Controls.Add(okButton);
            inputForm.Controls.Add(cancelButton);
            
            // Show the window and get user's answer
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                return answerBox.Text;
            }
            return ""; // User cancelled
        }
    }
}
