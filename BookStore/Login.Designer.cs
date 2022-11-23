namespace BookStore
{
    partial class Login
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
            this.loginpictureBox = new System.Windows.Forms.PictureBox();
            this.adminloginpanel = new System.Windows.Forms.Panel();
            this.userpanelpanel = new System.Windows.Forms.Panel();
            this.exitlabel2 = new System.Windows.Forms.Label();
            this.adminlabel = new System.Windows.Forms.Label();
            this.userloginbutton = new System.Windows.Forms.Button();
            this.userpasslabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.userpasswordtextBox = new System.Windows.Forms.TextBox();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.cancellabel = new System.Windows.Forms.Label();
            this.exitlabel = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.welcomepictureBox = new System.Windows.Forms.PictureBox();
            this.adminloginlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginpictureBox)).BeginInit();
            this.adminloginpanel.SuspendLayout();
            this.userpanelpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginpictureBox
            // 
            this.loginpictureBox.BackColor = System.Drawing.Color.MintCream;
            this.loginpictureBox.Image = global::BookStore.Properties.Resources.LoginBooks;
            this.loginpictureBox.Location = new System.Drawing.Point(14, 12);
            this.loginpictureBox.Name = "loginpictureBox";
            this.loginpictureBox.Size = new System.Drawing.Size(382, 426);
            this.loginpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginpictureBox.TabIndex = 0;
            this.loginpictureBox.TabStop = false;
            // 
            // adminloginpanel
            // 
            this.adminloginpanel.BackColor = System.Drawing.Color.MintCream;
            this.adminloginpanel.Controls.Add(this.cancellabel);
            this.adminloginpanel.Controls.Add(this.exitlabel);
            this.adminloginpanel.Controls.Add(this.loginbutton);
            this.adminloginpanel.Controls.Add(this.passwordlabel);
            this.adminloginpanel.Controls.Add(this.passwordtextBox);
            this.adminloginpanel.Controls.Add(this.welcomepictureBox);
            this.adminloginpanel.Controls.Add(this.adminloginlabel);
            this.adminloginpanel.Location = new System.Drawing.Point(383, 12);
            this.adminloginpanel.Name = "adminloginpanel";
            this.adminloginpanel.Size = new System.Drawing.Size(402, 426);
            this.adminloginpanel.TabIndex = 1;
            this.adminloginpanel.Visible = false;
            // 
            // userpanelpanel
            // 
            this.userpanelpanel.BackColor = System.Drawing.Color.MintCream;
            this.userpanelpanel.Controls.Add(this.exitlabel2);
            this.userpanelpanel.Controls.Add(this.adminlabel);
            this.userpanelpanel.Controls.Add(this.userloginbutton);
            this.userpanelpanel.Controls.Add(this.userpasslabel);
            this.userpanelpanel.Controls.Add(this.usernamelabel);
            this.userpanelpanel.Controls.Add(this.userpasswordtextBox);
            this.userpanelpanel.Controls.Add(this.usernametextBox);
            this.userpanelpanel.Controls.Add(this.pictureBox1);
            this.userpanelpanel.Controls.Add(this.welcomelabel);
            this.userpanelpanel.Location = new System.Drawing.Point(383, 12);
            this.userpanelpanel.Name = "userpanelpanel";
            this.userpanelpanel.Size = new System.Drawing.Size(402, 426);
            this.userpanelpanel.TabIndex = 3;
            // 
            // exitlabel2
            // 
            this.exitlabel2.AutoSize = true;
            this.exitlabel2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitlabel2.ForeColor = System.Drawing.Color.DimGray;
            this.exitlabel2.Location = new System.Drawing.Point(371, 1);
            this.exitlabel2.Name = "exitlabel2";
            this.exitlabel2.Size = new System.Drawing.Size(30, 35);
            this.exitlabel2.TabIndex = 9;
            this.exitlabel2.Text = "X";
            this.exitlabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitlabel2.Click += new System.EventHandler(this.exitlabel2_Click);
            // 
            // adminlabel
            // 
            this.adminlabel.AutoSize = true;
            this.adminlabel.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.adminlabel.ForeColor = System.Drawing.Color.DimGray;
            this.adminlabel.Location = new System.Drawing.Point(176, 362);
            this.adminlabel.Name = "adminlabel";
            this.adminlabel.Size = new System.Drawing.Size(58, 19);
            this.adminlabel.TabIndex = 8;
            this.adminlabel.Text = "Admin";
            this.adminlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminlabel.Click += new System.EventHandler(this.adminlabel_Click);
            // 
            // userloginbutton
            // 
            this.userloginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userloginbutton.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userloginbutton.ForeColor = System.Drawing.Color.DimGray;
            this.userloginbutton.Location = new System.Drawing.Point(148, 314);
            this.userloginbutton.Name = "userloginbutton";
            this.userloginbutton.Size = new System.Drawing.Size(112, 34);
            this.userloginbutton.TabIndex = 7;
            this.userloginbutton.Text = "Log in";
            this.userloginbutton.UseVisualStyleBackColor = true;
            this.userloginbutton.Click += new System.EventHandler(this.userloginbutton_Click);
            // 
            // userpasslabel
            // 
            this.userpasslabel.AutoSize = true;
            this.userpasslabel.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userpasslabel.ForeColor = System.Drawing.Color.DimGray;
            this.userpasslabel.Location = new System.Drawing.Point(30, 260);
            this.userpasslabel.Name = "userpasslabel";
            this.userpasslabel.Size = new System.Drawing.Size(86, 20);
            this.userpasslabel.TabIndex = 6;
            this.userpasslabel.Text = "password";
            this.userpasslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernamelabel.ForeColor = System.Drawing.Color.DimGray;
            this.usernamelabel.Location = new System.Drawing.Point(30, 212);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(89, 20);
            this.usernamelabel.TabIndex = 5;
            this.usernamelabel.Text = "username";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userpasswordtextBox
            // 
            this.userpasswordtextBox.Location = new System.Drawing.Point(125, 254);
            this.userpasswordtextBox.Name = "userpasswordtextBox";
            this.userpasswordtextBox.Size = new System.Drawing.Size(241, 31);
            this.userpasswordtextBox.TabIndex = 4;
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(125, 206);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(241, 31);
            this.usernametextBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookStore.Properties.Resources.Hygge_Bookstore;
            this.pictureBox1.Location = new System.Drawing.Point(168, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomelabel.ForeColor = System.Drawing.Color.DimGray;
            this.welcomelabel.Location = new System.Drawing.Point(24, 68);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(347, 30);
            this.welcomelabel.TabIndex = 1;
            this.welcomelabel.Text = "Welcome to Hygge Bookshop";
            this.welcomelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancellabel
            // 
            this.cancellabel.AutoSize = true;
            this.cancellabel.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.cancellabel.ForeColor = System.Drawing.Color.DimGray;
            this.cancellabel.Location = new System.Drawing.Point(171, 304);
            this.cancellabel.Name = "cancellabel";
            this.cancellabel.Size = new System.Drawing.Size(59, 19);
            this.cancellabel.TabIndex = 10;
            this.cancellabel.Text = "Cancel";
            this.cancellabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancellabel.Click += new System.EventHandler(this.cancellabel_Click);
            // 
            // exitlabel
            // 
            this.exitlabel.AutoSize = true;
            this.exitlabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitlabel.ForeColor = System.Drawing.Color.DimGray;
            this.exitlabel.Location = new System.Drawing.Point(371, 1);
            this.exitlabel.Name = "exitlabel";
            this.exitlabel.Size = new System.Drawing.Size(30, 35);
            this.exitlabel.TabIndex = 9;
            this.exitlabel.Text = "X";
            this.exitlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitlabel.Click += new System.EventHandler(this.exitlabel_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbutton.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginbutton.ForeColor = System.Drawing.Color.DimGray;
            this.loginbutton.Location = new System.Drawing.Point(145, 264);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(112, 34);
            this.loginbutton.TabIndex = 7;
            this.loginbutton.Text = "Log in";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordlabel.ForeColor = System.Drawing.Color.DimGray;
            this.passwordlabel.Location = new System.Drawing.Point(14, 198);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(86, 20);
            this.passwordlabel.TabIndex = 6;
            this.passwordlabel.Text = "password";
            this.passwordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(106, 192);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(264, 31);
            this.passwordtextBox.TabIndex = 4;
            // 
            // welcomepictureBox
            // 
            this.welcomepictureBox.Image = global::BookStore.Properties.Resources.Hygge_Bookstore;
            this.welcomepictureBox.Location = new System.Drawing.Point(163, 105);
            this.welcomepictureBox.Name = "welcomepictureBox";
            this.welcomepictureBox.Size = new System.Drawing.Size(73, 63);
            this.welcomepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.welcomepictureBox.TabIndex = 2;
            this.welcomepictureBox.TabStop = false;
            // 
            // adminloginlabel
            // 
            this.adminloginlabel.AutoSize = true;
            this.adminloginlabel.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminloginlabel.ForeColor = System.Drawing.Color.DimGray;
            this.adminloginlabel.Location = new System.Drawing.Point(120, 63);
            this.adminloginlabel.Name = "adminloginlabel";
            this.adminloginlabel.Size = new System.Drawing.Size(161, 30);
            this.adminloginlabel.TabIndex = 1;
            this.adminloginlabel.Text = "Admin Login";
            this.adminloginlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userpanelpanel);
            this.Controls.Add(this.adminloginpanel);
            this.Controls.Add(this.loginpictureBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.loginpictureBox)).EndInit();
            this.adminloginpanel.ResumeLayout(false);
            this.adminloginpanel.PerformLayout();
            this.userpanelpanel.ResumeLayout(false);
            this.userpanelpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomepictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox loginpictureBox;
        private Panel adminloginpanel;
        private Label adminloginlabel;
        private PictureBox welcomepictureBox;
        private TextBox passwordtextBox;
        private Button loginbutton;
        private Label passwordlabel;
        private Label exitlabel;
        private Label cancellabel;
        private Panel userpanelpanel;
        private Label exitlabel2;
        private Label adminlabel;
        private Button userloginbutton;
        private Label userpasslabel;
        private Label usernamelabel;
        private TextBox userpasswordtextBox;
        private TextBox usernametextBox;
        private PictureBox pictureBox1;
        private Label welcomelabel;
    }
}