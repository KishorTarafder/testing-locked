namespace C_PROJECT
{
    partial class forgotpass_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotpass_form));
            this.BTNCHANGEPASS = new System.Windows.Forms.Button();
            this.TXTEMAIL = new System.Windows.Forms.TextBox();
            this.LBLPASSWORD = new System.Windows.Forms.Label();
            this.LBLUSERNAME = new System.Windows.Forms.Label();
            this.TXTUSERNAME = new System.Windows.Forms.TextBox();
            this.LBLNEWPASS = new System.Windows.Forms.Label();
            this.NEWPASS_CHANGE = new System.Windows.Forms.TextBox();
            this.LBLCHANGEPASS = new System.Windows.Forms.Label();
            this.BTNBACK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNCHANGEPASS
            // 
            this.BTNCHANGEPASS.BackColor = System.Drawing.Color.Transparent;
            this.BTNCHANGEPASS.FlatAppearance.BorderSize = 0;
            this.BTNCHANGEPASS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCHANGEPASS.Location = new System.Drawing.Point(696, 550);
            this.BTNCHANGEPASS.Name = "BTNCHANGEPASS";
            this.BTNCHANGEPASS.Size = new System.Drawing.Size(187, 36);
            this.BTNCHANGEPASS.TabIndex = 21;
            this.BTNCHANGEPASS.Text = "CHANGE PASSWORD";
            this.BTNCHANGEPASS.UseVisualStyleBackColor = false;
            this.BTNCHANGEPASS.Click += new System.EventHandler(this.BTNCHANGEPASS_Click);
            // 
            // TXTEMAIL
            // 
            this.TXTEMAIL.Location = new System.Drawing.Point(640, 344);
            this.TXTEMAIL.Multiline = true;
            this.TXTEMAIL.Name = "TXTEMAIL";
            this.TXTEMAIL.Size = new System.Drawing.Size(287, 41);
            this.TXTEMAIL.TabIndex = 20;
            this.TXTEMAIL.TextChanged += new System.EventHandler(this.TXTOLDPASS_TextChanged);
            // 
            // LBLPASSWORD
            // 
            this.LBLPASSWORD.AutoSize = true;
            this.LBLPASSWORD.BackColor = System.Drawing.Color.Transparent;
            this.LBLPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPASSWORD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLPASSWORD.Location = new System.Drawing.Point(635, 295);
            this.LBLPASSWORD.Name = "LBLPASSWORD";
            this.LBLPASSWORD.Size = new System.Drawing.Size(88, 29);
            this.LBLPASSWORD.TabIndex = 19;
            this.LBLPASSWORD.Text = "EMAIL";
            this.LBLPASSWORD.Click += new System.EventHandler(this.LBLPASSWORD_Click);
            // 
            // LBLUSERNAME
            // 
            this.LBLUSERNAME.AutoSize = true;
            this.LBLUSERNAME.BackColor = System.Drawing.Color.Transparent;
            this.LBLUSERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUSERNAME.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLUSERNAME.Location = new System.Drawing.Point(635, 175);
            this.LBLUSERNAME.Name = "LBLUSERNAME";
            this.LBLUSERNAME.Size = new System.Drawing.Size(156, 29);
            this.LBLUSERNAME.TabIndex = 18;
            this.LBLUSERNAME.Text = "USERNAME";
            // 
            // TXTUSERNAME
            // 
            this.TXTUSERNAME.Location = new System.Drawing.Point(640, 244);
            this.TXTUSERNAME.Multiline = true;
            this.TXTUSERNAME.Name = "TXTUSERNAME";
            this.TXTUSERNAME.Size = new System.Drawing.Size(287, 35);
            this.TXTUSERNAME.TabIndex = 17;
            this.TXTUSERNAME.TextChanged += new System.EventHandler(this.TXTUSERNAME_TextChanged);
            // 
            // LBLNEWPASS
            // 
            this.LBLNEWPASS.AutoSize = true;
            this.LBLNEWPASS.BackColor = System.Drawing.Color.Transparent;
            this.LBLNEWPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNEWPASS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLNEWPASS.Location = new System.Drawing.Point(635, 402);
            this.LBLNEWPASS.Name = "LBLNEWPASS";
            this.LBLNEWPASS.Size = new System.Drawing.Size(225, 29);
            this.LBLNEWPASS.TabIndex = 22;
            this.LBLNEWPASS.Text = "NEW PASSWORD";
            this.LBLNEWPASS.Click += new System.EventHandler(this.LBLNEWPASS_Click);
            // 
            // NEWPASS_CHANGE
            // 
            this.NEWPASS_CHANGE.Location = new System.Drawing.Point(640, 449);
            this.NEWPASS_CHANGE.Multiline = true;
            this.NEWPASS_CHANGE.Name = "NEWPASS_CHANGE";
            this.NEWPASS_CHANGE.Size = new System.Drawing.Size(287, 42);
            this.NEWPASS_CHANGE.TabIndex = 23;
            this.NEWPASS_CHANGE.TextChanged += new System.EventHandler(this.NEWPASS_TextChanged);
            // 
            // LBLCHANGEPASS
            // 
            this.LBLCHANGEPASS.AutoSize = true;
            this.LBLCHANGEPASS.BackColor = System.Drawing.Color.Transparent;
            this.LBLCHANGEPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCHANGEPASS.Location = new System.Drawing.Point(30, 38);
            this.LBLCHANGEPASS.Name = "LBLCHANGEPASS";
            this.LBLCHANGEPASS.Size = new System.Drawing.Size(376, 38);
            this.LBLCHANGEPASS.TabIndex = 24;
            this.LBLCHANGEPASS.Text = "CHANGE PASSWORD";
            // 
            // BTNBACK
            // 
            this.BTNBACK.FlatAppearance.BorderSize = 2;
            this.BTNBACK.Location = new System.Drawing.Point(12, 550);
            this.BTNBACK.Name = "BTNBACK";
            this.BTNBACK.Size = new System.Drawing.Size(162, 47);
            this.BTNBACK.TabIndex = 25;
            this.BTNBACK.Text = "BACK";
            this.BTNBACK.UseVisualStyleBackColor = true;
            this.BTNBACK.Click += new System.EventHandler(this.BTNBACK_Click);
            // 
            // forgotpass_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 666);
            this.Controls.Add(this.BTNBACK);
            this.Controls.Add(this.LBLCHANGEPASS);
            this.Controls.Add(this.NEWPASS_CHANGE);
            this.Controls.Add(this.LBLNEWPASS);
            this.Controls.Add(this.BTNCHANGEPASS);
            this.Controls.Add(this.TXTEMAIL);
            this.Controls.Add(this.LBLPASSWORD);
            this.Controls.Add(this.LBLUSERNAME);
            this.Controls.Add(this.TXTUSERNAME);
            this.Name = "forgotpass_form";
            this.Text = "forgotpass_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCHANGEPASS;
        private System.Windows.Forms.TextBox TXTEMAIL;
        private System.Windows.Forms.Label LBLPASSWORD;
        private System.Windows.Forms.Label LBLUSERNAME;
        private System.Windows.Forms.TextBox TXTUSERNAME;
        private System.Windows.Forms.Label LBLNEWPASS;
        private System.Windows.Forms.TextBox NEWPASS_CHANGE;
        private System.Windows.Forms.Label LBLCHANGEPASS;
        private System.Windows.Forms.Button BTNBACK;
    }
}