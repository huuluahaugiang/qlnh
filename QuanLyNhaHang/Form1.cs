using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MyTools;



namespace QuanLyNhaHang
{
    public partial class Form1 : Form
    {
        
        static string ChuoiKetNoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNH;Integrated Security=True";        
        string MaBan;
        int MaHoaDon=0;
        public Form1()
        {
            InitializeComponent();
        }

        void AddDataToListBan()
        {
            MyDataBase myDB = new MyDataBase(ChuoiKetNoi);
            DataTable dt = new DataTable();
            dt = myDB.GetDataBySqlString(@"Select MaBan, TenBan from BAN Where TrangThai = '0'");
            lstBan.DataSource = dt;
            lstBan.DisplayMember = "TenBan";
            lstBan.ValueMember = "MaBan";
            lstBan.SelectedValue= "MaBan";
        }

        void AddDataToListMon()
        {
            MyDataBase myDB = new MyDataBase(ChuoiKetNoi);
            DataTable dt = new DataTable();
            dt = myDB.GetDataBySqlString(@"Select MaMon, TenMon from MONAN");            
            lstMon.DataSource = dt;
            lstMon.DisplayMember = "TenMon";
            lstMon.ValueMember = "MaMon";
        }
        void FormatDataGridViewHD()
        {
            dgvDatBan.Columns[0].HeaderText = "Mã bàn";
            dgvDatBan.Columns[0].Width = 80;            
            dgvDatBan.Columns[1].HeaderText = "Tên bàn";
            dgvDatBan.Columns[1].Width = 100;
            dgvDatBan.Columns[2].HeaderText = "Mã hóa đơn";
            dgvDatBan.Columns[2].Width = 150;
            dgvDatBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i <= 2; i++)
            {
                dgvDatBan.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDatBan.Columns[i].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);                
            }
            this.dgvDatBan.DefaultCellStyle.Font = new Font("Arial", 9.75F);
        }

        void FormatListView()
        {
            lsvHoaDon.Columns.Add("Tên hàng", 120);
            lsvHoaDon.Columns.Add("ĐVT", 40);
            lsvHoaDon.Columns.Add("SLG", 40).TextAlign = HorizontalAlignment.Right;
            lsvHoaDon.Columns.Add("Đơn giá", 70).TextAlign = HorizontalAlignment.Right;
            lsvHoaDon.Columns.Add("Thành tiền", 80).TextAlign = HorizontalAlignment.Right;
            lsvHoaDon.View = View.Details;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddDataToListBan();
            LoadGridViewKhach();
            AddDataToListMon();
            numericUpDown1.Value = 1;
            MaBan = string.Empty;
            FormatDataGridViewHD();

            FormatListView();
        }
        
        void LoadHoaDon(int SoHoaDon)
        {
            lsvHoaDon.Items.Clear();
            lsvHoaDon.View = View.Details;
            lsvHoaDon.GridLines = true;
            lsvHoaDon.FullRowSelect = true;
            DataTable dt = new DataTable();
            MyDataBase myDB = new MyDataBase(ChuoiKetNoi);
            myDB.ConnectToDatabase();
            SqlCommand dc = new SqlCommand();
            dc.Connection = myDB.cnn;
            dc.CommandType = CommandType.StoredProcedure;
            dc.CommandText = "ThanhTien";            
            dc.Parameters.AddWithValue("@MaHoaDon", SoHoaDon);
            SqlDataAdapter da = new SqlDataAdapter(dc);
            da.Fill(dt);            
            long TongTien = 0;

            ListViewItem lItem;
            foreach (DataRow dr in dt.Rows)
            {
                lItem = new ListViewItem(dr["TenMon"].ToString());                
                lItem.SubItems.Add(dr["DVT"].ToString());
                lItem.SubItems.Add(dr["SoLuong"].ToString());
                lItem.SubItems.Add(dr["DonGia1"].ToString());
                lItem.SubItems.Add(dr["ThanhTien"].ToString());
                lsvHoaDon.Items.Add(lItem);
                TongTien = TongTien + Convert.ToInt32(dr["ThanhTien"].ToString());
            }
            TienChu tc = new TienChu();
            string bangchu = tc.BangChu(TongTien);
            tStThanhTien.Text = "Bàn " + MaBan + " tổng cộng: " + string.Format("{0:##,#}", TongTien) + " (" + bangchu + ")";                
        }

        
        private void LoadGridViewKhach()
        {                                  
            DataTable dt = new DataTable();
            MyDataBase myDB = new MyDataBase(ChuoiKetNoi);            
            dt = myDB.GetDataBySqlString(@"Select MaBan, TenBan, MaHD FROM DATBAN");
            dgvDatBan.DataSource = dt;
        }

        private void lstBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBan.SelectedIndex!=-1)
                MaBan = lstBan.SelectedValue.ToString();
                //MessageBox.Show(lstBan.Text);
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            if (lstMon.SelectedIndex != -1)
            {
                MyDataBase myDB = new MyDataBase(ChuoiKetNoi);
                string sqlstr = @"Insert Into HOADON(MaHD, MaBan, MaMon, SoLuong) Values('" + MaHoaDon + "', '" + MaBan + "', '" + lstMon.SelectedValue.ToString() + "', " + numericUpDown1.Value.ToString() + ")";
                myDB.ExcuteSqlStr(sqlstr);
                LoadHoaDon(MaHoaDon);
            }
        }
       
        private void btnDatBan_Click(object sender, EventArgs e)
        {
            if (lstBan.SelectedIndex != -1)
            {
                MyDataBase myDB = new MyDataBase(ChuoiKetNoi);
                myDB.ExcuteSqlStr(@"UPDATE BAN Set TrangThai = '1' Where (MaBan = '" + MaBan + "')");
                MyDataBase myDB2 = new MyDataBase(ChuoiKetNoi);
                myDB2.ExcuteSqlStr(@"Insert Into DATBAN(MaBan, TenBan) Values('" + lstBan.SelectedValue.ToString() + "', N'" + lstBan.Text + "')");                
                AddDataToListBan();
                LoadGridViewKhach();
            }
        }

        private void lstBan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            if (!MaBan.Equals(string.Empty))
            {
                MyDataBase myDB = new MyDataBase(ChuoiKetNoi);
                myDB.ExcuteSqlStr(@"UPDATE BAN Set TrangThai = '0' Where (MaBan = '" + MaBan.Trim() + "')");
                MyDataBase myDB1 = new MyDataBase(ChuoiKetNoi);
                myDB1.ExcuteSqlStr(@"Delete From DATBAN Where MaBan = '" + MaBan + "'");
                AddDataToListBan();
                LoadGridViewKhach();
            }
        }
        private void dgvKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            //MaBan = dgvDatBan.Rows[e.RowIndex].Cells["MaBan"].Value.ToString();
            //MaHoaDon= int.Parse(dgvDatBan.Rows[e.RowIndex].Cells["MaHD"].Value.ToString());
            //LoadHoaDon(MaHoaDon);
        }

        private void dgvKhach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MaBan = dgvDatBan.Rows[e.RowIndex].Cells["MaBan"].Value.ToString();
                MaHoaDon = int.Parse(dgvDatBan.Rows[e.RowIndex].Cells["MaHD"].Value.ToString());
                LoadHoaDon(MaHoaDon);
            }
        }

        private void dgvDatBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatBan_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void lstMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
        }

        private void btgnTinhTien_Click(object sender, EventArgs e)
        {            
            MyDataBase myDB = new MyDataBase(ChuoiKetNoi);
            myDB.ExcuteSqlStr(@"UPDATE BAN Set TrangThai = '0'");
            AddDataToListBan();
            LoadGridViewKhach();
        }
    }
}
