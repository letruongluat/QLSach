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
    public partial class frm_Sach : Form
    {
        public frm_Sach()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();
        public void LoadSach()
        {
            String sql = "Select * from SACH";
            dataGridView1.DataSource = lopchung.LoadDuLieu(sql);
        }
        public void LoadDanhMuc()
        {
            String sql = "Select * from DANHMUC";
            cb_DanhMuc.DataSource = lopchung.LoadDuLieu(sql);
            cb_DanhMuc.DisplayMember = "TenDanhMuc";
            cb_DanhMuc.ValueMember = "MaDanhMuc";
        }
        public void LoadNXB()
        {
            String sql = "Select * from NXB";
            cb_NXB.DataSource = lopchung.LoadDuLieu(sql);
            cb_NXB.DisplayMember = "TenNXB";
            cb_NXB.ValueMember = "MaNXB";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Sach_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadNXB();
            LoadSach();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            String sqlThem = "INSERT INTO SACH VALUES('" + txt_MaSach.Text + "', " +
                "N'" + txt_TenSach.Text + "', " +
                Convert.ToInt32(txt_SoLuong.Text) + ", " +
                "N'" + txt_Mota.Text + "', " +
                "N'" + txt_TacGia.Text + "', " +
                "N'" + cb_DanhMuc.SelectedValue + "', " +
                "N'" + cb_NXB.SelectedValue + "', " +
                "Convert(DateTime, '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "', 103))"
;
            lopchung.NonQuery(sqlThem);
            LoadSach();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            String sqlSua = "UPDATE SACH SET TenSach = N'" + txt_TenSach.Text + "', " +
                "SoLuong = " + Convert.ToInt32(txt_SoLuong.Text) + ", " +
                "MoTa = N'" + txt_Mota.Text + "', " +
                "TacGia = N'" + txt_TacGia.Text + "', " +
                "TenDanhMuc = N'" + cb_DanhMuc.SelectedValue + "', " +
                "TenNXB = N'" + cb_NXB.SelectedValue + "', " +
                "NgayNhap = Convert(DateTime,'" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "', 103) " +
                "WHERE MaSach = '" + txt_MaSach.Text + "'";
            lopchung.NonQuery(sqlSua);
            LoadSach();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSach.Text = dataGridView1.CurrentRow.Cells["MaSach"].Value.ToString();
            txt_TenSach.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_SoLuong.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_TacGia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Mota.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cb_DanhMuc.SelectedValue = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cb_NXB.SelectedValue = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            String sqlXoa = "delete from SACH where MaSach = '" + txt_MaSach.Text + "' ";
            lopchung.NonQuery(sqlXoa);
            LoadSach();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_ThemDM_Click(object sender, EventArgs e)
        {
            String sqlThem = "insert into DANHMUC Values('" + txt_MaDanhMuc.Text + "'," +
                "N'" + txt_TenDanhMuc.Text + "')";
            lopchung.NonQuery(sqlThem);
        }

        private void btn_XoaDM_Click(object sender, EventArgs e)
        {
            String sqlXoa = "delete from DANHMUC where MaDanhMuc='" + txt_MaDanhMuc.Text + "'";
            lopchung.NonQuery(sqlXoa);
        }

        private void cb_DanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void btn_LoadDM_Click(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }

        private void btn_LoadSach_Click(object sender, EventArgs e)
        {
            LoadSach();
        }
    }
}

