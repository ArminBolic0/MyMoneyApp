using MyMoney.forms;
using System.Security.Cryptography;

namespace MyMoney
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            var frmRegister = new RegisterForm();
            this.Hide();
            if(frmRegister.ShowDialog() == DialogResult.OK)
            {
                frmRegister.Close();
            }
            this.Show();
        }
    }
}
