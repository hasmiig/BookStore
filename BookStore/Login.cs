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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exitlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminlabel_Click(object sender, EventArgs e)
        {
            adminloginpanel.Visible = true;
            userpanelpanel.Visible = false;
        }

        private void cancellabel_Click(object sender, EventArgs e)
        {
            adminloginpanel.Visible = false;
            userpanelpanel.Visible = true;
        }

        private void exitlabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userloginbutton_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
            this.Hide();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Admin admin=new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
