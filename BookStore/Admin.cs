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
    public partial class Admin : Form
    {

        SqlConnection conn=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hasmi\\OneDrive\\Documents\\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Admin()
        {
            InitializeComponent();
            
        }

        private void exitlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (bookTitletextBox.Text == "" || authortextBox.Text == "" || quantitynumericUpDown.Value == 0 || PricetextBox.Text == "" || categoriescomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into BookTbl " +
                        "values('" + bookTitletextBox.Text + "','" + authortextBox.Text + "','" + categoriescomboBox.SelectedValue + "','" + quantitynumericUpDown.Value.ToString() + "','" + PricetextBox.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book saved successfully");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
            populate();
            clear();
        }

        private void clear()
        {
            bookTitletextBox.Clear();
            authortextBox.Clear();
            quantitynumericUpDown.Value = 0;
            categoriescomboBox.SelectedIndex = -1;
            categoriescomboBox.Text = "Select Category";
            PricetextBox.Clear();
        }

        private void populate()
        {
            try
            {
                conn.Open();
                /*string query = "select * from Booktbl";
                SqlDataAdapter sda=new SqlDataAdapter(query,conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                booksdataGridView.DataSource = ds.Tables[0];
                */
                string query = "select b.BId as ID, b.BTitle as Name, b.BAuthor as Author, c.description as Category, b.BQty as Quantity, b.BPrice as Price from BookTbl b join CategoryTbl c on c.categoryID=b.BCat ";
                SqlCommand cmd= new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                booksdataGridView.DataSource = dataTable;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            booksdataGridView.ClearSelection();
        }

        private void filter()
        {
            try
            {
                conn.Open();
                /*string query = "select * from Booktbl where BCat = '"+(int)(filtercomboBox.SelectedValue)+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                booksdataGridView.DataSource = ds.Tables[0];
                */

                string query = "select b.BId as ID, b.BTitle as Name, b.BAuthor as Author, c.description as Category, b.BQty as Quantity, b.BPrice as Price from BookTbl b join CategoryTbl c on c.categoryID=b.BCat WHERE BCat='"+Convert.ToInt32(filtercomboBox.SelectedValue)+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                booksdataGridView.DataSource = dataTable;
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
        private void booksdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bookTitletextBox.Text = booksdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                authortextBox.Text = booksdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                categoriescomboBox.Text = booksdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                categoriescomboBox.SelectedItem = booksdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                quantitynumericUpDown.Value = Convert.ToInt32(booksdataGridView.SelectedRows[0].Cells[4].Value.ToString());
                PricetextBox.Text = booksdataGridView.SelectedRows[0].Cells[5].Value.ToString();
                
                if (bookTitletextBox.Text == "")
                {
                    key = 0;
                }
                else { key = Convert.ToInt32(booksdataGridView.SelectedRows[0].Cells[0].Value.ToString()); }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (bookTitletextBox.Text == "" || authortextBox.Text == "" || quantitynumericUpDown.Value == 0 || PricetextBox.Text == "" || categoriescomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select Book from Table");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "delete from BookTbl where BId="+key+";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book deleted successfully");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
            populate();
            clear();
        }

       

        private void Admin_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from CategoryTbl",conn);
            DataTable categoryTable;
            DataTable filterTable;
            try
            {
                conn.Open();
                SqlDataReader reader=cmd.ExecuteReader();
                categoryTable=new DataTable();
                categoryTable.Load(reader);
                
                categoriescomboBox.DataSource=categoryTable;
                categoriescomboBox.DisplayMember = "description";
                categoriescomboBox.ValueMember = "CategoryID";
                categoriescomboBox.SelectedIndex = -1;
                categoriescomboBox.Text = "Select Category";
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close();}

            try
            {
                conn.Open();
                SqlDataReader reader =cmd.ExecuteReader();
                filterTable = new DataTable();
                filterTable.Load(reader);
                reader.Close();
                filtercomboBox.DataSource = filterTable;
                filtercomboBox.DisplayMember = "description";
                filtercomboBox.ValueMember = "CategoryID";
                filtercomboBox.SelectedIndex = -1;
                filtercomboBox.Text = "Filter";
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close();}
                
            populate();
        }

       

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (bookTitletextBox.Text == "" || authortextBox.Text == "" || quantitynumericUpDown.Value == 0 || PricetextBox.Text == "" || categoriescomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select Book from Table");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "update BookTbl set BTitle='" + bookTitletextBox.Text + "', BAuthor='" + authortextBox.Text + "',BCat=" + categoriescomboBox.SelectedValue + ",BQty=" + quantitynumericUpDown.Value.ToString() + ",BPrice=" + PricetextBox.Text + " where BId="+key+";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book updated successfully");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
            populate();
            clear();
        }

        private void addcatbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookCategories bookCategories=new BookCategories();
            bookCategories.Show();
        }

        private void coffeelabel_Click(object sender, EventArgs e)
        {
            CoffeeShop coffeeShop = new CoffeeShop();
            coffeeShop.Show();
            this.Hide();
        }

        private void musiclabel_Click(object sender, EventArgs e)
        {
            Music music = new Music();
            music.Show();
            this.Hide();
        }

        private void userlabel_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();
        }

        private void Inventorylabel_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Hide();
        }

        private void logoutlabel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
