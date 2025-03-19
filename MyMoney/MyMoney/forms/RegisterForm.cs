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
        public RegisterForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length < 2)
            {
                txtName.BackColor = Color.IndianRed;
                lblLenghtError.Visible = true;
            }
            else if (RegexHelpers.ContainsNonCharacters(txtName))
            {
                txtName.BackColor = Color.IndianRed;
                lblNonCharacterError.Visible = true;
            }
            else
            {
                lblLenghtError.Visible = false;
                lblNonCharacterError.Visible = false;
                txtName.BackColor = DefaultBackColor;
            }

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            if (txtSurname.Text.Length < 2)
            {
                txtSurname.BackColor = Color.IndianRed;
                lblSurnameLenghtError.Visible = true;
            }
            else if (RegexHelpers.ContainsNonCharacters(txtSurname))
            {
                txtSurname.BackColor = Color.IndianRed;
                lblSurnameNonCharacterError.Visible = true;
            }
            else
            {
                lblSurnameLenghtError.Visible = false;
                lblSurnameNonCharacterError.Visible = false;
                txtSurname.BackColor = DefaultBackColor;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!RegexHelpers.PasswordValidator(txtPassword))
            {
                txtPassword.BackColor = Color.IndianRed;
                lblPasswordError.Visible = true;
            }
            else
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
            if(!RegexHelpers.EmailValidator(txtEmail))
            {
                lblEmailError.Visible = true;
                txtEmail.BackColor = Color.IndianRed;  
            }
            else
            {
                lblEmailError.Visible = false;
                txtEmail.BackColor = DefaultBackColor;
            }
        }
    }
}
