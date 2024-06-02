namespace BillingSystem
{
    public partial class RegisterScreen : Form
    {
        private readonly DatabaseConnector databaseConnector = new();

        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void CancelRegisterButton_Click(object sender, EventArgs e)
        {
            LoginScreen loginscreen = new();
            loginscreen.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = UserBox.Text;
            string password = PasswordBox.Text;

            if (username.Length < 3)
            {
                MessageBox.Show("The username is too short. Try another.");
            }
            else if (password.Length < 3)
            {
                MessageBox.Show("The password is too short. Try another.");
            }
            else if (this.databaseConnector.User_Exists(username) || username == AdminCredentials.Username)
            {
                MessageBox.Show("That username is taken. Try another.");
            }
            else if (username.Length >= 3 && password.Length >= 3)
            {
                bool userCreated = this.databaseConnector.User_Create(username, password);

                if (userCreated)
                {
                    MessageBox.Show("User registered successfully.");

                    LoginScreen loginscreen = new();
                    loginscreen.Show();
                    this.Close();
                } 
                else
                {
                    MessageBox.Show("Failed to register the user.");
                }
            }
            else
            {
                MessageBox.Show("Something went wrong. Try again.");
            }
        }

        private void RegisterScreen_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
