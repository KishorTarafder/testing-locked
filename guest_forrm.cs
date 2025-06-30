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
            
            // When user types in search box, search for courses
            TXTSEARCH.TextChanged += TXTSEARCH_TextChanged;
            
            // When form opens, show all courses
            this.Load += guest_Load;
        }

        // This method shows courses on the screen
        // If user searches, it shows only matching courses
        private void ShowCoursesInFlowPanel(string searchText)
        {
            // Step 1: Clear any old course cards from screen
            FLOWLATOUTPNL.Controls.Clear();

            // Step 2: Get course data from database (super simple way!)
            DataTable courseData = GetCoursesFromDatabase(searchText);

            // Step 3: Create visual cards for each course
            foreach (DataRow course in courseData.Rows)
            {
                // Create a card (box) for this course
                Panel courseCard = CreateCourseCard();
                
                // Add course image to card
                PictureBox courseImage = CreateCourseImage(course);
                
                // Add course title to card
                Label courseTitle = CreateCourseTitle(course);
                
                // Add course price to card
                Label coursePrice = CreateCoursePrice(course);
                
                // Add "Get Access" button to card
                Button accessButton = CreateAccessButton();

                // Put all parts into the course card
                courseCard.Controls.Add(courseImage);
                courseCard.Controls.Add(courseTitle);
                courseCard.Controls.Add(coursePrice);
                courseCard.Controls.Add(accessButton);
                
                // Add the complete course card to main panel
                FLOWLATOUTPNL.Controls.Add(courseCard);
            }
        }

        // Create the main card (box) that holds course info
        private Panel CreateCourseCard()
        {
            Panel card = new Panel();
            card.Width = 180;           // Card width in pixels
            card.Height = 220;          // Card height in pixels
            card.Margin = new Padding(10);  // Space around card
            card.BorderStyle = BorderStyle.FixedSingle;  // Draw border around card
            return card;
        }

        // Create and setup the course image
        private PictureBox CreateCourseImage(DataRow course)
        {
            PictureBox image = new PictureBox();
            image.Width = 160;          // Image width
            image.Height = 100;         // Image height
            image.Top = 5;              // Position from top of card
            image.Left = 10;            // Position from left of card
            image.SizeMode = PictureBoxSizeMode.StretchImage;  // Fit image in box

            // Check if course has an image in database
            if (!(course["THUMBNAIL"] is DBNull))
            {
                // Get image data from database (stored as bytes)
                byte[] imageBytes = (byte[])course["THUMBNAIL"];
                
                // Convert bytes to actual image
                using (MemoryStream imageStream = new MemoryStream(imageBytes))
                {
                    image.Image = Image.FromStream(imageStream);
                }
            }
            
            return image;
        }

        // Create and setup the course title text
        private Label CreateCourseTitle(DataRow course)
        {
            Label title = new Label();
            title.Text = course["TITLE"].ToString();  // Get title from database
            title.Top = 110;            // Position from top of card
            title.Left = 10;            // Position from left of card
            title.Width = 160;          // Label width
            title.Font = new Font("Segoe UI", 10, FontStyle.Bold);  // Make text bold
            return title;
        }

        // Create and setup the course price text
        private Label CreateCoursePrice(DataRow course)
        {
            Label price = new Label();
            string priceText = "Price: " + course["PRICE"].ToString() + " points";
            price.Text = priceText;     // Show price with "points" word
            price.Top = 140;            // Position from top of card
            price.Left = 10;            // Position from left of card  
            price.Width = 160;          // Label width
            return price;
        }

        // Create the "Get Access" button
        private Button CreateAccessButton()
        {
            Button button = new Button();
            button.Text = "Get Access";
            button.Top = 170;           // Position from top of card
            button.Left = 10;           // Position from left of card
            button.Width = 160;         // Button width
            button.BackColor = Color.Orange;  // Orange background
            button.ForeColor = Color.White;   // White text
            
            // When user clicks button, show message
            button.Click += AccessButton_Click;
            
            return button;
        }

        // What happens when user clicks "Get Access" button
        private void AccessButton_Click(object sender, EventArgs e)
        {
            string message = "Please login to access this course.";
            string title = "Login Required";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // When user types in search box, search for courses
        private void TXTSEARCH_TextChanged(object sender, EventArgs e)
        {
            string searchText = TXTSEARCH.Text.Trim();  // Get text and remove spaces
            ShowCoursesInFlowPanel(searchText);         // Show matching courses
        }

        // When form first opens, show all courses
        private void guest_Load(object sender, EventArgs e)
        {
            string searchText = TXTSEARCH.Text.Trim();  // Get any text in search box
            ShowCoursesInFlowPanel(searchText);         // Show courses
        }

        // This method exists but doesn't do anything (can be ignored)
        private void FLOWLATOUTPNL_Paint(object sender, PaintEventArgs e)
        {
            // Empty - this is normal, just leave it
        }

        // When user clicks "Back" button, go to login form
        private void BTNBACK_Click(object sender, EventArgs e)
        {
            // Create new login form
            LOGINFORM loginForm = new LOGINFORM();
            
            // Hide this guest form
            this.Hide();
            
            // Show the login form
            loginForm.Show();
        }

        // SUPER SIMPLE DATABASE METHOD - no complex security stuff!
        private DataTable GetCoursesFromDatabase(string searchText)
        {
            string sql;
            
            if (string.IsNullOrEmpty(searchText))
            {
                // No search - show all courses
                sql = "SELECT ID, TITLE, PRICE, THUMBNAIL FROM COURSES";
            }
            else
            {
                // Simple search - just add the text directly!
                sql = "SELECT ID, TITLE, PRICE, THUMBNAIL FROM COURSES WHERE TITLE LIKE '%" + searchText + "%'";
            }

            // Get data from database (easy way!)
            using (SqlConnection databaseConnection = DBConnection.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, databaseConnection);
                DataTable results = new DataTable();
                adapter.Fill(results); // This handles Open/Close automatically!
                
                return results;
            }
        }
    }
}
