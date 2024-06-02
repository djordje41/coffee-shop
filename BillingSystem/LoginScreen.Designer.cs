namespace BillingSystem
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            Register = new Label();
            UserBox = new TextBox();
            label1 = new Label();
            PasswordBox = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            AcceptLoginButton = new Button();
            ExitLoginButton = new Button();
            RegisterLink = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Register
            // 
            Register.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Register.AutoSize = true;
            Register.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Register.ForeColor = Color.FromArgb(12, 142, 112);
            Register.Location = new Point(150, 37);
            Register.Name = "Register";
            Register.Size = new Size(85, 25);
            Register.TabIndex = 0;
            Register.Text = "Prijava";
            Register.TextAlign = ContentAlignment.MiddleCenter;
            Register.Click += label1_Click;
            // 
            // UserBox
            // 
            UserBox.BackColor = Color.White;
            UserBox.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            UserBox.ForeColor = Color.Black;
            UserBox.Location = new Point(105, 259);
            UserBox.Name = "UserBox";
            UserBox.Size = new Size(175, 21);
            UserBox.TabIndex = 1;
            UserBox.TextChanged += UserBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(12, 142, 112);
            label1.Location = new Point(134, 236);
            label1.Name = "label1";
            label1.Size = new Size(121, 18);
            label1.TabIndex = 2;
            label1.Text = "Korisničko ime";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.White;
            PasswordBox.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.ForeColor = Color.Black;
            PasswordBox.Location = new Point(105, 316);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(175, 21);
            PasswordBox.TabIndex = 2;
            PasswordBox.UseSystemPasswordChar = true;
            PasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(12, 142, 112);
            label2.Location = new Point(158, 293);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 2;
            label2.Text = "Lozinka";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AcceptLoginButton
            // 
            AcceptLoginButton.BackColor = Color.FromArgb(12, 142, 112);
            AcceptLoginButton.FlatStyle = FlatStyle.Popup;
            AcceptLoginButton.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            AcceptLoginButton.ForeColor = Color.White;
            AcceptLoginButton.Location = new Point(105, 374);
            AcceptLoginButton.Name = "AcceptLoginButton";
            AcceptLoginButton.Size = new Size(76, 24);
            AcceptLoginButton.TabIndex = 3;
            AcceptLoginButton.Text = "Potvrdi";
            AcceptLoginButton.UseVisualStyleBackColor = false;
            AcceptLoginButton.Click += AcceptButton_Click;
            // 
            // ExitLoginButton
            // 
            ExitLoginButton.BackColor = Color.FromArgb(12, 142, 112);
            ExitLoginButton.FlatStyle = FlatStyle.Popup;
            ExitLoginButton.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            ExitLoginButton.ForeColor = Color.White;
            ExitLoginButton.Location = new Point(205, 374);
            ExitLoginButton.Name = "ExitLoginButton";
            ExitLoginButton.Size = new Size(76, 24);
            ExitLoginButton.TabIndex = 4;
            ExitLoginButton.Text = "Izlaz";
            ExitLoginButton.UseVisualStyleBackColor = false;
            ExitLoginButton.Click += CancelButton_Click;
            // 
            // RegisterLink
            // 
            RegisterLink.ActiveLinkColor = Color.FromArgb(209, 120, 66);
            RegisterLink.AutoSize = true;
            RegisterLink.LinkColor = Color.Black;
            RegisterLink.Location = new Point(159, 408);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(67, 15);
            RegisterLink.TabIndex = 5;
            RegisterLink.TabStop = true;
            RegisterLink.Text = "Registracija";
            RegisterLink.TextAlign = ContentAlignment.MiddleCenter;
            RegisterLink.LinkClicked += RegisterLink_LinkClicked;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 249, 244);
            ClientSize = new Size(384, 461);
            ControlBox = false;
            Controls.Add(RegisterLink);
            Controls.Add(ExitLoginButton);
            Controls.Add(AcceptLoginButton);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordBox);
            Controls.Add(UserBox);
            Controls.Add(Register);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prijava";
            Load += LoginScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Register;
        private TextBox UserBox;
        private Label label1;
        private TextBox PasswordBox;
        private Label label2;
        private PictureBox pictureBox1;
        private Button AcceptLoginButton;
        private Button ExitLoginButton;
        private LinkLabel RegisterLink;
    }
}