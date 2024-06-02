using System.Data;

namespace BillingSystem
{
    public partial class CloseCashRegister : Form
    {
        private readonly DatabaseConnector db = new();
        private List<Receipt> receipts = new();

        public CloseCashRegister()
        {
            InitializeComponent();
            LoadReceipts();
        }

        private void LoadReceipts()
        {
            receipts = db.Receipt_List();

            if (receipts == null || receipts.Count == 0)
            {
                MessageBox.Show("No receipts found.");
                return;
            }

            // Clear existing items and columns
            lvwCerrar.Items.Clear();
            lvwCerrar.Columns.Clear();

            // Get unique item names for columns
            var itemNames = receipts
                .SelectMany(r => r.ItemReceipts)
                .Select(ir => ir.Item.Title)
                .Distinct()
                .ToList();

            // Add columns dynamically
            lvwCerrar.Columns.Add("ID", 100);
            lvwCerrar.Columns.Add("User", 100);
            foreach (var itemName in itemNames)
            {
                lvwCerrar.Columns.Add(itemName, 100);
            }

            // Add rows
            foreach (var receipt in receipts)
            {
                ListViewItem listViewItem = new ListViewItem(receipt.Id.ToString());
                listViewItem.SubItems.Add(receipt.User.Username);

                foreach (var itemName in itemNames)
                {
                    var itemReceipt = receipt.ItemReceipts.FirstOrDefault(ir => ir.Item.Title == itemName);
                    listViewItem.SubItems.Add(itemReceipt?.Quantity.ToString() ?? "0");
                }

                lvwCerrar.Items.Add(listViewItem);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Add your back button logic here
        }

        private void RecordRegisterButton_Click(object sender, EventArgs e)
        {
            // Add your record register button logic here
        }

        private void CloseCashRegister_Load(object sender, EventArgs e)
        {
            // Add your form load logic here
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (receipts.Count != 0)
                {
                    string registersDirectory = Path.Combine(Application.StartupPath, "Registers");

                    // Create the directory if it doesn't exist
                    Directory.CreateDirectory(registersDirectory);

                    string fileName = $"caja_{DateTime.Now.ToString("dd.mm.yyyy_HH.mm.ss")}.txt";
                    string filePath = Path.Combine(registersDirectory, fileName);

                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.Write("Today were sold:" + Environment.NewLine);
                        foreach (ColumnHeader column in lvwCerrar.Columns)
                        {
                            sw.Write(column.Text + "\t");
                        }
                        sw.WriteLine();

                        foreach (ListViewItem item in lvwCerrar.Items)
                        {
                            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                            {
                                sw.Write(subItem.Text + "\t");
                            }
                            sw.WriteLine();
                        }

                        // Calculate total from receipts
                        double totalItems = receipts.Sum(r => r.ItemReceipts.Sum(ir => ir.Quantity));
                        decimal totalSold = receipts.Sum(r => r.ItemReceipts.Sum(ir => ir.Quantity * ir.Item.Price));

                        sw.WriteLine($"Total items sold: {totalItems}" + Environment.NewLine);
                        sw.WriteLine($"Total money earned: ${totalSold}" + Environment.NewLine);
                    }

                    MessageBox.Show("Register recorded.");

                    db.Receipts_Delete();

                    Close();
                }
                else
                {
                    MessageBox.Show("Empty list.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
