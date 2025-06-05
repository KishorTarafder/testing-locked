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
            this.BTNLOGIN = new System.Windows.Forms.Button();
            this.LBLLOGIN = new System.Windows.Forms.Label();
            this.TXTUSERNAME = new System.Windows.Forms.TextBox();
            this.LBLUSERNAME = new System.Windows.Forms.Label();
            this.LBLPASSWORD = new System.Windows.Forms.Label();
            this.TXTPASSWORD = new System.Windows.Forms.TextBox();
            this.BTNPASSWORD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNLOGIN
            // 
            this.BTNLOGIN.Location = new System.Drawing.Point(192, 456);
            this.BTNLOGIN.Name = "BTNLOGIN";
            this.BTNLOGIN.Size = new System.Drawing.Size(167, 74);
            this.BTNLOGIN.TabIndex = 1;
            this.BTNLOGIN.Text = "LOGIN";
            this.BTNLOGIN.UseVisualStyleBackColor = true;
            this.BTNLOGIN.Click += new System.EventHandler(this.BTNLOGIN_Click);
            // 
            // LBLLOGIN
            // 
            this.LBLLOGIN.AutoSize = true;
            this.LBLLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLOGIN.Location = new System.Drawing.Point(452, 41);
            this.LBLLOGIN.Name = "LBLLOGIN";
            this.LBLLOGIN.Size = new System.Drawing.Size(124, 38);
            this.LBLLOGIN.TabIndex = 2;
            this.LBLLOGIN.Text = "LOGIN";
            // 
            // TXTUSERNAME
            // 
            this.TXTUSERNAME.Location = new System.Drawing.Point(192, 188);
            this.TXTUSERNAME.Multiline = true;
            this.TXTUSERNAME.Name = "TXTUSERNAME";
            this.TXTUSERNAME.Size = new System.Drawing.Size(307, 48);
            this.TXTUSERNAME.TabIndex = 3;
            this.TXTUSERNAME.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LBLUSERNAME
            // 
            this.LBLUSERNAME.AutoSize = true;
            this.LBLUSERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUSERNAME.Location = new System.Drawing.Point(185, 135);
            this.LBLUSERNAME.Name = "LBLUSERNAME";
            this.LBLUSERNAME.Size = new System.Drawing.Size(212, 38);
            this.LBLUSERNAME.TabIndex = 4;
            this.LBLUSERNAME.Text = "USERNAME";
            this.LBLUSERNAME.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBLPASSWORD
            // 
            this.LBLPASSWORD.AutoSize = true;
            this.LBLPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPASSWORD.Location = new System.Drawing.Point(185, 275);
            this.LBLPASSWORD.Name = "LBLPASSWORD";
            this.LBLPASSWORD.Size = new System.Drawing.Size(218, 38);
            this.LBLPASSWORD.TabIndex = 5;
            this.LBLPASSWORD.Text = "PASSWORD";
            // 
            // TXTPASSWORD
            // 
            this.TXTPASSWORD.Location = new System.Drawing.Point(192, 356);
            this.TXTPASSWORD.Multiline = true;
            this.TXTPASSWORD.Name = "TXTPASSWORD";
            this.TXTPASSWORD.Size = new System.Drawing.Size(307, 48);
            this.TXTPASSWORD.TabIndex = 6;
            this.TXTPASSWORD.TextChanged += new System.EventHandler(this.TXTPASSWORD_TextChanged);
            // 
            // BTNPASSWORD
            // 
            this.BTNPASSWORD.Location = new System.Drawing.Point(384, 456);
            this.BTNPASSWORD.Name = "BTNPASSWORD";
            this.BTNPASSWORD.Size = new System.Drawing.Size(167, 74);
            this.BTNPASSWORD.TabIndex = 7;
            this.BTNPASSWORD.Text = "PASSWORD";
            this.BTNPASSWORD.UseVisualStyleBackColor = true;
            this.BTNPASSWORD.Click += new System.EventHandler(this.BTNPASSWORD_Click);
            // 
            // LOGINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 663);
            this.Controls.Add(this.BTNPASSWORD);
            this.Controls.Add(this.TXTPASSWORD);
            this.Controls.Add(this.LBLPASSWORD);
            this.Controls.Add(this.LBLUSERNAME);
            this.Controls.Add(this.TXTUSERNAME);
            this.Controls.Add(this.LBLLOGIN);
            this.Controls.Add(this.BTNLOGIN);
            this.Name = "LOGINFORM";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNLOGIN;
        private System.Windows.Forms.Label LBLLOGIN;
        private System.Windows.Forms.TextBox TXTUSERNAME;
        private System.Windows.Forms.Label LBLUSERNAME;
        private System.Windows.Forms.Label LBLPASSWORD;
        private System.Windows.Forms.TextBox TXTPASSWORD;
        private System.Windows.Forms.Button BTNPASSWORD;
    }
}

