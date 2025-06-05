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
            this.LBLLOGIN = new System.Windows.Forms.Label();
            this.TXTPASSWORD = new System.Windows.Forms.TextBox();
            this.LBLPASSWORD = new System.Windows.Forms.Label();
            this.LBLUSERNAME = new System.Windows.Forms.Label();
            this.TXTUSERNAME = new System.Windows.Forms.TextBox();
            this.LBLUSERROLE = new System.Windows.Forms.Label();
            this.LBLNAME = new System.Windows.Forms.Label();
            this.TXTNAME = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTNSIGNUP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLLOGIN
            // 
            this.LBLLOGIN.AutoSize = true;
            this.LBLLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLOGIN.Location = new System.Drawing.Point(444, 51);
            this.LBLLOGIN.Name = "LBLLOGIN";
            this.LBLLOGIN.Size = new System.Drawing.Size(149, 38);
            this.LBLLOGIN.TabIndex = 3;
            this.LBLLOGIN.Text = "SIGNUP";
            this.LBLLOGIN.Click += new System.EventHandler(this.LBLLOGIN_Click);
            // 
            // TXTPASSWORD
            // 
            this.TXTPASSWORD.Location = new System.Drawing.Point(135, 392);
            this.TXTPASSWORD.Multiline = true;
            this.TXTPASSWORD.Name = "TXTPASSWORD";
            this.TXTPASSWORD.Size = new System.Drawing.Size(307, 48);
            this.TXTPASSWORD.TabIndex = 10;
            // 
            // LBLPASSWORD
            // 
            this.LBLPASSWORD.AutoSize = true;
            this.LBLPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPASSWORD.Location = new System.Drawing.Point(128, 328);
            this.LBLPASSWORD.Name = "LBLPASSWORD";
            this.LBLPASSWORD.Size = new System.Drawing.Size(218, 38);
            this.LBLPASSWORD.TabIndex = 9;
            this.LBLPASSWORD.Text = "PASSWORD";
            // 
            // LBLUSERNAME
            // 
            this.LBLUSERNAME.AutoSize = true;
            this.LBLUSERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUSERNAME.Location = new System.Drawing.Point(128, 188);
            this.LBLUSERNAME.Name = "LBLUSERNAME";
            this.LBLUSERNAME.Size = new System.Drawing.Size(212, 38);
            this.LBLUSERNAME.TabIndex = 8;
            this.LBLUSERNAME.Text = "USERNAME";
            // 
            // TXTUSERNAME
            // 
            this.TXTUSERNAME.Location = new System.Drawing.Point(135, 256);
            this.TXTUSERNAME.Multiline = true;
            this.TXTUSERNAME.Name = "TXTUSERNAME";
            this.TXTUSERNAME.Size = new System.Drawing.Size(307, 48);
            this.TXTUSERNAME.TabIndex = 7;
            this.TXTUSERNAME.TextChanged += new System.EventHandler(this.TXTUSERNAME_TextChanged);
            // 
            // LBLUSERROLE
            // 
            this.LBLUSERROLE.AutoSize = true;
            this.LBLUSERROLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUSERROLE.Location = new System.Drawing.Point(128, 483);
            this.LBLUSERROLE.Name = "LBLUSERROLE";
            this.LBLUSERROLE.Size = new System.Drawing.Size(217, 38);
            this.LBLUSERROLE.TabIndex = 11;
            this.LBLUSERROLE.Text = "USER ROLE";
            // 
            // LBLNAME
            // 
            this.LBLNAME.AutoSize = true;
            this.LBLNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNAME.Location = new System.Drawing.Point(595, 188);
            this.LBLNAME.Name = "LBLNAME";
            this.LBLNAME.Size = new System.Drawing.Size(116, 38);
            this.LBLNAME.TabIndex = 13;
            this.LBLNAME.Text = "NAME";
            // 
            // TXTNAME
            // 
            this.TXTNAME.Location = new System.Drawing.Point(602, 256);
            this.TXTNAME.Multiline = true;
            this.TXTNAME.Name = "TXTNAME";
            this.TXTNAME.Size = new System.Drawing.Size(307, 48);
            this.TXTNAME.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ADMIN",
            "STUDENT",
            "TEACHER",
            "GUEST"});
            this.comboBox1.Location = new System.Drawing.Point(336, 497);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BTNSIGNUP
            // 
            this.BTNSIGNUP.Location = new System.Drawing.Point(135, 566);
            this.BTNSIGNUP.Name = "BTNSIGNUP";
            this.BTNSIGNUP.Size = new System.Drawing.Size(167, 74);
            this.BTNSIGNUP.TabIndex = 16;
            this.BTNSIGNUP.Text = "SIGNUP";
            this.BTNSIGNUP.UseVisualStyleBackColor = true;
            this.BTNSIGNUP.Click += new System.EventHandler(this.BTNSIGNUP_Click);
            // 
            // signup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 730);
            this.Controls.Add(this.BTNSIGNUP);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TXTNAME);
            this.Controls.Add(this.LBLNAME);
            this.Controls.Add(this.LBLUSERROLE);
            this.Controls.Add(this.TXTPASSWORD);
            this.Controls.Add(this.LBLPASSWORD);
            this.Controls.Add(this.LBLUSERNAME);
            this.Controls.Add(this.TXTUSERNAME);
            this.Controls.Add(this.LBLLOGIN);
            this.Name = "signup_form";
            this.Text = "signup_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLLOGIN;
        private System.Windows.Forms.TextBox TXTPASSWORD;
        private System.Windows.Forms.Label LBLPASSWORD;
        private System.Windows.Forms.Label LBLUSERNAME;
        private System.Windows.Forms.TextBox TXTUSERNAME;
        private System.Windows.Forms.Label LBLUSERROLE;
        private System.Windows.Forms.Label LBLNAME;
        private System.Windows.Forms.TextBox TXTNAME;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BTNSIGNUP;
    }
}