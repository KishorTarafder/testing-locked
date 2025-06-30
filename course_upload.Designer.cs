namespace C_PROJECT
{
    partial class course_upload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(course_upload));
            this.BTNADDCOURSE = new System.Windows.Forms.Button();
            this.TXTYOUTUBELINK = new System.Windows.Forms.TextBox();
            this.LBLYTLINK = new System.Windows.Forms.Label();
            this.LBLCOURSENAME = new System.Windows.Forms.Label();
            this.TXTCOURSENAME = new System.Windows.Forms.TextBox();
            this.BTNUPLOAD = new System.Windows.Forms.Button();
            this.LBLPRICE = new System.Windows.Forms.Label();
            this.TXTPRICE = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNBROWSE = new System.Windows.Forms.Button();
            this.BTNSAVE = new System.Windows.Forms.Button();
            this.BTNBACK = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LBLBALACE = new System.Windows.Forms.Label();
            this.LBLSHOWUSRNAME = new System.Windows.Forms.Label();
            this.LBLUSER = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNADDCOURSE
            // 
            this.BTNADDCOURSE.Location = new System.Drawing.Point(1047, 40);
            this.BTNADDCOURSE.Name = "BTNADDCOURSE";
            this.BTNADDCOURSE.Size = new System.Drawing.Size(20, 16);
            this.BTNADDCOURSE.TabIndex = 13;
            this.BTNADDCOURSE.Text = "ADD COURSE";
            this.BTNADDCOURSE.UseVisualStyleBackColor = true;
            this.BTNADDCOURSE.Click += new System.EventHandler(this.BTNADDCOURSE_Click);
            // 
            // TXTYOUTUBELINK
            // 
            this.TXTYOUTUBELINK.Location = new System.Drawing.Point(76, 271);
            this.TXTYOUTUBELINK.Multiline = true;
            this.TXTYOUTUBELINK.Name = "TXTYOUTUBELINK";
            this.TXTYOUTUBELINK.Size = new System.Drawing.Size(307, 48);
            this.TXTYOUTUBELINK.TabIndex = 12;
            this.TXTYOUTUBELINK.TextChanged += new System.EventHandler(this.TXTYOUTUBELINK_TextChanged);
            // 
            // LBLYTLINK
            // 
            this.LBLYTLINK.AutoSize = true;
            this.LBLYTLINK.BackColor = System.Drawing.Color.Transparent;
            this.LBLYTLINK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLYTLINK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLYTLINK.Location = new System.Drawing.Point(71, 228);
            this.LBLYTLINK.Name = "LBLYTLINK";
            this.LBLYTLINK.Size = new System.Drawing.Size(104, 29);
            this.LBLYTLINK.TabIndex = 11;
            this.LBLYTLINK.Text = "YTLINK";
            this.LBLYTLINK.Click += new System.EventHandler(this.LBLYTLINK_Click);
            // 
            // LBLCOURSENAME
            // 
            this.LBLCOURSENAME.AutoSize = true;
            this.LBLCOURSENAME.BackColor = System.Drawing.Color.Transparent;
            this.LBLCOURSENAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCOURSENAME.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLCOURSENAME.Location = new System.Drawing.Point(71, 106);
            this.LBLCOURSENAME.Name = "LBLCOURSENAME";
            this.LBLCOURSENAME.Size = new System.Drawing.Size(194, 29);
            this.LBLCOURSENAME.TabIndex = 10;
            this.LBLCOURSENAME.Text = "COURSENAME";
            // 
            // TXTCOURSENAME
            // 
            this.TXTCOURSENAME.Location = new System.Drawing.Point(76, 158);
            this.TXTCOURSENAME.Multiline = true;
            this.TXTCOURSENAME.Name = "TXTCOURSENAME";
            this.TXTCOURSENAME.Size = new System.Drawing.Size(307, 48);
            this.TXTCOURSENAME.TabIndex = 9;
            this.TXTCOURSENAME.TextChanged += new System.EventHandler(this.TXTCOURSENAME_TextChanged);
            // 
            // BTNUPLOAD
            // 
            this.BTNUPLOAD.Location = new System.Drawing.Point(1063, 40);
            this.BTNUPLOAD.Name = "BTNUPLOAD";
            this.BTNUPLOAD.Size = new System.Drawing.Size(15, 16);
            this.BTNUPLOAD.TabIndex = 8;
            this.BTNUPLOAD.Text = "UPLOAD";
            this.BTNUPLOAD.UseVisualStyleBackColor = true;
            this.BTNUPLOAD.Click += new System.EventHandler(this.BTNUPLOAD_Click);
            // 
            // LBLPRICE
            // 
            this.LBLPRICE.AutoSize = true;
            this.LBLPRICE.BackColor = System.Drawing.Color.Transparent;
            this.LBLPRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPRICE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLPRICE.Location = new System.Drawing.Point(71, 338);
            this.LBLPRICE.Name = "LBLPRICE";
            this.LBLPRICE.Size = new System.Drawing.Size(90, 29);
            this.LBLPRICE.TabIndex = 14;
            this.LBLPRICE.Text = "PRICE";
            // 
            // TXTPRICE
            // 
            this.TXTPRICE.Location = new System.Drawing.Point(76, 382);
            this.TXTPRICE.Multiline = true;
            this.TXTPRICE.Name = "TXTPRICE";
            this.TXTPRICE.Size = new System.Drawing.Size(307, 48);
            this.TXTPRICE.TabIndex = 15;
            this.TXTPRICE.TextChanged += new System.EventHandler(this.TXTPRICE_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(687, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 291);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BTNBROWSE
            // 
            this.BTNBROWSE.BackColor = System.Drawing.Color.Transparent;
            this.BTNBROWSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBROWSE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNBROWSE.Location = new System.Drawing.Point(863, 462);
            this.BTNBROWSE.Name = "BTNBROWSE";
            this.BTNBROWSE.Size = new System.Drawing.Size(138, 63);
            this.BTNBROWSE.TabIndex = 18;
            this.BTNBROWSE.Text = "BROWSE";
            this.BTNBROWSE.UseVisualStyleBackColor = false;
            this.BTNBROWSE.Click += new System.EventHandler(this.BTNBROWSE_Click);
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.BackColor = System.Drawing.Color.Transparent;
            this.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSAVE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNSAVE.Location = new System.Drawing.Point(668, 462);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(133, 63);
            this.BTNSAVE.TabIndex = 19;
            this.BTNSAVE.Text = "SAVE";
            this.BTNSAVE.UseVisualStyleBackColor = false;
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // BTNBACK
            // 
            this.BTNBACK.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTNBACK.Location = new System.Drawing.Point(76, 462);
            this.BTNBACK.Name = "BTNBACK";
            this.BTNBACK.Size = new System.Drawing.Size(137, 57);
            this.BTNBACK.TabIndex = 23;
            this.BTNBACK.Text = "BACK";
            this.BTNBACK.UseVisualStyleBackColor = false;
            this.BTNBACK.Click += new System.EventHandler(this.BTNBACK_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LBLBALACE
            // 
            this.LBLBALACE.AutoSize = true;
            this.LBLBALACE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLBALACE.Location = new System.Drawing.Point(1060, 72);
            this.LBLBALACE.Name = "LBLBALACE";
            this.LBLBALACE.Size = new System.Drawing.Size(76, 16);
            this.LBLBALACE.TabIndex = 22;
            this.LBLBALACE.Text = "BALANCE";
            this.LBLBALACE.Visible = false;
            this.LBLBALACE.Click += new System.EventHandler(this.LBLBALACE_Click);
            // 
            // LBLSHOWUSRNAME
            // 
            this.LBLSHOWUSRNAME.AutoSize = true;
            this.LBLSHOWUSRNAME.BackColor = System.Drawing.Color.Transparent;
            this.LBLSHOWUSRNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSHOWUSRNAME.ForeColor = System.Drawing.Color.Transparent;
            this.LBLSHOWUSRNAME.Location = new System.Drawing.Point(123, 31);
            this.LBLSHOWUSRNAME.Name = "LBLSHOWUSRNAME";
            this.LBLSHOWUSRNAME.Size = new System.Drawing.Size(181, 39);
            this.LBLSHOWUSRNAME.TabIndex = 21;
            this.LBLSHOWUSRNAME.Text = "DEFAULT";
            this.LBLSHOWUSRNAME.Click += new System.EventHandler(this.LBLSHOWUSRNAME_Click);
            // 
            // LBLUSER
            // 
            this.LBLUSER.AutoSize = true;
            this.LBLUSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUSER.ForeColor = System.Drawing.Color.Transparent;
            this.LBLUSER.Location = new System.Drawing.Point(1042, 121);
            this.LBLUSER.Name = "LBLUSER";
            this.LBLUSER.Size = new System.Drawing.Size(151, 25);
            this.LBLUSER.TabIndex = 20;
            this.LBLUSER.Text = "USER NAME :";
            this.LBLUSER.Visible = false;
            this.LBLUSER.Click += new System.EventHandler(this.LBLUSER_Click);
            // 
            // course_upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 647);
            this.Controls.Add(this.BTNBACK);
            this.Controls.Add(this.LBLBALACE);
            this.Controls.Add(this.LBLSHOWUSRNAME);
            this.Controls.Add(this.LBLUSER);
            this.Controls.Add(this.BTNSAVE);
            this.Controls.Add(this.BTNBROWSE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TXTPRICE);
            this.Controls.Add(this.LBLPRICE);
            this.Controls.Add(this.BTNADDCOURSE);
            this.Controls.Add(this.TXTYOUTUBELINK);
            this.Controls.Add(this.LBLYTLINK);
            this.Controls.Add(this.LBLCOURSENAME);
            this.Controls.Add(this.TXTCOURSENAME);
            this.Controls.Add(this.BTNUPLOAD);
            this.DoubleBuffered = true;
            this.Name = "course_upload";
            this.Text = "course_upload";
            this.Load += new System.EventHandler(this.course_upload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNADDCOURSE;
        private System.Windows.Forms.TextBox TXTYOUTUBELINK;
        private System.Windows.Forms.Label LBLYTLINK;
        private System.Windows.Forms.Label LBLCOURSENAME;
        private System.Windows.Forms.TextBox TXTCOURSENAME;
        private System.Windows.Forms.Button BTNUPLOAD;
        private System.Windows.Forms.Label LBLPRICE;
        private System.Windows.Forms.TextBox TXTPRICE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNBROWSE;
        private System.Windows.Forms.Button BTNSAVE;
        private System.Windows.Forms.Button BTNBACK;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LBLBALACE;
        private System.Windows.Forms.Label LBLSHOWUSRNAME;
        private System.Windows.Forms.Label LBLUSER;
    }
}