using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyNhaHang
{
    public partial class Form1 : Form
    {
        SqlConnection cnn;
        public Form1()
        {
            InitializeComponent();
        }

        void AddDataToListBan()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(@"Select MaBan, TenBan from BAN Where TrangThai = '0'", cnn);
            da.Fill(dt);
            lstBan.DataSource = dt;            
            lstBan.DisplayMember = "TenBan";
            lstBan.ValueMember = "MaBan";
        }

        void AddDataToListDatBan()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(@"Select MaHD, TenBan from DATBAN", cnn);
            da.Fill(dt);
            lstKhach.DataSource = dt;
            lstKhach.DisplayMember = "TenBan";
            lstKhach.ValueMember = "MaHD";
        }

        void AddDataToListMonAn()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(@"Select MaMon, TenMon from MONAN", cnn);
            da.Fill(dt);
            lstMon.DataSource = dt;
            lstMon.DisplayMember = "TenMon";
            lstMon.ValueMember = "MaMon";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string StrSql = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNH;Integrated Security=True";
            cnn = new SqlConnection(StrSql);
            try
            {
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("Khong the ket noi duonc du lieu!", "Error");
            }
            
            AddDataToListBan();
            AddDataToListDatBan();
            AddDataToListMonAn();
            numericUpDown1.Value = 1;
        }
        
        void LoadHoaDon()
        {
            SqlCommand dc = new SqlCommand();
            SqlDataAdapter  da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            dc.Connection = cnn;
            dc.CommandType = CommandType.StoredProcedure;
            dc.CommandText = "spHoaDon";
            dc.Parameters.Add("@MaBan", SqlDbType.VarChar, 10, "MaBan");            
            dc.Parameters["@MaBan"].Value = lstBan.SelectedValue.ToString();
            da.SelectCommand = dc;
            da.Fill(dt);
            dgvHoaDon.DataSource = dt; 
        }
        private void lstBan_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show(lstBan.Text);
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {       
            SqlCommand dc = new SqlCommand();                                 
            dc.Connection = cnn;
            dc.CommandType = CommandType.Text;              
            dc.Parameters.Add("@MaBan", SqlDbType.VarChar, 10, "MaBan");
            dc.Parameters["@MaBan"].Value=lstBan.SelectedValue.ToString();
            dc.Parameters.Add("@MaMon", SqlDbType.VarChar, 10, "MaMon");
            dc.Parameters["@MaMon"].Value = lstMon.SelectedValue.ToString();
            dc.Parameters.Add("@SoLuong", SqlDbType.Int,10, "SoLuong");
            dc.Parameters["@SoLuong"].Value = numericUpDown1.Value;
            dc.CommandText = "Insert Into HOADON(MaBan,MaMon,SoLuong) Values(@MaBan,@MaMon,@SoLuong)";
            dc.ExecuteNonQuery();
            LoadHoaDon();
        }

       
        private void btnDatBan_Click(object sender, EventArgs e)
        {
            
            SqlCommand dcBan = new SqlCommand();
            dcBan.Connection = cnn;
            dcBan.CommandType = CommandType.Text;
            dcBan.Parameters.Add("@TrangThai", SqlDbType.VarChar, 10).Value = "1";
            dcBan.Parameters.Add("@MaBan", SqlDbType.VarChar, 10).Value = lstBan.SelectedValue.ToString();
            dcBan.CommandText = "UPDATE BAN Set TrangThai = @TrangThai Where (MaBan = @MaBan)";
            dcBan.ExecuteNonQuery();
            
            SqlCommand dc = new SqlCommand();
            dc.Connection = cnn;
            dc.CommandType = CommandType.Text;
            dc.Parameters.Add("@TenBan", SqlDbType.VarChar, 10).Value = lstBan.Text;
            dc.CommandText = "Insert Into DATBAN(TenBan) Values(@TenBan)";
            dc.ExecuteNonQuery();
            AddDataToListBan();
            AddDataToListDatBan();
        }

        private void lstBan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            SqlCommand dcBan = new SqlCommand();
            dcBan.Connection = cnn;
            dcBan.CommandType = CommandType.Text;
            dcBan.Parameters.Add("@TrangThai", SqlDbType.VarChar, 10).Value = "0";
            dcBan.Parameters.Add("@MaBan", SqlDbType.VarChar, 10).Value = lstBan.SelectedValue.ToString();
            dcBan.CommandText = "UPDATE BAN Set TrangThai = @TrangThai Where (MaBan = @MaBan)";
            dcBan.ExecuteNonQuery();
            

            SqlCommand dc = new SqlCommand();
            dc.Connection = cnn;
            dc.CommandType = CommandType.Text;
            dc.Parameters.Add("@MaHD", SqlDbType.VarChar, 10).Value = lstKhach.SelectedValue.ToString();
            dc.CommandText = "Delete From DATBAN Where MaHD = @MaHD";
            dc.ExecuteNonQuery();
            AddDataToListDatBan();
            AddDataToListBan();
        }
    }
}
