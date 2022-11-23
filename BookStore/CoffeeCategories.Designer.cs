namespace BookStore
{
    partial class CoffeeCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editbutton = new System.Windows.Forms.Button();
            this.coffeecategoriesdataGridView = new System.Windows.Forms.DataGridView();
            this.addcategorybutton = new System.Windows.Forms.Button();
            this.entercatlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitlabel = new System.Windows.Forms.Label();
            this.cofCattextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeecategoriesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.editbutton);
            this.panel1.Controls.Add(this.coffeecategoriesdataGridView);
            this.panel1.Controls.Add(this.addcategorybutton);
            this.panel1.Controls.Add(this.entercatlabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exitlabel);
            this.panel1.Controls.Add(this.cofCattextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 426);
            this.panel1.TabIndex = 1;
            // 
            // editbutton
            // 
            this.editbutton.BackColor = System.Drawing.Color.RosyBrown;
            this.editbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editbutton.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editbutton.Location = new System.Drawing.Point(259, 121);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(172, 34);
            this.editbutton.TabIndex = 37;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = false;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // coffeecategoriesdataGridView
            // 
            this.coffeecategoriesdataGridView.AllowUserToAddRows = false;
            this.coffeecategoriesdataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            this.coffeecategoriesdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.coffeecategoriesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.coffeecategoriesdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.coffeecategoriesdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.coffeecategoriesdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.coffeecategoriesdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.coffeecategoriesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coffeecategoriesdataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.coffeecategoriesdataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.coffeecategoriesdataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.coffeecategoriesdataGridView.Location = new System.Drawing.Point(55, 174);
            this.coffeecategoriesdataGridView.MultiSelect = false;
            this.coffeecategoriesdataGridView.Name = "coffeecategoriesdataGridView";
            this.coffeecategoriesdataGridView.ReadOnly = true;
            this.coffeecategoriesdataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.coffeecategoriesdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.coffeecategoriesdataGridView.RowHeadersVisible = false;
            this.coffeecategoriesdataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Footlight MT Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.coffeecategoriesdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.coffeecategoriesdataGridView.RowTemplate.Height = 33;
            this.coffeecategoriesdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.coffeecategoriesdataGridView.Size = new System.Drawing.Size(376, 217);
            this.coffeecategoriesdataGridView.TabIndex = 36;
            this.coffeecategoriesdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coffeecategoriesdataGridView_CellClick);
            // 
            // addcategorybutton
            // 
            this.addcategorybutton.BackColor = System.Drawing.Color.RosyBrown;
            this.addcategorybutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addcategorybutton.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addcategorybutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addcategorybutton.Location = new System.Drawing.Point(55, 121);
            this.addcategorybutton.Name = "addcategorybutton";
            this.addcategorybutton.Size = new System.Drawing.Size(198, 34);
            this.addcategorybutton.TabIndex = 20;
            this.addcategorybutton.Text = "Add";
            this.addcategorybutton.UseVisualStyleBackColor = false;
            this.addcategorybutton.Click += new System.EventHandler(this.addcategorybutton_Click);
            // 
            // entercatlabel
            // 
            this.entercatlabel.AutoSize = true;
            this.entercatlabel.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entercatlabel.Location = new System.Drawing.Point(55, 66);
            this.entercatlabel.Name = "entercatlabel";
            this.entercatlabel.Size = new System.Drawing.Size(157, 19);
            this.entercatlabel.TabIndex = 12;
            this.entercatlabel.Text = "Enter New Category";
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
            // cofCattextBox
            // 
            this.cofCattextBox.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cofCattextBox.Location = new System.Drawing.Point(55, 88);
            this.cofCattextBox.Name = "cofCattextBox";
            this.cofCattextBox.Size = new System.Drawing.Size(376, 27);
            this.cofCattextBox.TabIndex = 1;
            // 
            // CoffeeCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoffeeCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoffeeCategories";
            this.Load += new System.EventHandler(this.CoffeeCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeecategoriesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button editbutton;
        private DataGridView coffeecategoriesdataGridView;
        private Button addcategorybutton;
        private Label entercatlabel;
        private PictureBox pictureBox1;
        private Label exitlabel;
        private TextBox cofCattextBox;
    }
}