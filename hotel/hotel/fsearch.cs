using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class fsearch : Form
    {
        public fsearch()
        {
            InitializeComponent();
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            //kiem tra phong trong!!!
            freserve reserve = new freserve();
            reserve.Show();
        }
    }
}
