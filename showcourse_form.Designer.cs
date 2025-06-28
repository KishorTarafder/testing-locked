namespace C_PROJECT
{
    partial class showcourse_form
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
            this.GRIDVIEWSHOWALL = new System.Windows.Forms.DataGridView();
            this.BTNSHOWCOURSES = new System.Windows.Forms.Button();
            this.BTNUPDATE = new System.Windows.Forms.Button();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.BTNBACK = new System.Windows.Forms.Button();
            this.TXTSEARCH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWSHOWALL)).BeginInit();
            this.SuspendLayout();
            // 
            // GRIDVIEWSHOWALL
            // 
            this.GRIDVIEWSHOWALL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWSHOWALL.Location = new System.Drawing.Point(84, 66);
            this.GRIDVIEWSHOWALL.Name = "GRIDVIEWSHOWALL";
            this.GRIDVIEWSHOWALL.RowHeadersWidth = 51;
            this.GRIDVIEWSHOWALL.RowTemplate.Height = 24;
            this.GRIDVIEWSHOWALL.Size = new System.Drawing.Size(938, 442);
            this.GRIDVIEWSHOWALL.TabIndex = 1;
            this.GRIDVIEWSHOWALL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEWSHOWALL_CellContentClick);
            // 
            // BTNSHOWCOURSES
            // 
            this.BTNSHOWCOURSES.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTNSHOWCOURSES.Location = new System.Drawing.Point(69, 531);
            this.BTNSHOWCOURSES.Name = "BTNSHOWCOURSES";
            this.BTNSHOWCOURSES.Size = new System.Drawing.Size(213, 56);
            this.BTNSHOWCOURSES.TabIndex = 17;
            this.BTNSHOWCOURSES.Text = "SHOW COURSES";
            this.BTNSHOWCOURSES.UseVisualStyleBackColor = true;
            this.BTNSHOWCOURSES.Click += new System.EventHandler(this.BTNSHOWCOURSES_Click);
            // 
            // BTNUPDATE
            // 
            this.BTNUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTNUPDATE.Location = new System.Drawing.Point(316, 531);
            this.BTNUPDATE.Name = "BTNUPDATE";
            this.BTNUPDATE.Size = new System.Drawing.Size(213, 56);
            this.BTNUPDATE.TabIndex = 18;
            this.BTNUPDATE.Text = "UPDATE";
            this.BTNUPDATE.UseVisualStyleBackColor = true;
            this.BTNUPDATE.Click += new System.EventHandler(this.BTNUPDATE_Click);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTNDELETE.Location = new System.Drawing.Point(563, 531);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(213, 56);
            this.BTNDELETE.TabIndex = 19;
            this.BTNDELETE.Text = "DELETE";
            this.BTNDELETE.UseVisualStyleBackColor = true;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // BTNBACK
            // 
            this.BTNBACK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTNBACK.Location = new System.Drawing.Point(809, 531);
            this.BTNBACK.Name = "BTNBACK";
            this.BTNBACK.Size = new System.Drawing.Size(213, 56);
            this.BTNBACK.TabIndex = 20;
            this.BTNBACK.Text = "BACK";
            this.BTNBACK.UseVisualStyleBackColor = true;
            this.BTNBACK.Click += new System.EventHandler(this.BTNBACK_Click);
            // 
            // TXTSEARCH
            // 
            this.TXTSEARCH.Location = new System.Drawing.Point(715, 12);
            this.TXTSEARCH.Multiline = true;
            this.TXTSEARCH.Name = "TXTSEARCH";
            this.TXTSEARCH.Size = new System.Drawing.Size(307, 48);
            this.TXTSEARCH.TabIndex = 21;
            this.TXTSEARCH.TextChanged += new System.EventHandler(this.TXTSEARCH_TextChanged);
            // 
            // showcourse_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 621);
            this.Controls.Add(this.TXTSEARCH);
            this.Controls.Add(this.BTNBACK);
            this.Controls.Add(this.BTNDELETE);
            this.Controls.Add(this.BTNUPDATE);
            this.Controls.Add(this.BTNSHOWCOURSES);
            this.Controls.Add(this.GRIDVIEWSHOWALL);
            this.Name = "showcourse_form";
            this.Text = "Course Management - View, Update & Delete Courses";
            this.Load += new System.EventHandler(this.showcourse_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWSHOWALL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GRIDVIEWSHOWALL;
        private System.Windows.Forms.Button BTNSHOWCOURSES;
        private System.Windows.Forms.Button BTNUPDATE;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.Button BTNBACK;
        private System.Windows.Forms.TextBox TXTSEARCH;
    }
}