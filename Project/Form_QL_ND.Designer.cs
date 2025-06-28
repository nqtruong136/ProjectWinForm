
namespace Project
{
    partial class Form_QL_ND
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
            this.dgvQLND = new System.Windows.Forms.DataGridView();
            this.MaNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLND)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Người Dùng";
            // 
            // dgvQLND
            // 
            this.dgvQLND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNguoiDung,
            this.TenDangNhap,
            this.MatKhau,
            this.HoVaTen,
            this.SoDienThoai,
            this.DiaChi,
            this.VaiTro,
            this.TrangThai});
            this.dgvQLND.Location = new System.Drawing.Point(30, 101);
            this.dgvQLND.Name = "dgvQLND";
            this.dgvQLND.RowHeadersWidth = 51;
            this.dgvQLND.RowTemplate.Height = 24;
            this.dgvQLND.Size = new System.Drawing.Size(1094, 408);
            this.dgvQLND.TabIndex = 1;
            // 
            // MaNguoiDung
            // 
            this.MaNguoiDung.HeaderText = "Mã Người Dùng";
            this.MaNguoiDung.MinimumWidth = 6;
            this.MaNguoiDung.Name = "MaNguoiDung";
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Width = 130;
            // 
            // MatKhau
            // 
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 125;
            // 
            // HoVaTen
            // 
            this.HoVaTen.HeaderText = "Họ và Tên";
            this.HoVaTen.MinimumWidth = 6;
            this.HoVaTen.Name = "HoVaTen";
            this.HoVaTen.Width = 145;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 130;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 160;
            // 
            // VaiTro
            // 
            this.VaiTro.HeaderText = "Vai Trò";
            this.VaiTro.MinimumWidth = 6;
            this.VaiTro.Name = "VaiTro";
            this.VaiTro.Width = 120;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái Hoạt Động";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 130;
            // 
            // Form_QL_ND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 554);
            this.Controls.Add(this.dgvQLND);
            this.Controls.Add(this.label1);
            this.Name = "Form_QL_ND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Người Dùng";
            this.Load += new System.EventHandler(this.Form_QL_ND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLND)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQLND;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}