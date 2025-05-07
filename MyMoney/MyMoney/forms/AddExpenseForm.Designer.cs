namespace MyMoney.forms
{
    partial class AddExpenseForm
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
            cbExpenseCategory = new ComboBox();
            label1 = new Label();
            numAmount = new NumericUpDown();
            label2 = new Label();
            btnAddExpense = new Button();
            txtDescription = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // cbExpenseCategory
            // 
            cbExpenseCategory.FormattingEnabled = true;
            cbExpenseCategory.Location = new Point(94, 38);
            cbExpenseCategory.Name = "cbExpenseCategory";
            cbExpenseCategory.Size = new Size(153, 23);
            cbExpenseCategory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(123, 20);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Expense category";
            // 
            // numAmount
            // 
            numAmount.Location = new Point(94, 93);
            numAmount.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(153, 23);
            numAmount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(116, 75);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 4;
            label2.Text = "Amount of money($):";
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(116, 336);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(131, 35);
            btnAddExpense.TabIndex = 5;
            btnAddExpense.Text = "Add expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(16, 139);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(337, 176);
            txtDescription.TabIndex = 6;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(138, 121);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Description:";
            // 
            // AddExpenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(365, 383);
            Controls.Add(txtDescription);
            Controls.Add(btnAddExpense);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numAmount);
            Controls.Add(label1);
            Controls.Add(cbExpenseCategory);
            Name = "AddExpenseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddExpense";
            Load += AddExpenseForm_Load;
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbExpenseCategory;
        private Label label1;
        private NumericUpDown numAmount;
        private Label label2;
        private Button btnAddExpense;
        private TextBox txtDescription;
        private Label label3;
    }
}