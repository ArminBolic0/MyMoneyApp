using MyMoney.forms;
using MyMoney.Helpers;
using System.Security.Cryptography;

namespace MyMoney
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            var frmRegister = new RegisterForm();
            this.Hide();
            if (frmRegister.ShowDialog() == DialogResult.OK)
            {
                frmRegister.Close();
            }
            this.Show();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!RegexHelpers.EmailValidator(txtEmail))
            {
                lblEmailError.Visible = true;
                txtEmail.BackColor = Color.IndianRed;
            }
            else
            {
                lblEmailError.Hide();
                txtEmail.BackColor = DefaultBackColor;
            }
        }
    }
}
