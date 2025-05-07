using Data;
using Database;
using MyMoney.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMoney.forms
{
    public partial class RegisterForm : Form
    {

        DataBaseContext dbContext = new DataBaseContext();
        List<User> users;
        public RegisterForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.FormBorderStyle = FormBorderStyle.None;
            users = dbContext.Users.ToList();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 2)
            {
                lblLenghtError.Visible = false;
                lblNonCharacterError.Visible = false;
                txtName.BackColor = DefaultBackColor;
            }
            else if (!RegexHelpers.ContainsNonCharacters(txtName))
            {
                lblLenghtError.Visible = false;
                lblNonCharacterError.Visible = false;
                txtName.BackColor = DefaultBackColor;
            }

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (txtSurname.Text.Length > 2)
            {
                lblSurnameLenghtError.Visible = false;
                lblSurnameNonCharacterError.Visible = false;
                txtSurname.BackColor = DefaultBackColor;
            }
            else if (!RegexHelpers.ContainsNonCharacters(txtSurname))
            {
                lblSurnameLenghtError.Visible = false;
                lblSurnameNonCharacterError.Visible = false;
                txtSurname.BackColor = DefaultBackColor;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (RegexHelpers.PasswordValidator(txtPassword))
            {
                txtPassword.BackColor = DefaultBackColor;
                lblPasswordError.Visible = false;
            }
        }

        private void cbVisiblePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVisiblePassword.Checked)
                txtPassword.PasswordChar = '\0';
            else txtPassword.PasswordChar = '*';
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (RegexHelpers.EmailValidator(txtEmail))
            {
                lblEmailError.Visible = false;
                txtEmail.BackColor = DefaultBackColor;
            }
        }

        private bool nameHandler()
        {
            if (txtName.Text.Length < 2)
            {
                txtName.BackColor = Color.IndianRed;
                lblLenghtError.Visible = true;
                return false;
            }
            else if (RegexHelpers.ContainsNonCharacters(txtName))
            {
                txtName.BackColor = Color.IndianRed;
                lblNonCharacterError.Visible = true;
                return false;
            }
            return true;
        }

        private bool surnameHandler()
        {
            if (txtSurname.Text.Length < 2)
            {
                txtSurname.BackColor = Color.IndianRed;
                lblSurnameLenghtError.Visible = true;
                lblRegistrationSuccesful.Visible = false;
                return false;
            }
            else if (RegexHelpers.ContainsNonCharacters(txtSurname))
            {
                txtSurname.BackColor = Color.IndianRed;
                lblSurnameNonCharacterError.Visible = true;
                lblRegistrationSuccesful.Visible = false;
                return false;
            }
            return true;
        }

        private bool emailHandler()
        {
            lblEmailInUse.Visible = false;
            if (!RegexHelpers.EmailValidator(txtEmail))
            {
                lblEmailError.Visible = true;
                txtEmail.BackColor = Color.IndianRed;
                lblRegistrationSuccesful.Visible = false;
                return false;
            }
            return true;
        }

        private bool passwordHandler()
        {
            if (!RegexHelpers.PasswordValidator(txtPassword))
            {
                txtPassword.BackColor = Color.IndianRed;
                lblPasswordError.Visible = true;
                lblRegistrationSuccesful.Visible = false;
                return false;
            }
            return true;
        }

        private bool databaseCheck() // Checks if email is already in use by another account
        {
            foreach (User user in users)
            {
                if (user.email == txtEmail.Text) return false;
            }
            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!nameHandler()) return;
            if (!surnameHandler()) return;
            if (!emailHandler()) return;
            if (!passwordHandler()) return;
            users = dbContext.Users.ToList();
            if (databaseCheck())
            {
                var (hash, salt) = Helpers.PasswordHasher.HashPassword(txtPassword.Text);
                User newUser = new()
                {
                    name = txtName.Text,
                    surname = txtSurname.Text,
                    email = txtEmail.Text,
                    password_hash = hash,
                    password_salt = salt
                };

                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
                lblRegistrationSuccesful.Visible = true;
                return;
            }
            else
            {
                lblEmailInUse.Visible = true;
            }

            lblRegistrationSuccesful.Visible = false;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

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
