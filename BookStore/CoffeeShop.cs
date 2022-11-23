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
    public partial class CoffeeShop : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hasmi\\OneDrive\\Documents\\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void bookslabel_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void musiclabel_Click(object sender, EventArgs e)
        {
            Music music=new Music();
            music.Show();
            this.Hide();
        }

        private void userlabel_Click(object sender, EventArgs e)
        {
            Users users=new Users();
            users.Show();
            this.Hide();
        }

        private void Inventorylabel_Click(object sender, EventArgs e)
        {
            Inventory inventory=new Inventory();
            inventory.Show();
            this.Hide();
        }

        private void logoutlabel_Click(object sender, EventArgs e)
        {
            Login login=new Login();
            login.Show();
            this.Hide();
        }

        private void CoffeeShop_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Select * from ItemCategoryTbl", conn);
            DataTable categoryTable;
            DataTable filterTable;
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                categoryTable = new DataTable();
                categoryTable.Load(reader);

                categoriescomboBox.DataSource = categoryTable;
                categoriescomboBox.DisplayMember = "itemdescription";
                categoriescomboBox.ValueMember = "ItemCatId";
                categoriescomboBox.SelectedIndex = -1;
                categoriescomboBox.Text = "Select Category";
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                filterTable = new DataTable();
                filterTable.Load(reader);
                reader.Close();
                filtercomboBox.DataSource = filterTable;
                filtercomboBox.DisplayMember = "itemdescription";
                filtercomboBox.ValueMember = "ItemCatId";
                filtercomboBox.SelectedItem = -1;
                filtercomboBox.Text = "Filter";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }

            populate();
        }

        private void populate()
        {
            try
            {
                conn.Open();
                string query = "select co.ItemId as ID, co.ItemName as Drink, c.itemdescription as Category, co.ItemPrice as Price from CoffeeTbl co join ItemCategoryTbl c on c.ItemCatId=co.ItemCategory ;";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                coffeedataGridView.DataSource = dataTable;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            coffeedataGridView.ClearSelection();
        }

        private void exitlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (itemnametextBox.Text == "" || PricetextBox.Text == "" || categoriescomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into CoffeeTbl " +
                        "values('" + itemnametextBox.Text + "','" + PricetextBox.Text + "','" + categoriescomboBox.SelectedValue  + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item saved successfully");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
            populate();
            clear();
        }
        private void clear()
        {
            itemnametextBox.Text = "";
            PricetextBox.Text = "";
            categoriescomboBox.SelectedIndex = -1;
            categoriescomboBox.Text = "Select Category";
        }

        private void filter()
        {
            try
            {
                int a = (int)(filtercomboBox.SelectedValue);
                string query = "select co.ItemId as ID, co.ItemName as Drink, c.itemdescription as Category, co.ItemPrice as Price from CoffeeTbl co join ItemCategoryTbl c on c.ItemCatId=co.ItemCategory WHERE ItemCategory='" + a + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn); 
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                coffeedataGridView.DataSource = dataTable;
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        private void filtercomboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filter();
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            filtercomboBox.SelectedIndex = -1;
            filtercomboBox.Text = "Filter";
            populate();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            clear();
            filtercomboBox.SelectedIndex = -1;
            filtercomboBox.Text = "Filter";
        }
        
        int key = 0;
        private void coffeedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                itemnametextBox.Text = coffeedataGridView.SelectedRows[0].Cells[1].Value.ToString();              
                categoriescomboBox.Text = coffeedataGridView.SelectedRows[0].Cells[2].Value.ToString();
                
                PricetextBox.Text = coffeedataGridView.SelectedRows[0].Cells[3].Value.ToString();

                if (itemnametextBox.Text == "")
                {
                    key = 0;
                }
                else { key = Convert.ToInt32(coffeedataGridView.SelectedRows[0].Cells[0].Value.ToString()); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (itemnametextBox.Text == "" || PricetextBox.Text == "" || categoriescomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "delete from CoffeeTbl where ItemId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item deleted successfully");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
            populate();
            clear();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (itemnametextBox.Text == "" || PricetextBox.Text == "" || categoriescomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "update CoffeeTbl set ItemName='" + itemnametextBox.Text +  "', ItemCategory=" + categoriescomboBox.SelectedValue +  ", ItemPrice=" + PricetextBox.Text + " where ItemId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item updated successfully");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
            populate();
            clear();
        }

        private void addcatbutton_Click(object sender, EventArgs e)
        {
            CoffeeCategories coffeeCategories= new CoffeeCategories();
            coffeeCategories.Show();
            this.Hide();
        }
    }
}
