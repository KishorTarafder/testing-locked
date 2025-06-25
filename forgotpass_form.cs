using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PROJECT
{
    public partial class forgotpass_form : Form
    {
        public forgotpass_form()
        {
            InitializeComponent();
        }

        private void LBLPASSWORD_Click(object sender, EventArgs e)
        {

        }

        private void TXTUSERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTOLDPASS_TextChanged(object sender, EventArgs e)
        {

        }

        private void NEWPASS_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNCHANGEPASS_Click(object sender, EventArgs e)
        {
            CRUD db = new CRUD();
            // sir er online class 1h35 min ish 

            string update_query = "UPDATE signup_info SET Password = '" + NEWPASS.Text + "' WHERE Username = '" + TXTUSERNAME.Text + "' and Password = '"+TXTOLDPASS.Text+"'";
            int result = db.Update(update_query);

            if (result > 0)
                MessageBox.Show("Password changed successfully!");
            else
                MessageBox.Show("Failed to change password.");
        }
    }
}
