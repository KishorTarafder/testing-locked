namespace C_PROJECT
{
    partial class LOGINFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGINFORM));
            this.BTNLOGIN = new System.Windows.Forms.Button();
            this.TXTUSERNAME = new System.Windows.Forms.TextBox();
            this.TXTPASSWORD = new System.Windows.Forms.TextBox();
            this.BTNSIGNUP = new System.Windows.Forms.Button();
            this.BTNFORGOTPASS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNLOGIN
            // 
            this.BTNLOGIN.BackColor = System.Drawing.Color.Transparent;
            this.BTNLOGIN.FlatAppearance.BorderSize = 0;
            this.BTNLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLOGIN.ForeColor = System.Drawing.Color.Transparent;
            this.BTNLOGIN.Location = new System.Drawing.Point(99, 389);
            this.BTNLOGIN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNLOGIN.Name = "BTNLOGIN";
            this.BTNLOGIN.Size = new System.Drawing.Size(264, 33);
            this.BTNLOGIN.TabIndex = 1;
            this.BTNLOGIN.Text = "LOGIN";
            this.BTNLOGIN.UseVisualStyleBackColor = false;
            this.BTNLOGIN.Click += new System.EventHandler(this.BTNLOGIN_Click);
            // 
            // TXTUSERNAME
            // 
            this.TXTUSERNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTUSERNAME.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUSERNAME.Location = new System.Drawing.Point(136, 222);
            this.TXTUSERNAME.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TXTUSERNAME.Multiline = true;
            this.TXTUSERNAME.Name = "TXTUSERNAME";
            this.TXTUSERNAME.Size = new System.Drawing.Size(227, 34);
            this.TXTUSERNAME.TabIndex = 3;
            this.TXTUSERNAME.TextChanged += new System.EventHandler(this.TXTUSERNAME_TextChanged);
            // 
            // TXTPASSWORD
            // 
            this.TXTPASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTPASSWORD.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPASSWORD.Location = new System.Drawing.Point(125, 310);
            this.TXTPASSWORD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TXTPASSWORD.Multiline = true;
            this.TXTPASSWORD.Name = "TXTPASSWORD";
            this.TXTPASSWORD.Size = new System.Drawing.Size(238, 31);
            this.TXTPASSWORD.TabIndex = 6;
            this.TXTPASSWORD.TextChanged += new System.EventHandler(this.TXTPASSWORD_TextChanged);
            // 
            // BTNSIGNUP
            // 
            this.BTNSIGNUP.BackColor = System.Drawing.Color.Transparent;
            this.BTNSIGNUP.FlatAppearance.BorderSize = 0;
            this.BTNSIGNUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSIGNUP.ForeColor = System.Drawing.Color.Transparent;
            this.BTNSIGNUP.Location = new System.Drawing.Point(235, 439);
            this.BTNSIGNUP.Margin = new System.Windows.Forms.Padding(0);
            this.BTNSIGNUP.Name = "BTNSIGNUP";
            this.BTNSIGNUP.Size = new System.Drawing.Size(128, 32);
            this.BTNSIGNUP.TabIndex = 7;
            this.BTNSIGNUP.Text = "SIGN UP";
            this.BTNSIGNUP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNSIGNUP.UseMnemonic = false;
            this.BTNSIGNUP.UseVisualStyleBackColor = false;
            this.BTNSIGNUP.Click += new System.EventHandler(this.BTNPASSWORD_Click);
            // 
            // BTNFORGOTPASS
            // 
            this.BTNFORGOTPASS.BackColor = System.Drawing.Color.Transparent;
            this.BTNFORGOTPASS.FlatAppearance.BorderSize = 0;
            this.BTNFORGOTPASS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNFORGOTPASS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNFORGOTPASS.Location = new System.Drawing.Point(239, 347);
            this.BTNFORGOTPASS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTNFORGOTPASS.Name = "BTNFORGOTPASS";
            this.BTNFORGOTPASS.Size = new System.Drawing.Size(159, 36);
            this.BTNFORGOTPASS.TabIndex = 8;
            this.BTNFORGOTPASS.Text = "forgot password ?";
            this.BTNFORGOTPASS.UseVisualStyleBackColor = false;
            this.BTNFORGOTPASS.Click += new System.EventHandler(this.BTNFORGOTPASS_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(21, 179);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "login  :";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LOGINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 625);
            this.Controls.Add(this.BTNSIGNUP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNFORGOTPASS);
            this.Controls.Add(this.TXTPASSWORD);
            this.Controls.Add(this.TXTUSERNAME);
            this.Controls.Add(this.BTNLOGIN);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(1000, 710);
            this.MinimumSize = new System.Drawing.Size(1000, 622);
            this.Name = "LOGINFORM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNLOGIN;
        private System.Windows.Forms.TextBox TXTUSERNAME;
        private System.Windows.Forms.TextBox TXTPASSWORD;
        private System.Windows.Forms.Button BTNSIGNUP;
        private System.Windows.Forms.Button BTNFORGOTPASS;
        private System.Windows.Forms.Button button1;
    }
}

