using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSach
{
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();
        public void LoadKH()
        {
            String sql = "Select * from KHACHHANG";
            dataGridView1.DataSource = lopchung.LoadDuLieu(sql);
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            String sqlThem = "INSERT INTO KHACHHANG VALUES('" + txt_TenDangNhap.Text + "'," +
                "'" + txt_MatKhau.Text + "'," +
                "N'" + txt_HoTen.Text + "'," +
                "'" + txt_CCCD.Text + "')";
            lopchung.NonQuery(sqlThem);
            LoadKH();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            String sqlSua = "UPDATE KHACHHANG SET MatKhau = '" + txt_MatKhau.Text + "'," +
                "HoTen = N'" + txt_HoTen.Text + "'," +
                "CCCD = '" + txt_CCCD.Text + "' WHERE TenDangNhap='" + txt_TenDangNhap.Text + "'";
            lopchung.NonQuery(sqlSua);
            LoadKH();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            String sqlXoa = "DELETE FROM KHACHHANG where TenDangNhap = '" + txt_TenDangNhap.Text + "'";
            lopchung.NonQuery(sqlXoa);
            LoadKH();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TenDangNhap.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_MatKhau.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_HoTen.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_CCCD.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}

  