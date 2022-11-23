namespace BookStore
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int start = 0;
        private void splashtimer_Tick(object sender, EventArgs e)
        {
            start += 1;
            splashprogressBar.Value = start;
            percentagelabel.Text = start + "%";
            if (splashprogressBar.Value == 100)
            {
                splashprogressBar.Value = 0;
                splashtimer.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            splashtimer.Start();
        }
    }
}