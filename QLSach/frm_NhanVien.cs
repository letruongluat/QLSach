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
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();
        public void LoadNV()
        {
            String sql = "Select * from NHANVIEN";
            dataGridView1.DataSource = lopchung.LoadDuLieu(sql);
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            rbt_Nam.Checked = true;
            LoadNV();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            String gt = "Nam";
            if (rbt_Nu.Checked == true) gt = "Nữ";
            String sqlThem = "INSERT INTO NHANVIEN VALUES('" + txt_MaNV.Text + "', " +
                "N'" + txt_HoTen.Text + "', " +
                "Convert(DateTime, '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "', 103)," +
                "'" + txt_SDT.Text + "', " +
                "N'" + gt + "', " +
                "N'" + txt_CCCD.Text + "', " +
                "N'" + txt_DiaChi.Text + "') ";
            ;
            lopchung.NonQuery(sqlThem);
            LoadNV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            String gt = "Nam";
            if (rbt_Nu.Checked == true) gt = "Nữ";
            String sqlSua = "UPDATE NHANVIEN SET HoTen = N'" + txt_HoTen.Text + "', " +
                "NgaySinh = Convert(DateTime, '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "', 103), " +
                "SoDienThoai = '" + txt_SDT.Text + "', " +
                "GioiTinh = N'" + gt + "', " +
                "CCCD = '" + txt_CCCD.Text + "', " +
                "DiaChi = N'" + txt_DiaChi.Text + "' " +
                "WHERE MaNV = '" + txt_MaNV.Text + "'";
            lopchung.NonQuery(sqlSua);
            LoadNV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_HoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_SDT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            String gt = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (gt == "Nam") rbt_Nam.Checked = true;
            else rbt_Nu.Checked = true;
            txt_CCCD.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            String sqlXoa = "Delete from NHANVIEN where MaNV = '" + txt_MaNV.Text + "'";
            lopchung.NonQuery(sqlXoa);
            LoadNV();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

