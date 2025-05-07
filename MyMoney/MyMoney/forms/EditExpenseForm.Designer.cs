namespace MyMoney.forms
{
    partial class EditExpenseForm
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
            txtDescription = new TextBox();
            btnSaveChanges = new Button();
            label3 = new Label();
            label2 = new Label();
            numAmount = new NumericUpDown();
            label1 = new Label();
            cbExpenseCategory = new ComboBox();
            btnExit = new Button();
            btnDeleteExpense = new Button();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(17, 138);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(337, 176);
            txtDescription.TabIndex = 13;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(37, 332);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(131, 35);
            btnSaveChanges.TabIndex = 12;
            btnSaveChanges.Text = "Save changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(139, 120);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 10;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(117, 74);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 11;
            label2.Text = "Amount of money($):";
            // 
            // numAmount
            // 
            numAmount.Location = new Point(95, 92);
            numAmount.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(153, 23);
            numAmount.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(124, 19);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 8;
            label1.Text = "Expense category";
            // 
            // cbExpenseCategory
            // 
            cbExpenseCategory.FormattingEnabled = true;
            cbExpenseCategory.Location = new Point(95, 37);
            cbExpenseCategory.Name = "cbExpenseCategory";
            cbExpenseCategory.Size = new Size(153, 23);
            cbExpenseCategory.TabIndex = 7;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LimeGreen;
            btnExit.BackgroundImage = Properties.Resources.mainBackground;
            btnExit.BackgroundImageLayout = ImageLayout.Center;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(325, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 32);
            btnExit.TabIndex = 18;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDeleteExpense
            // 
            btnDeleteExpense.BackColor = Color.Firebrick;
            btnDeleteExpense.Cursor = Cursors.Hand;
            btnDeleteExpense.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteExpense.ForeColor = SystemColors.ButtonFace;
            btnDeleteExpense.Location = new Point(203, 332);
            btnDeleteExpense.Name = "btnDeleteExpense";
            btnDeleteExpense.Size = new Size(131, 35);
            btnDeleteExpense.TabIndex = 19;
            btnDeleteExpense.Text = "DELETE EXPENSE";
            btnDeleteExpense.UseVisualStyleBackColor = false;
            btnDeleteExpense.Click += btnDeleteExpense_Click;
            // 
            // EditExpenseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(369, 390);
            Controls.Add(btnDeleteExpense);
            Controls.Add(btnExit);
            Controls.Add(txtDescription);
            Controls.Add(btnSaveChanges);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numAmount);
            Controls.Add(label1);
            Controls.Add(cbExpenseCategory);
            Name = "EditExpenseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditExpenseForm";
            Load += EditExpenseForm_Load;
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private Button btnSaveChanges;
        private Label label3;
        private Label label2;
        private NumericUpDown numAmount;
        private Label label1;
        private ComboBox cbExpenseCategory;
        private Button btnExit;
        private Button btnDeleteExpense;
    }
}