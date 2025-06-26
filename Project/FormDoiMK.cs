using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormDoiMK : Form
    {
        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các textbox
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string xacNhanMKMoi = txtXacNhanMKMoi.Text;

            // --- BẮT ĐẦU KIỂM TRA DỮ LIỆU ---

            // 1. Kiểm tra các ô có bị bỏ trống không
            if (string.IsNullOrWhiteSpace(matKhauCu) || string.IsNullOrWhiteSpace(matKhauMoi) || string.IsNullOrWhiteSpace(xacNhanMKMoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra mật khẩu mới và xác nhận có trùng khớp không
            if (matKhauMoi != xacNhanMKMoi)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không trùng khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Kiểm tra mật khẩu mới có trùng với mật khẩu cũ không
            if (matKhauMoi == matKhauCu)
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Lấy ID người dùng hiện tại từ Session
            int currentUserId = CurrentUserSession.MaNguoiDung;

            // 5. Lấy mật khẩu cũ từ CSDL để so sánh
            string dbPassword = HAMXULY.GetUserPassword(currentUserId);
            if (dbPassword == null || dbPassword != matKhauCu)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- NẾU TẤT CẢ ĐỀU HỢP LỆ ---
            if (HAMXULY.UpdateUserPassword(currentUserId, matKhauMoi))
            {
                MessageBox.Show("Đổi mật khẩu thành công! Bạn sẽ được đăng xuất để đăng nhập lại.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Gán DialogResult để Form Index biết là đã thành công
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, không thể cập nhật mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMatKhau.Checked)
            {
                txtMatKhauCu.PasswordChar = '\0'; // \0 là ký tự rỗng
                txtMatKhauMoi.PasswordChar = '\0';
                txtXacNhanMKMoi.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauCu.PasswordChar = '*';
                txtMatKhauMoi.PasswordChar = '*';
                txtXacNhanMKMoi.PasswordChar = '*';
            }
        }

        private void FormDoiMK_Load(object sender, EventArgs e)
        {

        }
    }
}
