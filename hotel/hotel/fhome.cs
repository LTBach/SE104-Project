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
            fcatalog ctl = new fcatalog();
            ctl.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            fsearch se = new fsearch();
            se.Show();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            fbill bill = new fbill();
            bill.Show();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            freport rp = new freport();
            rp.Show();
        }

        private void btn_adjust_Click(object sender, EventArgs e)
        {
            frules rl = new frules();
            rl.Show();
        }
    }
}
