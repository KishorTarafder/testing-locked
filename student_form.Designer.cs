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
            this.LBLSHOWUSRNAME = new System.Windows.Forms.Label();
            this.LBLBALACE = new System.Windows.Forms.Label();
            this.BTNBACK = new System.Windows.Forms.Button();
            this.LBLCOURSENAME = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTSEARCH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FLOWLATOUTPNL
            // 
            this.FLOWLATOUTPNL.AutoScroll = true;
            this.FLOWLATOUTPNL.BackColor = System.Drawing.Color.Transparent;
            this.FLOWLATOUTPNL.Location = new System.Drawing.Point(486, 60);
            this.FLOWLATOUTPNL.Name = "FLOWLATOUTPNL";
            this.FLOWLATOUTPNL.Size = new System.Drawing.Size(576, 538);
            this.FLOWLATOUTPNL.TabIndex = 0;
            this.FLOWLATOUTPNL.Paint += new System.Windows.Forms.PaintEventHandler(this.FLOWLATOUTPNL_Paint);
            // 
            // LBLSHOWUSRNAME
            // 
            this.LBLSHOWUSRNAME.AutoSize = true;
            this.LBLSHOWUSRNAME.BackColor = System.Drawing.Color.Transparent;
            this.LBLSHOWUSRNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSHOWUSRNAME.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBLSHOWUSRNAME.Location = new System.Drawing.Point(198, 15);
            this.LBLSHOWUSRNAME.Name = "LBLSHOWUSRNAME";
            this.LBLSHOWUSRNAME.Size = new System.Drawing.Size(110, 25);
            this.LBLSHOWUSRNAME.TabIndex = 4;
            this.LBLSHOWUSRNAME.Text = "DEFAULT";
            this.LBLSHOWUSRNAME.Click += new System.EventHandler(this.LBLSHOWUSRNAME_Click);
            // 
            // LBLBALACE
            // 
            this.LBLBALACE.AutoSize = true;
            this.LBLBALACE.BackColor = System.Drawing.Color.Transparent;
            this.LBLBALACE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLBALACE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBLBALACE.Location = new System.Drawing.Point(195, 63);
            this.LBLBALACE.Name = "LBLBALACE";
            this.LBLBALACE.Size = new System.Drawing.Size(113, 25);
            this.LBLBALACE.TabIndex = 5;
            this.LBLBALACE.Text = "BALANCE";
            this.LBLBALACE.Click += new System.EventHandler(this.LBLBALACE_Click);
            // 
            // BTNBACK
            // 
            this.BTNBACK.BackColor = System.Drawing.Color.SaddleBrown;
            this.BTNBACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBACK.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTNBACK.Location = new System.Drawing.Point(35, 527);
            this.BTNBACK.Name = "BTNBACK";
            this.BTNBACK.Size = new System.Drawing.Size(157, 42);
            this.BTNBACK.TabIndex = 18;
            this.BTNBACK.Text = "BACK";
            this.BTNBACK.UseVisualStyleBackColor = false;
            this.BTNBACK.Click += new System.EventHandler(this.BTNBACK_Click);
            // 
            // LBLCOURSENAME
            // 
            this.LBLCOURSENAME.AutoSize = true;
            this.LBLCOURSENAME.BackColor = System.Drawing.Color.Transparent;
            this.LBLCOURSENAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCOURSENAME.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLCOURSENAME.Location = new System.Drawing.Point(12, 12);
            this.LBLCOURSENAME.Name = "LBLCOURSENAME";
            this.LBLCOURSENAME.Size = new System.Drawing.Size(177, 29);
            this.LBLCOURSENAME.TabIndex = 19;
            this.LBLCOURSENAME.Text = "USERNAME  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "BALANCE     :";
            // 
            // TXTSEARCH
            // 
            this.TXTSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSEARCH.Location = new System.Drawing.Point(755, 12);
            this.TXTSEARCH.Name = "TXTSEARCH";
            this.TXTSEARCH.Size = new System.Drawing.Size(280, 26);
            this.TXTSEARCH.TabIndex = 5;
            this.TXTSEARCH.TextChanged += new System.EventHandler(this.TXTSEARCH_TextChanged);
            // 
            // student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 599);
            this.Controls.Add(this.TXTSEARCH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLCOURSENAME);
            this.Controls.Add(this.BTNBACK);
            this.Controls.Add(this.LBLBALACE);
            this.Controls.Add(this.LBLSHOWUSRNAME);
            this.Controls.Add(this.FLOWLATOUTPNL);
            this.DoubleBuffered = true;
            this.Name = "student_form";
            this.Text = "student_form";
            this.Load += new System.EventHandler(this.student_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLOWLATOUTPNL;
        private System.Windows.Forms.Label LBLSHOWUSRNAME;
        private System.Windows.Forms.Label LBLBALACE;
        private System.Windows.Forms.Button BTNBACK;
        private System.Windows.Forms.Label LBLCOURSENAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTSEARCH;
    }
}