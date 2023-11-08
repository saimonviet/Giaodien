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
            listView1.Items.Clear();
            string query = "SELECT [dbo].[Table.KHACHHANG].MAKHACHHANG, [dbo].[Table.KHACHHANG].TENKHACHHANG, [dbo].[Table.KHACHHANG].CCCD, [dbo].[Table_DATPHONG].NGAYDAT, [dbo].[Table_DATPHONG].NGAYTRA " +
                                    "FROM [dbo].[Table.KHACHHANG] " +
                                    "INNER JOIN [dbo].[Table_DATPHONG] ON [dbo].[Table.KHACHHANG].MAKHACHHANG = [dbo].[Table_DATPHONG].MAKHACHHANG";
            DataProvider provider = new DataProvider();
            using (SqlDataReader reader = provider.ExecuteReader(query))
            {
                int i = 0;
                while (reader.Read())
                {
                    listView1.Items.Add(reader[0].ToString());
                    listView1.Items[i].SubItems.Add(reader[1].ToString());
                    listView1.Items[i].SubItems.Add(reader[2].ToString());
                    listView1.Items[i].SubItems.Add(reader[3].ToString());
                    listView1.Items[i].SubItems.Add(reader[4].ToString());
                    i++;
                }
            }
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
            listView1.Items.Clear();
            string query = "SELECT [dbo].[Table.KHACHHANG].MAKHACHHANG, [dbo].[Table.KHACHHANG].TENKHACHHANG, [dbo].[Table.KHACHHANG].CCCD, [dbo].[Table_DATPHONG].NGAYDAT, [dbo].[Table_DATPHONG].NGAYTRA " +
                                    "FROM [dbo].[Table.KHACHHANG]" +
                                    "INNER JOIN [dbo].[Table_DATPHONG] ON [dbo].[Table.KHACHHANG].MAKHACHHANG = [dbo].[Table_DATPHONG].MAKHACHHANG WHERE([dbo].[Table.KHACHHANG].SOPHONG like '%" + tbsophong.Text + "%')";
            DataProvider provider = new DataProvider();
            using (SqlDataReader reader = provider.ExecuteReader(query))
            {
                int i = 0;
                while (reader.Read())
                {
                    listView1.Items.Add(reader[0].ToString());
                    listView1.Items[i].SubItems.Add(reader[1].ToString());
                    listView1.Items[i].SubItems.Add(reader[2].ToString());
                    listView1.Items[i].SubItems.Add(reader[3].ToString());
                    listView1.Items[i].SubItems.Add(reader[4].ToString());
                    i++;
                }
            }

        }
        private void Tongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void Thanhtoan_Click(object sender, EventArgs e)
        {
        /*    string quer = "SELECT [dbo].[Table.KHACHHANG].SOPHONG, [dbo].[Table_DATPHONG].IDDATPHONG " +
                                           "FROM [dbo].[Table.KHACHHANG]" +
                                           "INNER JOIN [dbo].[Table_DATPHONG] ON [dbo].[Table.KHACHHANG].MAKHACHHANG = [dbo].[Table_DATPHONG].MAKHACHHANG WHERE ([dbo].[Table.KHACHHANG].SOPHONG = N'" + tbsophong.Text + @"')";
            DataProvider provide = new DataProvider();
            using (SqlDataReader reader = provide.ExecuteReader(quer))
            {
            while (reader.Read())
                {
                    string iddatphong= reader[1].ToString();
                    
                }
                    }
            if (!string.IsNullOrEmpty(Tongtien.Text))
             {
                 // Lấy giá trị từ TextBox
                 string tong = Tongtien.Text;

                 // Tạo câu truy vấn SQL INSERT
                 string query = $"INSERT INTO [dbo].[Table_HOADON] (IDDATPHONG, TONG) VALUES ('{iddatphong}','{tong}')";

                 // Sử dụng class DataProvider để thực hiện truy vấn
                 DataProvider provider = new DataProvider();
                 provider.ExecuteQuery(query);

                 // Xóa dữ liệu từ TextBox sau khi thêm vào DataGridView
                 tbtenkhach.Text = "";
                 songayluutru.Text = "";
                 tbtienphong.Text = "";
                 Tongtien.Text = "";
             }
            
            */
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

       


                

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string query = "SELECT [dbo].[Table.KHACHHANG].SOPHONG, [dbo].[Table.KHACHHANG].TENKHACHHANG, DATEDIFF(DAY, [dbo].[Table_DATPHONG].NGAYDAT, [dbo].[Table_DATPHONG].NGAYTRA) ,  DATEDIFF(DAY, [dbo].[Table_DATPHONG].NGAYDAT,[dbo].[Table_DATPHONG].NGAYTRA) *[dbo].[Table_IDLOAIPHONG].DONGIA " +
                                            "FROM [dbo].[Table.KHACHHANG]" +
                                            "INNER JOIN [dbo].[Table_DATPHONG] ON [dbo].[Table.KHACHHANG].MAKHACHHANG = [dbo].[Table_DATPHONG].MAKHACHHANG" +
                                            " JOIN [dbo].[Table_SOPHONG] ON [dbo].[Table.KHACHHANG].SOPHONG = [dbo].[Table_SOPHONG].SOPHONG" +
                                            " JOIN [dbo].[Table_IDLOAIPHONG] ON [dbo].[Table_SOPHONG].IDLOAIPHONG = [dbo].[Table_IDLOAIPHONG].IDLOAIPHONG" + " WHERE ([dbo].[Table.KHACHHANG].SOPHONG = N'"+ tbsophong.Text + @"')";
            DataProvider provider = new DataProvider();
            using (SqlDataReader reader = provider.ExecuteReader(query))
            {
            while (reader.Read())
                {
                    tbtenkhach.Text = reader[1].ToString();
                    songayluutru.Text = reader[2].ToString();
                    tbtienphong.Text = reader[3].ToString();
                    Tongtien.Text = reader[3].ToString();
                }
                    }
        }
    }
}
