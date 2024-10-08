
namespace QLSach
{
    partial class frm_Sach
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
            this.cb_DanhMuc = new System.Windows.Forms.ComboBox();
            this.txt_Mota = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_NXB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TacGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_MaDanhMuc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TenDanhMuc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_ThemDM = new System.Windows.Forms.Button();
            this.btn_XoaDM = new System.Windows.Forms.Button();
            this.btn_LoadDM = new System.Windows.Forms.Button();
            this.btn_LoadSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_DanhMuc
            // 
            this.cb_DanhMuc.FormattingEnabled = true;
            this.cb_DanhMuc.Location = new System.Drawing.Point(651, 152);
            this.cb_DanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_DanhMuc.Name = "cb_DanhMuc";
            this.cb_DanhMuc.Size = new System.Drawing.Size(231, 28);
            this.cb_DanhMuc.TabIndex = 29;
            this.cb_DanhMuc.SelectedIndexChanged += new System.EventHandler(this.cb_DanhMuc_SelectedIndexChanged);
            // 
            // txt_Mota
            // 
            this.txt_Mota.Location = new System.Drawing.Point(191, 329);
            this.txt_Mota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Mota.Multiline = true;
            this.txt_Mota.Name = "txt_Mota";
            this.txt_Mota.Size = new System.Drawing.Size(691, 148);
            this.txt_Mota.TabIndex = 28;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(651, 88);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(231, 26);
            this.txt_SoLuong.TabIndex = 25;
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Location = new System.Drawing.Point(191, 154);
            this.txt_TenSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(231, 26);
            this.txt_TenSach.TabIndex = 24;
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Location = new System.Drawing.Point(191, 85);
            this.txt_MaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(231, 26);
            this.txt_MaSach.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(508, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(25, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(466, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mã danh mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(25, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(412, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "QUẢN LÝ SÁCH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_NXB
            // 
            this.cb_NXB.FormattingEnabled = true;
            this.cb_NXB.Location = new System.Drawing.Point(651, 218);
            this.cb_NXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_NXB.Name = "cb_NXB";
            this.cb_NXB.Size = new System.Drawing.Size(231, 28);
            this.cb_NXB.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(547, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 26);
            this.label7.TabIndex = 30;
            this.label7.Text = "NXB";
            // 
            // txt_TacGia
            // 
            this.txt_TacGia.Location = new System.Drawing.Point(191, 218);
            this.txt_TacGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TacGia.Name = "txt_TacGia";
            this.txt_TacGia.Size = new System.Drawing.Size(231, 26);
            this.txt_TacGia.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(30, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 26);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tác Giả";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 548);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1282, 261);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Location = new System.Drawing.Point(27, 491);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(91, 49);
            this.btn_Them.TabIndex = 35;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(159, 491);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(91, 49);
            this.btn_Xoa.TabIndex = 36;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(300, 491);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(91, 49);
            this.btn_Sua.TabIndex = 37;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Dong.Location = new System.Drawing.Point(792, 491);
            this.btn_Dong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(91, 49);
            this.btn_Dong.TabIndex = 38;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(22, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 26);
            this.label9.TabIndex = 39;
            this.label9.Text = "Ngày Nhập Sách";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(214, 270);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 35);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // txt_MaDanhMuc
            // 
            this.txt_MaDanhMuc.Location = new System.Drawing.Point(1080, 46);
            this.txt_MaDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaDanhMuc.Name = "txt_MaDanhMuc";
            this.txt_MaDanhMuc.Size = new System.Drawing.Size(231, 26);
            this.txt_MaDanhMuc.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(918, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 26);
            this.label10.TabIndex = 41;
            this.label10.Text = "Mã Danh Mục";
            // 
            // txt_TenDanhMuc
            // 
            this.txt_TenDanhMuc.Location = new System.Drawing.Point(1081, 88);
            this.txt_TenDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenDanhMuc.Name = "txt_TenDanhMuc";
            this.txt_TenDanhMuc.Size = new System.Drawing.Size(231, 26);
            this.txt_TenDanhMuc.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(918, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 26);
            this.label11.TabIndex = 43;
            this.label11.Text = "Tên Danh Mục";
            // 
            // btn_ThemDM
            // 
            this.btn_ThemDM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemDM.Location = new System.Drawing.Point(939, 141);
            this.btn_ThemDM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ThemDM.Name = "btn_ThemDM";
            this.btn_ThemDM.Size = new System.Drawing.Size(183, 49);
            this.btn_ThemDM.TabIndex = 45;
            this.btn_ThemDM.Text = "Thêm danh mục";
            this.btn_ThemDM.UseVisualStyleBackColor = true;
            this.btn_ThemDM.Click += new System.EventHandler(this.btn_ThemDM_Click);
            // 
            // btn_XoaDM
            // 
            this.btn_XoaDM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaDM.Location = new System.Drawing.Point(1169, 140);
            this.btn_XoaDM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XoaDM.Name = "btn_XoaDM";
            this.btn_XoaDM.Size = new System.Drawing.Size(91, 49);
            this.btn_XoaDM.TabIndex = 46;
            this.btn_XoaDM.Text = "Xóa";
            this.btn_XoaDM.UseVisualStyleBackColor = true;
            this.btn_XoaDM.Click += new System.EventHandler(this.btn_XoaDM_Click);
            // 
            // btn_LoadDM
            // 
            this.btn_LoadDM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_LoadDM.Location = new System.Drawing.Point(939, 340);
            this.btn_LoadDM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LoadDM.Name = "btn_LoadDM";
            this.btn_LoadDM.Size = new System.Drawing.Size(183, 49);
            this.btn_LoadDM.TabIndex = 47;
            this.btn_LoadDM.Text = "Load Danh mục";
            this.btn_LoadDM.UseVisualStyleBackColor = true;
            this.btn_LoadDM.Click += new System.EventHandler(this.btn_LoadDM_Click);
            // 
            // btn_LoadSach
            // 
            this.btn_LoadSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_LoadSach.Location = new System.Drawing.Point(1130, 340);
            this.btn_LoadSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LoadSach.Name = "btn_LoadSach";
            this.btn_LoadSach.Size = new System.Drawing.Size(183, 49);
            this.btn_LoadSach.TabIndex = 48;
            this.btn_LoadSach.Text = "Load Sách";
            this.btn_LoadSach.UseVisualStyleBackColor = true;
            this.btn_LoadSach.Click += new System.EventHandler(this.btn_LoadSach_Click);
            // 
            // frm_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1325, 892);
            this.Controls.Add(this.btn_LoadSach);
            this.Controls.Add(this.btn_LoadDM);
            this.Controls.Add(this.btn_XoaDM);
            this.Controls.Add(this.btn_ThemDM);
            this.Controls.Add(this.txt_TenDanhMuc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_MaDanhMuc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_TacGia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_NXB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_DanhMuc);
            this.Controls.Add(this.txt_Mota);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.txt_TenSach);
            this.Controls.Add(this.txt_MaSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_Sach";
            this.Load += new System.EventHandler(this.frm_Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_DanhMuc;
        private System.Windows.Forms.TextBox txt_Mota;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_NXB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TacGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_MaDanhMuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TenDanhMuc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_ThemDM;
        private System.Windows.Forms.Button btn_XoaDM;
        private System.Windows.Forms.Button btn_LoadDM;
        private System.Windows.Forms.Button btn_LoadSach;
    }
}