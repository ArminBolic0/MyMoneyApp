namespace MyMoney.forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            lblRegister = new Label();
            btnRegister = new Button();
            label3 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            txtSurname = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lblLenghtError = new Label();
            lblNonCharacterError = new Label();
            lblSurnameNonCharacterError = new Label();
            lblSurnameLenghtError = new Label();
            lblPasswordError = new Label();
            pictureBox1 = new PictureBox();
            cbVisiblePassword = new CheckBox();
            label6 = new Label();
            lblEmailError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRegister
            // 
            lblRegister.Anchor = AnchorStyles.None;
            lblRegister.AutoSize = true;
            lblRegister.BackColor = Color.Transparent;
            lblRegister.ForeColor = SystemColors.ActiveCaption;
            lblRegister.Location = new Point(265, 407);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(246, 15);
            lblRegister.TabIndex = 11;
            lblRegister.Text = "You already have account? Click here to login";
            lblRegister.Click += lblRegister_Click;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.BackColor = Color.Transparent;
            btnRegister.BackgroundImage = (Image)resources.GetObject("btnRegister.BackgroundImage");
            btnRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegister.Font = new Font("Neogrey Medium", 15F);
            btnRegister.ForeColor = SystemColors.ButtonFace;
            btnRegister.Location = new Point(333, 369);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(125, 34);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Neogrey Medium", 12F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(345, 306);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 8;
            label3.Text = "password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Neogrey Medium", 12F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(369, 261);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 9;
            label2.Text = "email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.ControlText;
            txtEmail.Location = new Point(293, 284);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 22);
            txtEmail.TabIndex = 6;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.ControlText;
            txtPassword.Location = new Point(293, 330);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(203, 22);
            txtPassword.TabIndex = 7;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Neogrey Medium", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(202, 76);
            label1.Name = "label1";
            label1.Size = new Size(265, 48);
            label1.TabIndex = 5;
            label1.Text = "MyMoney";
            // 
            // txtSurname
            // 
            txtSurname.Anchor = AnchorStyles.None;
            txtSurname.BackColor = SystemColors.Window;
            txtSurname.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSurname.ForeColor = SystemColors.ControlText;
            txtSurname.Location = new Point(293, 238);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(203, 22);
            txtSurname.TabIndex = 6;
            txtSurname.TextAlign = HorizontalAlignment.Center;
            txtSurname.TextChanged += txtSurname_TextChanged;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.BackColor = SystemColors.Window;
            txtName.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = SystemColors.ControlText;
            txtName.Location = new Point(293, 192);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 22);
            txtName.TabIndex = 6;
            txtName.TextAlign = HorizontalAlignment.Center;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Neogrey Medium", 12F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(351, 214);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 9;
            label4.Text = "surname";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Neogrey Medium", 12F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(366, 168);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 9;
            label5.Text = "name";
            // 
            // lblLenghtError
            // 
            lblLenghtError.Anchor = AnchorStyles.None;
            lblLenghtError.AutoSize = true;
            lblLenghtError.BackColor = Color.Transparent;
            lblLenghtError.ForeColor = Color.OrangeRed;
            lblLenghtError.Location = new Point(502, 194);
            lblLenghtError.Name = "lblLenghtError";
            lblLenghtError.Size = new Size(215, 15);
            lblLenghtError.TabIndex = 12;
            lblLenghtError.Text = "Name must contain atleast 2 characters";
            lblLenghtError.Visible = false;
            // 
            // lblNonCharacterError
            // 
            lblNonCharacterError.Anchor = AnchorStyles.None;
            lblNonCharacterError.AutoSize = true;
            lblNonCharacterError.BackColor = Color.Transparent;
            lblNonCharacterError.ForeColor = Color.OrangeRed;
            lblNonCharacterError.Location = new Point(502, 194);
            lblNonCharacterError.Name = "lblNonCharacterError";
            lblNonCharacterError.Size = new Size(165, 15);
            lblNonCharacterError.TabIndex = 12;
            lblNonCharacterError.Text = "Name can only contain letters";
            lblNonCharacterError.Visible = false;
            // 
            // lblSurnameNonCharacterError
            // 
            lblSurnameNonCharacterError.Anchor = AnchorStyles.None;
            lblSurnameNonCharacterError.AutoSize = true;
            lblSurnameNonCharacterError.BackColor = Color.Transparent;
            lblSurnameNonCharacterError.ForeColor = Color.OrangeRed;
            lblSurnameNonCharacterError.Location = new Point(502, 240);
            lblSurnameNonCharacterError.Name = "lblSurnameNonCharacterError";
            lblSurnameNonCharacterError.Size = new Size(180, 15);
            lblSurnameNonCharacterError.TabIndex = 12;
            lblSurnameNonCharacterError.Text = "Surname can only contain letters";
            lblSurnameNonCharacterError.Visible = false;
            // 
            // lblSurnameLenghtError
            // 
            lblSurnameLenghtError.Anchor = AnchorStyles.None;
            lblSurnameLenghtError.AutoSize = true;
            lblSurnameLenghtError.BackColor = Color.Transparent;
            lblSurnameLenghtError.ForeColor = Color.OrangeRed;
            lblSurnameLenghtError.Location = new Point(502, 240);
            lblSurnameLenghtError.Name = "lblSurnameLenghtError";
            lblSurnameLenghtError.Size = new Size(230, 15);
            lblSurnameLenghtError.TabIndex = 12;
            lblSurnameLenghtError.Text = "Surname must contain atleast 2 characters";
            lblSurnameLenghtError.Visible = false;
            // 
            // lblPasswordError
            // 
            lblPasswordError.Anchor = AnchorStyles.None;
            lblPasswordError.AutoSize = true;
            lblPasswordError.BackColor = Color.Transparent;
            lblPasswordError.ForeColor = Color.OrangeRed;
            lblPasswordError.Location = new Point(502, 319);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(281, 45);
            lblPasswordError.TabIndex = 12;
            lblPasswordError.Text = "Password must be at least 8 characters long \r\nand contain at least 1 uppercase letter, \r\n1 lowercase letter, 1 number, and 1 special character";
            lblPasswordError.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(458, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // cbVisiblePassword
            // 
            cbVisiblePassword.Anchor = AnchorStyles.None;
            cbVisiblePassword.AutoSize = true;
            cbVisiblePassword.BackColor = Color.Transparent;
            cbVisiblePassword.Location = new Point(275, 334);
            cbVisiblePassword.Name = "cbVisiblePassword";
            cbVisiblePassword.Size = new Size(15, 14);
            cbVisiblePassword.TabIndex = 14;
            cbVisiblePassword.UseVisualStyleBackColor = false;
            cbVisiblePassword.CheckedChanged += cbVisiblePassword_CheckedChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.MenuBar;
            label6.Location = new Point(234, 333);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 15;
            label6.Text = "Visible";
            // 
            // lblEmailError
            // 
            lblEmailError.Anchor = AnchorStyles.None;
            lblEmailError.AutoSize = true;
            lblEmailError.BackColor = Color.Transparent;
            lblEmailError.ForeColor = Color.OrangeRed;
            lblEmailError.Location = new Point(502, 286);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(85, 15);
            lblEmailError.TabIndex = 12;
            lblEmailError.Text = "Email not valid";
            lblEmailError.Visible = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(cbVisiblePassword);
            Controls.Add(pictureBox1);
            Controls.Add(lblSurnameNonCharacterError);
            Controls.Add(lblPasswordError);
            Controls.Add(lblEmailError);
            Controls.Add(lblSurnameLenghtError);
            Controls.Add(lblNonCharacterError);
            Controls.Add(lblLenghtError);
            Controls.Add(lblRegister);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtSurname);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegister;
        private Button btnRegister;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtSurname;
        private TextBox txtName;
        private Label label4;
        private Label label5;
        private Label lblLenghtError;
        private Label lblNonCharacterError;
        private Label lblSurnameNonCharacterError;
        private Label lblSurnameLenghtError;
        private Label lblPasswordError;
        private PictureBox pictureBox1;
        private CheckBox cbVisiblePassword;
        private Label label6;
        private Label lblEmailError;
    }
}