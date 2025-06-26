
namespace Project
{
    partial class UserControl_DoanhThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTaoHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cboflterHTTT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pnl_info_date = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.chkApDungNgay = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.cboHinhThucThanhToan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSoTienKM = new System.Windows.Forms.Label();
            this.lblHT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNguoiTao = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_info_date.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeight = 29;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.HoVaTen,
            this.NgayTaoHoaDon,
            this.TongTien});
            this.dgvHoaDon.Location = new System.Drawing.Point(517, 163);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(831, 429);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            this.dgvHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellDoubleClick);
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDon.MinimumWidth = 6;
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            this.MaHoaDon.Width = 125;
            // 
            // HoVaTen
            // 
            this.HoVaTen.HeaderText = "Người Lập Hóa Đơn";
            this.HoVaTen.MinimumWidth = 6;
            this.HoVaTen.Name = "HoVaTen";
            this.HoVaTen.ReadOnly = true;
            this.HoVaTen.Width = 175;
            // 
            // NgayTaoHoaDon
            // 
            this.NgayTaoHoaDon.HeaderText = "Ngày Tạo";
            this.NgayTaoHoaDon.MinimumWidth = 6;
            this.NgayTaoHoaDon.Name = "NgayTaoHoaDon";
            this.NgayTaoHoaDon.ReadOnly = true;
            this.NgayTaoHoaDon.Width = 200;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 200;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Người Tạo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboflterHTTT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.pnl_info_date);
            this.panel1.Controls.Add(this.chkApDungNgay);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboNguoiTao);
            this.panel1.Controls.Add(this.dgvHoaDon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 635);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Raleway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 44);
            this.label6.TabIndex = 22;
            this.label6.Text = "Quản Lý Doanh Thu";
            // 
            // cboflterHTTT
            // 
            this.cboflterHTTT.FormattingEnabled = true;
            this.cboflterHTTT.Location = new System.Drawing.Point(265, 219);
            this.cboflterHTTT.Name = "cboflterHTTT";
            this.cboflterHTTT.Size = new System.Drawing.Size(188, 24);
            this.cboflterHTTT.TabIndex = 21;
            this.cboflterHTTT.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hình thức thanh toán";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(265, 508);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(114, 45);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // pnl_info_date
            // 
            this.pnl_info_date.Controls.Add(this.label3);
            this.pnl_info_date.Controls.Add(this.label4);
            this.pnl_info_date.Controls.Add(this.dtpDenNgay);
            this.pnl_info_date.Controls.Add(this.dtpTuNgay);
            this.pnl_info_date.Location = new System.Drawing.Point(90, 350);
            this.pnl_info_date.Name = "pnl_info_date";
            this.pnl_info_date.Size = new System.Drawing.Size(302, 114);
            this.pnl_info_date.TabIndex = 18;
            this.pnl_info_date.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "To";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(85, 67);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpDenNgay.TabIndex = 16;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(85, 19);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpTuNgay.TabIndex = 15;
            // 
            // chkApDungNgay
            // 
            this.chkApDungNgay.AutoSize = true;
            this.chkApDungNgay.Location = new System.Drawing.Point(267, 327);
            this.chkApDungNgay.Name = "chkApDungNgay";
            this.chkApDungNgay.Size = new System.Drawing.Size(127, 21);
            this.chkApDungNgay.TabIndex = 17;
            this.chkApDungNgay.Text = "Lọc Theo Ngày";
            this.chkApDungNgay.UseVisualStyleBackColor = true;
            this.chkApDungNgay.CheckedChanged += new System.EventHandler(this.chkApDungNgay_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanel1.Controls.Add(this.lblTongDoanhThu, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboHinhThucThanhToan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSoTienKM, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHT, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(510, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(831, 60);
            this.tableLayoutPanel1.TabIndex = 14;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTongDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(561, 30);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(267, 30);
            this.lblTongDoanhThu.TabIndex = 5;
            this.lblTongDoanhThu.Text = "label13";
            this.lblTongDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboHinhThucThanhToan
            // 
            this.cboHinhThucThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThucThanhToan.FormattingEnabled = true;
            this.cboHinhThucThanhToan.Location = new System.Drawing.Point(3, 3);
            this.cboHinhThucThanhToan.Name = "cboHinhThucThanhToan";
            this.cboHinhThucThanhToan.Size = new System.Drawing.Size(273, 28);
            this.cboHinhThucThanhToan.TabIndex = 0;
            this.cboHinhThucThanhToan.SelectedIndexChanged += new System.EventHandler(this.cboHinhThucThanhToan_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(282, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 30);
            this.label9.TabIndex = 1;
            this.label9.Text = "Số Tiền Đã Khuyến Mãi";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(561, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 30);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tổng Doanh Thu";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoTienKM
            // 
            this.lblSoTienKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSoTienKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoTienKM.Location = new System.Drawing.Point(282, 30);
            this.lblSoTienKM.Name = "lblSoTienKM";
            this.lblSoTienKM.Size = new System.Drawing.Size(273, 30);
            this.lblSoTienKM.TabIndex = 3;
            this.lblSoTienKM.Text = "label11";
            this.lblSoTienKM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHT
            // 
            this.lblHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHT.Location = new System.Drawing.Point(3, 30);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(273, 30);
            this.lblHT.TabIndex = 4;
            this.lblHT.Text = "label12";
            this.lblHT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày Tạo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboNguoiTao
            // 
            this.cboNguoiTao.FormattingEnabled = true;
            this.cboNguoiTao.Location = new System.Drawing.Point(40, 219);
            this.cboNguoiTao.Name = "cboNguoiTao";
            this.cboNguoiTao.Size = new System.Drawing.Size(188, 24);
            this.cboNguoiTao.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1422, 58);
            this.panel2.TabIndex = 3;
            // 
            // UserControl_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UserControl_DoanhThu";
            this.Size = new System.Drawing.Size(1422, 693);
            this.Load += new System.EventHandler(this.UserControl_DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_info_date.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNguoiTao;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboHinhThucThanhToan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblSoTienKM;
        private System.Windows.Forms.Label lblHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTaoHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Panel pnl_info_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.CheckBox chkApDungNgay;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboflterHTTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
