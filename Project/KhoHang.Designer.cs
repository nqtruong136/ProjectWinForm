namespace Project
{
    partial class KhoHang
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
            this.LuoiKho = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.txtSoton = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.pnlKho = new System.Windows.Forms.Panel();
            this.bntThem = new System.Windows.Forms.Button();
            this.bntDong = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntLuu = new System.Windows.Forms.Button();
            this.bntHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LuoiKho)).BeginInit();
            this.pnlKho.SuspendLayout();
            this.SuspendLayout();
            // 
            // LuoiKho
            // 
            this.LuoiKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LuoiKho.Location = new System.Drawing.Point(60, 213);
            this.LuoiKho.Name = "LuoiKho";
            this.LuoiKho.RowHeadersWidth = 51;
            this.LuoiKho.RowTemplate.Height = 24;
            this.LuoiKho.Size = new System.Drawing.Size(690, 186);
            this.LuoiKho.TabIndex = 0;
            this.LuoiKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Kho Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Tồn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn vị tính";
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(161, 13);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(175, 34);
            this.txtMahang.TabIndex = 6;
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(512, 13);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(198, 34);
            this.txtTenhang.TabIndex = 7;
            // 
            // txtSoton
            // 
            this.txtSoton.Location = new System.Drawing.Point(161, 82);
            this.txtSoton.Name = "txtSoton";
            this.txtSoton.Size = new System.Drawing.Size(119, 34);
            this.txtSoton.TabIndex = 8;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(512, 80);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(123, 34);
            this.txtDVT.TabIndex = 9;
            // 
            // pnlKho
            // 
            this.pnlKho.Controls.Add(this.txtDVT);
            this.pnlKho.Controls.Add(this.txtSoton);
            this.pnlKho.Controls.Add(this.txtTenhang);
            this.pnlKho.Controls.Add(this.txtMahang);
            this.pnlKho.Controls.Add(this.label5);
            this.pnlKho.Controls.Add(this.label4);
            this.pnlKho.Controls.Add(this.label3);
            this.pnlKho.Controls.Add(this.label2);
            this.pnlKho.Location = new System.Drawing.Point(25, 62);
            this.pnlKho.Name = "pnlKho";
            this.pnlKho.Size = new System.Drawing.Size(754, 139);
            this.pnlKho.TabIndex = 10;
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(25, 436);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(108, 43);
            this.bntThem.TabIndex = 11;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntDong
            // 
            this.bntDong.Location = new System.Drawing.Point(678, 436);
            this.bntDong.Name = "bntDong";
            this.bntDong.Size = new System.Drawing.Size(101, 43);
            this.bntDong.TabIndex = 12;
            this.bntDong.Text = "Đóng";
            this.bntDong.UseVisualStyleBackColor = true;
            this.bntDong.Click += new System.EventHandler(this.bntDong_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Location = new System.Drawing.Point(166, 436);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(93, 43);
            this.bntXoa.TabIndex = 13;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntSua
            // 
            this.bntSua.Location = new System.Drawing.Point(292, 436);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(91, 43);
            this.bntSua.TabIndex = 14;
            this.bntSua.Text = "Sửa";
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // bntLuu
            // 
            this.bntLuu.Location = new System.Drawing.Point(424, 436);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(96, 43);
            this.bntLuu.TabIndex = 15;
            this.bntLuu.Text = "Lưu";
            this.bntLuu.UseVisualStyleBackColor = true;
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // bntHuy
            // 
            this.bntHuy.Location = new System.Drawing.Point(546, 436);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(102, 43);
            this.bntHuy.TabIndex = 16;
            this.bntHuy.Text = "Hủy";
            this.bntHuy.UseVisualStyleBackColor = true;
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.bntHuy);
            this.Controls.Add(this.bntLuu);
            this.Controls.Add(this.bntSua);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntDong);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.pnlKho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LuoiKho);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "KhoHang";
            this.Text = "KhoHang";
            this.Load += new System.EventHandler(this.KhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LuoiKho)).EndInit();
            this.pnlKho.ResumeLayout(false);
            this.pnlKho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LuoiKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.TextBox txtSoton;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Panel pnlKho;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button bntDong;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntLuu;
        private System.Windows.Forms.Button bntHuy;
    }
}