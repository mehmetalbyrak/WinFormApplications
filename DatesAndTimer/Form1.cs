namespace DatesAndTimer
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        DateTime today;
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            timTime.Enabled = true;

        }


        // for timer
        private void timTime_Tick(object sender, EventArgs e)
        {

            today = DateTime.Now;

            lblDayOfWeek.Text = today.DayOfWeek.ToString();
            lblMonth.Text = today.ToString("MMMM");
            lblYear.Text = today.Year.ToString();
            lblDayNumberOfMonth.Text = today.Day.ToString();

            lblTime.Text = today.ToLongTimeString();
        }
    }
}
