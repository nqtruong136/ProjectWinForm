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
