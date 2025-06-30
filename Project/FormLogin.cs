using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormLogin : Form
    {

        // === COPY PASTE TOÀN BỘ PHẦN NÀY VÀO FORM CỦA BẠN ===

        // === CÁC BIẾN VÀ HÀM CHO ANIMATION ===

        private Random rand = new Random();

        // Các màu nguồn và đích cho gradient nền
        private Color sourceColor1, targetColor1;
        private Color sourceColor2, targetColor2;

        // Màu nền hiện tại
        private Color currentColor1, currentColor2;

        // Các màu nguồn và đích cho MÀU CHỮ (đơn sắc)
        private Color sourceTextColor, targetTextColor, currentTextColor;

        // Quản lý tiến trình animation
        private int animationDuration = 3000;
        private int totalSteps;
        private int currentStep = 0;

        
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        


        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Khởi tạo màu nền ban đầu
            sourceColor1 = Color.FromArgb(23, 35, 49);
            targetColor1 = Color.FromArgb(41, 57, 80);
            sourceColor2 = Color.FromArgb(14, 22, 33);
            targetColor2 = Color.FromArgb(23, 35, 49);
            currentColor1 = sourceColor1;
            currentColor2 = sourceColor2;

            // Tính toán màu chữ ban đầu dựa trên độ sáng của nền
            double avgBrightness = (GetBrightness(currentColor1) + GetBrightness(currentColor2)) / 2.0;
            currentTextColor = (avgBrightness > 130) ? Color.Black : Color.White;
            sourceTextColor = currentTextColor;
            targetTextColor = currentTextColor;

            // Tính toán các bước cho animation
            totalSteps = animationDuration / timerColorChange.Interval;

            // Bắt đầu timer
            timerColorChange.Enabled = true;
            timerColorChange.Start();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            pnlUnderlineUser.BackColor = Color.Cyan;
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            pnlUnderlineUser.BackColor = Color.Gray;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            pnlUnderlinePass.BackColor = Color.Cyan;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            pnlUnderlinePass.BackColor = Color.Gray;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPass.PasswordChar= '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Boolean KTThongTin()
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Bạn chưa Nhập UserName", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Bạn chưa Nhập PassWord", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            HAMXULY.Connect();
            
            if (KTThongTin())
            {
                string user = txtUser.Text.Trim();
                string pass = txtPass.Text.Trim();
                string query = "SELECT * FROM NguoiDung WHERE TenDangNhap = @tenDN";
                DataTable dttb = new DataTable();

                SqlParameter paramUser = new SqlParameter("@tenDN", user);

                // Dùng hàm truy vấn có tham số an toàn
                if (HAMXULY.TruyVan(query, dttb, paramUser))
                {
                    string status = dttb.Rows[0]["TrangThaiHoatDong"].ToString();
                    Console.WriteLine(status);
                    // Nếu tìm thấy người dùng, bây giờ ta kiểm tra mật khẩu trong code C#
                    if (status == "False") {
                        string dbPass = dttb.Rows[0]["MatKhauMaHoa"].ToString();
                        
                        

                        if (pass == dbPass)
                        {
                            // === ĐĂNG NHẬP THÀNH CÔNG ===
                            this.Hide(); // Ẩn form Login đi

                            // Lấy thông tin
                            string hoVaTen = dttb.Rows[0]["HoVaTen"].ToString();
                            string maNguoiDung = dttb.Rows[0]["MaNguoiDung"].ToString();
                            int maNguoiDungg = Convert.ToInt32(dttb.Rows[0]["MaNguoiDung"]);
                            string maVaiTro = dttb.Rows[0]["MaVaiTro"].ToString();
                            int maVaiTroo = Convert.ToInt32(dttb.Rows[0]["MaVaiTro"]);
                            string tenDangNhap = dttb.Rows[0]["TenDangNhap"].ToString();
                            
                            if (HAMXULY.UpdateStatus(maNguoiDungg.ToString(), "1")>0) ///////////////
                            {
                                //MessageBox.Show("Cập Nhật Trạng Thái Thành Công");
                            }
                            else { MessageBox.Show("Cập Nhật Trạng Thái Thất Bại"); }

                            CurrentUserSession.SetCurrentUser(maNguoiDungg, hoVaTen, maVaiTroo, tenDangNhap,"True");
                            // Tạo và hiển thị form Index
                            Index fm = new Index(hoVaTen, maNguoiDung, maVaiTro);
                            fm.Show(); // Dùng Show() thay vì ShowDialog() để form login có thể bị đóng hoàn toàn
                        }
                        else
                        {
                            // Tìm thấy user nhưng sai mật khẩu
                            MessageBox.Show("Sai mật khẩu. Vui lòng thử lại.");
                            txtPass.Focus();
                        }
                    }
                    else { MessageBox.Show("Tài Khoản Đã Được Đăng Nhập Tại Nơi Khác. Vui Lòng Đăng Xuất Để Tiếp Tục Đăng Nhập "); txtUser.Focus() ; }
                }
                else
                {
                    // Không tìm thấy người dùng
                    MessageBox.Show("Tài khoản không tồn tại ");
                    txtUser.Focus();
                }

            }
        }
        public void ResetPass()
        {
            // Xóa trắng các textbox
            txtPass.Text = "";

            // Có thể thêm logic để trả lại placeholder text nếu bạn có dùng
            // AddPlaceholder(txtUsername, "Nhập tài khoản của bạn");
            // AddPlaceholder(txtPassword, "Nhập mật khẩu");

            // Di chuyển con trỏ về ô username
            txtPass.Focus();
        }

        

        private void pnlLogin_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 1. Vẽ nền gradient cho pnlLogin
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                pnlLogin.ClientRectangle,
                currentColor1,
                currentColor2,
                45f))
            {
                e.Graphics.FillRectangle(brush, pnlLogin.ClientRectangle);
            }

            // 2. Vẽ lại chữ cho các control đã được làm trong suốt nền
            // Dùng TextRenderer để vẽ chữ với MỘT MÀU ĐƠN SẮC
            TextRenderer.DrawText(e.Graphics, btnLogin.Text, btnLogin.Font,
                btnLogin.Bounds, currentTextColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            // Làm tương tự cho các control khác nếu bạn đã set nền trong suốt cho chúng
            // Ví dụ:
            // TextRenderer.DrawText(e.Graphics, lblUsername.Text, lblUsername.Font, lblUsername.Bounds, currentTextColor);
            // TextRenderer.DrawText(e.Graphics, btnThoat.Text, btnThoat.Font, btnThoat.Bounds, currentTextColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

        }

        private void timerColorChange_Tick(object sender, EventArgs e)
        {
            if (currentStep <= totalSteps)
            {
                // Tính toán tiến trình (progress) của animation
                double progress = (double)currentStep / totalSteps;
                progress = progress * progress * (3.0 - 2.0 * progress); // Easing function cho mượt

                // Nội suy màu nền
                currentColor1 = BlendColor(sourceColor1, targetColor1, progress);
                currentColor2 = BlendColor(sourceColor2, targetColor2, progress);

                // Nội suy màu chữ
                currentTextColor = BlendColor(sourceTextColor, targetTextColor, progress);

                currentStep++;
                // Yêu cầu pnlLogin vẽ lại chính nó
                pnlLogin.Invalidate();
            }
            else
            {
                // Khi animation cũ kết thúc, chuẩn bị cho animation mới
                currentStep = 0;

                // Màu nền: đích cũ -> nguồn mới, và tạo ra một đích mới ngẫu nhiên
                sourceColor1 = targetColor1;
                sourceColor2 = targetColor2;
                targetColor1 = Color.FromArgb(rand.Next(60), rand.Next(80), rand.Next(100));
                targetColor2 = Color.FromArgb(rand.Next(20), rand.Next(40), rand.Next(60));

                // MÀU CHỮ: quyết định màu đích mới và bắt đầu chuyển đổi
                sourceTextColor = currentTextColor; // Màu nguồn là màu cuối cùng của lần trước
                double avgBrightness = (GetBrightness(targetColor1) + GetBrightness(targetColor2)) / 2.0;
                targetTextColor = (avgBrightness > 130) ? Color.Black : Color.White; // Quyết định màu đích mới
            }
        }

        

        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        
        private Color BlendColor(Color source, Color target, double progress)
        {
            int r = (int)(source.R + (target.R - source.R) * progress);
            int g = (int)(source.G + (target.G - source.G) * progress);
            int b = (int)(source.B + (target.B - source.B) * progress);
            return Color.FromArgb(r, g, b);
        }

        private int GetBrightness(Color c)
        {
            return (int)Math.Sqrt(
               c.R * c.R * .241 +
               c.G * c.G * .691 +
               c.B * c.B * .068);
        }
    }
}
