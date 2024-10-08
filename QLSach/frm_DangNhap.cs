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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            String sqlDN = "select count (*) from TAIKHOAN " +
                "where TenDangNhap = N'" + txt_TenDangNhap.Text + "' " +
                "and MatKhau = '" + txt_MatKhau.Text + "'";
            int kq = lopchung.Scalar(sqlDN);
            if (kq >= 1)
            {
                frm_Main main = new frm_Main();
                main.Show();
            }
            else MessageBox.Show("Sai tên ĐN hoặc MK");

        }
        int tat = 0;
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ko", "Thông Báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                tat = 1;
                this.Close();
            }
        }

        private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tat == 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn Closing ko", "Thông Báo",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

    