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
            btnAddExpense = new Button();
            lblWelcome = new Label();
            lblTotalExpenses = new Label();
            SuspendLayout();
            // 
            // btnAddExpense
            // 
            btnAddExpense.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddExpense.BackColor = Color.Transparent;
            btnAddExpense.Font = new Font("WarHeliosCondCBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddExpense.Location = new Point(148, 422);
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
            lblWelcome.ForeColor = SystemColors.Highlight;
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
            lblTotalExpenses.ForeColor = Color.IndianRed;
            lblTotalExpenses.Location = new Point(12, 114);
            lblTotalExpenses.Name = "lblTotalExpenses";
            lblTotalExpenses.Size = new Size(0, 20);
            lblTotalExpenses.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(915, 538);
            Controls.Add(lblTotalExpenses);
            Controls.Add(lblWelcome);
            Controls.Add(btnAddExpense);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddExpense;
        private Label lblWelcome;
        private Label lblTotalExpenses;
    }
}