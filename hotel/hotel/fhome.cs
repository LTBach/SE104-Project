namespace hotel
{
    public partial class fhome : Form
    {
        public fhome()
        {
            InitializeComponent();
            btn_intro.TabStop = false;
            btn_intro.FlatStyle = FlatStyle.Flat;
            btn_intro.FlatAppearance.BorderSize = 0;
        }
        
        private void btn_intro_Click(object sender, EventArgs e)
        {
            freview rv = new freview();
            rv.Show();
        }

        private void btn_catalog_Click(object sender, EventArgs e)
        {
            fcatalog f2 = new fcatalog();
            f2.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            fsearch f3 = new fsearch();
            f3.Show();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            fbill f5 = new fbill();
            f5.Show();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            freport f6 = new freport();
            f6.Show();
        }
    }
}