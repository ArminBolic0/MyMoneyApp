using Data;
using Database;
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
    public partial class MainForm : Form
    {
        DataBaseContext dbContext = new DataBaseContext();
        User currentUser = new User();
        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome {currentUser.name} {currentUser.surname}!";
            lblTotalExpenses.Text = $"Total expenses: {calculateExpenses()} $";
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            var newForm = new AddExpenseForm(currentUser);
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                newForm.Close();
            }
            updateData();
        }

        private float calculateExpenses()
        {
            float total = dbContext.Expenses.Where(e=>e.user_id == currentUser.Id).Sum(e=>e.amount);
            return total;
        }

        private void updateData()
        {
            lblTotalExpenses.Text = $"Total expenses: {calculateExpenses()} $";
        }
    }
}
