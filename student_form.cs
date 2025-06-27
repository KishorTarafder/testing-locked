using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.IO;



namespace C_PROJECT
{
    public partial class student_form : Form
    {

        private string username;






        public student_form(string user)
        {
            InitializeComponent();
            

            username = user; // Sets the username for use in this form

        }


        public student_form()
        {
            InitializeComponent();

        }

        //............ADD KORSI TO SHOW KER KOTO BALACE AND USER NAMME ETC 
        private void ShowUserInfo()
        {
            
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






        private void student_form_Load(object sender, EventArgs e)
        {


           
            ShowUserInfo(); // Display the student's info
            ShowAllCoursesInFlowPanel(); 
        

        }

        //private void ShowAllCoursesInFlowPanel()
        //{
        //    FLOWLATOUTPNL.Controls.Clear(); // Remove old cards

        //    // This old method is commented out - using centralized DBConnection now
        //    string sql = "SELECT ID, TITLE, PRICE, YOUTUBEID, THUMBNAIL FROM COURSES";

        //    using (SqlConnection conn = new SqlConnection(connStr))
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            // Create a panel to hold image + info
        //            Panel card = new Panel();
        //            card.Width = 180;
        //            card.Height = 220;
        //            card.Margin = new Padding(10);

        //            // Show thumbnail if it exists
        //            PictureBox pic = new PictureBox();
        //            pic.Width = 160; pic.Height = 100; pic.Top = 5; pic.Left = 10; pic.SizeMode = PictureBoxSizeMode.StretchImage;
        //            if (!(reader["THUMBNAIL"] is DBNull))
        //            {
        //                byte[] imgBytes = (byte[])reader["THUMBNAIL"];
        //                using (MemoryStream ms = new MemoryStream(imgBytes))
        //                {
        //                    pic.Image = Image.FromStream(ms);
        //                }
        //            }

        //            // Course title
        //            Label lblTitle = new Label();
        //            lblTitle.Text = reader["TITLE"].ToString();
        //            lblTitle.Top = 110; lblTitle.Left = 10;
        //            lblTitle.Width = 160; lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

        //            // Price
        //            Label lblPrice = new Label();
        //            lblPrice.Text = "Price: " + reader["PRICE"].ToString();
        //            lblPrice.Top = 140; lblPrice.Left = 10; lblPrice.Width = 100;

        //            // Play button
        //            Button btnPlay = new Button();
        //            btnPlay.Text = "PLAY";
        //            btnPlay.Top = 170; btnPlay.Left = 10; btnPlay.Width = 160;
        //            string yt = reader["YOUTUBEID"].ToString();
        //            btnPlay.Click += (s, ev) => { System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=" + yt); };

        //            // Add to card
        //            card.Controls.Add(pic);
        //            card.Controls.Add(lblTitle);
        //            card.Controls.Add(lblPrice);
        //            card.Controls.Add(btnPlay);

        //            // Add card to the FlowLayoutPanel
        //            FLOWLATOUTPNL.Controls.Add(card);
        //        }

        //        conn.Close();
        //    }
        //}

        private void ShowAllCoursesInFlowPanel()
        {
            FLOWLATOUTPNL.Controls.Clear(); // Remove old cards

            // Using centralized connection string from DBConnection
            string sql = "SELECT ID, TITLE, PRICE, YOUTUBEID, THUMBNAIL FROM COURSES";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int courseId = Convert.ToInt32(reader["ID"]); // Get course ID

                    // Create a panel to hold image + info
                    Panel card = new Panel();
                    card.Width = 180;
                    card.Height = 220;
                    card.Margin = new Padding(10);
                    card.BorderStyle = BorderStyle.FixedSingle; // Add border

                    // Show thumbnail if it exists
                    PictureBox pic = new PictureBox();
                    pic.Width = 160; pic.Height = 100; pic.Top = 5; pic.Left = 10; pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (!(reader["THUMBNAIL"] is DBNull))
                    {
                        byte[] imgBytes = (byte[])reader["THUMBNAIL"];
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            pic.Image = Image.FromStream(ms);
                        }
                    }

                    // Course title
                    Label lblTitle = new Label();
                    lblTitle.Text = reader["TITLE"].ToString();
                    lblTitle.Top = 110; lblTitle.Left = 10;
                    lblTitle.Width = 160; lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                    // Price
                    Label lblPrice = new Label();
                    lblPrice.Text = "Price: " + reader["PRICE"].ToString() + " points";
                    lblPrice.Top = 140; lblPrice.Left = 10; lblPrice.Width = 160;

                    // Check if user already bought this course
                    bool hasPurchased = HasUserPurchasedCourse(courseId);

                    // Smart Buy/Play button
                    Button btnAction = new Button();
                    btnAction.Top = 170; btnAction.Left = 10; btnAction.Width = 160;

                    if (hasPurchased) // If user owns the course
                    {
                        btnAction.Text = "PLAY";
                        btnAction.BackColor = Color.Green;
                        btnAction.ForeColor = Color.White;
                        string yt = reader["YOUTUBEID"].ToString();
                        btnAction.Click += (s, ev) => {
                            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=" + yt);
                        };
                    }
                    else // If user doesn't own the course
                    {
                        btnAction.Text = "BUY";
                        btnAction.BackColor = Color.Orange;
                        btnAction.ForeColor = Color.White;
                        int price = Convert.ToInt32(reader["PRICE"]);
                        string title = reader["TITLE"].ToString();
                        string yt = reader["YOUTUBEID"].ToString();
                        btnAction.Click += (s, ev) => {
                            BuyCourse(courseId, price, title, yt);
                        };
                    }

                    // Add to card
                    card.Controls.Add(pic);
                    card.Controls.Add(lblTitle);
                    card.Controls.Add(lblPrice);
                    card.Controls.Add(btnAction);

                    // Add card to the FlowLayoutPanel
                    FLOWLATOUTPNL.Controls.Add(card);
                }
                
