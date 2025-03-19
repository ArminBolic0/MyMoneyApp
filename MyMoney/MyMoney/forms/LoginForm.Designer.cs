namespace MyMoney
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            lblRegister = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblEmailError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.ControlText;
            txtPassword.Location = new Point(301, 252);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(203, 22);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.ControlText;
            txtEmail.Location = new Point(301, 195);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 22);
            txtEmail.TabIndex = 1;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Neogrey Medium", 12F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(375, 171);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 2;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Neogrey Medium", 12F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(353, 228);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 2;
            label3.Text = "password";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Font = new Font("Neogrey Medium", 15F);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(353, 302);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblRegister
            // 
            lblRegister.Anchor = AnchorStyles.None;
            lblRegister.AutoSize = true;
            lblRegister.BackColor = Color.Transparent;
            lblRegister.ForeColor = SystemColors.ActiveCaption;
            lblRegister.Location = new Point(273, 351);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(271, 15);
            lblRegister.TabIndex = 4;
            lblRegister.Text = "You don't have and account? Click here to register";
            lblRegister.Click += lblRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(484, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Neogrey Medium", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(227, 99);
            label1.Name = "label1";
            label1.Size = new Size(265, 48);
            label1.TabIndex = 14;
            label1.Text = "MyMoney";
            // 
            // lblEmailError
            // 
            lblEmailError.Anchor = AnchorStyles.None;
            lblEmailError.AutoSize = true;
            lblEmailError.BackColor = Color.Transparent;
            lblEmailError.ForeColor = Color.OrangeRed;
            lblEmailError.Location = new Point(511, 199);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(85, 15);
            lblEmailError.TabIndex = 16;
            lblEmailError.Text = "Email not valid";
            lblEmailError.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEmailError);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblRegister);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Name = "LoginForm";
            StartPosition = FormStartPosition.Manual;
            Text = "MyMoney";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Label lblRegister;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblEmailError;
    }
}
