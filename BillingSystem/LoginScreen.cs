namespace BillingSystem
{
    public partial class LoginScreen : Form
    {
        readonly DatabaseConnector db = new();

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            string username = UserBox.Text;
            string password = PasswordBox.Text;

            // Authenticate user using database
            User? user = db.User_Authenticate(username, password);

            if (user != null)
            {
                this.ResetAndClose();
                PrincipalScreen principalScreen = new(user);
                principalScreen.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password. Try again.");
                this.ResetFields();
                UserBox.Focus();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool RegisterUser(string username, string password)
        {
            bool userCreated = this.db.User_Create(username, password);

            if (userCreated)
            {
                MessageBox.Show("User registered successfully!");
            }
            else
            {
                MessageBox.Show("User already exists.");
            }

            return userCreated;
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ResetAndClose();
            RegisterScreen registerScreen = new RegisterScreen();
            registerScreen.ShowDialog();
        }

        private void ResetFields()
        {
            UserBox.Clear();
            PasswordBox.Clear();
        }

        private void ResetAndClose()
        {
            this.ResetFields();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            this.ActiveControl = UserBox;
        }
    }
}