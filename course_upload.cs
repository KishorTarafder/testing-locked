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
        private string username; // Store the logged-in user's username

        // Constructor that accepts username
        public course_upload(string user)
        {
            InitializeComponent();
            username = user; // Set the username for use in this form
        }

        public course_upload()
        {
            InitializeComponent();
        }

        // Method to show user information in the labels
        private void ShowUserInfo()
        {
            if (string.IsNullOrEmpty(username))
            {
                LBLSHOWUSRNAME.Text = "Guest User";
                LBLBALACE.Text = "Balance: N/A";
                return;
            }

            CRUD db = new CRUD();

            // Prepare a query to get the user's info
            string sql = $"SELECT Username, Balance FROM signup_info WHERE Username = '{username}'";

            // Execute the query, get the results in a DataTable
            DataTable dt = db.Select(sql);

            if (dt.Rows.Count == 1)
            {
                // Get the username and balance from the first row
                string user = dt.Rows[0]["Username"].ToString();
                int bal = Convert.ToInt32(dt.Rows[0]["Balance"]);

                // Show in your labels
                LBLSHOWUSRNAME.Text = $"Welcome, {user}!";
                LBLBALACE.Text = $"Balance: {bal}";
            }
            else
            {
                // If not found, show something empty or error
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
            open.Filter= "image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Assuming you want to display the selected image in a PictureBox named 'pictureBox1'
                pictureBox1.Image = new Bitmap(open.FileName);
                imagepath = open.FileName; 
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {

            //...............convert korsi binary teh 

            byte[] imageData = null;
            if (imagepath != "")
            {
                using (Stream   st = File.OpenRead(imagepath))
                {
                    imageData = new byte[st.Length];
                    st.Read(imageData, 0, imageData.Length);
                }
                {

                }
            }





            //.............//
            SqlConnection conn = DBConnection.GetConnection();
            try
            {
              //  conn.Open();
              //  string sql = "INSERT INTO COURSES (CourseName, CourseImage, YouTubeLink) VALUES (@CourseName, @CourseImage, @YouTubeLink)";
              //  SqlCommand cmd = new SqlCommand(sql, conn);
              //  cmd.Parameters.AddWithValue("@CourseName", TXTCOURSENAME.Text);
              ////cmd.Parameters.AddWithValue("@CourseDescription", TXTDESCRIPTION.Text);
              //  cmd.Parameters.AddWithValue("@CourseImage", imageData); // Assuming imageData is a byte array
              //  cmd.Parameters.AddWithValue("@YouTubeLink", TXTYOUTUBELINK.Text);


                conn.Open();
                string sql = "INSERT INTO COURSES (TITLE, THUMBNAIL, YOUTUBEID,PRICE) VALUES (@TITLE, @THUMBNAIL, @YOUTUBEID,@PRICE)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TITLE", TXTCOURSENAME.Text);            // Course name
                cmd.Parameters.AddWithValue("@THUMBNAIL", imageData);                 // Image
                cmd.Parameters.AddWithValue("@YOUTUBEID", TXTYOUTUBELINK.Text);
                cmd.Parameters.AddWithValue("@PRICE", TXTPRICE.Text);




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
            {
               
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

        }
    }
}
