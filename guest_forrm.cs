using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace C_PROJECT
{
    public partial class guest_forrm : Form
    {
        public guest_forrm()
        {
            InitializeComponent();
            
            TXTSEARCH.TextChanged += TXTSEARCH_TextChanged;
            
            this.Load += guest_Load;
        }

        private void ShowCoursesInFlowPanel(string searchText)
        {
            FLOWLATOUTPNL.Controls.Clear();

            DataTable courseData = GetCoursesFromDatabase(searchText);

            foreach (DataRow course in courseData.Rows)
            {
                Panel courseCard = CreateCourseCard();
                
                PictureBox courseImage = CreateCourseImage(course);
                
                Label courseTitle = CreateCourseTitle(course);
                
                Label coursePrice = CreateCoursePrice(course);
                
                Button accessButton = CreateAccessButton();

                courseCard.Controls.Add(courseImage);
                courseCard.Controls.Add(courseTitle);
                courseCard.Controls.Add(coursePrice);
                courseCard.Controls.Add(accessButton);
                
                FLOWLATOUTPNL.Controls.Add(courseCard);
            }
        }

        private Panel CreateCourseCard()
        {
            Panel card = new Panel();
            card.Width = 180;
            card.Height = 220;
            card.Margin = new Padding(10);
            card.BorderStyle = BorderStyle.FixedSingle;
            return card;
        }

        private PictureBox CreateCourseImage(DataRow course)
        {
            PictureBox image = new PictureBox();
            image.Width = 160;
            image.Height = 100;
            image.Top = 5;
            image.Left = 10;
            image.SizeMode = PictureBoxSizeMode.StretchImage;

            if (!(course["THUMBNAIL"] is DBNull))
            {
                byte[] imageBytes = (byte[])course["THUMBNAIL"];
                
                using (MemoryStream imageStream = new MemoryStream(imageBytes))
                {
                    image.Image = Image.FromStream(imageStream);
                }
            }
            
            return image;
        }

        private Label CreateCourseTitle(DataRow course)
        {
            Label title = new Label();
            title.Text = course["TITLE"].ToString();
            title.Top = 110;
            title.Left = 10;
            title.Width = 160;
            title.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            return title;
        }

        private Label CreateCoursePrice(DataRow course)
        {
            Label price = new Label();
            string priceText = "Price: " + course["PRICE"].ToString() + " points";
            price.Text = priceText;
            price.Top = 140;
            price.Left = 10;
            price.Width = 160;
            return price;
        }

        private Button CreateAccessButton()
        {
            Button button = new Button();
            button.Text = "Get Access";
            button.Top = 170;
            button.Left = 10;
            button.Width = 160;
            button.BackColor = Color.Orange;
            button.ForeColor = Color.White;
            
            button.Click += AccessButton_Click;
            
            return button;
        }

        private void AccessButton_Click(object sender, EventArgs e)
        {
            string message = "Please login to access this course.";
            string title = "Login Required";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TXTSEARCH_TextChanged(object sender, EventArgs e)
        {
            string searchText = TXTSEARCH.Text.Trim();
            ShowCoursesInFlowPanel(searchText);
        }

        private void guest_Load(object sender, EventArgs e)
        {
            string searchText = TXTSEARCH.Text.Trim();
            ShowCoursesInFlowPanel(searchText);
        }

        private void FLOWLATOUTPNL_Paint(object sender, PaintEventArgs e)
        {
        }




        private void BTNBACK_Click(object sender, EventArgs e)
        {
            LOGINFORM loginForm = new LOGINFORM();
            
            this.Hide();
            
            loginForm.Show();
        }

        private DataTable GetCoursesFromDatabase(string searchText)
        {
            string sql;
            
            if (string.IsNullOrEmpty(searchText))
            {
                sql = "SELECT ID, TITLE, PRICE, THUMBNAIL FROM COURSES";
            }
            else
            {
                sql = "SELECT ID, TITLE, PRICE, THUMBNAIL FROM COURSES WHERE TITLE LIKE '%" + searchText + "%'";
            }

            using (SqlConnection databaseConnection = DBConnection.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, databaseConnection);
                DataTable results = new DataTable();
                adapter.Fill(results);
                
                return results;
            }
        }

        private void LBLSHOWUSRNAME_Click(object sender, EventArgs e)
        {

        }

        private void LBLBALACE_Click(object sender, EventArgs e)
        {

        }
    }
}
