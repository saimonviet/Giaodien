namespace GiaoDien_qlpks
{
    partial class checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabthanhtoan = new TabPage();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            songayluutru = new TextBox();
            label6 = new Label();
            tbtiendv = new TextBox();
            tbtenkhach = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            tbtienphong = new TextBox();
            Thanhtoan = new Button();
            Tongtien = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            tbsophong = new TextBox();
            Timkiem = new Button();
            label2 = new Label();
            tabcheckout = new TabPage();
            dtgvdanhsachthanhtoan = new DataGridView();
            chectout = new Button();
            idphongthanhtoan = new TextBox();
            button4 = new Button();
            tbmkh = new TextBox();
            button3 = new Button();
            tbidhoadon = new TextBox();
            button2 = new Button();
            button1 = new Button();
            dataProviderBindingSource1 = new BindingSource(components);
            dataProviderBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabthanhtoan.SuspendLayout();
            panel1.SuspendLayout();
            tabcheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvdanhsachthanhtoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataProviderBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataProviderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabthanhtoan);
            tabControl1.Controls.Add(tabcheckout);
            tabControl1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 5);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(912, 587);
            tabControl1.TabIndex = 0;
            // 
            // tabthanhtoan
            // 
            tabthanhtoan.BackColor = Color.MistyRose;
            tabthanhtoan.Controls.Add(listView1);
            tabthanhtoan.Controls.Add(songayluutru);
            tabthanhtoan.Controls.Add(label6);
            tabthanhtoan.Controls.Add(tbtiendv);
            tabthanhtoan.Controls.Add(tbtenkhach);
            tabthanhtoan.Controls.Add(label1);
            tabthanhtoan.Controls.Add(label3);
            tabthanhtoan.Controls.Add(label5);
            tabthanhtoan.Controls.Add(tbtienphong);
            tabthanhtoan.Controls.Add(Thanhtoan);
            tabthanhtoan.Controls.Add(Tongtien);
            tabthanhtoan.Controls.Add(label7);
            tabthanhtoan.Controls.Add(panel1);
            tabthanhtoan.Location = new Point(4, 39);
            tabthanhtoan.Margin = new Padding(3, 4, 3, 4);
            tabthanhtoan.Name = "tabthanhtoan";
            tabthanhtoan.Padding = new Padding(3, 4, 3, 4);
            tabthanhtoan.Size = new Size(904, 544);
            tabthanhtoan.TabIndex = 0;
            tabthanhtoan.Text = "Thanh toán";
            tabthanhtoan.Click += tabthanhtoan_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Location = new Point(10, 117);
            listView1.Name = "listView1";
            listView1.Size = new Size(889, 203);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.Click += listView1_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã KH";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên khách hàng";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "CCCD";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ngày đặt ";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ngày trả";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 180;
            // 
            // songayluutru
            // 
            songayluutru.Location = new Point(213, 402);
            songayluutru.Margin = new Padding(3, 4, 3, 4);
            songayluutru.Name = "songayluutru";
            songayluutru.ReadOnly = true;
            songayluutru.Size = new Size(188, 36);
            songayluutru.TabIndex = 3;
            songayluutru.TextChanged += songayluutru_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 192, 192);
            label6.Location = new Point(472, 339);
            label6.Name = "label6";
            label6.Size = new Size(123, 30);
            label6.TabIndex = 0;
            label6.Text = "Tiền phòng";
            // 
            // tbtiendv
            // 
            tbtiendv.Location = new Point(632, 405);
            tbtiendv.Margin = new Padding(3, 4, 3, 4);
            tbtiendv.Name = "tbtiendv";
            tbtiendv.ReadOnly = true;
            tbtiendv.Size = new Size(188, 36);
            tbtiendv.TabIndex = 1;
            tbtiendv.TextChanged += texttenkhach_TextChanged;
            // 
            // tbtenkhach
            // 
            tbtenkhach.Location = new Point(213, 336);
            tbtenkhach.Margin = new Padding(3, 4, 3, 4);
            tbtenkhach.Name = "tbtenkhach";
            tbtenkhach.ReadOnly = true;
            tbtenkhach.Size = new Size(188, 36);
            tbtenkhach.TabIndex = 1;
            tbtenkhach.TextChanged += tienphong_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(22, 342);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 192);
            label3.Location = new Point(13, 405);
            label3.Name = "label3";
            label3.Size = new Size(172, 30);
            label3.TabIndex = 2;
            label3.Text = "Số Ngày Lưu Trú";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 192, 192);
            label5.Location = new Point(466, 402);
            label5.Name = "label5";
            label5.Size = new Size(129, 30);
            label5.TabIndex = 2;
            label5.Text = "Tiền dịch vụ";
            // 
            // tbtienphong
            // 
            tbtienphong.Location = new Point(632, 336);
            tbtienphong.Margin = new Padding(3, 4, 3, 4);
            tbtienphong.Name = "tbtienphong";
            tbtienphong.ReadOnly = true;
            tbtienphong.Size = new Size(188, 36);
            tbtienphong.TabIndex = 4;
            tbtienphong.TextChanged += tiendichvu_TextChanged;
            // 
            // Thanhtoan
            // 
            Thanhtoan.BackColor = Color.FromArgb(255, 128, 128);
            Thanhtoan.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Thanhtoan.Location = new Point(760, 477);
            Thanhtoan.Margin = new Padding(3, 4, 3, 4);
            Thanhtoan.Name = "Thanhtoan";
            Thanhtoan.Size = new Size(138, 59);
            Thanhtoan.TabIndex = 5;
            Thanhtoan.Text = "Thanh toán";
            Thanhtoan.UseVisualStyleBackColor = false;
            Thanhtoan.Click += Thanhtoan_Click;
            // 
            // Tongtien
            // 
            Tongtien.Location = new Point(566, 477);
            Tongtien.Margin = new Padding(3, 4, 3, 4);
            Tongtien.Name = "Tongtien";
            Tongtien.ReadOnly = true;
            Tongtien.Size = new Size(188, 36);
            Tongtien.TabIndex = 4;
            Tongtien.TextChanged += Tongtien_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MistyRose;
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(472, 473);
            label7.Name = "label7";
            label7.Size = new Size(88, 40);
            label7.TabIndex = 3;
            label7.Text = "Tổng";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(tbsophong);
            panel1.Controls.Add(Timkiem);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(10, 44);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 79);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // tbsophong
            // 
            tbsophong.Location = new Point(124, 22);
            tbsophong.Name = "tbsophong";
            tbsophong.Size = new Size(378, 36);
            tbsophong.TabIndex = 5;
            tbsophong.TextChanged += textBox1_TextChanged;
            // 
            // Timkiem
            // 
            Timkiem.BackColor = Color.FromArgb(255, 128, 128);
            Timkiem.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Timkiem.Location = new Point(535, 15);
            Timkiem.Margin = new Padding(3, 4, 3, 4);
            Timkiem.Name = "Timkiem";
            Timkiem.Size = new Size(108, 51);
            Timkiem.TabIndex = 4;
            Timkiem.Text = "Tìm";
            Timkiem.UseVisualStyleBackColor = false;
            Timkiem.Click += Timkiem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(3, 25);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 2;
            label2.Text = "Số Phòng";
            label2.Click += label2_Click;
            // 
            // tabcheckout
            // 
            tabcheckout.BackColor = Color.MistyRose;
            tabcheckout.Controls.Add(dtgvdanhsachthanhtoan);
            tabcheckout.Controls.Add(chectout);
            tabcheckout.Controls.Add(idphongthanhtoan);
            tabcheckout.Controls.Add(button4);
            tabcheckout.Controls.Add(tbmkh);
            tabcheckout.Controls.Add(button3);
            tabcheckout.Controls.Add(tbidhoadon);
            tabcheckout.Controls.Add(button2);
            tabcheckout.Controls.Add(button1);
            tabcheckout.Location = new Point(4, 39);
            tabcheckout.Margin = new Padding(3, 4, 3, 4);
            tabcheckout.Name = "tabcheckout";
            tabcheckout.Padding = new Padding(3, 4, 3, 4);
            tabcheckout.Size = new Size(904, 544);
            tabcheckout.TabIndex = 1;
            tabcheckout.Text = "Check out";
            // 
            // dtgvdanhsachthanhtoan
            // 
            dtgvdanhsachthanhtoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvdanhsachthanhtoan.Location = new Point(9, 75);
            dtgvdanhsachthanhtoan.Margin = new Padding(3, 4, 3, 4);
            dtgvdanhsachthanhtoan.Name = "dtgvdanhsachthanhtoan";
            dtgvdanhsachthanhtoan.RowHeadersWidth = 51;
            dtgvdanhsachthanhtoan.RowTemplate.Height = 25;
            dtgvdanhsachthanhtoan.Size = new Size(499, 445);
            dtgvdanhsachthanhtoan.TabIndex = 15;
            // 
            // chectout
            // 
            chectout.BackColor = Color.FromArgb(255, 192, 128);
            chectout.Location = new Point(686, 448);
            chectout.Margin = new Padding(3, 4, 3, 4);
            chectout.Name = "chectout";
            chectout.Size = new Size(136, 53);
            chectout.TabIndex = 14;
            chectout.Text = "Check out";
            chectout.UseVisualStyleBackColor = false;
            // 
            // idphongthanhtoan
            // 
            idphongthanhtoan.Location = new Point(686, 352);
            idphongthanhtoan.Margin = new Padding(3, 4, 3, 4);
            idphongthanhtoan.Name = "idphongthanhtoan";
            idphongthanhtoan.Size = new Size(221, 36);
            idphongthanhtoan.TabIndex = 13;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(515, 347);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(152, 52);
            button4.TabIndex = 12;
            button4.Text = "Số Phòng";
            button4.UseVisualStyleBackColor = false;
            // 
            // tbmkh
            // 
            tbmkh.Location = new Point(681, 224);
            tbmkh.Margin = new Padding(3, 4, 3, 4);
            tbmkh.Name = "tbmkh";
            tbmkh.Size = new Size(221, 36);
            tbmkh.TabIndex = 11;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(515, 219);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(152, 52);
            button3.TabIndex = 10;
            button3.Text = "Mã khách hàng";
            button3.UseVisualStyleBackColor = false;
            // 
            // tbidhoadon
            // 
            tbidhoadon.Location = new Point(681, 95);
            tbidhoadon.Margin = new Padding(3, 4, 3, 4);
            tbidhoadon.Name = "tbidhoadon";
            tbidhoadon.Size = new Size(221, 36);
            tbidhoadon.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(515, 85);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(130, 59);
            button2.TabIndex = 8;
            button2.Text = "ID Hoá đơn";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(9, 8);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(499, 59);
            button1.TabIndex = 6;
            button1.Text = "Danh sách khách hàng đã thanh toán";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataProviderBindingSource1
            // 
            dataProviderBindingSource1.DataSource = typeof(DAO.DataProvider);
            // 
            // dataProviderBindingSource
            // 
            dataProviderBindingSource.DataSource = typeof(DAO.DataProvider);
            // 
            // checkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "checkout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check out";
            tabControl1.ResumeLayout(false);
            tabthanhtoan.ResumeLayout(false);
            tabthanhtoan.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabcheckout.ResumeLayout(false);
            tabcheckout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvdanhsachthanhtoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataProviderBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataProviderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabcheckout;
        private Button button1;
        private TextBox idphongthanhtoan;
        private Button button4;
        private TextBox tbmkh;
        private Button button3;
        private TextBox tbidhoadon;
        private Button button2;
        private Button chectout;
        private DataGridView dtgvdanhsachthanhtoan;
        private TabPage tabthanhtoan;
        private Button Thanhtoan;
        private TextBox Tongtien;
        private Label label7;
        private TextBox tbtienphong;
        private Label label5;
        private TextBox tbtenkhach;
        private Label label3;
        private Panel panel1;
        private Button Timkiem;
        private Label label2;
        private TextBox tbtiendv;
        private Label label1;
        private TextBox songayluutru;
        private Label label6;
        private BindingSource dataProviderBindingSource;
        private BindingSource dataProviderBindingSource1;
        private TextBox tbsophong;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}