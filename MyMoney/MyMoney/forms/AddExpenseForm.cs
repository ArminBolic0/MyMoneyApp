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
    public partial class AddExpenseForm : Form
    {
        DataBaseContext dbContext = new DataBaseContext();
        User currentUser = new User();
        public AddExpenseForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void AddExpenseForm_Load(object sender, EventArgs e)
        {
            setupForm();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                txtDescription.BackColor = Color.IndianRed;
                return;
            }
            ExpenseCategory eCategory = cbExpenseCategory.SelectedItem as ExpenseCategory;
            dbContext.Users.Attach(currentUser);
            Expense newExpense = new()
            {
                amount = (float)numAmount.Value,
                user = currentUser,
                description = txtDescription.Text,
                expenseCategory_id = eCategory.id,
                expenseCategory = eCategory
            };
            dbContext.Expenses.Add(newExpense);
            dbContext.SaveChanges();
            Close();
            return;
        }

        private void setupForm()
        {
            cbExpenseCategory.DataSource = dbContext.ExpenseCategories.ToList();
            cbExpenseCategory.ValueMember = "id";
            cbExpenseCategory.DisplayMember = "category_name";
            cbExpenseCategory.SelectedIndex = 0;
            Helpers.VisualStyle.btnStyle(btnAddExpense);
            Helpers.VisualStyle.cbStyle(cbExpenseCategory);
            Helpers.VisualStyle.numStyle(numAmount);
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text)) txtDescription.BackColor = Color.IndianRed;
            else txtDescription.BackColor = SystemColors.Window;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
