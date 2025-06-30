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
        private DataTable allCoursesData;
        
        public showcourse_form()
        {
            InitializeComponent();
        }

        private void showcourse_form_Load(object sender, EventArgs e)
        {
            this.Text = "Show All Courses";
            
            ShowAllCourses();
        }

        private void ShowAllCourses()
        {
            try
            {
                CRUD db = new CRUD();
                
                string sql = "SELECT ID, TITLE, INSTRUCTOR, PRICE, YOUTUBEID, ADDEDBY FROM COURSES";
                allCoursesData = db.Select(sql);
                
                GRIDVIEWSHOWALL.DataSource = allCoursesData;
                
                GRIDVIEWSHOWALL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                GRIDVIEWSHOWALL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                
                MessageBox.Show("Found " + allCoursesData.Rows.Count + " courses", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load courses. Error: " + ex.Message, "Error");
            }
        }

        private void TXTSEARCH_TextChanged(object sender, EventArgs e)
        {
            string searchText = TXTSEARCH.Text;
            
            if (string.IsNullOrEmpty(searchText))
            {
                GRIDVIEWSHOWALL.DataSource = allCoursesData;
                return;
            }
            
            try
            {
                string filter = "TITLE LIKE '%" + searchText + "%' OR INSTRUCTOR LIKE '%" + searchText + "%' OR ADDEDBY LIKE '%" + searchText + "%'";
                
                DataView filteredView = new DataView(allCoursesData);
                filteredView.RowFilter = filter;
                
                GRIDVIEWSHOWALL.DataSource = filteredView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message, "Error");
            }
        }

        private void BTNSHOWCOURSES_Click(object sender, EventArgs e)
        {
            ShowAllCourses();
            
            TXTSEARCH.Text = "";
            
            MessageBox.Show("Courses refreshed!", "Done");
        }

        private void BTNUPDATE_Click(object sender, EventArgs e)
        {
            if (GRIDVIEWSHOWALL.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please click on a course first!", "No Course Selected");
                return;
            }
            
            try
            {
                DataGridViewRow selectedRow = GRIDVIEWSHOWALL.SelectedRows[0];
                int courseId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string currentTitle = selectedRow.Cells["TITLE"].Value.ToString();
                string currentPrice = selectedRow.Cells["PRICE"].Value.ToString();
                
                string newTitle = SimpleInputBox("Enter new course title:", currentTitle);
                if (string.IsNullOrEmpty(newTitle)) return;
                
                string newPrice = SimpleInputBox("Enter new price:", currentPrice);
                if (string.IsNullOrEmpty(newPrice)) return;
                
                int priceNumber;
                if (!int.TryParse(newPrice, out priceNumber))
                {
                    MessageBox.Show("Price must be a number!", "Invalid Price");
                    return;
                }
                
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
                    ShowAllCourses();
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

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            if (GRIDVIEWSHOWALL.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please click on a course first!", "No Course Selected");
                return;
            }
            
            try
            {
                DataGridViewRow selectedRow = GRIDVIEWSHOWALL.SelectedRows[0];
                int courseId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string courseTitle = selectedRow.Cells["TITLE"].Value.ToString();
                
                DialogResult result = MessageBox.Show("Are you sure you want to delete '" + courseTitle + "'?", "Delete Course", MessageBoxButtons.YesNo);
                
                if (result == DialogResult.No)
                {
                    return;
                }
                
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
                    ShowAllCourses();
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

        private void BTNBACK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to go back?", "Go Back", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void GRIDVIEWSHOWALL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private string SimpleInputBox(string question, string defaultAnswer)
        {
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
            
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                return answerBox.Text;
            }
            return "";
        }
    }
}
