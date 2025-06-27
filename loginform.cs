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
    public partial class LOGINFORM : Form
    {

       




        public LOGINFORM()
        {
            InitializeComponent();
        }


        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-HNPCF1F\\SQLEXPRESS;Initial Catalog=DBLOGIN;Integrated Security=True;Trust Server Certificate=True");











        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            CRUD db = new CRUD();
            string query = "SELECT * FROM signup_info WHERE Username = '" + TXTUSERNAME.Text + "' AND Password = '" + TXTPASSWORD.Text + "'";
            DataTable dt = db.Select(query);

            if (dt.Rows.Count == 1) // matching username/password
            {
                if (dt.Rows[0][4].ToString() == "1") // Status column (column 4)
                {
                    string userType = dt.Rows[0][3].ToString(); // UserType column (column 3)

                    if (userType == "ADMIN")
                    {
                        new admin_control_form().Show();
                        this.Hide();
                    }
                    else if (userType == "STUDENT")
                    {
                        //new student_form().Show();


                        new student_form(TXTUSERNAME.Text).Show(); // Pass username!

                        this.Hide();
                    }
                    else if (userType == "TEACHER")
                    {
                        //new customer_form().Show();
                        //this.Hide();
                    }


                    else if (userType == "GUEST")
                    {
                        new guest_forrm().Show();
                        this.Hide();    

                    }


                    else
                    {
                        MessageBox.Show("Unknown user type.");
                    }
                }
                else
                {
                    MessageBox.Show("Your account is disabled.\nContact with admin");
                }
            }
            else
            {
                MessageBox.Show("Wrong credentials\nTry again");
            }



        }

        private void TXTPASSWORD_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNPASSWORD_Click(object sender, EventArgs e)
        {
            Form signupForm = new signup_form();
            this.Hide();
            signupForm.Show();
        }

        private void BTNFORGOTPASS_Click(object sender, EventArgs e)
        {
            Form forgotpass_form = new forgotpass_form();
            this.Hide();
            forgotpass_form.Show();
        }

        private void TXTUSERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNTESTADMIN_Click(object sender, EventArgs e)
        {
            //Form adminForm = new admin_control_form();
            //this.Hide();
            //adminForm.Show();

            Form course_upload = new course_upload();
            this.Hide();
            course_upload.Show();
        }
    }
}
