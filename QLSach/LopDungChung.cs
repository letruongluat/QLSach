using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLSach
{
    class LopDungChung
    {

        String duongDan = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\LTUngDung.net\DoAn\DoAnNhom_QLSach\QLSach\QLSach\QLSach.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(duongDan);
        }
        public DataTable LoadDuLieu(String sqlD)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlD, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void NonQuery(string sqlNonQuery)
        {
            try
            {
                SqlCommand comm = new SqlCommand(sqlNonQuery, conn);
                conn.Open();
                int ketqua = 0;
                try
                {
                    ketqua = comm.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Lỗi định dạng dữ liệu: " + ex.Message);
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show("Lỗi chuyển đổi kiểu dữ liệu: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

                conn.Close();
                if (ketqua >= 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        public void SuaKhongThongBao(String sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
        }
        public int Scalar(String sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int ketQua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketQua;
        }
    }
}
