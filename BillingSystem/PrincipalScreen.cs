namespace BillingSystem
{
    public partial class PrincipalScreen : Form
    {
        private readonly User user;

        public PrincipalScreen(User user)
        {
            this.user = user;

            InitializeComponent();
        }

        private void PrincipalScreen_Load(object sender, EventArgs e)
        {
            if (user.Username == AdminCredentials.Username)
            {
                usersToolStripMenuItem.Enabled = true;
            }
            else
            {
                usersToolStripMenuItem.Enabled = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LabelService_Click(object sender, EventArgs e)
        {
        }

        private void LabelTotal_Click(object sender, EventArgs e)
        {
        }

        private void Subtotal_Click(object sender, EventArgs e)
        {
        }

        /*=================================== Code ==================================*/

        public void PreviewPurchase()
        {
            decimal subtotal = itemTotals.Values.Sum(); // Calculate subtotal based on item totals

            Subtotal.Text = $"${subtotal}"; // Update subtotal label

            decimal taxes = subtotal * 0.08m; // Calculate taxes
            Taxes.Text = $"${taxes}"; // Update taxes label

            decimal total = subtotal + taxes; // Calculate total before service charge
            decimal service = total * 0.10m; // Calculate service charge
            decimal grandTotal = total + service; // Calculate grand total

            if (CheckBoxService.Checked) // Check if service charge is applied
            {
                Service.Text = $"${service}"; // Update service charge label
                LabelTotal.Text = $"${grandTotal}"; // Update grand total label
            }
            else
            {
                Service.Text = ""; // Clear service charge label if not applied
                LabelTotal.Text = $"${total}"; // Update grand total label without service charge
            }
        }

        /*------------------------------- BUTTONS -----------------------------------*/

        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Reset all dynamic checkboxes
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Name.StartsWith("CheckBox"))
                {
                    checkBox.Checked = false;
                }
            }

            // Reset all textboxes
            foreach (Control control in this.Controls)
            {
                if (control is TextBoxBase textBoxBase)
                {
                    textBoxBase.Clear();
                }
            }

            // Reset subtotal, taxes, service charge, and grand total labels
            Subtotal.Text = "";
            Taxes.Text = "";
            Service.Text = "";
            LabelTotal.Text = "$00000";
            ReceiptTextBox.Text = "";
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users usersScreen = new();
            usersScreen.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            usersToolStripMenuItem.Enabled = false;
            LoginScreen loginscreen = new LoginScreen();
            loginscreen.Show();
            this.Hide();
        }

        private void ReceiptTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void CheckBoxService_CheckedChanged(object sender, EventArgs e)
        {
            PreviewPurchase();
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            ReceiptTextBox.Clear();
            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");
            string hour = DateTime.Now.ToString("hh:mm:ss");

            ReceiptTextBox.AppendText("\t\tRESTAURANT NAME" + Environment.NewLine);
            ReceiptTextBox.AppendText("\t" + "            RESTAURANT LOCATION" + Environment.NewLine);
            ReceiptTextBox.AppendText("\t" + "                     NIT: 00000000-0" + Environment.NewLine);
            ReceiptTextBox.AppendText("\t" + "                   DIR: CR 00 #00 - 00" + Environment.NewLine);
            ReceiptTextBox.AppendText("\t" + "                    TEL: 0000000 OP 0" + Environment.NewLine);
            ReceiptTextBox.AppendText(Environment.NewLine);
            ReceiptTextBox.AppendText("-----------------------------------------------------------" + Environment.NewLine);
            ReceiptTextBox.AppendText("PRINT: 1\t\t\t Cash Register No: 1" + Environment.NewLine);
            ReceiptTextBox.AppendText("SALES INVOICE #M0: \t 000000" + Environment.NewLine);
            ReceiptTextBox.AppendText("ORDER:    7" + Environment.NewLine);
            ReceiptTextBox.AppendText($"DATE:    {date}\t HOUR:    {hour}" + Environment.NewLine);
            ReceiptTextBox.AppendText($"ATTENDED BY: {this.user.Username}" + Environment.NewLine);
            ReceiptTextBox.AppendText(Environment.NewLine);
            ReceiptTextBox.AppendText("====================================" + Environment.NewLine);
            ReceiptTextBox.AppendText("CANT\tDESCRIPTION\t\tPRICE\t    TOTAL" + Environment.NewLine);

            double totalAmount = 0.0;

            foreach (KeyValuePair<int, (CheckBox, NumericUpDown)> pair in checkBoxCounterMapping)
            {
                CheckBox checkBox = pair.Value.Item1;
                NumericUpDown counter = pair.Value.Item2;

                if (checkBox.Checked)
                {
                    string productName = this.items[pair.Key].Title;
                    decimal price = this.items[pair.Key].Price;
                    decimal quantity = counter.Value;
                    decimal total = price * quantity;

                    int spacesNeeded = Math.Max(0, 30 - productName.Length);
                    string spaceBetween = new string(' ', spacesNeeded);

                    ReceiptTextBox.AppendText($"{quantity}\t{productName}{spaceBetween}\t{price:F2}\t    {total:F2}" + Environment.NewLine);
                    totalAmount += (double)total;
                }
            }

            ReceiptTextBox.AppendText("====================================" + Environment.NewLine);
            ReceiptTextBox.AppendText($"\t\t\tTOTAL:\t\t{totalAmount:F2}" + Environment.NewLine);
            ReceiptTextBox.AppendText($"\t\t\tDISC:\t\t0" + Environment.NewLine);

            if (CheckBoxService.Checked)
            {
                double serviceCharge = Math.Floor(totalAmount * 0.10);
                double grandTotal = totalAmount + serviceCharge;
                ReceiptTextBox.AppendText($"\t\t\tSERVICE:\t\t{serviceCharge:F2}" + Environment.NewLine);
                ReceiptTextBox.AppendText($"\t\t\tTOTAL:\t\t{grandTotal:F2}" + Environment.NewLine);
            }
            else
            {
                ReceiptTextBox.AppendText($"\t\t\tTOTAL:\t\t{totalAmount:F2}" + Environment.NewLine);
            }

            ReceiptTextBox.AppendText("====================================" + Environment.NewLine);

            CreateReceipt();
        }

        private void CreateReceipt()
        {
            List<ItemReceipt> receipeItems = new();

            // Check if there are any items with quantity greater than zero
            foreach (KeyValuePair<int, (CheckBox, NumericUpDown)> pair in checkBoxCounterMapping)
            {
                CheckBox checkBox = pair.Value.Item1;
                NumericUpDown counter = pair.Value.Item2;

                if (checkBox.Checked)
                {
                    decimal quantity = counter.Value;

                    if (quantity > 0)
                    {
                        ItemReceipt itemReceipt = new ItemReceipt
                        {
                            ItemId = pair.Key,
                            ReceiptId = 0, // This will be updated later
                            Quantity = (int)quantity,
                        };

                        receipeItems.Add(itemReceipt);
                    }
                }
            }

            // If there are no items with quantity greater than zero, return without creating the receipt
            if (receipeItems.Count == 0)
            {
                MessageBox.Show("No items selected for the receipt.");
                return;
            }

            // Create the receipt
            Receipt newReceipt = db.Receipt_Create(user);

            // Update the ReceiptId for each ItemReceipt
            foreach (var itemReceipt in receipeItems)
            {
                itemReceipt.ReceiptId = newReceipt.Id;
            }

            // Save the item receipts
            db.ItemReceipts_Create(receipeItems.ToArray());
        }

        private void closeCashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCashRegister closeCashRegister = new();
            closeCashRegister.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTextBox.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void toolStripPrintButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void ToolStripCopyButton_Click(object sender, EventArgs e)
        {
            ReceiptTextBox.SelectAll();
            ReceiptTextBox.Focus();
            ReceiptTextBox.Copy();
        }

        private void ToolStripCutButton_Click(object sender, EventArgs e)
        {
            ReceiptTextBox.SelectAll();
            ReceiptTextBox.Focus();
            ReceiptTextBox.Cut();
        }

        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Receipt";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    sw.WriteLine(ReceiptTextBox.Text);
            }
        }
    }
}