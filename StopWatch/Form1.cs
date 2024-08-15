namespace StopWatch
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }


        DateTime start;
        DateTime stop;
        TimeSpan elapsedTime;
        private void btnStart_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            txtStart.Text = start.ToLongTimeString();
            txtEnd.Text = "";
            txtElapsed.Text = "";

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = DateTime.Now;
            txtEnd.Text = stop.ToLongTimeString();
            elapsedTime = stop - start;
            txtElapsed.Text = elapsedTime.Seconds.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
