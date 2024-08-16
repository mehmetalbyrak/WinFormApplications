namespace BankAccount
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double monthlyDeposit = Convert.ToDouble(txtMonthlyDeposit.Text);
            double yearlyInterest = Convert.ToDouble(txtYearlyInterest.Text);
            int numberOfMonths = Convert.ToInt32(txtNumberOfMonths.Text);

            double monthlyInterestRate = yearlyInterest / 100 / 12;
            double finalBalance = monthlyDeposit * ((Math.Pow(1 + monthlyInterestRate, numberOfMonths) - 1) / monthlyInterestRate);

            txtFinalBalance.Text = finalBalance.ToString("F2");
        }

        private void btnClearBoxes_Click(object sender, EventArgs e)
        {
            txtMonthlyDeposit.Clear();
            txtYearlyInterest.Clear();
            txtNumberOfMonths.Clear();

            txtFinalBalance.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
