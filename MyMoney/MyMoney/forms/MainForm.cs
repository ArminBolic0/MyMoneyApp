﻿using Data;
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


using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

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
            loadForm();
        }

        private void loadForm()
        {
            lblWelcome.Text = $"Welcome {currentUser.name} {currentUser.surname}!";
            Helpers.VisualStyle.dgvStyle(dgvExpenses);
            Helpers.VisualStyle.btnStyle(btnAddExpense);
            Helpers.VisualStyle.cbStyle(cbFilterExpense);
            cbFilterExpense.SelectedIndex = 0;
            updateData();
            updateChart();
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
            float total = dbContext.Expenses.Where(e => e.user_id == currentUser.Id).Sum(e => e.amount);
            return total;
        }

        private void updateData()
        {
            lblTotalExpenses.Text = $"Total expenses: {calculateExpenses()} $";
            dgvExpenses.DataSource = dbContext.Expenses.Where(e => e.user_id == currentUser.Id).ToList();
            foreach (DataGridViewRow row in dgvExpenses.Rows)
            {
                Expense expense = row.DataBoundItem as Expense;
                ExpenseCategory eCategory = dbContext.ExpenseCategories.Where(e => e.id == expense.expenseCategory_id).FirstOrDefault();
                row.Cells[0].Value = eCategory.category_name;
                row.Cells[1].Value = expense.amount;
                row.Cells[2].Value = expense.description;
            }
            updateChart();
        }


        private void updateChart()
        {
            float totalExpenses = calculateExpenses();
            txtGroceries.Cursor = Cursors.Default;
            txtTransportation.Cursor = Cursors.Default;
            txtMedical.Cursor = Cursors.Default;
            txtRent.Cursor = Cursors.Default;
            txtInsurance.Cursor = Cursors.Default;
            txtEntertainment.Cursor = Cursors.Default;
            txtSavings.Cursor = Cursors.Default;
            txtInvestment.Cursor = Cursors.Default;
            txtOther.Cursor = Cursors.Default;
            float groceriesExpenses = dbContext.Expenses.Where(e => e.user_id == currentUser.Id).Where(e => e.expenseCategory_id == 1).Sum(e => e.amount);
            float transportationExpenses = dbContext.Expenses.Where(e => e.user_id == currentUser.Id).Where(e => e.expenseCategory_id == 2).Sum(e => e.amount);
            float medicalExpenses = dbContext.Expenses.Where(e => e.user_id == currentUser.Id).Where(e => e.expenseCategory_id == 3).Sum(e => e.amount);
            float rentExpenses = dbContext.Expenses.Where(e => e.user_id == currentUser.Id).Where(e => e.expenseCategory_id == 4).Sum(e => e.amount);
            float insuranceExpenses = dbContext.Expenses.Where(e => e.user_id == currentUser.Id).Where(e => e.expenseCategory_id == 5).Sum(e => e.amount);
            float entertainmentExpenses = dbContext.Expenses.Where(e => e.user_id == currentUser.Id).Where(e => e.expenseCategory_id == 6).Sum(e => e.amount);
            float savingsExpenses = dbContext.Expenses.Where(e => e.user_id == currentUser.Id).Where(e => e.expenseCategory_id == 7).Sum(e => e.amount);
            float investmentExpenses = dbContext.Expenses.Where(e => e.user_id == currentUser.Id).Where(e => e.expenseCategory_id == 8).Sum(e => e.amount);
            float otherExpenses = dbContext.Expenses.Where(e => e.user_id == currentUser.Id).Where(e => e.expenseCategory_id == 0).Sum(e => e.amount);

            txtGroceries.Width = (int)Math.Round((groceriesExpenses / totalExpenses) * 300);
            txtTransportation.Width = (int)Math.Round((transportationExpenses / totalExpenses) * 300);
            txtMedical.Width = (int)Math.Round((medicalExpenses / totalExpenses) * 300);
            txtRent.Width = (int)Math.Round((rentExpenses / totalExpenses) * 300);
            txtInsurance.Width = (int)Math.Round((insuranceExpenses / totalExpenses) * 300);
            txtEntertainment.Width = (int)Math.Round((entertainmentExpenses / totalExpenses) * 300);
            txtSavings.Width = (int)Math.Round((savingsExpenses / totalExpenses) * 300);
            txtInvestment.Width = (int)Math.Round((investmentExpenses / totalExpenses) * 300);
            txtOther.Width = (int)Math.Round((otherExpenses / totalExpenses) * 300);

            lblPercentageGroceries.Text = $"{Math.Round((groceriesExpenses / totalExpenses) * 100)}%";
            lblPercentageTransportation.Text = $"{Math.Round((transportationExpenses / totalExpenses) * 100)}%";
            lblPercentageMedical.Text = $"{Math.Round((medicalExpenses / totalExpenses) * 100)}%";
            lblPercentageRent.Text = $"{Math.Round((rentExpenses / totalExpenses) * 100)}%";
            lblPercentageInsurance.Text = $"{Math.Round((insuranceExpenses / totalExpenses) * 100)}%";
            lblPercentageEntertainment.Text = $"{Math.Round((entertainmentExpenses / totalExpenses) * 100)}%";
            lblPercentageSavings.Text = $"{Math.Round((savingsExpenses / totalExpenses) * 100)}%";
            lblPercentageInvestment.Text = $"{Math.Round((investmentExpenses / totalExpenses) * 100)}%";
            lblPercentageOther.Text = $"{Math.Round((otherExpenses / totalExpenses) * 100)}%";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvExpenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvExpenses.Rows[e.RowIndex];
            Expense expense = row.DataBoundItem as Expense;
            var editForm = new EditExpenseForm(currentUser, expense);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                editForm.Close();
            }
            dbContext = new DataBaseContext();
            int selectedIndex = dgvExpenses.CurrentRow?.Index ?? -1;
            updateData();

            if (selectedIndex >= 0 && selectedIndex < dgvExpenses.Rows.Count)
            {
                dgvExpenses.CurrentCell = dgvExpenses.Rows[selectedIndex].Cells[0];
                dgvExpenses.Rows[selectedIndex].Selected = true;
            }
        }

        private void cbFilterExpense_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterExpense.SelectedItem == "*All")
            {
                dgvExpenses.DataSource = dbContext.Expenses.Where(e => e.user_id == currentUser.Id).ToList();
                lblTotalExpenses.Text = $"Total expenses: {dbContext.Expenses.Where(e => e.user_id == currentUser.Id).Sum(e => e.amount)}"; ;
            }
            else
            {
                dgvExpenses.DataSource = dbContext.Expenses.Where(e => e.user_id == currentUser.Id).Where(e => e.expenseCategory.category_name == cbFilterExpense.SelectedItem).ToList();
                lblTotalExpenses.Text = $"{cbFilterExpense.SelectedItem} expenses: {dbContext.Expenses.Where(e=>e.user_id == currentUser.Id).Where(e=>e.expenseCategory.category_name == cbFilterExpense.SelectedItem).Sum(e=>e.amount)}";
            }
            foreach (DataGridViewRow row in dgvExpenses.Rows)
            {
                Expense expense = row.DataBoundItem as Expense;
                ExpenseCategory eCategory = dbContext.ExpenseCategories.Where(e => e.id == expense.expenseCategory_id).FirstOrDefault();
                row.Cells[0].Value = eCategory.category_name;
                row.Cells[1].Value = expense.amount;
                row.Cells[2].Value = expense.description;
            }

        }
    }
}
