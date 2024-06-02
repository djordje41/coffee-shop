namespace BillingSystem
{
    partial class CloseCashRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseCashRegister));
            lvwCerrar = new ListView();
            RecordButton = new Button();
            CloseButton = new Button();
            ID = new ColumnHeader();
            Korisnik = new ColumnHeader();
            Stavke = new ColumnHeader();
            SuspendLayout();
            // 
            // lvwCerrar
            // 
            lvwCerrar.Columns.AddRange(new ColumnHeader[] { ID, Korisnik, Stavke });
            lvwCerrar.Location = new Point(15, 12);
            lvwCerrar.Name = "lvwCerrar";
            lvwCerrar.Size = new Size(905, 501);
            lvwCerrar.TabIndex = 7;
            lvwCerrar.UseCompatibleStateImageBehavior = false;
            lvwCerrar.View = View.Details;
            // 
            // RecordButton
            // 
            RecordButton.BackColor = Color.FromArgb(12, 142, 112);
            RecordButton.Cursor = Cursors.Hand;
            RecordButton.FlatStyle = FlatStyle.Popup;
            RecordButton.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            RecordButton.ForeColor = Color.White;
            RecordButton.Location = new Point(107, 544);
            RecordButton.Margin = new Padding(0);
            RecordButton.Name = "RecordButton";
            RecordButton.Size = new Size(320, 50);
            RecordButton.TabIndex = 16;
            RecordButton.TabStop = false;
            RecordButton.Text = "Sačuvaj kasu u registar";
            RecordButton.UseVisualStyleBackColor = false;
            RecordButton.Click += RecordButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(12, 142, 112);
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatStyle = FlatStyle.Popup;
            CloseButton.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(507, 544);
            CloseButton.Margin = new Padding(0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(320, 50);
            CloseButton.TabIndex = 17;
            CloseButton.TabStop = false;
            CloseButton.Text = "Zatvori";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // ID
            // 
            ID.Text = "ID Računa";
            ID.Width = 80;
            // 
            // Korisnik
            // 
            Korisnik.Text = "Korisnik";
            Korisnik.Width = 80;
            // 
            // Stavke
            // 
            Stavke.Text = "Stavke";
            Stavke.Width = 100;
            // 
            // CloseCashRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 244);
            ClientSize = new Size(934, 621);
            ControlBox = false;
            Controls.Add(CloseButton);
            Controls.Add(RecordButton);
            Controls.Add(lvwCerrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(950, 660);
            MinimumSize = new Size(950, 660);
            Name = "CloseCashRegister";
            Text = "Registar kase";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvwCerrar;
        public Button RecordButton;
        public Button CloseButton;
        private ColumnHeader ID;
        private ColumnHeader Korisnik;
        private ColumnHeader Stavke;
    }
}