namespace BillingSystem
{
    public partial class Users : Form
    {
        private readonly DatabaseConnector connector = new();

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // Fetch users from the database
            List<User> users = this.connector.User_List();

            // Clear existing rows
            dgvAdmin.Rows.Clear();

            // Loop through the users and add them to the DataGridView
            for (int i = 0; i < users.Count; i++)
            {
                dgvAdmin.Rows.Add();
                dgvAdmin.Rows[i].Cells[0].Value = users[i].Id; // Assuming the first column is for user ID
                dgvAdmin.Rows[i].Cells[1].Value = users[i].Username; // Assuming the second column is for username
                dgvAdmin.Rows[i].Cells[2].Value = users[i].Password; // Assuming the third column is for password
            }
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackUsersButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
