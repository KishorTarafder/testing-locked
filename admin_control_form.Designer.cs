namespace C_PROJECT
{
    partial class admin_control_form
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
            this.BTNSHOWALL = new System.Windows.Forms.Button();
            this.BTNSEARCH = new System.Windows.Forms.Button();
            this.TXTSEARCH = new System.Windows.Forms.TextBox();
            this.LBLID = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.LBLUSERNAME = new System.Windows.Forms.Label();
            this.TXTUSERNAME = new System.Windows.Forms.TextBox();
            this.LBLPASSWORD = new System.Windows.Forms.Label();
            this.TXTPASSWORD = new System.Windows.Forms.TextBox();
            this.LBLUSERTYPE = new System.Windows.Forms.Label();
            this.TXTUSERTYPE = new System.Windows.Forms.TextBox();
            this.LBLSTATUS = new System.Windows.Forms.Label();
            this.TXTSTATUS = new System.Windows.Forms.TextBox();
            this.BTNUPDATE = new System.Windows.Forms.Button();
            this.BTNADD = new System.Windows.Forms.Button();
            this.BTNBACK = new System.Windows.Forms.Button();
            this.BTNSHOWCOURSE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWSHOWALL)).BeginInit();
            this.SuspendLayout();
            // 
            // GRIDVIEWSHOWALL
            // 
            this.GRIDVIEWSHOWALL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWSHOWALL.Location = new System.Drawing.Point(515, 91);
            this.GRIDVIEWSHOWALL.Name = "GRIDVIEWSHOWALL";
            this.GRIDVIEWSHOWALL.RowHeadersWidth = 51;
            this.GRIDVIEWSHOWALL.RowTemplate.Height = 24;
            this.GRIDVIEWSHOWALL.Size = new System.Drawing.Size(810, 502);
            this.GRIDVIEWSHOWALL.TabIndex = 0;
            this.GRIDVIEWSHOWALL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEWSHOWALL_CellClick);
            this.GRIDVIEWSHOWALL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEWSHOWALL_CellContentClick);
            // 
            // BTNSHOWALL
            // 
            this.BTNSHOWALL.Location = new System.Drawing.Point(262, 626);
            this.BTNSHOWALL.Name = "BTNSHOWALL";
            this.BTNSHOWALL.Size = new System.Drawing.Size(213, 56);
            this.BTNSHOWALL.TabIndex = 1;
            this.BTNSHOWALL.Text = "SHOW ALL";
            this.BTNSHOWALL.UseVisualStyleBackColor = true;
            this.BTNSHOWALL.Click += new System.EventHandler(this.BTNSHOWALL_Click);
            // 
            // BTNSEARCH
            // 
            this.BTNSEARCH.Location = new System.Drawing.Point(1112, 37);
            this.BTNSEARCH.Name = "BTNSEARCH";
            this.BTNSEARCH.Size = new System.Drawing.Size(213, 48);
            this.BTNSEARCH.TabIndex = 2;
            this.BTNSEARCH.Text = "SEARCH";
            this.BTNSEARCH.UseVisualStyleBackColor = true;
            this.BTNSEARCH.Click += new System.EventHandler(this.BTNSEARCH_Click);
            // 
            // TXTSEARCH
            // 
            this.TXTSEARCH.Location = new System.Drawing.Point(799, 37);
            this.TXTSEARCH.Multiline = true;
            this.TXTSEARCH.Name = "TXTSEARCH";
            this.TXTSEARCH.Size = new System.Drawing.Size(307, 48);
            this.TXTSEARCH.TabIndex = 4;
            this.TXTSEARCH.TextChanged += new System.EventHandler(this.TXTSEARCH_TextChanged);
            // 
            // LBLID
            // 
            this.LBLID.AutoSize = true;
            this.LBLID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLID.Location = new System.Drawing.Point(27, 101);
            this.LBLID.Name = "LBLID";
            this.LBLID.Size = new System.Drawing.Size(33, 25);
            this.LBLID.TabIndex = 6;
            this.LBLID.Text = "ID";
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(191, 91);
            this.TXTID.Multiline = true;
            this.TXTID.Name = "TXTID";
            this.TXTID.ReadOnly = true;
            this.TXTID.Size = new System.Drawing.Size(307, 48);
            this.TXTID.TabIndex = 5;
            this.TXTID.TextChanged += new System.EventHandler(this.TXTID_TextChanged);
            // 
            // LBLUSERNAME
            // 
            this.LBLUSERNAME.AutoSize = true;
            this.LBLUSERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUSERNAME.Location = new System.Drawing.Point(24, 171);
            this.LBLUSERNAME.Name = "LBLUSERNAME";
            this.LBLUSERNAME.Size = new System.Drawing.Size(132, 25);
            this.LBLUSERNAME.TabIndex = 8;
            this.LBLUSERNAME.Text = "USERNAME";
            // 
            // TXTUSERNAME
            // 
            this.TXTUSERNAME.Location = new System.Drawing.Point(188, 161);
            this.TXTUSERNAME.Multiline = true;
            this.TXTUSERNAME.Name = "TXTUSERNAME";
            this.TXTUSERNAME.Size = new System.Drawing.Size(307, 48);
            this.TXTUSERNAME.TabIndex = 7;
            this.TXTUSERNAME.TextChanged += new System.EventHandler(this.TXTUSERNAME_TextChanged);
            // 
            // LBLPASSWORD
            // 
            this.LBLPASSWORD.AutoSize = true;
            this.LBLPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPASSWORD.Location = new System.Drawing.Point(27, 244);
            this.LBLPASSWORD.Name = "LBLPASSWORD";
            this.LBLPASSWORD.Size = new System.Drawing.Size(138, 25);
            this.LBLPASSWORD.TabIndex = 10;
            this.LBLPASSWORD.Text = "PASSWORD";
            // 
            // TXTPASSWORD
            // 
            this.TXTPASSWORD.Location = new System.Drawing.Point(191, 234);
            this.TXTPASSWORD.Multiline = true;
            this.TXTPASSWORD.Name = "TXTPASSWORD";
            this.TXTPASSWORD.Size = new System.Drawing.Size(307, 48);
            this.TXTPASSWORD.TabIndex = 9;
            this.TXTPASSWORD.TextChanged += new System.EventHandler(this.TXTPASSWORD_TextChanged);
            // 
            // LBLUSERTYPE
            // 
            this.LBLUSERTYPE.AutoSize = true;
            this.LBLUSERTYPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUSERTYPE.Location = new System.Drawing.Point(27, 316);
            this.LBLUSERTYPE.Name = "LBLUSERTYPE";
            this.LBLUSERTYPE.Size = new System.Drawing.Size(126, 25);
            this.LBLUSERTYPE.TabIndex = 12;
            this.LBLUSERTYPE.Text = "USERTYPE";
            // 
            // TXTUSERTYPE
            // 
            this.TXTUSERTYPE.Location = new System.Drawing.Point(191, 306);
            this.TXTUSERTYPE.Multiline = true;
            this.TXTUSERTYPE.Name = "TXTUSERTYPE";
            this.TXTUSERTYPE.Size = new System.Drawing.Size(307, 48);
            this.TXTUSERTYPE.TabIndex = 11;
            this.TXTUSERTYPE.TextChanged += new System.EventHandler(this.TXTUSERTYPE_TextChanged);
            // 
            // LBLSTATUS
            // 
            this.LBLSTATUS.AutoSize = true;
            this.LBLSTATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSTATUS.Location = new System.Drawing.Point(27, 397);
            this.LBLSTATUS.Name = "LBLSTATUS";
            this.LBLSTATUS.Size = new System.Drawing.Size(100, 25);
            this.LBLSTATUS.TabIndex = 14;
            this.LBLSTATUS.Text = "STATUS";
            // 
            // TXTSTATUS
            // 
            this.TXTSTATUS.Location = new System.Drawing.Point(191, 387);
            this.TXTSTATUS.Multiline = true;
            this.TXTSTATUS.Name = "TXTSTATUS";
            this.TXTSTATUS.Size = new System.Drawing.Size(307, 48);
            this.TXTSTATUS.TabIndex = 13;
            this.TXTSTATUS.TextChanged += new System.EventHandler(this.TXTSTATUS_TextChanged);
            // 
            // BTNUPDATE
            // 
            this.BTNUPDATE.Location = new System.Drawing.Point(12, 626);
            this.BTNUPDATE.Name = "BTNUPDATE";
            this.BTNUPDATE.Size = new System.Drawing.Size(184, 56);
            this.BTNUPDATE.TabIndex = 15;
            this.BTNUPDATE.Text = "UPDATE";
            this.BTNUPDATE.UseVisualStyleBackColor = true;
            this.BTNUPDATE.Click += new System.EventHandler(this.BTNUPDATE_Click);
            // 
            // BTNADD
            // 
            this.BTNADD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTNADD.Location = new System.Drawing.Point(262, 462);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(213, 56);
            this.BTNADD.TabIndex = 16;
            this.BTNADD.Text = "ADD";
            this.BTNADD.UseVisualStyleBackColor = true;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // BTNBACK
            // 
            this.BTNBACK.Location = new System.Drawing.Point(1112, 626);
            this.BTNBACK.Name = "BTNBACK";
            this.BTNBACK.Size = new System.Drawing.Size(213, 56);
            this.BTNBACK.TabIndex = 17;
            this.BTNBACK.Text = "BACK";
            this.BTNBACK.UseVisualStyleBackColor = true;
            this.BTNBACK.Click += new System.EventHandler(this.BTNBACK_Click);
            // 
            // BTNSHOWCOURSE
            // 
            this.BTNSHOWCOURSE.Location = new System.Drawing.Point(515, 37);
            this.BTNSHOWCOURSE.Name = "BTNSHOWCOURSE";
            this.BTNSHOWCOURSE.Size = new System.Drawing.Size(213, 48);
            this.BTNSHOWCOURSE.TabIndex = 18;
            this.BTNSHOWCOURSE.Text = "EXIT";
            this.BTNSHOWCOURSE.UseVisualStyleBackColor = true;
            this.BTNSHOWCOURSE.Click += new System.EventHandler(this.BTNSHOWCOURSE_Click);
            // 
            // admin_control_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 694);
            this.Controls.Add(this.BTNSHOWCOURSE);
            this.Controls.Add(this.BTNBACK);
            this.Controls.Add(this.BTNADD);
            this.Controls.Add(this.BTNUPDATE);
            this.Controls.Add(this.LBLSTATUS);
            this.Controls.Add(this.TXTSTATUS);
            this.Controls.Add(this.LBLUSERTYPE);
            this.Controls.Add(this.TXTUSERTYPE);
            this.Controls.Add(this.LBLPASSWORD);
            this.Controls.Add(this.TXTPASSWORD);
            this.Controls.Add(this.LBLUSERNAME);
            this.Controls.Add(this.TXTUSERNAME);
            this.Controls.Add(this.LBLID);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.TXTSEARCH);
            this.Controls.Add(this.BTNSEARCH);
            this.Controls.Add(this.BTNSHOWALL);
            this.Controls.Add(this.GRIDVIEWSHOWALL);
            this.Name = "admin_control_form";
            this.Text = "admin_form";
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWSHOWALL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GRIDVIEWSHOWALL;
        private System.Windows.Forms.Button BTNSHOWALL;
        private System.Windows.Forms.Button BTNSEARCH;
        private System.Windows.Forms.TextBox TXTSEARCH;
        private System.Windows.Forms.Label LBLID;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label LBLUSERNAME;
        private System.Windows.Forms.TextBox TXTUSERNAME;
        private System.Windows.Forms.Label LBLPASSWORD;
        private System.Windows.Forms.TextBox TXTPASSWORD;
        private System.Windows.Forms.Label LBLUSERTYPE;
        private System.Windows.Forms.TextBox TXTUSERTYPE;
        private System.Windows.Forms.Label LBLSTATUS;
        private System.Windows.Forms.TextBox TXTSTATUS;
        private System.Windows.Forms.Button BTNUPDATE;
        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.Button BTNBACK;
        private System.Windows.Forms.Button BTNSHOWCOURSE;
    }
}