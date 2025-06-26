
namespace Project
{
    partial class FormDoiMK
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
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtXacNhanMKMoi = new System.Windows.Forms.TextBox();
            this.chkHienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu Cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu Mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(253, 111);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '*';
            this.txtMatKhauCu.Size = new System.Drawing.Size(157, 22);
            this.txtMatKhauCu.TabIndex = 3;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(253, 149);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(157, 22);
            this.txtMatKhauMoi.TabIndex = 4;
            // 
            // txtXacNhanMKMoi
            // 
            this.txtXacNhanMKMoi.Location = new System.Drawing.Point(253, 189);
            this.txtXacNhanMKMoi.Name = "txtXacNhanMKMoi";
            this.txtXacNhanMKMoi.PasswordChar = '*';
            this.txtXacNhanMKMoi.Size = new System.Drawing.Size(157, 22);
            this.txtXacNhanMKMoi.TabIndex = 5;
            // 
            // chkHienThiMatKhau
            // 
            this.chkHienThiMatKhau.AutoSize = true;
            this.chkHienThiMatKhau.Location = new System.Drawing.Point(212, 241);
            this.chkHienThiMatKhau.Name = "chkHienThiMatKhau";
            this.chkHienThiMatKhau.Size = new System.Drawing.Size(140, 21);
            this.chkHienThiMatKhau.TabIndex = 6;
            this.chkHienThiMatKhau.Text = "Hiển thị mật khẩu";
            this.chkHienThiMatKhau.UseVisualStyleBackColor = true;
            this.chkHienThiMatKhau.CheckedChanged += new System.EventHandler(this.chkHienThiMatKhau_CheckedChanged);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(133, 303);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(86, 29);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(324, 303);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 29);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 479);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.chkHienThiMatKhau);
            this.Controls.Add(this.txtXacNhanMKMoi);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoiMK";
            this.Load += new System.EventHandler(this.FormDoiMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtXacNhanMKMoi;
        private System.Windows.Forms.CheckBox chkHienThiMatKhau;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
    }
}