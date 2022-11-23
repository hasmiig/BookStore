using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookStore
{
    public partial class BookCategories : Form
    {

        SqlConnection conn=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hasmi\\OneDrive\\Documents\\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        public BookCategories()
        {
            InitializeComponent();
        }

        private void BookCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            SqlCommand cmd = new SqlCommand("Select description from CategoryTbl", conn);
            DataTable dataTable=new DataTable();

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                bookscategoriesdataGridView.DataSource = dataTable;
          
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }
        private void exitlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void addcategorybutton_Click(object sender, EventArgs e)
        {
            if (bookCattextBox.Text == "") { MessageBox.Show("Enter category please!"); return; }
            SqlCommand cmd=new SqlCommand("Insert into CategoryTbl Values('"+bookCattextBox.Text+"')", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();        
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            bookCattextBox.Text = "";
            populate();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (bookCattextBox.Text == "") 
            { 
                MessageBox.Show("Select a Category");
                return;
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "update CategoryTbl set description='" + bookCattextBox.Text +"' where description= '" + bookscategoriesdataGridView.SelectedCells[0].Value.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Added successfully");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
            populate();
            bookCattextBox.Clear();
        }

        private void bookcategoriesdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookCattextBox.Text = bookscategoriesdataGridView.SelectedCells[0].Value.ToString();
        }

    }
}
