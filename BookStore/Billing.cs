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
    public partial class Billing : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hasmi\\OneDrive\\Documents\\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        double totalbooksprice = 0, subtotalbooksprice = 0;
        double totalalbumsprice = 0, subalbumsprice = 0;
        double totalcoffeeprice = 0, subcoffeeprice = 0;
        CoffeeOrder[] coffeeOrders = new CoffeeOrder[100]; int count = 0;

        public Billing()
        {
            InitializeComponent();
        }

        private void exitlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutlabel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void checkoutlabel_Click(object sender, EventArgs e)
        {
            billingtabControl.SelectedTab = checkouttabPage;
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from CategoryTbl", conn);
            DataTable filterTable;

            //Books tab page: 
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                filterTable = new DataTable();
                filterTable.Load(reader);
                reader.Close();
                filterbookcomboBox.DataSource = filterTable;
                filterbookcomboBox.DisplayMember = "description";
                filterbookcomboBox.ValueMember = "CategoryID";
                filterbookcomboBox.SelectedIndex = -1;
                filterbookcomboBox.Text = "Filter";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }

            populatebooks();

            //Music tab page:
            cmd = new SqlCommand("Select * from MusicCategoryTbl", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                filterTable = new DataTable();
                filterTable.Load(reader);
                reader.Close();
                albumcomboBox.DataSource = filterTable;
                albumcomboBox.DisplayMember = "Mdescription";
                albumcomboBox.ValueMember = "MCId";
                albumcomboBox.SelectedIndex = -1;
                albumcomboBox.Text = "Filter";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }

            populateMusic();

            //Coffee tab page:
            cmd = new SqlCommand("Select * from ItemCategoryTbl", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                filterTable = new DataTable();
                filterTable.Load(reader);
                reader.Close();
                coffeecomboBox.DataSource = filterTable;
                coffeecomboBox.DisplayMember = "itemdescription";
                coffeecomboBox.ValueMember = "ItemCatId";
                coffeecomboBox.SelectedIndex = -1;
                coffeecomboBox.Text = "Filter";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }

            populateMenu();

        }

        //book tab page:
        private void populatebooks()
        {
            try
            {
                conn.Open();
                string query = "select b.BTitle as Name, b.BAuthor as Author, c.description as Category, b.BPrice as Price from BookTbl b join CategoryTbl c on c.categoryID=b.BCat ";
                SqlCommand cmd = new SqlCommand(query, conn);
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

        //music tab page:
        private void populateMusic()
        {
            try
            {
                conn.Open();
                string query = "select m.MName as Name, m.MArt as Artist, c.Mdescription as Category, m.MPrice as Price from MusicTbl m join MusicCategoryTbl c on c.MCId=m.MCat ";
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

        //coffee tab page
        private void populateMenu()
        {
            try
            {
                conn.Open();
                string query = "select co.ItemName as Drink, co.ItemPrice as Price from CoffeeTbl co";
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

        //book tab page
        
        private void booksdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BookNametextBox.Text = booksdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                bookunitPricetextBox.Text = booksdataGridView.SelectedRows[0].Cells[3].Value.ToString();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            
        }

        //music tab page
        private void musicdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                albumnametextBox.Text = musicdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                albumunitpricetextBox.Text = musicdataGridView.SelectedRows[0].Cells[3].Value.ToString();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //book tab page
        private void resetbutton1_Click(object sender, EventArgs e)
        {
            bookcartlistView.Items.Clear();
            totalbooksprice = 0;
            subtotalbooksprice = 0;
            booktotaltextBox.Clear();
        }

        private void resetbutton2_Click(object sender, EventArgs e)
        {
            albumlistView.Items.Clear();
            totalalbumsprice = 0;
            subalbumsprice = 0;
            albumtotaltextBox.Clear();
            musicdataGridView.ClearSelection();
        }

        //book tab page:
        private void removebookbutton_Click(object sender, EventArgs e)

        {
            if (bookcartlistView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select Book from Cart");
            }
            else
            {

                subtotalbooksprice -= Convert.ToDouble(bookcartlistView.SelectedItems[0].SubItems[1].Text.ToString().Remove(0, 1));
                totalbooksprice = (int)((subtotalbooksprice * 1.1) * 100 + 0.5);
                booktotaltextBox.Text = "Subtotal: $" + subtotalbooksprice + "\r\nTotal: $" + (double)totalbooksprice / 100;
                bookcartlistView.Items.Remove(bookcartlistView.SelectedItems[0]);

            }
        }

        //album tab page:
        private void removealbumbutton_Click(object sender, EventArgs e)
        {
            if (albumlistView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select Album from Cart");
            }
            else
            {
                subalbumsprice -= Convert.ToDouble(albumlistView.SelectedItems[0].SubItems[1].Text.ToString().Remove(0, 1));
                totalalbumsprice = (int)((subalbumsprice * 1.1) * 100 + 0.5);
                albumtotaltextBox.Text = "Subtotal: $" + subalbumsprice + "\r\nTotal: $" + (double)totalalbumsprice / 100;
                albumlistView.Items.Remove(albumlistView.SelectedItems[0]);
            }
        }


        //book tab page:
        private void addbookbutton_Click(object sender, EventArgs e)
        {
            if (booksdataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an Item"); return;

            }
            if (bookqtynumericUpDown.Value == 0)
            {
                MessageBox.Show("Select Quantity");
            }
            else
            {
                subtotalbooksprice += Convert.ToDouble(bookunitPricetextBox.Text) * (double)bookqtynumericUpDown.Value;
                totalbooksprice = (int)((subtotalbooksprice * 1.1) * 100 + 0.5);
                booktotaltextBox.Text = "Subtotal: $" + subtotalbooksprice + "\r\nTotal: $" + (double)totalbooksprice / 100;
                ListViewItem item = new ListViewItem((BookNametextBox.Text));
                item.SubItems.Add(("$" + Convert.ToDouble(bookunitPricetextBox.Text) * (double)bookqtynumericUpDown.Value).ToString());
                bookcartlistView.Items.Add(item);

                booksdataGridView.ClearSelection();
                BookNametextBox.Clear();
                bookunitPricetextBox.Clear();
                bookqtynumericUpDown.Value = 0;
            }
        }

        //album tab page:
        private void addmusicbutton_Click(object sender, EventArgs e)
        {
            if (musicdataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an Item"); return;

            }
            if (albumQtynumericUpDown.Value == 0)
            {
                MessageBox.Show("Select Quantity");
            }
            else
            {
                subalbumsprice += Convert.ToDouble(albumunitpricetextBox.Text) * (double)albumQtynumericUpDown.Value;
                totalalbumsprice = (int)((subalbumsprice * 1.1) * 100 + 0.5);
                albumtotaltextBox.Text = "Subtotal: $" + subalbumsprice + "\r\nTotal: $" + (double)totalalbumsprice / 100;
                ListViewItem item = new ListViewItem((albumnametextBox.Text));
                item.SubItems.Add(("$" + Convert.ToDouble(albumunitpricetextBox.Text) * (double)albumQtynumericUpDown.Value).ToString()); ;
                albumlistView.Items.Add(item);
                musicdataGridView.ClearSelection();
                albumnametextBox.Clear();
                albumunitpricetextBox.Clear();
                albumQtynumericUpDown.Value = 0;
            }
        }

        //book tab page: 
        private void bookfilter()
        {
            try
            {
                conn.Open();
                string query = "select b.BTitle as Name, b.BAuthor as Author, c.description as Category, b.BPrice as Price from BookTbl b join CategoryTbl c on c.categoryID=b.BCat  WHERE BCat='" + Convert.ToInt32(filterbookcomboBox.SelectedValue) + "'";
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

        //album tab page:
        private void musicfilter()
        {
            try
            {
                conn.Open();
                string query = "select m.MName as Name, m.MArt as Artist, c.Mdescription as Category, m.MPrice as Price from MusicTbl m join MusicCategoryTbl c on c.MCId=m.MCat  WHERE MCat='" + Convert.ToInt32(albumcomboBox.SelectedValue) + "'";
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

        //book tab page:
        private void refreshbookbutton_Click(object sender, EventArgs e)
        {
            filterbookcomboBox.SelectedIndex = -1;
            filterbookcomboBox.Text = "Filter";
            populatebooks();
            BookNametextBox.Clear();
            bookunitPricetextBox.Clear();
        }

        //music tab page:
        private void refreshalbumsbutton_Click(object sender, EventArgs e)
        {
            albumcomboBox.SelectedIndex = -1;
            albumcomboBox.Text = "Filter";
            populateMusic();
            albumnametextBox.Clear();
            albumunitpricetextBox.Clear();
        }



        private void filterbookcomboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bookfilter();
        }



        private void albumcomboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            musicfilter();
        }





        //Coffee tab page:
        private void addcoffeebutton_Click(object sender, EventArgs e)
        {
            if (coffeedataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an Item"); return;

            }
            if (coffeenumericUpDown.Value == 0)
            {
                MessageBox.Show("Select Quantity");
            }
            else
            {
                double price = 0;
                if (regularradioButton.Checked)
                {
                    price = Convert.ToDouble(coffeedataGridView.SelectedRows[0].Cells[1].Value.ToString());
                    //order[count].Size = radioMedium.Text;
                }
                else if (largeradioButton.Checked)
                {
                    price = Convert.ToDouble(coffeedataGridView.SelectedRows[0].Cells[1].Value.ToString()) + 2;
                    //order[count].Size = radioLarge.Text;
                }

                //string add = "";
                //int i = 0;

                foreach (CheckBox top in addonsgroupBox.Controls)
                {
                    if (top.Checked)
                    {
                        price += 0.50;
                        //order[count].addToppings(top.Text);
                        //aa += order[count].Toppings[i] + "\r\n";
                        //i++;
                    }
                }

                subcoffeeprice += price * (double)coffeenumericUpDown.Value;
                totalcoffeeprice = (int)((subcoffeeprice * 1.1) * 100 + 0.5);
                coffeetotaltextBox.Text = "Subtotal: $" + subcoffeeprice + "\r\nTotal: $" + (double)totalcoffeeprice / 100;
                ListViewItem item = new ListViewItem(coffeedataGridView.SelectedRows[0].Cells[0].Value.ToString());
                item.SubItems.Add(("$" + price * (double)coffeenumericUpDown.Value).ToString()); ;
                coffeelistView.Items.Add(item);

                CoffeeClear();
            }
        }
        private void CoffeeClear()
        {
            coffeenumericUpDown.Value = 0;
            regularradioButton.Checked = true;
            foreach (CheckBox top in addonsgroupBox.Controls)
            {
                top.Checked = false;
            }
            coffeedataGridView.ClearSelection();
        }



        private void resetbutton3_Click(object sender, EventArgs e)
        {
            coffeelistView.Items.Clear();
            totalcoffeeprice = 0;
            subcoffeeprice = 0;
            coffeetotaltextBox.Clear();
        }

        

        private void removecoffeebutton_Click(object sender, EventArgs e)
        {
            if (coffeelistView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select drink from Cart");
            }
            else
            {
                subcoffeeprice -= Convert.ToDouble(coffeelistView.SelectedItems[0].SubItems[1].Text.ToString().Remove(0, 1));
                totalcoffeeprice = (int)((subcoffeeprice * 1.1) * 100 + 0.5);
                coffeetotaltextBox.Text = "Subtotal: $" + subcoffeeprice + "\r\nTotal: $" + (double)totalcoffeeprice / 100;
                coffeelistView.Items.Remove(coffeelistView.SelectedItems[0]);

            }
        }

        private void menufilter()
        {
            try
            {
                conn.Open();
                string query = " select co.ItemName as Drink, co.ItemPrice as Price from CoffeeTbl co WHERE ItemCategory='" + Convert.ToInt32(coffeecomboBox.SelectedValue) + "'";
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
        private void coffeecomboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            menufilter();
        }

        private void refreshmenubutton_Click(object sender, EventArgs e)
        {
            coffeecomboBox.SelectedIndex = -1;
            coffeecomboBox.Text = "Filter";
            populateMenu();
            CoffeeClear();
        }

    }
}
