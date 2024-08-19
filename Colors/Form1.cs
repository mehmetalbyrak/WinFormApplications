namespace Colors
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Colors colors = new Colors("blue", 7);
            Colors colors2 = new Colors();

            colors2.ColorType = "yellow";
            colors2.ColorBrightness = 5;

            SpecialColors specialColors = new SpecialColors();
            specialColors.ColorType = "WHITE";
            specialColors.ColorBrightness = 7;
            specialColors.SpecialBrightness = 11;

            txtColors.Text = colors.DescribeColor();
            txtColors.Text += colors2.DescribeColor();

            txtColors.Text += colors.CompareColors();
            txtColors.Text += colors2.CompareColors();

            txtColors.Text += specialColors.DescribeColor();
            txtColors.Text += specialColors.DescribeColor();
        }
    }
}
