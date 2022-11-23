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
    public partial class CoffeeCategories : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hasmi\\OneDrive\\Documents\\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        public CoffeeCategories()
        {
            InitializeComponent();
        }

        private void CoffeeCategories_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void populate()
        {
            SqlCommand cmd = new SqlCommand("Select itemdescription from ItemCategoryTbl", conn);
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);               
                coffeecategoriesdataGridView.DataSource = dataTable;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        private void exitlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CoffeeShop coffeeShop = new CoffeeShop();
            coffeeShop.Show();
        }

        private void addcategorybutton_Click(object sender, EventArgs e)
        {
            if (cofCattextBox.Text == "") { MessageBox.Show("Enter category please!"); return; }
            SqlCommand cmd = new SqlCommand("Insert into ItemCategoryTbl Values('" + cofCattextBox.Text + "')", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            cofCattextBox.Text = "";
            populate();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (cofCattextBox.Text == "")
            {
                MessageBox.Show("Select a Category");
                return;
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "update ItemCategoryTbl set itemdescription='" + cofCattextBox.Text + "' where itemdescription= '" + coffeecategoriesdataGridView.SelectedCells[0].Value.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Added successfully");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
            populate();
            cofCattextBox.Clear();
        }

        private void coffeecategoriesdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cofCattextBox.Text = coffeecategoriesdataGridView.SelectedCells[0].Value.ToString();
        }
    }
}
