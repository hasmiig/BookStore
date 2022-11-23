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
    public partial class Users : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hasmi\\OneDrive\\Documents\\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Users()
        {
            InitializeComponent();
        }

        private void exitAdminlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (nameofusertextBox.Text == "" || phonetextBox.Text == "" ||  passwordtextBox.Text == "" || addresstextBox.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into UserTbl values('" + nameofusertextBox.Text + "','" + phonetextBox.Text + "','" + addresstextBox.Text + "','"+ passwordtextBox.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User saved successfully");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
            populate();
            clear();
        }
        private void clear()
        {
            nameofusertextBox.Text = "";
            phonetextBox.Text = "";
            passwordtextBox.Text = "";
            addresstextBox.Text = "";
        }
        private void populate()
        {
            try
            {
                /*
                string query = "select * from Usertbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                usersdataGridView.DataSource = ds.Tables[0];
                */
                conn.Open();
                string query = "select u.UId as ID, u.UName as Name, u.UPhone as 'Phone Number', u.UAdd as Address, u.UPass as Passowrd from UserTbl u";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                usersdataGridView.DataSource = dataTable;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            usersdataGridView.ClearSelection();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            clear();
        }


        int key = 0;
        private void usersdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                nameofusertextBox.Text = usersdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                phonetextBox.Text = usersdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                addresstextBox.Text = usersdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                passwordtextBox.Text = usersdataGridView.SelectedRows[0].Cells[4].Value.ToString();
                

                if (nameofusertextBox.Text == "")
                {
                    key = 0;
                }
                else { key = Convert.ToInt32(usersdataGridView.SelectedRows[0].Cells[0].Value.ToString()); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select User from Table");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "delete from UserTbl where UId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User deleted successfully");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
            populate();
            clear();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (nameofusertextBox.Text == "" || phonetextBox.Text == "" || passwordtextBox.Text == "" || addresstextBox.Text == "")
                MessageBox.Show("Select User from Table");
            
            else
            {
                try
                {
                    conn.Open();
                    string query = "update UserTbl set UName='" + nameofusertextBox.Text + "',UPhone='" + phonetextBox.Text + "',UAdd='" + addresstextBox.Text + "',UPass=" + passwordtextBox.Text +  " where UId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully");
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
