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
            // Make sure the event is hooked up (in case you didn't do it in Designer)
            TXTSEARCH.TextChanged += TXTSEARCH_TextChanged;
            this.Load += guest_Load; // Form load event
        }

        // Show all courses or filtered courses (by search term)
        private void ShowCoursesInFlowPanel(string searchTerm)
        {
            FLOWLATOUTPNL.Controls.Clear(); // Clear old course cards

            // Using centralized connection string from DBConnection
            string sql = "SELECT ID, TITLE, PRICE, THUMBNAIL FROM COURSES";

            if (!string.IsNullOrEmpty(searchTerm))
                sql += " WHERE TITLE LIKE @search";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                if (!string.IsNullOrEmpty(searchTerm))
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Build the course card
                    Panel card = new Panel
                    {
                        Width = 180,
                        Height = 220,
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Thumbnail
                    PictureBox pic = new PictureBox
                    {
                        Width = 160,
                        Height = 100,
                        Top = 5,
                        Left = 10,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    if (!(reader["THUMBNAIL"] is DBNull))
                    {
                        byte[] imgBytes = (byte[])reader["THUMBNAIL"];
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            pic.Image = Image.FromStream(ms);
                        }
                    }

                    // Title
                    Label lblTitle = new Label
                    {
                        Text = reader["TITLE"].ToString(),
                        Top = 110,
                        Left = 10,
                        Width = 160,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold)
                    };

                    // Price
                    Label lblPrice = new Label
                    {
                        Text = "Price: " + reader["PRICE"].ToString() + " points",
                        Top = 140,
                        Left = 10,
                        Width = 160
                    };

                    // Access button
                    Button btnGetAccess = new Button
                    {
                        Text = "Get Access",
                        Top = 170,
                        Left = 10,
                        Width = 160,
                        BackColor = Color.Orange,
                        ForeColor = Color.White
                    };
                    btnGetAccess.Click += (s, ev) =>
                    {
                        MessageBox.Show("Please login to access this course.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    };

                    // Add to card and to panel
                    card.Controls.Add(pic);
                    card.Controls.Add(lblTitle);
                    card.Controls.Add(lblPrice);
                    card.Controls.Add(btnGetAccess);
                    FLOWLATOUTPNL.Controls.Add(card);
                }

                conn.Close();
            }
        }

        // Live search: update when you type
        private void TXTSEARCH_TextChanged(object sender, EventArgs e)
        {
            ShowCoursesInFlowPanel(TXTSEARCH.Text.Trim());
        }

        // On form load, show all courses
        private void guest_Load(object sender, EventArgs e)
        {
            ShowCoursesInFlowPanel(TXTSEARCH.Text.Trim());
        }

        private void FLOWLATOUTPNL_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
