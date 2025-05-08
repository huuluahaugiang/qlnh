using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Form;

namespace MyTools
{
    public class MyDataBase
    {
        private SqlConnection _cnn;
        public SqlConnection cnn
        {
            get { return _cnn; }
            set { _cnn = value; }
        }
        private DataSet ds = new DataSet();

        public MyDataBase()
        {
            _cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLSV2021;Integrated Security=True");
        }

        public MyDataBase(string strConn)
        {
            _cnn = new SqlConnection(strConn);
        }
        public void ConnectToDatabase()
        {
            try
            {
                if (_cnn.State == ConnectionState.Closed)
                {
                    _cnn.Open();
                }
            }
            catch
            {
                
            }
        }

        public void DisConnect()
        {
            //if (_cnn.State == ConnectionState.Open)
            //{
            //    _cnn.Close();
            //    _cnn.Dispose();
            //    _cnn = null;
            //}
        }

        public DataTable GetDataBySqlString(string StrSql)
        {
            ConnectToDatabase();
            SqlCommand cmd = new SqlCommand(StrSql, _cnn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DisConnect();
            return dt;
        }

        public SqlDataReader GetDataBySqlString2(string StrSql)
        {
            ConnectToDatabase();
            SqlCommand dc = new SqlCommand(StrSql, _cnn);
            dc.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(dc);
            da.SelectCommand = dc;
            SqlDataReader dr = dc.ExecuteReader();
            DisConnect();
            return dr;
        }

        //public List<SinhVienDTO> SinhVienToList(string StrSql)
        //{
        //    ConnectToDatabase();
        //    SqlCommand dc = new SqlCommand(StrSql, _cnn);
        //    dc.CommandType = CommandType.Text;
        //    SqlDataAdapter da = new SqlDataAdapter(dc);
        //    da.SelectCommand = dc;
        //    SqlDataReader dr = dc.ExecuteReader();
        //    List<SinhVienDTO> DanhSachSV = new List<SinhVienDTO>();
        //    while (dr.Read())
        //    {
        //        DanhSachSV.Add(new SinhVienDTO(dr["MaSV"].ToString(), dr["TenSV"].ToString(), dr["GioiTinh"].ToString(), dr["NamSinh"].ToString(), dr["MaLop"].ToString()));
        //    }
        //    DisConnect();
        //    return DanhSachSV;
        //}

        public SqlDataReader GetDataByStoreProcedure2(string StoreName)
        {
            ConnectToDatabase();
            SqlCommand dc = new SqlCommand(StoreName, _cnn);
            dc.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(dc);
            da.SelectCommand = dc;
            SqlDataReader dr = dc.ExecuteReader();
            DisConnect();
            return dr;
        }

        public void ExcuteSqlStr(string strSql)
        {
            int result = 0;
            ConnectToDatabase();
            SqlCommand dc = new SqlCommand(strSql, _cnn);
            dc.CommandType = CommandType.Text;
            result = dc.ExecuteNonQuery();
            DisConnect();
            if (result <= 0)
                MessageBox.Show("Thực hiện không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Đã thao tác trên " + result + " dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DataTable GetDataByStoreProcedure(string StoreName)
        {
            ConnectToDatabase();
            SqlCommand command = new SqlCommand(StoreName, _cnn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DisConnect();
            return dt;
        }
        public void DeleteBySqlString(string StrSql)
        {
            ConnectToDatabase();
            SqlCommand cmd = new SqlCommand(StrSql, _cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            DisConnect();
        }
        public void DeleteByStoreProcedure(string StoreName)
        {
            ConnectToDatabase();
            SqlCommand cmd = new SqlCommand(StoreName, _cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            DisConnect();
        }

        public void XoaSV_sp(string MaSinhVien)
        {
            ConnectToDatabase();
            SqlCommand cmd = new SqlCommand("XoaSV", _cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(@"MaSV", SqlDbType.NVarChar, 10);
            cmd.Parameters[@"MaSV"].Value = MaSinhVien;
            cmd.ExecuteNonQuery();
            DisConnect();
        }

        public DataTable LayTatCaSinhVienDataSet()
        {
            ConnectToDatabase();
            SqlCommand cmd = new SqlCommand("Select * from SinhVien order by MaSV ASC", _cnn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "SinhVien");
            DataTable dt = new DataTable();
            dt = ds.Tables["SinhVien"];
            DisConnect();
            return dt;
        }

        public DataTable LayTatCaSinhVienClass()
        {
            DataTable dt = new DataTable();
            ConnectToDatabase();
            dt = GetDataBySqlString("Select * from SinhVien order by MaSV ASC");
            DisConnect();
            return dt;
        }

        public void AddDataToCombobox(ComboBox cbo, string TableName, string DisplayMember, string ValueMember)
        {
            ConnectToDatabase();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from " + TableName, cnn);
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = DisplayMember;
            cbo.ValueMember = ValueMember;
            DisConnect();
        }
        //private void BindingData()
        //{
        //    txtMaSV.DataBindings.Clear();
        //    txtMaSV.DataBindings.Add("Text", dgvSinhVien.DataSource, "MaSV");
        //    txtTenSV.DataBindings.Clear();
        //    txtTenSV.DataBindings.Add("Text", dgvSinhVien.DataSource, "TenSV");
        //    cboGioiTinh.DataBindings.Clear();
        //    cboGioiTinh.DataBindings.Add("Text", dgvSinhVien.DataSource, "GioiTinh");
        //    txtNamSinh.DataBindings.Clear();
        //    txtNamSinh.DataBindings.Add("Text", dgvSinhVien.DataSource, "NamSinh");
        //    cboMaLop.DataBindings.Clear();
        //    cboMaLop.DataBindings.Add("Text", dgvSinhVien.DataSource, "MaLop");
        //}
        public DataSet FillToDataSet()
        {
            ConnectToDatabase();
            ds = new DataSet();
            SqlDataAdapter daSinhVien;
            SqlDataAdapter daDiem;
            SqlDataAdapter daLop;
            DataTable dtLop = new DataTable("Lop");
            ds.Tables.Add(dtLop);

            DataTable dtSinhVien = new DataTable("SinhVien");
            ds.Tables.Add(dtSinhVien);

            DataTable dtDiem = new DataTable("Diem");
            ds.Tables.Add(dtDiem);

            daLop = new SqlDataAdapter("SELECT DISTINCT b.MaLop, TenLop FROM LOP a, SINHVIEN b WHERE a.MaLop=b.MaLop Order By MaLop ASC", cnn);
            daLop.TableMappings.Add("TableLop", "Lop");
            daLop.Fill(ds, "Lop");

            daSinhVien = new SqlDataAdapter("Select * from SinhVien", cnn);
            daSinhVien.TableMappings.Add("TableSinhVien", "SinhVien");
            daSinhVien.Fill(ds, "SinhVien");

            daDiem = new SqlDataAdapter("SELECT Diem.MaHocPhan, HocPhan.TenHocPhan, Diem.Diem, Diem.MaSV FROM Diem INNER JOIN HocPhan ON Diem.MaHocPhan = HocPhan.MaHocPhan", cnn);
            daDiem.TableMappings.Add("TableDiem", "Diem");
            daDiem.Fill(ds, "Diem");

            //tạo quan he giua cac bang
            DataRelation r_SinhVien_Lop = new DataRelation("", dtLop.Columns["MaLop"], dtSinhVien.Columns["MaLop"]);
            ds.Relations.Add(r_SinhVien_Lop);

            DataRelation r_SinhVien_Diem = new DataRelation("", dtSinhVien.Columns["MaSV"], dtDiem.Columns["MaSV"]);
            ds.Relations.Add(r_SinhVien_Diem);
            return ds;
        }

        public DataSet FillToDataSet_StackOverFlow()
        {
            DataTable dtTablesNames = new DataTable();
            try
            {
                ConnectToDatabase();
                //get the list of tables in the database into a DataTable
                string sTablesNamesQuery = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.Tables WHERE TABLE_TYPE = 'BASE TABLE' Order by TABLE_NAME";
                SqlDataAdapter sda1 = new SqlDataAdapter(sTablesNamesQuery, _cnn);
                sda1.Fill(dtTablesNames);

                //               
                DataSet dsAllTables = new DataSet();
                string sbQuery = "";
                //build the queries that will be used to retrieve the tables rows
                foreach (DataRow dr in dtTablesNames.Rows)
                {
                    sbQuery = "SELECT * FROM " + dr["TABLE_NAME"].ToString() + ";";
                }
                //
                SqlDataAdapter sda2 = new SqlDataAdapter(sbQuery, _cnn);
                sda2.Fill(dsAllTables);
                sda1.Dispose();
                sda2.Dispose();
                DisConnect();
                return dsAllTables;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
