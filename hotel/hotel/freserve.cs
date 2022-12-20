using hotel.MDphong;
using hotel.PhieuThue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotel
{
    public partial class freserve : Form
    {
        static string path = "Data Source=LAPTOP-1DM2B00F;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True";
        public freserve()
        {
            InitializeComponent();
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.Write(dataGridView1.ColumnCount);
            //MessageBox.Show(dataGridView1.ColumnCount);
        }

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            KhachHang newrow = new KhachHang();
            newrow.cmnd = txtNational_ID.Text;
            newrow.diachi = txtAddress.Text;
            newrow.tenKH = txtName.Text;
            newrow.loaiKH = "cc";
            if (newrow.notEmpty())
            {
                khachHangBindingSource.Add(newrow);
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
            else
                MessageBox.Show("Khach hang phai co day du thong tin", "Error");
            
            
            //dataGridView1.Rows.Add(newRow);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNational_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
