namespace C_PROJECT
{
    partial class student_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_form));
            this.FLOWLATOUTPNL = new System.Windows.Forms.FlowLayoutPanel();
            this.PNLHOLDDINGALL = new System.Windows.Forms.Panel();
            this.LBLVDOTITLE = new System.Windows.Forms.Label();
            this.BTNPLAYorBUY = new System.Windows.Forms.Button();
            this.PICBOX1 = new System.Windows.Forms.PictureBox();
            this.LBLUSER = new System.Windows.Forms.Label();
            this.LBLSHOWUSRNAME = new System.Windows.Forms.Label();
            this.LBLBALACE = new System.Windows.Forms.Label();
            this.BTNBACK = new System.Windows.Forms.Button();
            this.PNLHOLDDINGALL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX1)).BeginInit();
            this.SuspendLayout();
            // 
            // FLOWLATOUTPNL
            // 
            this.FLOWLATOUTPNL.AutoScroll = true;
            this.FLOWLATOUTPNL.Location = new System.Drawing.Point(403, 12);
            this.FLOWLATOUTPNL.Name = "FLOWLATOUTPNL";
            this.FLOWLATOUTPNL.Size = new System.Drawing.Size(629, 532);
            this.FLOWLATOUTPNL.TabIndex = 0;
            this.FLOWLATOUTPNL.Paint += new System.Windows.Forms.PaintEventHandler(this.FLOWLATOUTPNL_Paint);
            // 
            // PNLHOLDDINGALL
            // 
            this.PNLHOLDDINGALL.BackColor = System.Drawing.Color.Transparent;
            this.PNLHOLDDINGALL.Controls.Add(this.LBLVDOTITLE);
            this.PNLHOLDDINGALL.Controls.Add(this.BTNPLAYorBUY);
            this.PNLHOLDDINGALL.Controls.Add(this.PICBOX1);
            this.PNLHOLDDINGALL.Location = new System.Drawing.Point(0, 212);
            this.PNLHOLDDINGALL.Name = "PNLHOLDDINGALL";
            this.PNLHOLDDINGALL.Size = new System.Drawing.Size(349, 276);
            this.PNLHOLDDINGALL.TabIndex = 1;
            this.PNLHOLDDINGALL.Paint += new System.Windows.Forms.PaintEventHandler(this.PNLHOLDDINGALL_Paint);
            // 
            // LBLVDOTITLE
            // 
            this.LBLVDOTITLE.AutoSize = true;
            this.LBLVDOTITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLVDOTITLE.Location = new System.Drawing.Point(4, 198);
            this.LBLVDOTITLE.Name = "LBLVDOTITLE";
            this.LBLVDOTITLE.Size = new System.Drawing.Size(151, 25);
            this.LBLVDOTITLE.TabIndex = 2;
            this.LBLVDOTITLE.Text = "VIDEO TITLE ";
            // 
            // BTNPLAYorBUY
            // 
            this.BTNPLAYorBUY.Location = new System.Drawing.Point(0, 230);
            this.BTNPLAYorBUY.Name = "BTNPLAYorBUY";
            this.BTNPLAYorBUY.Size = new System.Drawing.Size(349, 43);
            this.BTNPLAYorBUY.TabIndex = 1;
            this.BTNPLAYorBUY.Text = "PLAY";
            this.BTNPLAYorBUY.UseVisualStyleBackColor = true;
            this.BTNPLAYorBUY.Click += new System.EventHandler(this.BTNPLAYorBUY_Click);
            // 
            // PICBOX1
            // 
            this.PICBOX1.BackColor = System.Drawing.Color.Transparent;
            this.PICBOX1.ErrorImage = null;
            this.PICBOX1.InitialImage = ((System.Drawing.Image)(resources.GetObject("PICBOX1.InitialImage")));
            this.PICBOX1.Location = new System.Drawing.Point(0, 4);
            this.PICBOX1.Name = "PICBOX1";
            this.PICBOX1.Size = new System.Drawing.Size(346, 191);
            this.PICBOX1.TabIndex = 0;
            this.PICBOX1.TabStop = false;
            this.PICBOX1.Click += new System.EventHandler(this.PICBOX1_Click);
            // 
            // LBLUSER
            // 
            this.LBLUSER.AutoSize = true;
            this.LBLUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUSER.Location = new System.Drawing.Point(12, 9);
            this.LBLUSER.Name = "LBLUSER";
            this.LBLUSER.Size = new System.Drawing.Size(151, 25);
            this.LBLUSER.TabIndex = 3;
            this.LBLUSER.Text = "USER NAME :";
            this.LBLUSER.Click += new System.EventHandler(this.LBLUSER_Click);
            // 
            // LBLSHOWUSRNAME
            // 
            this.LBLSHOWUSRNAME.AutoSize = true;
            this.LBLSHOWUSRNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSHOWUSRNAME.Location = new System.Drawing.Point(179, 9);
            this.LBLSHOWUSRNAME.Name = "LBLSHOWUSRNAME";
            this.LBLSHOWUSRNAME.Size = new System.Drawing.Size(110, 25);
            this.LBLSHOWUSRNAME.TabIndex = 4;
            this.LBLSHOWUSRNAME.Text = "DEFAULT";
            this.LBLSHOWUSRNAME.Click += new System.EventHandler(this.LBLSHOWUSRNAME_Click);
            // 
            // LBLBALACE
            // 
            this.LBLBALACE.AutoSize = true;
            this.LBLBALACE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLBALACE.Location = new System.Drawing.Point(179, 50);
            this.LBLBALACE.Name = "LBLBALACE";
            this.LBLBALACE.Size = new System.Drawing.Size(113, 25);
            this.LBLBALACE.TabIndex = 5;
            this.LBLBALACE.Text = "BALANCE";
            this.LBLBALACE.Click += new System.EventHandler(this.LBLBALACE_Click);
            // 
            // BTNBACK
            // 
            this.BTNBACK.Location = new System.Drawing.Point(880, 550);
            this.BTNBACK.Name = "BTNBACK";
            this.BTNBACK.Size = new System.Drawing.Size(152, 37);
            this.BTNBACK.TabIndex = 18;
            this.BTNBACK.Text = "BACK";
            this.BTNBACK.UseVisualStyleBackColor = true;
            this.BTNBACK.Click += new System.EventHandler(this.BTNBACK_Click);
            // 
            // student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 599);
            this.Controls.Add(this.BTNBACK);
            this.Controls.Add(this.PNLHOLDDINGALL);
            this.Controls.Add(this.LBLBALACE);
            this.Controls.Add(this.LBLSHOWUSRNAME);
            this.Controls.Add(this.LBLUSER);
            this.Controls.Add(this.FLOWLATOUTPNL);
            this.Name = "student_form";
            this.Text = "student_form";
            this.Load += new System.EventHandler(this.student_form_Load);
            this.PNLHOLDDINGALL.ResumeLayout(false);
            this.PNLHOLDDINGALL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLOWLATOUTPNL;
        private System.Windows.Forms.Panel PNLHOLDDINGALL;
        private System.Windows.Forms.PictureBox PICBOX1;
        private System.Windows.Forms.Button BTNPLAYorBUY;
        private System.Windows.Forms.Label LBLVDOTITLE;
        private System.Windows.Forms.Label LBLUSER;
        private System.Windows.Forms.Label LBLSHOWUSRNAME;
        private System.Windows.Forms.Label LBLBALACE;
        private System.Windows.Forms.Button BTNBACK;
    }
}