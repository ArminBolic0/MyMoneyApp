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
        }

        private void AddExpenseForm_Load(object sender, EventArgs e)
        {
            cbExpenseCategory.DataSource = dbContext.ExpenseCategories.ToList();
            cbExpenseCategory.ValueMember = "id";
            cbExpenseCategory.DisplayMember = "category_name";
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            ExpenseCategory eCategory = cbExpenseCategory.SelectedItem as ExpenseCategory;
            dbContext.Users.Attach(currentUser);
            Expense newExpense = new()
            {
                amount = (float)numAmount.Value,
                user = currentUser,
                expenseCategory_id = eCategory.id,
                expenseCategory = eCategory
            };
            dbContext.Expenses.Add(newExpense);
            dbContext.SaveChanges();
            Close();
            return;
        }
    }
}
