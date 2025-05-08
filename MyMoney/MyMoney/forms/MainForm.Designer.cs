namespace MyMoney.forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnAddExpense = new Button();
            lblWelcome = new Label();
            lblTotalExpenses = new Label();
            dgvExpenses = new DataGridView();
            Expense = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            label1 = new Label();
            Groceries = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtGroceries = new TextBox();
            txtTransportation = new TextBox();
            txtMedical = new TextBox();
            txtRent = new TextBox();
            txtInsurance = new TextBox();
            txtEntertainment = new TextBox();
            txtSavings = new TextBox();
            txtOther = new TextBox();
            txtInvestment = new TextBox();
            lblPercentageGroceries = new Label();
            lblPercentageTransportation = new Label();
            lblPercentageMedical = new Label();
            lblPercentageRent = new Label();
            lblPercentageInsurance = new Label();
            lblPercentageEntertainment = new Label();
            lblPercentageSavings = new Label();
            lblPercentageInvestment = new Label();
            lblPercentageOther = new Label();
            cbFilterExpense = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // btnAddExpense
            // 
            btnAddExpense.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddExpense.BackColor = Color.Transparent;
            btnAddExpense.Font = new Font("WarHeliosCondCBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddExpense.Location = new Point(26, 421);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(133, 23);
            btnAddExpense.TabIndex = 0;
            btnAddExpense.Text = "ADD EXPENSE";
            btnAddExpense.UseVisualStyleBackColor = false;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.WindowFrame;
            lblWelcome.Location = new Point(26, 21);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 21);
            lblWelcome.TabIndex = 1;
            // 
            // lblTotalExpenses
            // 
            lblTotalExpenses.AutoSize = true;
            lblTotalExpenses.BackColor = Color.Transparent;
            lblTotalExpenses.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalExpenses.ForeColor = SystemColors.Highlight;
            lblTotalExpenses.Location = new Point(26, 85);
            lblTotalExpenses.Name = "lblTotalExpenses";
            lblTotalExpenses.Size = new Size(0, 20);
            lblTotalExpenses.TabIndex = 2;
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AllowUserToDeleteRows = false;
            dgvExpenses.BackgroundColor = SystemColors.WindowFrame;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Columns.AddRange(new DataGridViewColumn[] { Expense, amount, description });
            dgvExpenses.GridColor = SystemColors.GradientActiveCaption;
            dgvExpenses.Location = new Point(26, 108);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.RowHeadersVisible = false;
            dgvExpenses.Size = new Size(390, 308);
            dgvExpenses.TabIndex = 3;
            dgvExpenses.CellDoubleClick += dgvExpenses_CellDoubleClick;
            // 
            // Expense
            // 
            Expense.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Expense.DefaultCellStyle = dataGridViewCellStyle1;
            Expense.HeaderText = "Expense";
            Expense.Name = "Expense";
            Expense.ReadOnly = true;
            // 
            // amount
            // 
            dataGridViewCellStyle2.Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amount.DefaultCellStyle = dataGridViewCellStyle2;
            amount.HeaderText = "Amount($)";
            amount.Name = "amount";
            amount.ReadOnly = true;
            // 
            // description
            // 
            dataGridViewCellStyle3.Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.DefaultCellStyle = dataGridViewCellStyle3;
            description.HeaderText = "Description";
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("WarHeliosCondCBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(607, 61);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 4;
            label1.Text = "Expenses chart";
            // 
            // Groceries
            // 
            Groceries.AutoSize = true;
            Groceries.BackColor = Color.Transparent;
            Groceries.Font = new Font("WarHeliosCondCBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Groceries.ForeColor = SystemColors.Highlight;
            Groceries.Location = new Point(467, 128);
            Groceries.Name = "Groceries";
            Groceries.Size = new Size(67, 18);
            Groceries.TabIndex = 4;
            Groceries.Text = "Groceries:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("WarHeliosCondCBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(467, 156);
            label2.Name = "label2";
            label2.Size = new Size(96, 18);
            label2.TabIndex = 4;
            label2.Text = "Transportation:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("WarHeliosCondCBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(467, 184);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 4;
            label3.Text = "Medical:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("WarHeliosCondCBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.CadetBlue;
            label4.Location = new Point(467, 212);
            label4.Name = "label4";
            label4.Size = new Size(97, 18);
            label4.TabIndex = 4;
            label4.Text = "Rent/Mortgage:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("WarHeliosCondCBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(467, 240);
            label5.Name = "label5";
            label5.Size = new Size(69, 18);
            label5.TabIndex = 4;
            label5.Text = "Insurance:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("WarHeliosCondCBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.CornflowerBlue;
            label6.Location = new Point(467, 268);
            label6.Name = "label6";
            label6.Size = new Size(90, 18);
            label6.TabIndex = 4;
            label6.Text = "Entertainment:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("WarHeliosCondCBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(467, 298);
            label7.Name = "label7";
            label7.Size = new Size(57, 18);
            label7.TabIndex = 4;
            label7.Text = "Savings:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("WarHeliosCondCBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DodgerBlue;
            label8.Location = new Point(467, 325);
            label8.Name = "label8";
            label8.Size = new Size(71, 18);
            label8.TabIndex = 4;
            label8.Text = "Invesment:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("WarHeliosCondCBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkCyan;
            label9.Location = new Point(467, 354);
            label9.Name = "label9";
            label9.Size = new Size(42, 18);
            label9.TabIndex = 4;
            label9.Text = "Other:";
            // 
            // txtGroceries
            // 
            txtGroceries.BackColor = SystemColors.Highlight;
            txtGroceries.Location = new Point(593, 133);
            txtGroceries.Multiline = true;
            txtGroceries.Name = "txtGroceries";
            txtGroceries.ReadOnly = true;
            txtGroceries.Size = new Size(100, 12);
            txtGroceries.TabIndex = 5;
            // 
            // txtTransportation
            // 
            txtTransportation.BackColor = SystemColors.ActiveCaption;
            txtTransportation.Location = new Point(593, 161);
            txtTransportation.Multiline = true;
            txtTransportation.Name = "txtTransportation";
            txtTransportation.ReadOnly = true;
            txtTransportation.Size = new Size(100, 12);
            txtTransportation.TabIndex = 5;
            // 
            // txtMedical
            // 
            txtMedical.BackColor = SystemColors.GradientActiveCaption;
            txtMedical.Location = new Point(593, 189);
            txtMedical.Multiline = true;
            txtMedical.Name = "txtMedical";
            txtMedical.ReadOnly = true;
            txtMedical.Size = new Size(100, 12);
            txtMedical.TabIndex = 5;
            // 
            // txtRent
            // 
            txtRent.BackColor = Color.CadetBlue;
            txtRent.ForeColor = Color.CadetBlue;
            txtRent.Location = new Point(593, 217);
            txtRent.Multiline = true;
            txtRent.Name = "txtRent";
            txtRent.ReadOnly = true;
            txtRent.Size = new Size(100, 12);
            txtRent.TabIndex = 5;
            // 
            // txtInsurance
            // 
            txtInsurance.BackColor = Color.SteelBlue;
            txtInsurance.Location = new Point(593, 245);
            txtInsurance.Multiline = true;
            txtInsurance.Name = "txtInsurance";
            txtInsurance.ReadOnly = true;
            txtInsurance.Size = new Size(100, 12);
            txtInsurance.TabIndex = 5;
            // 
            // txtEntertainment
            // 
            txtEntertainment.BackColor = Color.CornflowerBlue;
            txtEntertainment.Location = new Point(593, 273);
            txtEntertainment.Multiline = true;
            txtEntertainment.Name = "txtEntertainment";
            txtEntertainment.ReadOnly = true;
            txtEntertainment.Size = new Size(100, 12);
            txtEntertainment.TabIndex = 5;
            // 
            // txtSavings
            // 
            txtSavings.BackColor = Color.RoyalBlue;
            txtSavings.Location = new Point(593, 302);
            txtSavings.Multiline = true;
            txtSavings.Name = "txtSavings";
            txtSavings.ReadOnly = true;
            txtSavings.Size = new Size(100, 12);
            txtSavings.TabIndex = 5;
            // 
            // txtOther
            // 
            txtOther.BackColor = Color.DarkCyan;
            txtOther.Location = new Point(593, 357);
            txtOther.Multiline = true;
            txtOther.Name = "txtOther";
            txtOther.ReadOnly = true;
            txtOther.Size = new Size(100, 12);
            txtOther.TabIndex = 5;
            // 
            // txtInvestment
            // 
            txtInvestment.BackColor = Color.DodgerBlue;
            txtInvestment.Location = new Point(593, 328);
            txtInvestment.Multiline = true;
            txtInvestment.Name = "txtInvestment";
            txtInvestment.ReadOnly = true;
            txtInvestment.Size = new Size(100, 12);
            txtInvestment.TabIndex = 5;
            // 
            // lblPercentageGroceries
            // 
            lblPercentageGroceries.AutoSize = true;
            lblPercentageGroceries.BackColor = Color.Transparent;
            lblPercentageGroceries.Font = new Font("WarHeliosCondCBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentageGroceries.ForeColor = SystemColors.Highlight;
            lblPercentageGroceries.Location = new Point(563, 132);
            lblPercentageGroceries.Name = "lblPercentageGroceries";
            lblPercentageGroceries.Size = new Size(33, 14);
            lblPercentageGroceries.TabIndex = 4;
            lblPercentageGroceries.Text = "100%";
            // 
            // lblPercentageTransportation
            // 
            lblPercentageTransportation.AutoSize = true;
            lblPercentageTransportation.BackColor = Color.Transparent;
            lblPercentageTransportation.Font = new Font("WarHeliosCondCBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentageTransportation.ForeColor = SystemColors.ActiveCaption;
            lblPercentageTransportation.Location = new Point(563, 160);
            lblPercentageTransportation.Name = "lblPercentageTransportation";
            lblPercentageTransportation.Size = new Size(33, 14);
            lblPercentageTransportation.TabIndex = 4;
            lblPercentageTransportation.Text = "100%";
            // 
            // lblPercentageMedical
            // 
            lblPercentageMedical.AutoSize = true;
            lblPercentageMedical.BackColor = Color.Transparent;
            lblPercentageMedical.Font = new Font("WarHeliosCondCBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentageMedical.ForeColor = SystemColors.GradientActiveCaption;
            lblPercentageMedical.Location = new Point(563, 188);
            lblPercentageMedical.Name = "lblPercentageMedical";
            lblPercentageMedical.Size = new Size(33, 14);
            lblPercentageMedical.TabIndex = 4;
            lblPercentageMedical.Text = "100%";
            // 
            // lblPercentageRent
            // 
            lblPercentageRent.AutoSize = true;
            lblPercentageRent.BackColor = Color.Transparent;
            lblPercentageRent.Font = new Font("WarHeliosCondCBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentageRent.ForeColor = Color.CadetBlue;
            lblPercentageRent.Location = new Point(563, 217);
            lblPercentageRent.Name = "lblPercentageRent";
            lblPercentageRent.Size = new Size(33, 14);
            lblPercentageRent.TabIndex = 4;
            lblPercentageRent.Text = "100%";
            // 
            // lblPercentageInsurance
            // 
            lblPercentageInsurance.AutoSize = true;
            lblPercentageInsurance.BackColor = Color.Transparent;
            lblPercentageInsurance.Font = new Font("WarHeliosCondCBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentageInsurance.ForeColor = Color.SteelBlue;
            lblPercentageInsurance.Location = new Point(563, 243);
            lblPercentageInsurance.Name = "lblPercentageInsurance";
            lblPercentageInsurance.Size = new Size(33, 14);
            lblPercentageInsurance.TabIndex = 4;
            lblPercentageInsurance.Text = "100%";
            // 
            // lblPercentageEntertainment
            // 
            lblPercentageEntertainment.AutoSize = true;
            lblPercentageEntertainment.BackColor = Color.Transparent;
            lblPercentageEntertainment.Font = new Font("WarHeliosCondCBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentageEntertainment.ForeColor = Color.CornflowerBlue;
            lblPercentageEntertainment.Location = new Point(563, 273);
            lblPercentageEntertainment.Name = "lblPercentageEntertainment";
            lblPercentageEntertainment.Size = new Size(33, 14);
            lblPercentageEntertainment.TabIndex = 4;
            lblPercentageEntertainment.Text = "100%";
            // 
            // lblPercentageSavings
            // 
            lblPercentageSavings.AutoSize = true;
            lblPercentageSavings.BackColor = Color.Transparent;
            lblPercentageSavings.Font = new Font("WarHeliosCondCBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentageSavings.ForeColor = Color.RoyalBlue;
            lblPercentageSavings.Location = new Point(563, 300);
            lblPercentageSavings.Name = "lblPercentageSavings";
            lblPercentageSavings.Size = new Size(33, 14);
            lblPercentageSavings.TabIndex = 4;
            lblPercentageSavings.Text = "100%";
            // 
            // lblPercentageInvestment
            // 
            lblPercentageInvestment.AutoSize = true;
            lblPercentageInvestment.BackColor = Color.Transparent;
            lblPercentageInvestment.Font = new Font("WarHeliosCondCBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentageInvestment.ForeColor = Color.DodgerBlue;
            lblPercentageInvestment.Location = new Point(563, 326);
            lblPercentageInvestment.Name = "lblPercentageInvestment";
            lblPercentageInvestment.Size = new Size(33, 14);
            lblPercentageInvestment.TabIndex = 4;
            lblPercentageInvestment.Text = "100%";
            // 
            // lblPercentageOther
            // 
            lblPercentageOther.AutoSize = true;
            lblPercentageOther.BackColor = Color.Transparent;
            lblPercentageOther.Font = new Font("WarHeliosCondCBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentageOther.ForeColor = Color.DarkCyan;
            lblPercentageOther.Location = new Point(563, 355);
            lblPercentageOther.Name = "lblPercentageOther";
            lblPercentageOther.Size = new Size(33, 14);
            lblPercentageOther.TabIndex = 4;
            lblPercentageOther.Text = "100%";
            // 
            // cbFilterExpense
            // 
            cbFilterExpense.FormattingEnabled = true;
            cbFilterExpense.Items.AddRange(new object[] { "*All", "Groceries", "Transportation", "Medical", "Rent/Mortgage", "Insurance", "Entertainment", "Savings", "Investment", "Other" });
            cbFilterExpense.Location = new Point(303, 421);
            cbFilterExpense.Name = "cbFilterExpense";
            cbFilterExpense.Size = new Size(113, 23);
            cbFilterExpense.TabIndex = 6;
            cbFilterExpense.SelectedIndexChanged += cbFilterExpense_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(915, 547);
            Controls.Add(cbFilterExpense);
            Controls.Add(txtInvestment);
            Controls.Add(txtOther);
            Controls.Add(txtSavings);
            Controls.Add(txtEntertainment);
            Controls.Add(txtInsurance);
            Controls.Add(txtRent);
            Controls.Add(txtMedical);
            Controls.Add(txtTransportation);
            Controls.Add(txtGroceries);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblPercentageOther);
            Controls.Add(lblPercentageInvestment);
            Controls.Add(lblPercentageSavings);
            Controls.Add(lblPercentageEntertainment);
            Controls.Add(lblPercentageInsurance);
            Controls.Add(lblPercentageRent);
            Controls.Add(lblPercentageMedical);
            Controls.Add(lblPercentageTransportation);
            Controls.Add(lblPercentageGroceries);
            Controls.Add(Groceries);
            Controls.Add(label1);
            Controls.Add(dgvExpenses);
            Controls.Add(lblTotalExpenses);
            Controls.Add(lblWelcome);
            Controls.Add(btnAddExpense);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyMoney";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddExpense;
        private Label lblWelcome;
        private Label lblTotalExpenses;
        private DataGridView dgvExpenses;
        private Label label1;
        private Label Groceries;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtGroceries;
        private TextBox txtTransportation;
        private TextBox txtMedical;
        private TextBox txtRent;
        private TextBox txtInsurance;
        private TextBox txtEntertainment;
        private TextBox txtSavings;
        private TextBox txtOther;
        private TextBox txtInvestment;
        private DataGridViewTextBoxColumn Expense;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn description;
        private Label lblPercentageGroceries;
        private Label lblPercentageTransportation;
        private Label lblPercentageMedical;
        private Label lblPercentageRent;
        private Label lblPercentageInsurance;
        private Label lblPercentageEntertainment;
        private Label lblPercentageSavings;
        private Label lblPercentageInvestment;
        private Label lblPercentageOther;
        private ComboBox cbFilterExpense;
    }
}