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

        private void ShowUserInfo()
        {
            
            CRUD db = new CRUD();

            string sql = $"SELECT Username, Balance FROM signup_info WHERE Username = '{username}'";

            DataTable dt = db.Select(sql);

            if (dt.Rows.Count == 1)
            {
                string user = dt.Rows[0]["Username"].ToString();
                int balancee = Convert.ToInt32(dt.Rows[0]["Balance"]);

                LBLSHOWUSRNAME.Text = $"  {user}   !";
                LBLBALACE.Text = $"    {balancee}";
            }
            else
            {
                LBLSHOWUSRNAME.Text = "Unknown user";
                LBLBALACE.Text = "Balance: N/A";
            }
        }






        private void student_form_Load(object sender, EventArgs e)
        {


           
            ShowUserInfo(); // all student er info dekhabe
            ShowAllCoursesInFlowPanel(); 
        

        }

        private void ShowAllCoursesInFlowPanel(string searchText = "")//  course dekhabe and kinda dynamic
        {
            FLOWLATOUTPNL.Controls.Clear();

            string sql = "SELECT ID, TITLE, PRICE, YOUTUBEID, THUMBNAIL FROM COURSES";
            
            if (!string.IsNullOrEmpty(searchText))
            {
                sql += $" WHERE TITLE LIKE '%{searchText}%'";
            }

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                bool foundResults = false;

                while (reader.Read())
                {
                    foundResults = true;
                    int courseId = Convert.ToInt32(reader["ID"]);

                    Panel card = new Panel();
                    card.Width = 180;
                    card.Height = 220;
                    card.Margin = new Padding(10);
                    card.BorderStyle = BorderStyle.FixedSingle;

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

                    Label lblTitle = new Label();
                    lblTitle.Text = reader["TITLE"].ToString();
                    lblTitle.Top = 110; lblTitle.Left = 10;
                    lblTitle.Width = 160; lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                    Label lblPrice = new Label();
                    lblPrice.Text = "Price: " + reader["PRICE"].ToString();
                    lblPrice.Top = 140; lblPrice.Left = 10; lblPrice.Width = 160;

                    bool hasPurchased = HasUserPurchasedCourse(courseId);

                    Button btnAction = new Button();
                    btnAction.Top = 170; btnAction.Left = 10; btnAction.Width = 160;

                    if (hasPurchased)
                    {
                        btnAction.Text = "PLAY";
                        btnAction.BackColor = Color.Green;
                        string yt = reader["YOUTUBEID"].ToString();
                        btnAction.Click += (s, ev) => { 
                            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=" + yt); 
                        };
                    }
                    else
                    {
                        btnAction.Text = "BUY";
                        btnAction.BackColor = Color.Orange;
                        int price = Convert.ToInt32(reader["PRICE"]);
                        string title = reader["TITLE"].ToString();
                        string yt = reader["YOUTUBEID"].ToString();
                        btnAction.Click += (s, ev) => {
                            BuyCourse(courseId, price, title, yt);
                        };
                    }

                    card.Controls.Add(pic);
                    card.Controls.Add(lblTitle);
                    card.Controls.Add(lblPrice);
                    card.Controls.Add(btnAction);

                    FLOWLATOUTPNL.Controls.Add(card);
                }
                
                if (!foundResults && !string.IsNullOrEmpty(searchText))
                {
                    Label noResultsLabel = new Label();
                    noResultsLabel.Text = $"No courses found for '{searchText}'";
                    noResultsLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    noResultsLabel.ForeColor = Color.White;
                    noResultsLabel.AutoSize = true;
                    FLOWLATOUTPNL.Controls.Add(noResultsLabel);
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
                MessageBox.Show($"Insufficient balance! You need {price} points but have only {currentBalance} points.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Do you want to buy '{courseTitle}' for {price} points?\n\nYour current balance: {currentBalance} points\nAfter purchase: {currentBalance - price} points",
                "Confirm Purchase",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int newBalance = currentBalance - price;
                    string updateBalanceQuery = $"UPDATE signup_info SET Balance = {newBalance} WHERE Username = '{username}'";
                    int updateResult = db.Update(updateBalanceQuery);

                    if (updateResult > 0)
                    {
                        string purchaseQuery = $"INSERT INTO PURCHASES (USERNAME, COURSE_ID) VALUES ('{username}', {courseId})";
                        int purchaseResult = db.Insert(purchaseQuery);

                        if (purchaseResult > 0)
                        {
                            MessageBox.Show($"Course '{courseTitle}' purchased successfully!\n\nYou can now access the course anytime.",
                                "Purchase Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ShowUserInfo();
                            ShowAllCoursesInFlowPanel();
                        }
                        else
                        {
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

        private void BTNBACK_Click(object sender, EventArgs e)
        {
            LOGINFORM loginForm = new LOGINFORM();
            this.Hide(); // Hide the current form
            loginForm.Show(); // Show the login form
        }

        private void TXTSEARCH_TextChanged(object sender, EventArgs e)
        {
            string searchText = TXTSEARCH.Text.Trim();
            ShowAllCoursesInFlowPanel(searchText);
        }
    }
}
