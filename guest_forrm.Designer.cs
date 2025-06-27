namespace C_PROJECT
{
    partial class guest_forrm
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
            this.LBLBALACE = new System.Windows.Forms.Label();
            this.LBLSHOWUSRNAME = new System.Windows.Forms.Label();
            this.LBLUSER = new System.Windows.Forms.Label();
            this.FLOWLATOUTPNL = new System.Windows.Forms.FlowLayoutPanel();
            this.TXTSEARCH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBLBALACE
            // 
            this.LBLBALACE.AutoSize = true;
            this.LBLBALACE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLBALACE.Location = new System.Drawing.Point(176, 63);
            this.LBLBALACE.Name = "LBLBALACE";
            this.LBLBALACE.Size = new System.Drawing.Size(113, 25);
            this.LBLBALACE.TabIndex = 9;
            this.LBLBALACE.Text = "BALANCE";
            // 
            // LBLSHOWUSRNAME
            // 
            this.LBLSHOWUSRNAME.AutoSize = true;
            this.LBLSHOWUSRNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSHOWUSRNAME.Location = new System.Drawing.Point(176, 22);
            this.LBLSHOWUSRNAME.Name = "LBLSHOWUSRNAME";
            this.LBLSHOWUSRNAME.Size = new System.Drawing.Size(110, 25);
            this.LBLSHOWUSRNAME.TabIndex = 8;
            this.LBLSHOWUSRNAME.Text = "DEFAULT";
            // 
            // LBLUSER
            // 
            this.LBLUSER.AutoSize = true;
            this.LBLUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUSER.Location = new System.Drawing.Point(9, 22);
            this.LBLUSER.Name = "LBLUSER";
            this.LBLUSER.Size = new System.Drawing.Size(151, 25);
            this.LBLUSER.TabIndex = 7;
            this.LBLUSER.Text = "USER NAME :";
            // 
            // FLOWLATOUTPNL
            // 
            this.FLOWLATOUTPNL.AutoScroll = true;
            this.FLOWLATOUTPNL.Location = new System.Drawing.Point(14, 112);
            this.FLOWLATOUTPNL.Name = "FLOWLATOUTPNL";
            this.FLOWLATOUTPNL.Size = new System.Drawing.Size(945, 451);
            this.FLOWLATOUTPNL.TabIndex = 6;
            this.FLOWLATOUTPNL.Paint += new System.Windows.Forms.PaintEventHandler(this.FLOWLATOUTPNL_Paint);
            // 
            // TXTSEARCH
            // 
            this.TXTSEARCH.Location = new System.Drawing.Point(666, 22);
            this.TXTSEARCH.Multiline = true;
            this.TXTSEARCH.Name = "TXTSEARCH";
            this.TXTSEARCH.Size = new System.Drawing.Size(346, 46);
            this.TXTSEARCH.TabIndex = 10;
            this.TXTSEARCH.TextChanged += new System.EventHandler(this.TXTSEARCH_TextChanged);
            // 
            // guest_forrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 565);
            this.Controls.Add(this.TXTSEARCH);
            this.Controls.Add(this.LBLBALACE);
            this.Controls.Add(this.LBLSHOWUSRNAME);
            this.Controls.Add(this.LBLUSER);
            this.Controls.Add(this.FLOWLATOUTPNL);
            this.Name = "guest_forrm";
            this.Text = "guest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLBALACE;
        private System.Windows.Forms.Label LBLSHOWUSRNAME;
        private System.Windows.Forms.Label LBLUSER;
        private System.Windows.Forms.FlowLayoutPanel FLOWLATOUTPNL;
        private System.Windows.Forms.TextBox TXTSEARCH;
    }
}