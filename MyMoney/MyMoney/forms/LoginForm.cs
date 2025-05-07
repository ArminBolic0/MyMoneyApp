using Data;
using Database;
using MyMoney.forms;
using MyMoney.Helpers;
using System.Security.Cryptography;

namespace MyMoney
{
    public partial class LoginForm : Form
    {

        DataBaseContext dbContext = new DataBaseContext();
        List<User> users;
        public LoginForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.FormBorderStyle = FormBorderStyle.None;
            users = dbContext.Users.ToList();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            var frmRegister = new RegisterForm();
            this.Hide();
            if (frmRegister.ShowDialog() == DialogResult.OK)
            {
                frmRegister.Close();
            }
            if (!this.IsDisposed && !Application.MessageLoop)
            {
                return;
            }
            if (!this.IsDisposed)
            {
                this.Show();
                dbContext = new DataBaseContext();
                users = dbContext.Users.ToList();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (RegexHelpers.EmailValidator(txtEmail))
            {
                lblEmailError.Hide();
                txtEmail.BackColor = DefaultBackColor;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool accountExist = false;
            if (!RegexHelpers.EmailValidator(txtEmail))
            {
                lblEmailError.Visible = true;
                txtEmail.BackColor = Color.IndianRed;
                return;
            }
            if (txtPassword.Text.Length < 8)
            {
                txtPassword.BackColor = Color.IndianRed;
                return;
            }

            foreach (var user in users)
            {
                if (user.email == txtEmail.Text)
                {
                    accountExist = true;
                    if (Helpers.PasswordHasher.VerifyPassword(txtPassword.Text, user.password_hash, user.password_salt))
                    {
                        var novaForma = new MainForm(user);
                        this.Hide();
                        if (novaForma.ShowDialog() == DialogResult.OK)
                        {
                            novaForma.Close();
                        }
                    }
                    else lblInvalidPassword.Visible = true;
                }
            }
            if (!accountExist) lblAccountExist.Visible = true;
            else lblAccountExist.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 8) txtPassword.BackColor = DefaultBackColor;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblRegister_MouseHover(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.White;
        }

        private void lblRegister_MouseLeave(object sender, EventArgs e)
        {
            lblRegister.ForeColor = SystemColors.ActiveCaption;
        }
    }
}
