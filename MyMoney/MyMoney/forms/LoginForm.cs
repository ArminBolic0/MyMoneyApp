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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User newUser = new()
            {
                name = "Test",
                surname = "Test",
                email = "test@test.test",
                password = "testpass"
            };
            
            dbContext.Users.Add(newUser);
            dbContext.SaveChanges();
        }
    }
}
