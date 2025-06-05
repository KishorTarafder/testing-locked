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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            Form signupForm = new signup_form();
            
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
    }
}
