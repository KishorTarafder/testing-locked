namespace C_PROJECT
{
    partial class signup_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXTPASSWORD = new System.Windows.Forms.TextBox();
            this.LBLPASSWORD = new System.Windows.Forms.Label();
            this.LBLUSERNAME = new System.Windows.Forms.Label();
            this.TXTUSERNAME = new System.Windows.Forms.TextBox();
            this.LBLUSERROLE = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTNSIGNUP = new System.Windows.Forms.Button();
            this.BTNGOBACK = new System.Windows.Forms.Button();
            this.LBLCONFIRM = new System.Windows.Forms.Label();
            this.TXTCONFIRMPASS = new System.Windows.Forms.TextBox();
            this.TXTEMAIL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTPASSWORD
            // 
            this.TXTPASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPASSWORD.Location = new System.Drawing.Point(30, 333);
            this.TXTPASSWORD.Multiline = true;
            this.TXTPASSWORD.Name = "TXTPASSWORD";
            this.TXTPASSWORD.PasswordChar = '*';
            this.TXTPASSWORD.Size = new System.Drawing.Size(325, 31);
            this.TXTPASSWORD.TabIndex = 10;
            this.TXTPASSWORD.TextChanged += new System.EventHandler(this.TXTPASSWORD_TextChanged);
            // 
            // LBLPASSWORD
            // 
            this.LBLPASSWORD.AutoSize = true;
            this.LBLPASSWORD.BackColor = System.Drawing.Color.Transparent;
            this.LBLPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPASSWORD.Location = new System.Drawing.Point(16, 298);
            this.LBLPASSWORD.Name = "LBLPASSWORD";
            this.LBLPASSWORD.Size = new System.Drawing.Size(138, 25);
            this.LBLPASSWORD.TabIndex = 9;
            this.LBLPASSWORD.Text = "PASSWORD";
            // 
            // LBLUSERNAME
            // 
            this.LBLUSERNAME.AutoSize = true;
            this.LBLUSERNAME.BackColor = System.Drawing.Color.Transparent;
            this.LBLUSERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUSERNAME.Location = new System.Drawing.Point(22, 176);
            this.LBLUSERNAME.Name = "LBLUSERNAME";
            this.LBLUSERNAME.Size = new System.Drawing.Size(132, 25);
            this.LBLUSERNAME.TabIndex = 8;
            this.LBLUSERNAME.Text = "USERNAME";
            this.LBLUSERNAME.Click += new System.EventHandler(this.LBLUSERNAME_Click);
            // 
            // TXTUSERNAME
            // 
            this.TXTUSERNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTUSERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUSERNAME.Location = new System.Drawing.Point(30, 232);
            this.TXTUSERNAME.Multiline = true;
            this.TXTUSERNAME.Name = "TXTUSERNAME";
            this.TXTUSERNAME.Size = new System.Drawing.Size(325, 31);
            this.TXTUSERNAME.TabIndex = 7;
            this.TXTUSERNAME.TextChanged += new System.EventHandler(this.TXTUSERNAME_TextChanged);
            // 
            // LBLUSERROLE
            // 
            this.LBLUSERROLE.AutoSize = true;
            this.LBLUSERROLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUSERROLE.Location = new System.Drawing.Point(45, 495);
            this.LBLUSERROLE.Name = "LBLUSERROLE";
            this.LBLUSERROLE.Size = new System.Drawing.Size(115, 20);
            this.LBLUSERROLE.TabIndex = 11;
            this.LBLUSERROLE.Text = "USER ROLE";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ADMIN",
            "STUDENT",
            "TEACHER",
            "GUEST"});
            this.comboBox1.Location = new System.Drawing.Point(204, 491);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BTNSIGNUP
            // 
            this.BTNSIGNUP.BackColor = System.Drawing.Color.Transparent;
            this.BTNSIGNUP.Location = new System.Drawing.Point(49, 566);
            this.BTNSIGNUP.Name = "BTNSIGNUP";
            this.BTNSIGNUP.Size = new System.Drawing.Size(149, 64);
            this.BTNSIGNUP.TabIndex = 16;
            this.BTNSIGNUP.Text = "SIGNUP";
            this.BTNSIGNUP.UseVisualStyleBackColor = false;
            this.BTNSIGNUP.Click += new System.EventHandler(this.BTNSIGNUP_Click);
            // 
            // BTNGOBACK
            // 
            this.BTNGOBACK.BackColor = System.Drawing.Color.Transparent;
            this.BTNGOBACK.Location = new System.Drawing.Point(268, 566);
            this.BTNGOBACK.Name = "BTNGOBACK";
            this.BTNGOBACK.Size = new System.Drawing.Size(151, 64);
            this.BTNGOBACK.TabIndex = 17;
            this.BTNGOBACK.Text = "LOGIN";
            this.BTNGOBACK.UseVisualStyleBackColor = false;
            this.BTNGOBACK.Click += new System.EventHandler(this.BTNGOBACK_Click);
            // 
            // LBLCONFIRM
            // 
            this.LBLCONFIRM.AutoSize = true;
            this.LBLCONFIRM.BackColor = System.Drawing.SystemColors.Window;
            this.LBLCONFIRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCONFIRM.Location = new System.Drawing.Point(25, 395);
            this.LBLCONFIRM.Name = "LBLCONFIRM";
            this.LBLCONFIRM.Size = new System.Drawing.Size(187, 25);
            this.LBLCONFIRM.TabIndex = 18;
            this.LBLCONFIRM.Text = "Confirm Password";
            this.LBLCONFIRM.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXTCONFIRMPASS
            // 
            this.TXTCONFIRMPASS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTCONFIRMPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCONFIRMPASS.Location = new System.Drawing.Point(39, 430);
            this.TXTCONFIRMPASS.Multiline = true;
            this.TXTCONFIRMPASS.Name = "TXTCONFIRMPASS";
            this.TXTCONFIRMPASS.PasswordChar = '*';
            this.TXTCONFIRMPASS.Size = new System.Drawing.Size(325, 31);
            this.TXTCONFIRMPASS.TabIndex = 19;
            this.TXTCONFIRMPASS.TextChanged += new System.EventHandler(this.TXTCONFIRMPASS_TextChanged);
            // 
            // TXTEMAIL
            // 
            this.TXTEMAIL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TXTEMAIL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTEMAIL.Location = new System.Drawing.Point(645, 232);
            this.TXTEMAIL.Multiline = true;
            this.TXTEMAIL.Name = "TXTEMAIL";
            this.TXTEMAIL.Size = new System.Drawing.Size(325, 31);
            this.TXTEMAIL.TabIndex = 20;
            this.TXTEMAIL.TextChanged += new System.EventHandler(this.TXTEMAIL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(795, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "EMAIL";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // signup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTEMAIL);
            this.Controls.Add(this.TXTCONFIRMPASS);
            this.Controls.Add(this.LBLCONFIRM);
            this.Controls.Add(this.BTNGOBACK);
            this.Controls.Add(this.BTNSIGNUP);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LBLUSERROLE);
            this.Controls.Add(this.TXTPASSWORD);
            this.Controls.Add(this.LBLPASSWORD);
            this.Controls.Add(this.LBLUSERNAME);
            this.Controls.Add(this.TXTUSERNAME);
            this.Name = "signup_form";
            this.Text = "signup_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTPASSWORD;
        private System.Windows.Forms.Label LBLPASSWORD;
        private System.Windows.Forms.Label LBLUSERNAME;
        private System.Windows.Forms.TextBox TXTUSERNAME;
        private System.Windows.Forms.Label LBLUSERROLE;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BTNSIGNUP;
        private System.Windows.Forms.Button BTNGOBACK;
        private System.Windows.Forms.Label LBLCONFIRM;
        private System.Windows.Forms.TextBox TXTCONFIRMPASS;
        private System.Windows.Forms.TextBox TXTEMAIL;
        private System.Windows.Forms.Label label1;
    }
}