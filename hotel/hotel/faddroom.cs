using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hotel
{
    public partial class faddroom : Form
    {
        SqlExecuter exc = new SqlExecuter();
        public faddroom()
        {
            InitializeComponent();
            try
            {
                DataTable dt = exc.executeQuery("SELECT TenLoaiPhong FROM LOAIPHONG");
                foreach (DataRow row in dt.Rows)
                {
                    cbbRoomType.Items.Add(row["TenLoaiPhong"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbRoomType.SelectedIndex == null || txtRoomName.Text == "")
            {
                MessageBox.Show("Please fill in the blank");
            } 
            else
            {
                try {
                    string roomType = cbbRoomType.SelectedItem.ToString();

                    DataTable dt = exc.executeQuery("SELECT * FROM ID");
                    string roomId = dt.Rows[0]["MaPhong"].ToString();

                    dt = exc.executeQuery("SELECT MaLoaiPhong FROM LOAIPHONG WHERE TenLoaiPhong = '" + roomType + "'");
                    string roomTypeId = dt.Rows[0]["MaLoaiPhong"].ToString();

                    exc.executeNonQuery("INSERT INTO DANHMUCPHONG VALUES('" + roomId + "','" + txtRoomName.Text + "','Khong','" + roomTypeId + "','" + txtNote.Text + "')");

                    roomId = (Convert.ToInt32(roomId)+1).ToString();
                    //exc.executeNonQuery("UPDATE ")
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
