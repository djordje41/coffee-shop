using BillingSystem.Properties;
using System.Windows.Forms;

namespace BillingSystem
{
    partial class PrincipalScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private readonly DatabaseConnector db = new();

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalScreen));
            panel1 = new Panel();
            CheckBoxService = new CheckBox();
            LabelTaxes = new Label();
            label7 = new Label();
            Subtotal = new Label();
            Taxes = new Label();
            LabelService = new Label();
            Service = new Label();
            ExitButton = new Button();
            panel2 = new Panel();
            LabelTotalString = new Label();
            LabelTotal = new Label();
            ResetButton = new Button();
            ReceiptButton = new Button();
            panel4 = new Panel();
            ToolStrip = new ToolStrip();
            ToolStripCopyButton = new ToolStripButton();
            ToolStripCutButton = new ToolStripButton();
            toolStripSaveButton = new ToolStripButton();
            toolStripPrintButton = new ToolStripButton();
            ReceiptTextBox = new RichTextBox();
            LabelRestaurantName = new Label();
            UsersControl = new ToolStripMenuItem();
            UsersControlView = new ToolStripMenuItem();
            RegisterControls = new ToolStripMenuItem();
            RegisterControlsClose = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            controlsToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            registersToolStripMenuItem = new ToolStripMenuItem();
            closeCashRegisterToolStripMenuItem = new ToolStripMenuItem();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ToolStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(219, 219, 219);
            panel1.Controls.Add(CheckBoxService);
            panel1.Controls.Add(LabelTaxes);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Subtotal);
            panel1.Controls.Add(Taxes);
            panel1.Controls.Add(LabelService);
            panel1.Controls.Add(Service);
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ResetButton);
            panel1.Controls.Add(ReceiptButton);
            panel1.Location = new Point(0, 536);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 125);
            panel1.TabIndex = 0;
            // 
            // CheckBoxService
            // 
            CheckBoxService.AutoSize = true;
            CheckBoxService.Location = new Point(669, 98);
            CheckBoxService.Name = "CheckBoxService";
            CheckBoxService.Size = new Size(15, 14);
            CheckBoxService.TabIndex = 1;
            CheckBoxService.UseVisualStyleBackColor = true;
            CheckBoxService.CheckedChanged += CheckBoxService_CheckedChanged;
            // 
            // LabelTaxes
            // 
            LabelTaxes.AutoSize = true;
            LabelTaxes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTaxes.ForeColor = Color.FromArgb(12, 142, 112);
            LabelTaxes.Location = new Point(666, 52);
            LabelTaxes.Name = "LabelTaxes";
            LabelTaxes.Size = new Size(55, 20);
            LabelTaxes.TabIndex = 32;
            LabelTaxes.Text = "Porez";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(12, 142, 112);
            label7.Location = new Point(666, 15);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 31;
            label7.Text = "Ukupno";
            // 
            // Subtotal
            // 
            Subtotal.BackColor = Color.White;
            Subtotal.BorderStyle = BorderStyle.FixedSingle;
            Subtotal.Location = new Point(767, 10);
            Subtotal.Name = "Subtotal";
            Subtotal.Padding = new Padding(5, 0, 0, 0);
            Subtotal.Size = new Size(194, 32);
            Subtotal.TabIndex = 29;
            Subtotal.Text = " ";
            Subtotal.TextAlign = ContentAlignment.MiddleLeft;
            Subtotal.Click += Subtotal_Click;
            // 
            // Taxes
            // 
            Taxes.BackColor = Color.White;
            Taxes.BorderStyle = BorderStyle.FixedSingle;
            Taxes.Location = new Point(767, 49);
            Taxes.Name = "Taxes";
            Taxes.Padding = new Padding(5, 0, 0, 0);
            Taxes.Size = new Size(194, 32);
            Taxes.TabIndex = 28;
            Taxes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelService
            // 
            LabelService.AutoSize = true;
            LabelService.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelService.ForeColor = Color.FromArgb(12, 142, 112);
            LabelService.Location = new Point(669, 93);
            LabelService.Name = "LabelService";
            LabelService.Size = new Size(80, 20);
            LabelService.TabIndex = 26;
            LabelService.Text = "   Usluga";
            // 
            // Service
            // 
            Service.BackColor = Color.White;
            Service.BorderStyle = BorderStyle.FixedSingle;
            Service.Location = new Point(767, 88);
            Service.Name = "Service";
            Service.Padding = new Padding(5, 0, 0, 0);
            Service.Size = new Size(194, 32);
            Service.TabIndex = 25;
            Service.TextAlign = ContentAlignment.MiddleLeft;
            Service.Click += LabelService_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(12, 142, 112);
            ExitButton.CausesValidation = false;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(458, 13);
            ExitButton.Margin = new Padding(0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(184, 100);
            ExitButton.TabIndex = 24;
            ExitButton.TabStop = false;
            ExitButton.Text = "Izlaz";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel2.BackColor = Color.FromArgb(12, 142, 112);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(LabelTotalString);
            panel2.Controls.Add(LabelTotal);
            panel2.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(28, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 100);
            panel2.TabIndex = 20;
            panel2.Paint += panel2_Paint;
            // 
            // LabelTotalString
            // 
            LabelTotalString.BackColor = Color.White;
            LabelTotalString.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTotalString.ForeColor = Color.FromArgb(12, 142, 112);
            LabelTotalString.Location = new Point(0, 74);
            LabelTotalString.Name = "LabelTotalString";
            LabelTotalString.Size = new Size(208, 25);
            LabelTotalString.TabIndex = 20;
            LabelTotalString.Text = "UKUPNO";
            LabelTotalString.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelTotal
            // 
            LabelTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LabelTotal.AutoSize = true;
            LabelTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTotal.ForeColor = Color.White;
            LabelTotal.Location = new Point(64, 30);
            LabelTotal.Margin = new Padding(0);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(112, 20);
            LabelTotal.TabIndex = 19;
            LabelTotal.Text = "0000.00RSD";
            LabelTotal.TextAlign = ContentAlignment.MiddleCenter;
            LabelTotal.Click += LabelTotal_Click;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.FromArgb(12, 142, 112);
            ResetButton.Cursor = Cursors.Hand;
            ResetButton.FlatStyle = FlatStyle.Popup;
            ResetButton.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            ResetButton.ForeColor = Color.White;
            ResetButton.Location = new Point(265, 65);
            ResetButton.Margin = new Padding(0);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(164, 48);
            ResetButton.TabIndex = 16;
            ResetButton.TabStop = false;
            ResetButton.Text = "Resetuj";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // ReceiptButton
            // 
            ReceiptButton.BackColor = Color.FromArgb(12, 142, 112);
            ReceiptButton.Cursor = Cursors.Hand;
            ReceiptButton.FlatStyle = FlatStyle.Popup;
            ReceiptButton.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            ReceiptButton.ForeColor = Color.White;
            ReceiptButton.Location = new Point(265, 13);
            ReceiptButton.Margin = new Padding(0);
            ReceiptButton.Name = "ReceiptButton";
            ReceiptButton.Size = new Size(164, 48);
            ReceiptButton.TabIndex = 15;
            ReceiptButton.TabStop = false;
            ReceiptButton.Text = "Račun";
            ReceiptButton.UseVisualStyleBackColor = false;
            ReceiptButton.Click += ReceiptButton_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(219, 219, 219);
            panel4.CausesValidation = false;
            panel4.Controls.Add(ToolStrip);
            panel4.Controls.Add(ReceiptTextBox);
            panel4.Location = new Point(666, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(318, 537);
            panel4.TabIndex = 2;
            // 
            // ToolStrip
            // 
            ToolStrip.AutoSize = false;
            ToolStrip.BackColor = SystemColors.Control;
            ToolStrip.Dock = DockStyle.None;
            ToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            ToolStrip.Items.AddRange(new ToolStripItem[] { ToolStripCopyButton, ToolStripCutButton, toolStripSaveButton, toolStripPrintButton });
            ToolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            ToolStrip.Location = new Point(0, 1);
            ToolStrip.Margin = new Padding(3);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(318, 46);
            ToolStrip.TabIndex = 6;
            ToolStrip.Text = "toolStrip1";
            // 
            // ToolStripCopyButton
            // 
            ToolStripCopyButton.AutoSize = false;
            ToolStripCopyButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripCopyButton.Image = (Image)resources.GetObject("ToolStripCopyButton.Image");
            ToolStripCopyButton.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripCopyButton.ImageTransparentColor = Color.Magenta;
            ToolStripCopyButton.Margin = new Padding(68, 1, 0, 2);
            ToolStripCopyButton.Name = "ToolStripCopyButton";
            ToolStripCopyButton.Size = new Size(33, 33);
            ToolStripCopyButton.Text = "toolStripButton1";
            ToolStripCopyButton.ToolTipText = "Copy";
            ToolStripCopyButton.Click += ToolStripCopyButton_Click;
            // 
            // ToolStripCutButton
            // 
            ToolStripCutButton.AutoSize = false;
            ToolStripCutButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripCutButton.Image = (Image)resources.GetObject("ToolStripCutButton.Image");
            ToolStripCutButton.ImageScaling = ToolStripItemImageScaling.None;
            ToolStripCutButton.ImageTransparentColor = Color.Magenta;
            ToolStripCutButton.Margin = new Padding(10, 1, 0, 2);
            ToolStripCutButton.Name = "ToolStripCutButton";
            ToolStripCutButton.Size = new Size(33, 33);
            ToolStripCutButton.Text = "toolStripButton1";
            ToolStripCutButton.ToolTipText = "Cut";
            ToolStripCutButton.Click += ToolStripCutButton_Click;
            // 
            // toolStripSaveButton
            // 
            toolStripSaveButton.AutoSize = false;
            toolStripSaveButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSaveButton.Image = (Image)resources.GetObject("toolStripSaveButton.Image");
            toolStripSaveButton.ImageScaling = ToolStripItemImageScaling.None;
            toolStripSaveButton.ImageTransparentColor = Color.Magenta;
            toolStripSaveButton.Margin = new Padding(10, 1, 0, 2);
            toolStripSaveButton.Name = "toolStripSaveButton";
            toolStripSaveButton.Size = new Size(33, 33);
            toolStripSaveButton.Text = "toolStripButton2";
            toolStripSaveButton.ToolTipText = "Save";
            toolStripSaveButton.Click += toolStripSaveButton_Click;
            // 
            // toolStripPrintButton
            // 
            toolStripPrintButton.AutoSize = false;
            toolStripPrintButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripPrintButton.Image = (Image)resources.GetObject("toolStripPrintButton.Image");
            toolStripPrintButton.ImageScaling = ToolStripItemImageScaling.None;
            toolStripPrintButton.ImageTransparentColor = Color.Magenta;
            toolStripPrintButton.Margin = new Padding(10, 1, 0, 2);
            toolStripPrintButton.Name = "toolStripPrintButton";
            toolStripPrintButton.Padding = new Padding(10, 0, 0, 0);
            toolStripPrintButton.Size = new Size(33, 33);
            toolStripPrintButton.Text = "toolStripButton1";
            toolStripPrintButton.ToolTipText = "Print";
            toolStripPrintButton.Click += toolStripPrintButton_Click;
            // 
            // ReceiptTextBox
            // 
            ReceiptTextBox.AccessibleDescription = "Copy";
            ReceiptTextBox.AccessibleName = "Copy";
            ReceiptTextBox.BorderStyle = BorderStyle.FixedSingle;
            ReceiptTextBox.Cursor = Cursors.IBeam;
            ReceiptTextBox.Location = new Point(0, 47);
            ReceiptTextBox.Margin = new Padding(0);
            ReceiptTextBox.Name = "ReceiptTextBox";
            ReceiptTextBox.Size = new Size(318, 492);
            ReceiptTextBox.TabIndex = 0;
            ReceiptTextBox.Text = "";
            ReceiptTextBox.TextChanged += ReceiptTextBox_TextChanged;
            // 
            // LabelRestaurantName
            // 
            LabelRestaurantName.Location = new Point(0, 0);
            LabelRestaurantName.Name = "LabelRestaurantName";
            LabelRestaurantName.Size = new Size(100, 23);
            LabelRestaurantName.TabIndex = 0;
            // 
            // UsersControl
            // 
            UsersControl.Name = "UsersControl";
            UsersControl.Size = new Size(32, 19);
            // 
            // UsersControlView
            // 
            UsersControlView.Name = "UsersControlView";
            UsersControlView.Size = new Size(32, 19);
            // 
            // RegisterControls
            // 
            RegisterControls.Name = "RegisterControls";
            RegisterControls.Size = new Size(32, 19);
            // 
            // RegisterControlsClose
            // 
            RegisterControlsClose.Name = "RegisterControlsClose";
            RegisterControlsClose.Size = new Size(32, 19);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Items.AddRange(new ToolStripItem[] { controlsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 50;
            menuStrip1.Text = "menuStrip1";
            // 
            // controlsToolStripMenuItem
            // 
            controlsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem, registersToolStripMenuItem });
            controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            controlsToolStripMenuItem.Size = new Size(53, 20);
            controlsToolStripMenuItem.Text = "Opcije";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(180, 22);
            usersToolStripMenuItem.Text = "Korisnici";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(180, 22);
            viewToolStripMenuItem.Text = "Pregled";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // registersToolStripMenuItem
            // 
            registersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeCashRegisterToolStripMenuItem });
            registersToolStripMenuItem.Name = "registersToolStripMenuItem";
            registersToolStripMenuItem.Size = new Size(180, 22);
            registersToolStripMenuItem.Text = "Registri";
            // 
            // closeCashRegisterToolStripMenuItem
            // 
            closeCashRegisterToolStripMenuItem.Name = "closeCashRegisterToolStripMenuItem";
            closeCashRegisterToolStripMenuItem.Size = new Size(193, 22);
            closeCashRegisterToolStripMenuItem.Text = "Sačuvaj kasu u registar";
            closeCashRegisterToolStripMenuItem.Click += closeCashRegisterToolStripMenuItem_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // PrincipalScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 244);
            ClientSize = new Size(984, 661);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(1000, 700);
            Name = "PrincipalScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kasa";
            Load += PrincipalScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
            
            LoadItems();
        }

        private Dictionary<int, (CheckBox, NumericUpDown)> checkBoxCounterMapping = new Dictionary<int, (CheckBox, NumericUpDown)>();
        private Dictionary<int, Item> items = new Dictionary<int, Item>(); // assuming you have a way to get the price
        private Dictionary<int, decimal> itemTotals = new Dictionary<int, decimal>();

        private void LoadItems()
        {
            // Retrieve all items from the database
            List<Item> items = this.db.Item_List();

            // Define initial positions for dynamic controls
            int initialX = 47;
            int initialY = 80;
            int imageSize = 130;
            int spacingX = 98;
            int spacingY = 18;
            int labelOffsetY = 0; // Set label offset to 0 to overlap with the image
            int columnCount = 3; // Number of items per row

            for (int i = 0; i < items.Count; i++)
            {
                Item item = items[i];

                // Calculate positions
                int currentX = initialX + (i % columnCount) * (imageSize + spacingX);
                int currentY = initialY + (i / columnCount) * (imageSize + spacingY);

                // Create PictureBox
                PictureBox pictureBox = new PictureBox
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    ImageLocation = item.Image, // Use ImageLocation for path
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(currentX, currentY),
                    Size = new Size(imageSize, imageSize),
                    Name = $"pictureBox{i}",
                    TabIndex = 12,
                    TabStop = false
                };

                // Create Label
                Label label = new Label
                {
                    BackColor = Color.FromArgb(200, 255, 255, 255), // Semi-transparent white background
                    BorderStyle = BorderStyle.FixedSingle,
                    Font = new Font("Montserrat Medium", 9.75F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(12, 142, 112),
                    Location = new Point(currentX, currentY + labelOffsetY + imageSize - 25),
                    Size = new Size(imageSize, 25), // Adjust the size to fit over the image
                    Name = $"label{i}",
                    Text = item.Title,
                    TextAlign = ContentAlignment.MiddleCenter,
                    TabIndex = 47,
                };

                // Create CheckBox
                CheckBox checkBox = new CheckBox
                {
                    Location = new Point(currentX - 21, currentY + 1),
                    Size = new Size(15, 14),
                    Name = $"CheckBox{i}",
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // Create NumericUpDown
                NumericUpDown counter = new NumericUpDown
                {
                    Location = new Point(currentX - 44, currentY + 20),
                    Size = new Size(38, 23),
                    Name = $"Counter{i}",
                    Visible = false // Initially hidden, can be made visible based on logic
                };

                // Add controls to the form
                this.Controls.Add(pictureBox);
                this.Controls.Add(label); // Add the label after the picture box to place it in front
                this.Controls.Add(checkBox);
                this.Controls.Add(counter);

                // Ensure the label is on top of the image
                label.BringToFront();

                // Optionally add event handlers if needed
                checkBox.CheckedChanged += (s, e) =>
                {
                    counter.Visible = checkBox.Checked;
                };

                // Store mapping of checkboxes to counters
                checkBoxCounterMapping[item.Id] = (checkBox, counter);
                this.items[item.Id] = item;
                itemTotals[item.Id] = 0; // Initialize total for each item

                // Add event handlers
                checkBox.CheckedChanged += (s, e) => CheckBox_CheckedChanged(s, e, item.Id);
                counter.ValueChanged += (s, e) => Counter_ValueChanged(s, e, item.Id);
            }
        }


        private void CheckBox_CheckedChanged(object sender, EventArgs e, int itemId)
        {
            CheckBox checkBoxSender = sender as CheckBox;
            if (checkBoxSender != null && checkBoxCounterMapping.TryGetValue(itemId, out (CheckBox, NumericUpDown) checkboxCounter))
            {
                CheckBox checkBox = checkboxCounter.Item1;
                NumericUpDown numericUpDown = checkboxCounter.Item2;

                if (checkBox.Checked)
                {
                    numericUpDown.Visible = true;
                }
                else
                {
                    numericUpDown.Visible = false;
                    itemTotals[itemId] = 0;
                    numericUpDown.Value = 0;
                }
            }
        }

        private void Counter_ValueChanged(object sender, EventArgs e, int itemId)
        {
            NumericUpDown counter = sender as NumericUpDown;
            if (counter != null)
            {
                itemTotals[itemId] = this.items[itemId].Price * counter.Value;
                PreviewPurchase();
            }
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private CheckBox CheckBoxCheeseStick;
        private NumericUpDown MiloCakeCounter;
        public NumericUpDown ChocolateCakeCounter;
        public Label Service;
        public Button ResetButton;
        public Button ReceiptButton;
        public Button ExitButton;
        public CheckBox CheckBoxChocolateBread;
        public CheckBox CheckBoxWater;
        public CheckBox CheckBoxCroissant;
        public CheckBox CheckBoxPastry;
        public CheckBox CheckBoxOrangeJuice;
        public CheckBox CheckBoxMiloCake;
        public CheckBox CheckBoxCoffee;
        public CheckBox CheckBoxChocolateCake;
        public NumericUpDown CoffeeCounter;
        public NumericUpDown CheeseStickCounter;
        public NumericUpDown PastryCounter;
        public NumericUpDown OrangeJuiceCounter;
        public NumericUpDown CroissantCounter;
        public NumericUpDown WaterCounter;
        public NumericUpDown ChocolateBreadCounter;
        public Label Subtotal;
        public Label Taxes;
        private Label LabelService;
        private Label label7;
        private Label LabelTaxes;
        private Label LabelRestaurantName;
        private CheckBox CheckBoxService;
        private Panel panel2;
        private Label LabelTotalString;
        public Label LabelTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private RichTextBox ReceiptTextBox;
        private ToolStripMenuItem UsersControl;
        private ToolStripMenuItem UsersControlView;
        private ToolStripMenuItem RegisterControls;
        private ToolStripMenuItem RegisterControlsClose;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem controlsToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem registersToolStripMenuItem;
        private ToolStripMenuItem closeCashRegisterToolStripMenuItem;
        private ToolStrip ToolStrip;
        private ToolStripButton ToolStripCopyButton;
        private ToolStripButton ToolStripCutButton;
        private ToolStripButton toolStripSaveButton;
        private ToolStripButton toolStripPrintButton;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}