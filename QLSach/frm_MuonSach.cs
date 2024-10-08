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
    public partial class frm_MuonSach : Form
    {
        public frm_MuonSach()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();
        public void LoadDon()
        {
            String sql = "Select * from MUONSACH";
            dataGridView1.DataSource = lopchung.LoadDuLieu(sql);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_MuonSach_Load(object sender, EventArgs e)
        {
            LoadDon();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            String sqlThem = "Insert into MUONSACH values('" + txt_MaDon.Text + "'," +
                "Convert(DateTime, '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "', 103)," +
                "Convert(DateTime, '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "', 103)," +
                "'" + txt_TenDangNhap.Text + "', '" + txt_MaNV.Text + "', '" + txt_MaSach.Text + "')";
            lopchung.NonQuery(sqlThem);
            LoadDon();
            String sqlGiamSl = "UPDATE SACH SET SoLuong = SoLuong - 1 WHERE MaSach ='" + txt_MaSach.Text + "'";
            lopchung.SuaKhongThongBao(sqlGiamSl);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            String sqlSua = "Update MUONSACH set NgayMuon = Convert(DateTime,'" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "', 103)," +
                "NgayTra = Convert(DateTime,'" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "', 103)," +
                "TenDangNhap = '" + txt_TenDangNhap.Text + "'," +
                "MaNV = '" + txt_MaNV.Text + "'," +
                "MaSach = '" + txt_MaSach.Text + "' WHERE MaDon='" + txt_MaDon.Text + "'";
            lopchung.NonQuery(sqlSua);
            LoadDon();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaDon.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_TenDangNhap.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_MaNV.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_MaSach.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            String sqlXoa = "delete from MUONSACH where MaDon = '" + txt_MaDon.Text + "' ";
            lopchung.NonQuery(sqlXoa);
            LoadDon();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime d2 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
            DateTime d1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            TimeSpan a = d2 - d1;
            int ngay = a.Days;
            if (ngay < 0) MessageBox.Show("Ngày trả phải lớn hơn hoặc bằng ngày mượn");
            else
                lbl_Ngay.Text = "Mượn " + ngay.ToString() + " Ngày";
        }
    }
}

 