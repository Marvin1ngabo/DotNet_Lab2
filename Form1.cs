namespace App2
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            bool hasNumber = false;

            foreach (char c in txtuser.Text)
            {
                if (char.IsDigit(c))
                {
                    hasNumber = true;
                }
            }

            if (txtuser.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Please fill in the username and password");
            }
            else if (hasNumber == true)
            {
                MessageBox.Show("The username must not contain numbers");
            }
            else
            {
                Form_choose choose = new Form_choose();
                choose.Show();
                this.Hide();
            }
        }
    }
}
