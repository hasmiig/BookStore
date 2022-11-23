using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void exitlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void userlabel_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
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
