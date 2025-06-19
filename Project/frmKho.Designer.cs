namespace Project
{
    partial class frmKho
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtSoTon = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.LuoiKhoHang = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlkho = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LuoiKhoHang)).BeginInit();
            this.pnlkho.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Tồn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn vị tính";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(134, 15);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(231, 34);
            this.txtMaHang.TabIndex = 4;
            // 
            // txtSoTon
            // 
            this.txtSoTon.Location = new System.Drawing.Point(134, 99);
            this.txtSoTon.Name = "txtSoTon";
            this.txtSoTon.Size = new System.Drawing.Size(150, 34);
            this.txtSoTon.TabIndex = 5;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(506, 15);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(224, 34);
            this.txtTenHang.TabIndex = 6;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(506, 99);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(137, 34);
            this.txtDVT.TabIndex = 7;
            // 
            // LuoiKhoHang
            // 
            this.LuoiKhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LuoiKhoHang.Location = new System.Drawing.Point(41, 244);
            this.LuoiKhoHang.Name = "LuoiKhoHang";
            this.LuoiKhoHang.RowHeadersWidth = 51;
            this.LuoiKhoHang.RowTemplate.Height = 24;
            this.LuoiKhoHang.Size = new System.Drawing.Size(769, 177);
            this.LuoiKhoHang.TabIndex = 8;
            this.LuoiKhoHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LuoiKhoHang_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 464);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 41);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(173, 464);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 41);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(303, 464);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 41);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(438, 464);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 41);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(574, 464);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 41);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(689, 464);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(85, 41);
            this.btnDong.TabIndex = 14;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "QUẢN LÝ KHO ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlkho
            // 
            this.pnlkho.Controls.Add(this.txtDVT);
            this.pnlkho.Controls.Add(this.txtTenHang);
            this.pnlkho.Controls.Add(this.txtSoTon);
            this.pnlkho.Controls.Add(this.txtMaHang);
            this.pnlkho.Controls.Add(this.label4);
            this.pnlkho.Controls.Add(this.label3);
            this.pnlkho.Controls.Add(this.label2);
            this.pnlkho.Controls.Add(this.label1);
            this.pnlkho.Enabled = false;
            this.pnlkho.Location = new System.Drawing.Point(23, 80);
            this.pnlkho.Name = "pnlkho";
            this.pnlkho.Size = new System.Drawing.Size(787, 150);
            this.pnlkho.TabIndex = 16;
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 543);
            this.Controls.Add(this.pnlkho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.LuoiKhoHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmKho";
            this.Text = "frmKho";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LuoiKhoHang)).EndInit();
            this.pnlkho.ResumeLayout(false);
            this.pnlkho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtSoTon;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.DataGridView LuoiKhoHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlkho;
    }
}