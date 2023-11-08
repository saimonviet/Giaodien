using GiaoDien_qlpks.DAO;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace GiaoDien_qlpks
{
    public partial class checkout : Form
    {

        public checkout()
        {
            InitializeComponent();
            loadthanhtoanlist();
        }
        void loadthanhtoanlist()
        {

            string query = "SELECT [dbo].[Table.KHACHHANG].MAKHACHHANG, [dbo].[Table.KHACHHANG].TENKHACHHANG, [dbo].[Table.KHACHHANG].CCCD,  [dbo].[Table.KHACHHANG].SĐT, [dbo].[Table_DATPHONG].NGAYDAT, [dbo].[Table_DATPHONG].NGAYTRA " +
                                    "FROM [dbo].[Table.KHACHHANG] " +
                                    "INNER JOIN [dbo].[Table_DATPHONG] ON [dbo].[Table.KHACHHANG].MAKHACHHANG = [dbo].[Table_DATPHONG].MAKHACHHANG";
            DataProvider provider = new DataProvider();
            dataGridView1.DataSource = provider.ExecuteQuery(query);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void tienphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Timkiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT [dbo].[Table.KHACHHANG].MAKHACHHANG, [dbo].[Table.KHACHHANG].TENKHACHHANG, [dbo].[Table.KHACHHANG].CCCD,  [dbo].[Table.KHACHHANG].SĐT, [dbo].[Table_DATPHONG].NGAYDAT, [dbo].[Table_DATPHONG].NGAYTRA " +
                                    "FROM [dbo].[Table.KHACHHANG]"+
                                    "INNER JOIN [dbo].[Table_DATPHONG] ON [dbo].[Table.KHACHHANG].MAKHACHHANG = [dbo].[Table_DATPHONG].MAKHACHHANG WHERE([dbo].[Table.KHACHHANG].SOPHONG like '%" + tbsophong.Text + "%')";
            DataProvider provider = new DataProvider();
            dataGridView1.DataSource = provider.ExecuteQuery(query);
        }
        private void Tongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void Thanhtoan_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textsophong_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttenkhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabthanhtoan_Click(object sender, EventArgs e)
        {

        }

        private void tiendichvu_TextChanged(object sender, EventArgs e)
        {

        }

        private void songayluutru_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbsophong_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            string query = "SELECT [dbo].[Table.KHACHHANG].TENKHACHHANG, DATEDIFF(DAY, [dbo].[Table_DATPHONG].NGAYDAT, [dbo].[Table_DATPHONG].NGAYTRA) ,  DATEDIFF(DAY, [dbo].[Table_DATPHONG].NGAYDAT,[dbo].[Table_DATPHONG].NGAYTRA) *[dbo].[Table_IDLOAIPHONG].DONGIA " +
                                     "FROM [dbo].[Table.KHACHHANG]" +
                                     "INNER JOIN [dbo].[Table_DATPHONG] ON [dbo].[Table.KHACHHANG].MAKHACHHANG = [dbo].[Table_DATPHONG].MAKHACHHANG" +
                                     " JOIN [dbo].[Table_SOPHONG] ON [dbo].[Table.KHACHHANG].SOPHONG = [dbo].[Table_SOPHONG].SOPHONG" +
                                     " JOIN [dbo].[Table_IDLOAIPHONG] ON [dbo].[Table_SOPHONG].IDLOAIPHONG = [dbo].[Table_IDLOAIPHONG].IDLOAIPHONG";
 

            DataProvider provider = new DataProvider();
            using (SqlDataReader reader = provider.ExecuteReader (query))
            {
                if (reader.Read())
                {
                    tbtenkhach.Text = reader[0].ToString();
                    songayluutru.Text = reader[1].ToString();
                    tbtienphong.Text = reader[2].ToString();
                    Tongtien.Text = reader[2].ToString();
                }
            }

           /* if (e.RowIndex >= 0) // Đảm bảo chỉ số hàng hợp lệ được chọn
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // Lấy dữ liệu từ dòng đã chọn
                tbtenkhach.Text = row.Cells["TENKHACHHANG"].Value.ToString();

                // "Tên_Cột" là tên của cột mà bạn muốn lấy dữ liệu từ đó
            }*/

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
