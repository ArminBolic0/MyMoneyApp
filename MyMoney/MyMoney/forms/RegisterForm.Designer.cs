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
            SuspendLayout();
            // 
            // lblRegister
            // 
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
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Neogrey Medium", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(265, 76);
            label1.Name = "label1";
            label1.Size = new Size(258, 48);
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
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
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
    }
}