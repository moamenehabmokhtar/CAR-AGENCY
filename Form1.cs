namespace DBProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void CarsBrandsBT_Click(object sender, EventArgs e)
        {
            carBrand1.Show();
            signIn1.Hide();
            signUp1.Hide();
        }

        private void SignInBT_Click(object sender, EventArgs e)
        {
            carBrand1.Hide();
            signIn1.Show();
            signUp1.Hide();
        }

        private void SignupBT_Click(object sender, EventArgs e)
        {
            carBrand1.Hide();
            signIn1.Hide();
            signUp1.Show();
        }

        private void signUp1_Load(object sender, EventArgs e)
        {
            
        }
    }
}