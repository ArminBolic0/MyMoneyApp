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
    public partial class EditExpenseForm : Form
    {
        DataBaseContext dbContext = new DataBaseContext();
        User currentUser = new User();
        Expense currentExpense = new Expense();
        public EditExpenseForm(User user, Expense expense)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            currentUser = user;
            currentExpense = expense;
        }

        private void EditExpenseForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            Helpers.VisualStyle.btnStyle(btnSaveChanges);
            cbExpenseCategory.DataSource = dbContext.ExpenseCategories.ToList();
            cbExpenseCategory.DisplayMember = "category_name";
            cbExpenseCategory.ValueMember = "id";
            cbExpenseCategory.SelectedIndex = currentExpense.expenseCategory.id;
            numAmount.Value = (int)currentExpense.amount;
            txtDescription.Text = currentExpense.description;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var selectedCategoryId = (int)cbExpenseCategory.SelectedValue;
            Expense expenseToUpdate = dbContext.Expenses.Where(e => e.id == currentExpense.id).FirstOrDefault() as Expense;
            if (expenseToUpdate == null) Application.Exit();
            expenseToUpdate.amount = (int)numAmount.Value;
            expenseToUpdate.expenseCategory_id = selectedCategoryId;
            expenseToUpdate.description = txtDescription.Text;
            dbContext.Update(expenseToUpdate);
            dbContext.SaveChanges();
            this.Close();
        }

        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to delete this expense?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                Expense expenseToDelete = dbContext.Expenses.Where(e => e.id == currentExpense.id).FirstOrDefault() as Expense;
                dbContext.Remove(expenseToDelete);
                dbContext.SaveChanges();
                this.Close();
            }
        }
    }
}
