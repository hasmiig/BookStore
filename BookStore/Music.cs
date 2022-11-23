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
    public partial class Music : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hasmi\\OneDrive\\Documents\\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
       
        public Music()
        {
            InitializeComponent();
        }

        private void Music_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from MusicCategoryTbl", conn);
            DataTable categoryTable;
            DataTable filterTable;
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                categoryTable = new DataTable();
                categoryTable.Load(reader);

                categoriescomboBox.DataSource = categoryTable;
                categoriescomboBox.DisplayMember = "Mdescription";
                categoriescomboBox.ValueMember = "MCId";
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
                filtercomboBox.DisplayMember = "Mdescription";
                filtercomboBox.ValueMember = "MCID";
                filtercomboBox.SelectedIndex = -1;
                filtercomboBox.Text = "Filter";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }

            populate();
        }

        private void exitlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (AlbumtextBox.Text == "" || artisttextBox.Text == "" || quantitynumericUpDown.Value == 0 || PricetextBox.Text == "" || categoriescomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into MusicTbl " +
                        "values('" + AlbumtextBox.Text + "','" + artisttextBox.Text + "','" + categoriescomboBox.SelectedValue + "','" + quantitynumericUpDown.Value.ToString() + "','" + PricetextBox.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Album saved successfully");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
            populate();
            clear();
        }

        private void clear()
        {
            AlbumtextBox.Clear();
            artisttextBox.Clear();
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
                string query = "select m.MId as ID, m.MName as 'Album Name', m.MArt as Artist, c.Mdescription as Category, m.MQty as Quantity, m.MPrice as Price from MusicTbl m join MusicCategoryTbl c on c.MCId=m.MCat ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                musicdataGridView.DataSource = dataTable;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            musicdataGridView.ClearSelection();
        }

        private void filter()
        {
            try
            {
                conn.Open();              
                string query = "select m.MId as ID, m.MName as 'Album Name', m.MArt as Artist, c.Mdescription as Category, m.MQty as Quantity, m.MPrice as Price from MusicTbl m join MusicCategoryTbl c on c.MCId=m.MCat WHERE MCat='" + (int)(filtercomboBox.SelectedValue) + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                musicdataGridView.DataSource = dataTable;
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
        private void musicdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AlbumtextBox.Text = musicdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                artisttextBox.Text = musicdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                categoriescomboBox.Text = musicdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                categoriescomboBox.SelectedItem = musicdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                quantitynumericUpDown.Value = Convert.ToInt32(musicdataGridView.SelectedRows[0].Cells[4].Value.ToString());
                PricetextBox.Text = musicdataGridView.SelectedRows[0].Cells[5].Value.ToString();

                if (AlbumtextBox.Text == "")
                {
                    key = 0;
                }
                else { key = Convert.ToInt32(musicdataGridView.SelectedRows[0].Cells[0].Value.ToString()); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (AlbumtextBox.Text == "" || artisttextBox.Text == "" || quantitynumericUpDown.Value == 0 || PricetextBox.Text == "" || categoriescomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select Album from Table");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "delete from MusicTbl where MId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Album deleted successfully");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
            populate();
            clear();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (AlbumtextBox.Text == "" || artisttextBox.Text == "" || quantitynumericUpDown.Value == 0 || PricetextBox.Text == "" || categoriescomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select Book from Table");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "update MusicTbl set MName='" + AlbumtextBox.Text + "', MArt='" + artisttextBox.Text + "',MCat=" + categoriescomboBox.SelectedValue + ",MQty=" + quantitynumericUpDown.Value.ToString() + ",MPrice=" + PricetextBox.Text + " where MId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Album updated successfully");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
            populate();
            clear();
        }

        private void bookslabel_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void coffeelabel_Click(object sender, EventArgs e)
        {
            CoffeeShop coffeeShop=  new CoffeeShop();
            coffeeShop.Show();
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
