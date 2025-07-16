namespace Project
{
    partial class FormSanpham
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
            this.Lable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tjst = new System.Windows.Forms.Label();
            this.qưer = new System.Windows.Forms.Label();
            this.LuoiSP = new System.Windows.Forms.DataGridView();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtDGia = new System.Windows.Forms.TextBox();
            this.txtCtiet = new System.Windows.Forms.TextBox();
            this.CobMaDM = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LuoiSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Danh Mục";
            // 
            // Lable
            // 
            this.Lable.AutoSize = true;
            this.Lable.Location = new System.Drawing.Point(3, 155);
            this.Lable.Name = "Lable";
            this.Lable.Size = new System.Drawing.Size(82, 29);
            this.Lable.TabIndex = 2;
            this.Lable.Text = "Mô Tả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Sản Phẩm";
            // 
            // tjst
            // 
            this.tjst.AutoSize = true;
            this.tjst.Location = new System.Drawing.Point(534, 78);
            this.tjst.Name = "tjst";
            this.tjst.Size = new System.Drawing.Size(100, 29);
            this.tjst.TabIndex = 5;
            this.tjst.Text = "Đơn Giá";
            this.tjst.Click += new System.EventHandler(this.label6_Click);
            // 
            // qưer
            // 
            this.qưer.AutoSize = true;
            this.qưer.Location = new System.Drawing.Point(561, 160);
            this.qưer.Name = "qưer";
            this.qưer.Size = new System.Drawing.Size(97, 29);
            this.qưer.TabIndex = 6;
            this.qưer.Text = "Chi Tiết";
            // 
            // LuoiSP
            // 
            this.LuoiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LuoiSP.Location = new System.Drawing.Point(22, 375);
            this.LuoiSP.Name = "LuoiSP";
            this.LuoiSP.RowHeadersWidth = 51;
            this.LuoiSP.RowTemplate.Height = 24;
            this.LuoiSP.Size = new System.Drawing.Size(1103, 270);
            this.LuoiSP.TabIndex = 7;
            this.LuoiSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LuoiSP_CellContentClick);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(201, 3);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(201, 34);
            this.txtMaSP.TabIndex = 8;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(201, 73);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(303, 34);
            this.txtTenSP.TabIndex = 9;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(201, 155);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(339, 34);
            this.txtMoTa.TabIndex = 10;
            // 
            // txtDGia
            // 
            this.txtDGia.Location = new System.Drawing.Point(699, 78);
            this.txtDGia.Name = "txtDGia";
            this.txtDGia.Size = new System.Drawing.Size(259, 34);
            this.txtDGia.TabIndex = 11;
            // 
            // txtCtiet
            // 
            this.txtCtiet.Location = new System.Drawing.Point(678, 160);
            this.txtCtiet.Name = "txtCtiet";
            this.txtCtiet.Size = new System.Drawing.Size(422, 34);
            this.txtCtiet.TabIndex = 12;
            // 
            // CobMaDM
            // 
            this.CobMaDM.FormattingEnabled = true;
            this.CobMaDM.Location = new System.Drawing.Point(699, 3);
            this.CobMaDM.Name = "CobMaDM";
            this.CobMaDM.Size = new System.Drawing.Size(165, 37);
            this.CobMaDM.TabIndex = 13;
            this.CobMaDM.SelectedIndexChanged += new System.EventHandler(this.CobMaDM_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CobMaDM);
            this.panel1.Controls.Add(this.txtCtiet);
            this.panel1.Controls.Add(this.txtDGia);
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.txtTenSP);
            this.panel1.Controls.Add(this.txtMaSP);
            this.panel1.Controls.Add(this.qưer);
            this.panel1.Controls.Add(this.tjst);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Lable);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 235);
            this.panel1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 36);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quản Lý Sản Phẩm";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(44, 685);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 54);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(223, 685);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(109, 51);
            this.btnsua.TabIndex = 17;
            this.btnsua.Text = "Xóa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(422, 685);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 51);
            this.button3.TabIndex = 18;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(626, 685);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 51);
            this.button4.TabIndex = 19;
            this.button4.Text = "Lưu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(800, 685);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 51);
            this.button5.TabIndex = 20;
            this.button5.Text = "Hủy";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(979, 685);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 51);
            this.button6.TabIndex = 21;
            this.button6.Text = "Đóng";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // FormSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 761);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LuoiSP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormSanpham";
            this.Load += new System.EventHandler(this.FormSanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LuoiSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tjst;
        private System.Windows.Forms.Label qưer;
        private System.Windows.Forms.DataGridView LuoiSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtDGia;
        private System.Windows.Forms.TextBox txtCtiet;
        private System.Windows.Forms.ComboBox CobMaDM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}