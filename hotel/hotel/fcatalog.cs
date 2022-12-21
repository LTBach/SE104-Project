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
using System.Runtime.Intrinsics.Arm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hotel
{
    public partial class fcatalog : Form
    {
        static string path = "Data Source=LAPTOP-SJIHJC72\\SQL2022;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public fcatalog()
        {
            InitializeComponent();
            try
            {
                con = new SqlConnection(path);
                dt = new DataTable();
                cbbStatus.Items.Add("Co nguoi");
                cbbStatus.Items.Add("Khong");
                con.Open();
                adpt = new SqlDataAdapter("SELECT TenLoaiPhong FROM LOAIPHONG", con);
                adpt.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    cbbRoomType.Items.Add(row["TenLoaiPhong"].ToString());
                }
                con.Close();
                showTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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


        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            try
            {
                string Status = "";
                if (cbbStatus.SelectedItem != null) Status = cbbStatus.SelectedItem.ToString();

                string RoomType = "";
                if (cbbRoomType.SelectedItem != null) RoomType = cbbRoomType.SelectedItem.ToString();

                string Price = "0";
                if (txtPrice.Text != "") Price = txtPrice.Text;

                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select tenphong, tenloaiphong, dongiaTC, ghichu from loaiphong lp, danhmucphong dmp " +
                    "where lp.MaLoaiPhong = dmp.MaLoaiPhong and tenphong like '" + txtRoomName.Text + "%' and tenloaiphong like '"
                    + RoomType + "%' and dongiaTC > " + Price + " and tinhtrang like '" + Status + "%'", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
