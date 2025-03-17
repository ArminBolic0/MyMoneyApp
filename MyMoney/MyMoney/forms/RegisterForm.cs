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
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length < 2)
            {
                txtName.BackColor = Color.OrangeRed;
                lblLenghtError.Visible = true;
            }
            else if (RegexHelpers.ContainsNonCharacters(txtName))
            {
                txtName.BackColor = Color.OrangeRed;
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
                txtSurname.BackColor = Color.OrangeRed;
                lblSurnameLenghtError.Visible = true;
            }
            else if (RegexHelpers.ContainsNonCharacters(txtSurname))
            {
                txtSurname.BackColor = Color.OrangeRed;
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
            if(!RegexHelpers.PasswordValidator(txtPassword))
            {
                txtPassword.BackColor = Color.OrangeRed;
                lblPasswordError.Visible = true;
            }
            else
            {
                txtPassword.BackColor = DefaultBackColor;
                lblPasswordError.Visible = false;
            }
        }
    }
}