                conn.Close();
            }
        }












        private void BTNPLAYorBUY_Click(object sender, EventArgs e)
        {

        }

        private void FLOWLATOUTPNL_Paint(object sender, PaintEventArgs e)
        {








        }




        // ............................. TO BUY THE COURSE .............................

        private bool HasUserPurchasedCourse(int courseId)
        {
            CRUD db = new CRUD();
            string sql = $"SELECT COUNT(*) FROM PURCHASES WHERE USERNAME = '{username}' AND COURSE_ID = {courseId}";
            DataTable dt = db.Select(sql);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0][0]) > 0;
            }
            return false;
        }

        private void BuyCourse(int courseId, int price, string courseTitle, string youtubeId)
        {
            // Check user's current balance
            CRUD db = new CRUD();
            string balanceQuery = $"SELECT Balance FROM signup_info WHERE Username = '{username}'";
            DataTable dt = db.Select(balanceQuery);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("User not found!");
                return;
            }

            int currentBalance = Convert.ToInt32(dt.Rows[0]["Balance"]);

            if (currentBalance < price)
            {
                MessageBox.Show($"Insufficient balance! You need {price} points but have only {currentBalance} points.",
                    "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm purchase
            DialogResult result = MessageBox.Show(
                $"Do you want to buy '{courseTitle}' for {price} points?\n\nYour current balance: {currentBalance} points\nAfter purchase: {currentBalance - price} points",
                "Confirm Purchase",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Deduct balance
                    int newBalance = currentBalance - price;
                    string updateBalanceQuery = $"UPDATE signup_info SET Balance = {newBalance} WHERE Username = '{username}'";
                    int updateResult = db.Update(updateBalanceQuery);

                    if (updateResult > 0)
                    {
                        // Record purchase
                        string purchaseQuery = $"INSERT INTO PURCHASES (USERNAME, COURSE_ID) VALUES ('{username}', {courseId})";
                        int purchaseResult = db.Insert(purchaseQuery);

                        if (purchaseResult > 0)
                        {
                            MessageBox.Show($"Course '{courseTitle}' purchased successfully!\n\nYou can now access the course anytime.",
                                "Purchase Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the display
                            ShowUserInfo(); // Update balance display
                            ShowAllCoursesInFlowPanel(); // Refresh course cards
                        }
                        else
                        {
                            // Rollback balance if purchase recording failed
                            string rollbackQuery = $"UPDATE signup_info SET Balance = {currentBalance} WHERE Username = '{username}'";
                            db.Update(rollbackQuery);
                            MessageBox.Show("Error recording purchase. Your balance has been restored.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error processing payment. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during purchase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }














        private void PICBOX1_Click(object sender, EventArgs e)
        {

        }

        

        private void PNLINSIDE1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PNLHOLDDINGALL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LBLSHOWUSRNAME_Click(object sender, EventArgs e)
        {

        }

        private void LBLUSER_Click(object sender, EventArgs e)
        {

        }

        private void LBLBALACE_Click(object sender, EventArgs e)
        {

        }
    }
}
