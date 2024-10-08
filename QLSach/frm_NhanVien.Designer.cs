
namespace QLSach
{
    partial class frm_NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbt_Nam = new System.Windows.Forms.RadioButton();
            this.rbt_Nu = new System.Windows.Forms.RadioButton();
            this.gr_GioiTinh = new System.Windows.Forms.GroupBox();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.gr_GioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(515, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(207, 88);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(299, 26);
            this.txt_MaNV.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã Nhân viên";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(207, 122);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(299, 26);
            this.txt_HoTen.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(40, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(40, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 156);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 35);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // rbt_Nam
            // 
            this.rbt_Nam.AutoSize = true;
            this.rbt_Nam.Location = new System.Drawing.Point(7, 35);
            this.rbt_Nam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbt_Nam.Name = "rbt_Nam";
            this.rbt_Nam.Size = new System.Drawing.Size(85, 30);
            this.rbt_Nam.TabIndex = 42;
            this.rbt_Nam.TabStop = true;
            this.rbt_Nam.Text = "Nam";
            this.rbt_Nam.UseVisualStyleBackColor = true;
            // 
            // rbt_Nu
            // 
            this.rbt_Nu.AutoSize = true;
            this.rbt_Nu.Location = new System.Drawing.Point(133, 38);
            this.rbt_Nu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbt_Nu.Name = "rbt_Nu";
            this.rbt_Nu.Size = new System.Drawing.Size(68, 30);
            this.rbt_Nu.TabIndex = 43;
            this.rbt_Nu.TabStop = true;
            this.rbt_Nu.Text = "Nữ";
            this.rbt_Nu.UseVisualStyleBackColor = true;
            // 
            // gr_GioiTinh
            // 
            this.gr_GioiTinh.Controls.Add(this.rbt_Nam);
            this.gr_GioiTinh.Controls.Add(this.rbt_Nu);
            this.gr_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_GioiTinh.Location = new System.Drawing.Point(769, 69);
            this.gr_GioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gr_GioiTinh.Name = "gr_GioiTinh";
            this.gr_GioiTinh.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gr_GioiTinh.Size = new System.Drawing.Size(215, 81);
            this.gr_GioiTinh.TabIndex = 45;
            this.gr_GioiTinh.TabStop = false;
            this.gr_GioiTinh.Text = "Giới tính";
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Location = new System.Drawing.Point(936, 165);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(231, 26);
            this.txt_CCCD.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(769, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 26);
            this.label5.TabIndex = 46;
            this.label5.Text = "CCCD";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(207, 215);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(299, 26);
            this.txt_SDT.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(40, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 26);
            this.label6.TabIndex = 48;
            this.label6.Text = "Số điện thoại";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(936, 216);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(231, 26);
            this.txt_DiaChi.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(769, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 26);
            this.label7.TabIndex = 50;
            this.label7.Text = "Địa chỉ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 322);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 281);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Location = new System.Drawing.Point(45, 266);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(91, 49);
            this.btn_Them.TabIndex = 53;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(192, 266);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(91, 49);
            this.btn_Sua.TabIndex = 54;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(348, 266);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(91, 49);
            this.btn_Xoa.TabIndex = 55;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Dong.Location = new System.Drawing.Point(1095, 266);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(91, 49);
            this.btn_Dong.TabIndex = 56;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1325, 892);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_CCCD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gr_GioiTinh);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_NhanVien";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            this.gr_GioiTinh.ResumeLayout(false);
            this.gr_GioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbt_Nam;
        private System.Windows.Forms.RadioButton rbt_Nu;
        private System.Windows.Forms.GroupBox gr_GioiTinh;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Dong;
    }
}