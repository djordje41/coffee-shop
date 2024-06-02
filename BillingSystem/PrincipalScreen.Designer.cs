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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckBoxService = new System.Windows.Forms.CheckBox();
            this.LabelTaxes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.Taxes = new System.Windows.Forms.Label();
            this.LabelService = new System.Windows.Forms.Label();
            this.Service = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelTotalString = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ReceiptButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripCopyButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripCutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripPrintButton = new System.Windows.Forms.ToolStripButton();
            this.ReceiptTextBox = new System.Windows.Forms.RichTextBox();
            this.LabelRestaurantName = new System.Windows.Forms.Label();
            this.UsersControl = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersControlView = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterControls = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterControlsClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCashRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.CheckBoxService);
            this.panel1.Controls.Add(this.LabelTaxes);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Subtotal);
            this.panel1.Controls.Add(this.Taxes);
            this.panel1.Controls.Add(this.LabelService);
            this.panel1.Controls.Add(this.Service);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ResetButton);
            this.panel1.Controls.Add(this.ReceiptButton);
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 125);
            this.panel1.TabIndex = 0;
            // 
            // CheckBoxService
            // 
            this.CheckBoxService.AutoSize = true;
            this.CheckBoxService.Location = new System.Drawing.Point(671, 97);
            this.CheckBoxService.Name = "CheckBoxService";
            this.CheckBoxService.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxService.TabIndex = 1;
            this.CheckBoxService.UseVisualStyleBackColor = true;
            this.CheckBoxService.CheckedChanged += new System.EventHandler(this.CheckBoxService_CheckedChanged);
            // 
            // LabelTaxes
            // 
            this.LabelTaxes.AutoSize = true;
            this.LabelTaxes.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTaxes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.LabelTaxes.Location = new System.Drawing.Point(666, 52);
            this.LabelTaxes.Name = "LabelTaxes";
            this.LabelTaxes.Size = new System.Drawing.Size(61, 22);
            this.LabelTaxes.TabIndex = 32;
            this.LabelTaxes.Text = "Taxes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.label7.Location = new System.Drawing.Point(666, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "Subtotal";
            // 
            // Subtotal
            // 
            this.Subtotal.BackColor = System.Drawing.Color.White;
            this.Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Subtotal.Location = new System.Drawing.Point(767, 10);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Subtotal.Size = new System.Drawing.Size(194, 32);
            this.Subtotal.TabIndex = 29;
            this.Subtotal.Text = " ";
            this.Subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Subtotal.Click += new System.EventHandler(this.Subtotal_Click);
            // 
            // Taxes
            // 
            this.Taxes.BackColor = System.Drawing.Color.White;
            this.Taxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Taxes.Location = new System.Drawing.Point(767, 49);
            this.Taxes.Name = "Taxes";
            this.Taxes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Taxes.Size = new System.Drawing.Size(194, 32);
            this.Taxes.TabIndex = 28;
            this.Taxes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelService
            // 
            this.LabelService.AutoSize = true;
            this.LabelService.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.LabelService.Location = new System.Drawing.Point(669, 91);
            this.LabelService.Name = "LabelService";
            this.LabelService.Size = new System.Drawing.Size(91, 22);
            this.LabelService.TabIndex = 26;
            this.LabelService.Text = "   Service";
            // 
            // Service
            // 
            this.Service.BackColor = System.Drawing.Color.White;
            this.Service.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Service.Location = new System.Drawing.Point(767, 88);
            this.Service.Name = "Service";
            this.Service.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Service.Size = new System.Drawing.Size(194, 32);
            this.Service.TabIndex = 25;
            this.Service.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Service.Click += new System.EventHandler(this.LabelService_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.ExitButton.CausesValidation = false;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Montserrat", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(458, 13);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(184, 100);
            this.ExitButton.TabIndex = 24;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LabelTotalString);
            this.panel2.Controls.Add(this.LabelTotal);
            this.panel2.Font = new System.Drawing.Font("Montserrat", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(28, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 100);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LabelTotalString
            // 
            this.LabelTotalString.BackColor = System.Drawing.Color.White;
            this.LabelTotalString.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTotalString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.LabelTotalString.Location = new System.Drawing.Point(0, 74);
            this.LabelTotalString.Name = "LabelTotalString";
            this.LabelTotalString.Size = new System.Drawing.Size(208, 25);
            this.LabelTotalString.TabIndex = 20;
            this.LabelTotalString.Text = "Total";
            this.LabelTotalString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTotal
            // 
            this.LabelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTotal.ForeColor = System.Drawing.Color.White;
            this.LabelTotal.Location = new System.Drawing.Point(64, 30);
            this.LabelTotal.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(81, 22);
            this.LabelTotal.TabIndex = 19;
            this.LabelTotal.Text = "$00000";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTotal.Click += new System.EventHandler(this.LabelTotal_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Font = new System.Drawing.Font("Montserrat", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(265, 65);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(0);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(164, 48);
            this.ResetButton.TabIndex = 16;
            this.ResetButton.TabStop = false;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ReceiptButton
            // 
            this.ReceiptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(142)))), ((int)(((byte)(112)))));
            this.ReceiptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReceiptButton.Font = new System.Drawing.Font("Montserrat", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReceiptButton.ForeColor = System.Drawing.Color.White;
            this.ReceiptButton.Location = new System.Drawing.Point(265, 13);
            this.ReceiptButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReceiptButton.Name = "ReceiptButton";
            this.ReceiptButton.Size = new System.Drawing.Size(164, 48);
            this.ReceiptButton.TabIndex = 15;
            this.ReceiptButton.TabStop = false;
            this.ReceiptButton.Text = "Receipt";
            this.ReceiptButton.UseVisualStyleBackColor = false;
            this.ReceiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.panel4.CausesValidation = false;
            this.panel4.Controls.Add(this.ToolStrip);
            this.panel4.Controls.Add(this.ReceiptTextBox);
            this.panel4.Location = new System.Drawing.Point(666, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 537);
            this.panel4.TabIndex = 2;
            // 
            // ToolStrip
            // 
            this.ToolStrip.AutoSize = false;
            this.ToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripCopyButton,
            this.ToolStripCutButton,
            this.toolStripSaveButton,
            this.toolStripPrintButton});
            this.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStrip.Location = new System.Drawing.Point(0, 1);
            this.ToolStrip.Margin = new System.Windows.Forms.Padding(3);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(318, 46);
            this.ToolStrip.TabIndex = 6;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // ToolStripCopyButton
            // 
            this.ToolStripCopyButton.AutoSize = false;
            this.ToolStripCopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripCopyButton.Image")));
            this.ToolStripCopyButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripCopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripCopyButton.Margin = new System.Windows.Forms.Padding(68, 1, 0, 2);
            this.ToolStripCopyButton.Name = "ToolStripCopyButton";
            this.ToolStripCopyButton.Size = new System.Drawing.Size(33, 33);
            this.ToolStripCopyButton.Text = "toolStripButton1";
            this.ToolStripCopyButton.ToolTipText = "Copy";
            this.ToolStripCopyButton.Click += new System.EventHandler(this.ToolStripCopyButton_Click);
            // 
            // ToolStripCutButton
            // 
            this.ToolStripCutButton.AutoSize = false;
            this.ToolStripCutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripCutButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripCutButton.Image")));
            this.ToolStripCutButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripCutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripCutButton.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.ToolStripCutButton.Name = "ToolStripCutButton";
            this.ToolStripCutButton.Size = new System.Drawing.Size(33, 33);
            this.ToolStripCutButton.Text = "toolStripButton1";
            this.ToolStripCutButton.ToolTipText = "Cut";
            this.ToolStripCutButton.Click += new System.EventHandler(this.ToolStripCutButton_Click);
            // 
            // toolStripSaveButton
            // 
            this.toolStripSaveButton.AutoSize = false;
            this.toolStripSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveButton.Image")));
            this.toolStripSaveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveButton.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripSaveButton.Name = "toolStripSaveButton";
            this.toolStripSaveButton.Size = new System.Drawing.Size(33, 33);
            this.toolStripSaveButton.Text = "toolStripButton2";
            this.toolStripSaveButton.ToolTipText = "Save";
            this.toolStripSaveButton.Click += new System.EventHandler(this.toolStripSaveButton_Click);
            // 
            // toolStripPrintButton
            // 
            this.toolStripPrintButton.AutoSize = false;
            this.toolStripPrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrintButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrintButton.Image")));
            this.toolStripPrintButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrintButton.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripPrintButton.Name = "toolStripPrintButton";
            this.toolStripPrintButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripPrintButton.Size = new System.Drawing.Size(33, 33);
            this.toolStripPrintButton.Text = "toolStripButton1";
            this.toolStripPrintButton.ToolTipText = "Print";
            this.toolStripPrintButton.Click += new System.EventHandler(this.toolStripPrintButton_Click);
            // 
            // ReceiptTextBox
            // 
            this.ReceiptTextBox.AccessibleDescription = "Copy";
            this.ReceiptTextBox.AccessibleName = "Copy";
            this.ReceiptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReceiptTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReceiptTextBox.Location = new System.Drawing.Point(0, 47);
            this.ReceiptTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ReceiptTextBox.Name = "ReceiptTextBox";
            this.ReceiptTextBox.Size = new System.Drawing.Size(318, 492);
            this.ReceiptTextBox.TabIndex = 0;
            this.ReceiptTextBox.Text = "";
            this.ReceiptTextBox.TextChanged += new System.EventHandler(this.ReceiptTextBox_TextChanged);
            // 
            // UsersControl
            // 
            this.UsersControl.Name = "UsersControl";
            this.UsersControl.Size = new System.Drawing.Size(32, 19);
            // 
            // UsersControlView
            // 
            this.UsersControlView.Name = "UsersControlView";
            this.UsersControlView.Size = new System.Drawing.Size(32, 19);
            // 
            // RegisterControls
            // 
            this.RegisterControls.Name = "RegisterControls";
            this.RegisterControls.Size = new System.Drawing.Size(32, 19);
            // 
            // RegisterControlsClose
            // 
            this.RegisterControlsClose.Name = "RegisterControlsClose";
            this.RegisterControlsClose.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.registersToolStripMenuItem});
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.controlsToolStripMenuItem.Text = "Controls";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // registersToolStripMenuItem
            // 
            this.registersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeCashRegisterToolStripMenuItem});
            this.registersToolStripMenuItem.Name = "registersToolStripMenuItem";
            this.registersToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.registersToolStripMenuItem.Text = "Registers";
            // 
            // closeCashRegisterToolStripMenuItem
            // 
            this.closeCashRegisterToolStripMenuItem.Name = "closeCashRegisterToolStripMenuItem";
            this.closeCashRegisterToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.closeCashRegisterToolStripMenuItem.Text = "Close Cash Register";
            this.closeCashRegisterToolStripMenuItem.Click += new System.EventHandler(this.closeCashRegisterToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PrincipalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "PrincipalScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing System";
            this.Load += new System.EventHandler(this.PrincipalScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.LoadItems();
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