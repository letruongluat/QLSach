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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private void quanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_KhachHang"] == null)
            {
                frm_KhachHang fkh = new frm_KhachHang();
                fkh.MdiParent = this;
                fkh.Show();
            }
            else
            {
                Application.OpenForms["frm_KhachHang"].Activate();
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void quanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Sach"] == null)
            {
                frm_Sach fs = new frm_Sach();
                fs.MdiParent = this;
                fs.Show();
            }
            else
            {
                Application.OpenForms["frm_Sach"].Activate();
            }
        }

        private void quảnLýMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_MuonSach"] == null)
            {
                frm_MuonSach fms = new frm_MuonSach();
                fms.MdiParent = this;
                fms.Show();
            }
            else
            {
                Application.OpenForms["frm_MuonSach"].Activate();
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien fnv = new frm_NhanVien();
                fnv.MdiParent = this;
                fnv.Show();
            }
            else
            {
                Application.OpenForms["frm_NhanVien"].Activate();
            }
        }
    }
}


