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
        // string connectionString = "Data Source=DESKTOP-HNPCF1F\\SQLEXPRESS;Initial Catalog=DBLOGIN;Integrated Security=True;Encrypt=True;";
        string connectionString = "Data Source=DESKTOP-HNPCF1F\\SQLEXPRESS;Initial Catalog=DBLOGIN;Integrated Security=True;";



        public course_upload()
        {
            InitializeComponent();
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
            SqlConnection conn = new SqlConnection(connectionString);
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
    }
}
