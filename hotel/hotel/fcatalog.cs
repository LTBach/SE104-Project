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
    public partial class fcatalog : Form
    {
        static string path = "Data Source=LAPTOP-1DM2B00F;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public fcatalog()
        {
            con = new SqlConnection(path);
            InitializeComponent();
            //cbbStatus.Items.Add("Empty");
            //cbbStatus.Items.Add("Occupied");
            con.Open();
            dt = new DataTable();
            adpt = new SqlDataAdapter("SELECT MaLoaiPhong FROM LOAIPHONG", con);
            adpt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                //TextBox1.Text = row["ImagePath"].ToString();
                cbbRoomType.Items.Add(row["MaLoaiPhong"].ToString());
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_room_Click(object sender, EventArgs e)
        {
            faddroom newroom = new faddroom();
            newroom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
