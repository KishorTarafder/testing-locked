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
            this.BTNCHANGEPASS = new System.Windows.Forms.Button();
            this.TXTOLDPASS = new System.Windows.Forms.TextBox();
            this.LBLPASSWORD = new System.Windows.Forms.Label();
            this.LBLUSERNAME = new System.Windows.Forms.Label();
            this.TXTUSERNAME = new System.Windows.Forms.TextBox();
            this.LBLNEWPASS = new System.Windows.Forms.Label();
            this.NEWPASS = new System.Windows.Forms.TextBox();
            this.LBLCHANGEPASS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNCHANGEPASS
            // 
            this.BTNCHANGEPASS.Location = new System.Drawing.Point(103, 536);
            this.BTNCHANGEPASS.Name = "BTNCHANGEPASS";
            this.BTNCHANGEPASS.Size = new System.Drawing.Size(167, 74);
            this.BTNCHANGEPASS.TabIndex = 21;
            this.BTNCHANGEPASS.Text = "CHANGE PASSWORD";
            this.BTNCHANGEPASS.UseVisualStyleBackColor = true;
            this.BTNCHANGEPASS.Click += new System.EventHandler(this.BTNCHANGEPASS_Click);
            // 
            // TXTOLDPASS
            // 
            this.TXTOLDPASS.Location = new System.Drawing.Point(103, 295);
            this.TXTOLDPASS.Multiline = true;
            this.TXTOLDPASS.Name = "TXTOLDPASS";
            this.TXTOLDPASS.Size = new System.Drawing.Size(307, 48);
            this.TXTOLDPASS.TabIndex = 20;
            this.TXTOLDPASS.TextChanged += new System.EventHandler(this.TXTOLDPASS_TextChanged);
            // 
            // LBLPASSWORD
            // 
            this.LBLPASSWORD.AutoSize = true;
            this.LBLPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPASSWORD.Location = new System.Drawing.Point(101, 232);
            this.LBLPASSWORD.Name = "LBLPASSWORD";
            this.LBLPASSWORD.Size = new System.Drawing.Size(309, 38);
            this.LBLPASSWORD.TabIndex = 19;
            this.LBLPASSWORD.Text = "OLD PASSWORD ";
            this.LBLPASSWORD.Click += new System.EventHandler(this.LBLPASSWORD_Click);
            // 
            // LBLUSERNAME
            // 
            this.LBLUSERNAME.AutoSize = true;
            this.LBLUSERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUSERNAME.Location = new System.Drawing.Point(101, 90);
            this.LBLUSERNAME.Name = "LBLUSERNAME";
            this.LBLUSERNAME.Size = new System.Drawing.Size(212, 38);
            this.LBLUSERNAME.TabIndex = 18;
            this.LBLUSERNAME.Text = "USERNAME";
            // 
            // TXTUSERNAME
            // 
            this.TXTUSERNAME.Location = new System.Drawing.Point(103, 150);
            this.TXTUSERNAME.Multiline = true;
            this.TXTUSERNAME.Name = "TXTUSERNAME";
            this.TXTUSERNAME.Size = new System.Drawing.Size(307, 48);
            this.TXTUSERNAME.TabIndex = 17;
            this.TXTUSERNAME.TextChanged += new System.EventHandler(this.TXTUSERNAME_TextChanged);
            // 
            // LBLNEWPASS
            // 
            this.LBLNEWPASS.AutoSize = true;
            this.LBLNEWPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNEWPASS.Location = new System.Drawing.Point(102, 379);
            this.LBLNEWPASS.Name = "LBLNEWPASS";
            this.LBLNEWPASS.Size = new System.Drawing.Size(308, 38);
            this.LBLNEWPASS.TabIndex = 22;
            this.LBLNEWPASS.Text = "NEW PASSWORD";
            // 
            // NEWPASS
            // 
            this.NEWPASS.Location = new System.Drawing.Point(109, 454);
            this.NEWPASS.Multiline = true;
            this.NEWPASS.Name = "NEWPASS";
            this.NEWPASS.Size = new System.Drawing.Size(307, 48);
            this.NEWPASS.TabIndex = 23;
            this.NEWPASS.TextChanged += new System.EventHandler(this.NEWPASS_TextChanged);
            // 
            // LBLCHANGEPASS
            // 
            this.LBLCHANGEPASS.AutoSize = true;
            this.LBLCHANGEPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCHANGEPASS.Location = new System.Drawing.Point(447, 31);
            this.LBLCHANGEPASS.Name = "LBLCHANGEPASS";
            this.LBLCHANGEPASS.Size = new System.Drawing.Size(376, 38);
            this.LBLCHANGEPASS.TabIndex = 24;
            this.LBLCHANGEPASS.Text = "CHANGE PASSWORD";
            // 
            // forgotpass_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 666);
            this.Controls.Add(this.LBLCHANGEPASS);
            this.Controls.Add(this.NEWPASS);
            this.Controls.Add(this.LBLNEWPASS);
            this.Controls.Add(this.BTNCHANGEPASS);
            this.Controls.Add(this.TXTOLDPASS);
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
        private System.Windows.Forms.TextBox TXTOLDPASS;
        private System.Windows.Forms.Label LBLPASSWORD;
        private System.Windows.Forms.Label LBLUSERNAME;
        private System.Windows.Forms.TextBox TXTUSERNAME;
        private System.Windows.Forms.Label LBLNEWPASS;
        private System.Windows.Forms.TextBox NEWPASS;
        private System.Windows.Forms.Label LBLCHANGEPASS;
    }
}