namespace BookStore
{
    partial class Splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bookshoplabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splashprogressBar = new System.Windows.Forms.ProgressBar();
            this.progresslabel = new System.Windows.Forms.Label();
            this.percentagelabel = new System.Windows.Forms.Label();
            this.splashtimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookshoplabel
            // 
            this.bookshoplabel.AutoSize = true;
            this.bookshoplabel.Font = new System.Drawing.Font("Footlight MT Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookshoplabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bookshoplabel.Location = new System.Drawing.Point(212, 25);
            this.bookshoplabel.Name = "bookshoplabel";
            this.bookshoplabel.Size = new System.Drawing.Size(161, 24);
            this.bookshoplabel.TabIndex = 0;
            this.bookshoplabel.Text = "Hygge Bookshop";
            this.bookshoplabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookStore.Properties.Resources.Hygge_Bookstore;
            this.pictureBox1.Location = new System.Drawing.Point(212, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // splashprogressBar
            // 
            this.splashprogressBar.ForeColor = System.Drawing.Color.RosyBrown;
            this.splashprogressBar.Location = new System.Drawing.Point(152, 270);
            this.splashprogressBar.Name = "splashprogressBar";
            this.splashprogressBar.Size = new System.Drawing.Size(284, 10);
            this.splashprogressBar.TabIndex = 2;
            // 
            // progresslabel
            // 
            this.progresslabel.AutoSize = true;
            this.progresslabel.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progresslabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.progresslabel.Location = new System.Drawing.Point(258, 248);
            this.progresslabel.Name = "progresslabel";
            this.progresslabel.Size = new System.Drawing.Size(79, 19);
            this.progresslabel.TabIndex = 3;
            this.progresslabel.Text = "Loading...";
            this.progresslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // percentagelabel
            // 
            this.percentagelabel.AutoSize = true;
            this.percentagelabel.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentagelabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.percentagelabel.Location = new System.Drawing.Point(335, 248);
            this.percentagelabel.Name = "percentagelabel";
            this.percentagelabel.Size = new System.Drawing.Size(22, 19);
            this.percentagelabel.TabIndex = 4;
            this.percentagelabel.Text = "%";
            this.percentagelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splashtimer
            // 
            this.splashtimer.Tick += new System.EventHandler(this.splashtimer_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(580, 301);
            this.Controls.Add(this.percentagelabel);
            this.Controls.Add(this.progresslabel);
            this.Controls.Add(this.splashprogressBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bookshoplabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label bookshoplabel;
        private PictureBox pictureBox1;
        private ProgressBar splashprogressBar;
        private Label progresslabel;
        private Label percentagelabel;
        private System.Windows.Forms.Timer splashtimer;
    }
}