namespace BookStore
{
    partial class BookCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editbutton = new System.Windows.Forms.Button();
            this.bookscategoriesdataGridView = new System.Windows.Forms.DataGridView();
            this.addcategorybutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitlabel = new System.Windows.Forms.Label();
            this.bookCattextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookscategoriesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.editbutton);
            this.panel1.Controls.Add(this.bookscategoriesdataGridView);
            this.panel1.Controls.Add(this.addcategorybutton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exitlabel);
            this.panel1.Controls.Add(this.bookCattextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 426);
            this.panel1.TabIndex = 0;
            // 
            // editbutton
            // 
            this.editbutton.BackColor = System.Drawing.Color.RosyBrown;
            this.editbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editbutton.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editbutton.Location = new System.Drawing.Point(249, 121);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(182, 34);
            this.editbutton.TabIndex = 37;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = false;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // bookscategoriesdataGridView
            // 
            this.bookscategoriesdataGridView.AllowUserToAddRows = false;
            this.bookscategoriesdataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RosyBrown;
            this.bookscategoriesdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.bookscategoriesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookscategoriesdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.bookscategoriesdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.bookscategoriesdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookscategoriesdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.bookscategoriesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookscategoriesdataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookscategoriesdataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.bookscategoriesdataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.bookscategoriesdataGridView.Location = new System.Drawing.Point(55, 174);
            this.bookscategoriesdataGridView.MultiSelect = false;
            this.bookscategoriesdataGridView.Name = "bookscategoriesdataGridView";
            this.bookscategoriesdataGridView.ReadOnly = true;
            this.bookscategoriesdataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookscategoriesdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.bookscategoriesdataGridView.RowHeadersVisible = false;
            this.bookscategoriesdataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Footlight MT Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookscategoriesdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.bookscategoriesdataGridView.RowTemplate.Height = 33;
            this.bookscategoriesdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.bookscategoriesdataGridView.Size = new System.Drawing.Size(376, 217);
            this.bookscategoriesdataGridView.TabIndex = 36;
            this.bookscategoriesdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookcategoriesdataGridView_CellClick);
            // 
            // addcategorybutton
            // 
            this.addcategorybutton.BackColor = System.Drawing.Color.RosyBrown;
            this.addcategorybutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addcategorybutton.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addcategorybutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addcategorybutton.Location = new System.Drawing.Point(55, 121);
            this.addcategorybutton.Name = "addcategorybutton";
            this.addcategorybutton.Size = new System.Drawing.Size(157, 34);
            this.addcategorybutton.TabIndex = 20;
            this.addcategorybutton.Text = "Add";
            this.addcategorybutton.UseVisualStyleBackColor = false;
            this.addcategorybutton.Click += new System.EventHandler(this.addcategorybutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter New Category";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookStore.Properties.Resources.Back;
            this.pictureBox1.Location = new System.Drawing.Point(426, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // exitlabel
            // 
            this.exitlabel.AutoSize = true;
            this.exitlabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitlabel.ForeColor = System.Drawing.Color.DimGray;
            this.exitlabel.Location = new System.Drawing.Point(454, 1);
            this.exitlabel.Name = "exitlabel";
            this.exitlabel.Size = new System.Drawing.Size(30, 35);
            this.exitlabel.TabIndex = 10;
            this.exitlabel.Text = "X";
            this.exitlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitlabel.Click += new System.EventHandler(this.exitlabel_Click);
            // 
            // bookCattextBox
            // 
            this.bookCattextBox.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookCattextBox.Location = new System.Drawing.Point(55, 88);
            this.bookCattextBox.Name = "bookCattextBox";
            this.bookCattextBox.Size = new System.Drawing.Size(376, 27);
            this.bookCattextBox.TabIndex = 1;
            // 
            // BookCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookCategories";
            this.Load += new System.EventHandler(this.BookCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookscategoriesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox bookCattextBox;
        private PictureBox pictureBox1;
        private Label exitlabel;
        private Label label1;
        private Button addcategorybutton;
        private DataGridView bookscategoriesdataGridView;
        private Button editbutton;
    }
}