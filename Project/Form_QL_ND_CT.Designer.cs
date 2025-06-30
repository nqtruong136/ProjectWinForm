
namespace Project
{
    partial class Form_QL_ND_CT
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtEma = new System.Windows.Forms.TextBox();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.rdoNV = new System.Windows.Forms.RadioButton();
            this.rdoQL = new System.Windows.Forms.RadioButton();
            this.rdoAD = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEtk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCT_TT = new System.Windows.Forms.Panel();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlCT_TK = new System.Windows.Forms.Panel();
            this.txtVT = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlEdit.SuspendLayout();
            this.pnlCT_TT.SuspendLayout();
            this.pnlCT_TK.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 48);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Người Dùng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEma
            // 
            this.txtEma.Location = new System.Drawing.Point(193, 39);
            this.txtEma.Name = "txtEma";
            this.txtEma.Size = new System.Drawing.Size(157, 22);
            this.txtEma.TabIndex = 5;
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.SystemColors.Info;
            this.pnlEdit.Controls.Add(this.txtEdt);
            this.pnlEdit.Controls.Add(this.label13);
            this.pnlEdit.Controls.Add(this.rdoNV);
            this.pnlEdit.Controls.Add(this.rdoQL);
            this.pnlEdit.Controls.Add(this.rdoAD);
            this.pnlEdit.Controls.Add(this.label6);
            this.pnlEdit.Controls.Add(this.txtEmk);
            this.pnlEdit.Controls.Add(this.label4);
            this.pnlEdit.Controls.Add(this.txtEtk);
            this.pnlEdit.Controls.Add(this.label3);
            this.pnlEdit.Controls.Add(this.txtEdc);
            this.pnlEdit.Controls.Add(this.label2);
            this.pnlEdit.Controls.Add(this.txtEten);
            this.pnlEdit.Controls.Add(this.label1);
            this.pnlEdit.Controls.Add(this.txtEma);
            this.pnlEdit.Controls.Add(this.label5);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(444, 550);
            this.pnlEdit.TabIndex = 6;
            // 
            // rdoNV
            // 
            this.rdoNV.AutoSize = true;
            this.rdoNV.Checked = true;
            this.rdoNV.Location = new System.Drawing.Point(193, 496);
            this.rdoNV.Name = "rdoNV";
            this.rdoNV.Size = new System.Drawing.Size(95, 21);
            this.rdoNV.TabIndex = 17;
            this.rdoNV.TabStop = true;
            this.rdoNV.Text = "Nhân Viên";
            this.rdoNV.UseVisualStyleBackColor = true;
            // 
            // rdoQL
            // 
            this.rdoQL.AutoSize = true;
            this.rdoQL.Location = new System.Drawing.Point(193, 469);
            this.rdoQL.Name = "rdoQL";
            this.rdoQL.Size = new System.Drawing.Size(83, 21);
            this.rdoQL.TabIndex = 16;
            this.rdoQL.Text = "Quản Lý";
            this.rdoQL.UseVisualStyleBackColor = true;
            // 
            // rdoAD
            // 
            this.rdoAD.AutoSize = true;
            this.rdoAD.Location = new System.Drawing.Point(193, 442);
            this.rdoAD.Name = "rdoAD";
            this.rdoAD.Size = new System.Drawing.Size(68, 21);
            this.rdoAD.TabIndex = 15;
            this.rdoAD.Text = "Admin";
            this.rdoAD.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 48);
            this.label6.TabIndex = 14;
            this.label6.Text = "Vai Trò";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmk
            // 
            this.txtEmk.Location = new System.Drawing.Point(193, 392);
            this.txtEmk.Name = "txtEmk";
            this.txtEmk.Size = new System.Drawing.Size(157, 22);
            this.txtEmk.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 48);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mật Khẩu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEtk
            // 
            this.txtEtk.Location = new System.Drawing.Point(193, 339);
            this.txtEtk.Name = "txtEtk";
            this.txtEtk.Size = new System.Drawing.Size(157, 22);
            this.txtEtk.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 48);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tài Khoản";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEdc
            // 
            this.txtEdc.Location = new System.Drawing.Point(193, 141);
            this.txtEdc.Name = "txtEdc";
            this.txtEdc.Size = new System.Drawing.Size(157, 22);
            this.txtEdc.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "Địa Chỉ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEten
            // 
            this.txtEten.Location = new System.Drawing.Point(193, 84);
            this.txtEten.Name = "txtEten";
            this.txtEten.Size = new System.Drawing.Size(157, 22);
            this.txtEten.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ Tên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCT_TT
            // 
            this.pnlCT_TT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCT_TT.Controls.Add(this.label7);
            this.pnlCT_TT.Controls.Add(this.txtSDT);
            this.pnlCT_TT.Controls.Add(this.txtDC);
            this.pnlCT_TT.Controls.Add(this.label9);
            this.pnlCT_TT.Controls.Add(this.txtTen);
            this.pnlCT_TT.Controls.Add(this.label8);
            this.pnlCT_TT.Location = new System.Drawing.Point(573, 25);
            this.pnlCT_TT.Name = "pnlCT_TT";
            this.pnlCT_TT.Size = new System.Drawing.Size(388, 205);
            this.pnlCT_TT.TabIndex = 7;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(147, 102);
            this.txtDC.Name = "txtDC";
            this.txtDC.ReadOnly = true;
            this.txtDC.Size = new System.Drawing.Size(205, 22);
            this.txtDC.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 48);
            this.label9.TabIndex = 20;
            this.label9.Text = "Địa Chỉ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(147, 45);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(205, 22);
            this.txtTen.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 48);
            this.label8.TabIndex = 18;
            this.label8.Text = "Họ Và Tên";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCT_TK
            // 
            this.pnlCT_TK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCT_TK.Controls.Add(this.txtVT);
            this.pnlCT_TK.Controls.Add(this.txtMK);
            this.pnlCT_TK.Controls.Add(this.label12);
            this.pnlCT_TK.Controls.Add(this.txtTK);
            this.pnlCT_TK.Controls.Add(this.label11);
            this.pnlCT_TK.Controls.Add(this.label10);
            this.pnlCT_TK.Location = new System.Drawing.Point(573, 236);
            this.pnlCT_TK.Name = "pnlCT_TK";
            this.pnlCT_TK.Size = new System.Drawing.Size(275, 302);
            this.pnlCT_TK.TabIndex = 8;
            // 
            // txtVT
            // 
            this.txtVT.BackColor = System.Drawing.SystemColors.Control;
            this.txtVT.Location = new System.Drawing.Point(129, 32);
            this.txtVT.Name = "txtVT";
            this.txtVT.Size = new System.Drawing.Size(127, 22);
            this.txtVT.TabIndex = 28;
            // 
            // txtMK
            // 
            this.txtMK.BackColor = System.Drawing.SystemColors.Control;
            this.txtMK.Location = new System.Drawing.Point(129, 251);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(127, 22);
            this.txtMK.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 48);
            this.label12.TabIndex = 26;
            this.label12.Text = "Mật Khẩu";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTK
            // 
            this.txtTK.BackColor = System.Drawing.SystemColors.Control;
            this.txtTK.Location = new System.Drawing.Point(129, 147);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(127, 22);
            this.txtTK.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 48);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tài Khoản";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 48);
            this.label10.TabIndex = 22;
            this.label10.Text = "Vai Trò";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(467, 43);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(467, 101);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(467, 418);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 30);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.Location = new System.Drawing.Point(866, 363);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(82, 63);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(467, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(467, 372);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLua_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(147, 158);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(205, 22);
            this.txtSDT.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 48);
            this.label7.TabIndex = 23;
            this.label7.Text = "SDT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEdt
            // 
            this.txtEdt.Location = new System.Drawing.Point(193, 193);
            this.txtEdt.Name = "txtEdt";
            this.txtEdt.Size = new System.Drawing.Size(157, 22);
            this.txtEdt.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(53, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 48);
            this.label13.TabIndex = 18;
            this.label13.Text = "SDT";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_QL_ND_CT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(973, 550);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pnlCT_TK);
            this.Controls.Add(this.pnlCT_TT);
            this.Controls.Add(this.pnlEdit);
            this.Name = "Form_QL_ND_CT";
            this.Text = "Form_QL_ND_CT";
            this.Load += new System.EventHandler(this.Form_QL_ND_CT_Load);
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.pnlCT_TT.ResumeLayout(false);
            this.pnlCT_TT.PerformLayout();
            this.pnlCT_TK.ResumeLayout(false);
            this.pnlCT_TK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEma;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEtk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCT_TT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlCT_TK;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdoNV;
        private System.Windows.Forms.RadioButton rdoQL;
        private System.Windows.Forms.RadioButton rdoAD;
        private System.Windows.Forms.TextBox txtVT;
        private System.Windows.Forms.TextBox txtEdt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDT;
    }
}