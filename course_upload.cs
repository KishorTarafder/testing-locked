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
using System.IO;

namespace C_PROJECT
{
    public partial class course_upload : Form
    {

        string imagepath;
        private string username;

        public course_upload(string user)
        {
            InitializeComponent();
            username = user;
        }

        public course_upload()
        {
            InitializeComponent();
        }

        private void ShowUserInfo()
        {
            if (string.IsNullOrEmpty(username))
            {
                LBLSHOWUSRNAME.Text = "Guest User";
                LBLBALACE.Text = "Balance: N/A";
                return;
            }

            CRUD db = new CRUD();

            string sql = $"SELECT Username, Balance FROM signup_info WHERE Username = '{username}'";

            DataTable dt = db.Select(sql);

            if (dt.Rows.Count == 1)
            {
                string user = dt.Rows[0]["Username"].ToString();
                int bal = Convert.ToInt32(dt.Rows[0]["Balance"]);

                LBLSHOWUSRNAME.Text = $"Welcome, {user}!";
                LBLBALACE.Text = $"Balance: {bal}";
            }
            else
            {
                LBLSHOWUSRNAME.Text = "Unknown user";
                LBLBALACE.Text = "Balance: N/A";
            }
        }

        private void TXTYOUTUBELINK_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNBROWSE_Click(object sender, EventArgs e)
        {

                        OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                imagepath = open.FileName; 
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

                private void BTNSAVE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("You must be logged in to upload a course!", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(TXTCOURSENAME.Text))
            {
                MessageBox.Show("Please enter a course name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(TXTPRICE.Text))
            {
                MessageBox.Show("Please enter a price!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] imageData = null;
            if (imagepath != "")
            {
                using (Stream   st = File.OpenRead(imagepath))
                {
                    imageData = new byte[st.Length];
                    st.Read(imageData, 0, imageData.Length);
                }
            }
            SqlConnection conn = DBConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "INSERT INTO COURSES (TITLE, THUMBNAIL, YOUTUBEID, PRICE, ADDEDBY) VALUES (@TITLE, @THUMBNAIL, @YOUTUBEID, @PRICE, @ADDEDBY)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TITLE", TXTCOURSENAME.Text);
                cmd.Parameters.AddWithValue("@THUMBNAIL", imageData);
                cmd.Parameters.AddWithValue("@YOUTUBEID", TXTYOUTUBELINK.Text);
                cmd.Parameters.AddWithValue("@PRICE", TXTPRICE.Text);
                if (username == null || username == "")
                {
                    cmd.Parameters.AddWithValue("@ADDEDBY", "Unknown");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ADDEDBY", username);
                }

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Course uploaded successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to upload course. Please try again.");
                }

            }
            catch (Exception gg )
                        {
                MessageBox.Show("An error occurred: " + gg.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }





        }

        private void TXTPRICE_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLSHOWUSRNAME_Click(object sender, EventArgs e)
        {

        }

        private void LBLBALACE_Click(object sender, EventArgs e)
        {

        }

        private void LBLUSER_Click(object sender, EventArgs e)
        {

        }

        private void course_upload_Load(object sender, EventArgs e)
        {
            ShowUserInfo();
        }

        private void BTNBACK_Click(object sender, EventArgs e)
        {

        }

        private void BTNBACK_Click_1(object sender, EventArgs e)
        {
            LOGINFORM loginForm = new LOGINFORM();
            this.Hide();
            loginForm.Show();
        }

        private void BTNUPLOAD_Click(object sender, EventArgs e)
        {

        }

        private void TXTCOURSENAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNADDCOURSE_Click(object sender, EventArgs e)
        {

        }

        private void LBLYTLINK_Click(object sender, EventArgs e)
        {

        }
    }
}
