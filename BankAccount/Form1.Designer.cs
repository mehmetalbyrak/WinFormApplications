namespace BankAccount
{
    partial class frmMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMonthlyDeposit = new Label();
            lblYearlyInterest = new Label();
            lblNumberOfMonths = new Label();
            lblFinalBalance = new Label();
            txtMonthlyDeposit = new TextBox();
            txtYearlyInterest = new TextBox();
            txtNumberOfMonths = new TextBox();
            txtFinalBalance = new TextBox();
            btnCalculate = new Button();
            btnClearBoxes = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblMonthlyDeposit
            // 
            lblMonthlyDeposit.AutoSize = true;
            lblMonthlyDeposit.Location = new Point(202, 66);
            lblMonthlyDeposit.Name = "lblMonthlyDeposit";
            lblMonthlyDeposit.Size = new Size(95, 15);
            lblMonthlyDeposit.TabIndex = 0;
            lblMonthlyDeposit.Text = "Monthly Deposit";
            // 
            // lblYearlyInterest
            // 
            lblYearlyInterest.AutoSize = true;
            lblYearlyInterest.Location = new Point(202, 108);
            lblYearlyInterest.Name = "lblYearlyInterest";
            lblYearlyInterest.Size = new Size(80, 15);
            lblYearlyInterest.TabIndex = 1;
            lblYearlyInterest.Text = "Yearly Interest";
            // 
            // lblNumberOfMonths
            // 
            lblNumberOfMonths.AutoSize = true;
            lblNumberOfMonths.Location = new Point(202, 148);
            lblNumberOfMonths.Name = "lblNumberOfMonths";
            lblNumberOfMonths.Size = new Size(111, 15);
            lblNumberOfMonths.TabIndex = 2;
            lblNumberOfMonths.Text = "Number Of Months";
            // 
            // lblFinalBalance
            // 
            lblFinalBalance.AutoSize = true;
            lblFinalBalance.Location = new Point(202, 194);
            lblFinalBalance.Name = "lblFinalBalance";
            lblFinalBalance.Size = new Size(76, 15);
            lblFinalBalance.TabIndex = 3;
            lblFinalBalance.Text = "Final Balance";
            // 
            // txtMonthlyDeposit
            // 
            txtMonthlyDeposit.Location = new Point(316, 63);
            txtMonthlyDeposit.Name = "txtMonthlyDeposit";
            txtMonthlyDeposit.Size = new Size(117, 23);
            txtMonthlyDeposit.TabIndex = 4;
            // 
            // txtYearlyInterest
            // 
            txtYearlyInterest.Location = new Point(316, 100);
            txtYearlyInterest.Name = "txtYearlyInterest";
            txtYearlyInterest.Size = new Size(117, 23);
            txtYearlyInterest.TabIndex = 5;
            // 
            // txtNumberOfMonths
            // 
            txtNumberOfMonths.Location = new Point(316, 140);
            txtNumberOfMonths.Name = "txtNumberOfMonths";
            txtNumberOfMonths.Size = new Size(117, 23);
            txtNumberOfMonths.TabIndex = 6;
            // 
            // txtFinalBalance
            // 
            txtFinalBalance.Location = new Point(316, 186);
            txtFinalBalance.Name = "txtFinalBalance";
            txtFinalBalance.Size = new Size(117, 23);
            txtFinalBalance.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(202, 244);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(84, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClearBoxes
            // 
            btnClearBoxes.Location = new Point(316, 244);
            btnClearBoxes.Name = "btnClearBoxes";
            btnClearBoxes.Size = new Size(117, 23);
            btnClearBoxes.TabIndex = 9;
            btnClearBoxes.Text = "Clear Boxes";
            btnClearBoxes.UseVisualStyleBackColor = true;
            btnClearBoxes.Click += btnClearBoxes_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(202, 290);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(231, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClearBoxes);
            Controls.Add(btnCalculate);
            Controls.Add(txtFinalBalance);
            Controls.Add(txtNumberOfMonths);
            Controls.Add(txtYearlyInterest);
            Controls.Add(txtMonthlyDeposit);
            Controls.Add(lblFinalBalance);
            Controls.Add(lblNumberOfMonths);
            Controls.Add(lblYearlyInterest);
            Controls.Add(lblMonthlyDeposit);
            Name = "frmMainForm";
            Text = "Bank Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonthlyDeposit;
        private Label lblYearlyInterest;
        private Label lblNumberOfMonths;
        private Label lblFinalBalance;
        private TextBox txtMonthlyDeposit;
        private TextBox txtYearlyInterest;
        private TextBox txtNumberOfMonths;
        private TextBox txtFinalBalance;
        private Button btnCalculate;
        private Button btnClearBoxes;
        private Button btnExit;
    }
}
