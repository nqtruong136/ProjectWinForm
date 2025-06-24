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
    public partial class Index : Form
    {
        
        public string codeUser;
        public string codeRole;
        UserControl_Pos ucPOS ;
        public Index(string nameuser,string codeuser,string coderole)
        {
            InitializeComponent();
            statusUser.Text = "Xin Chào '"+CurrentUserSession.HoVaTen+"'";
            
            this.codeRole = CurrentUserSession.MaVaiTro.ToString();
            this.codeUser = CurrentUserSession.MaNguoiDung.ToString();
            if (!this.DesignMode)
            {
                PhanQuyen();
            }
        }
        private void PhanQuyen()
        {
            // Giả sử: 1 = Admin, 2 = Quản lý, 3 = Nhân viên
            // Và bạn có các nút: btnNhanVien, btnKho, btnBaoCao

            if (this.codeRole == "1") // Nếu là Admin
            {
                // Admin thấy tất cả
                
            }
            else if (this.codeRole == "2") // Nếu là Quản lý
            {
                tạoTàiKhoảnToolStripMenuItem.Enabled = false;
            }
            else // Mặc định là Nhân viên
            {
                quảnLýKhôToolStripMenuItem.Enabled = false;
                quảnLýSảnPhẩmToolStripMenuItem1.Enabled = false;
            }
        }
        private void ShowUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();             // Xóa những control hiện tại (ẩn tất cả)
            uc.Dock = DockStyle.Fill;               // Cho UserControl chiếm hết panel
            try
            {
                pnlContent.Controls.Add(uc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chi tiết: " + ex.Message + "\nStackTrace:\n" + ex.StackTrace);
            
            } 
        }
                       // Thêm control mới vào sân khấu
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (!this.DesignMode)
            {
                if (ucPOS == null || ucPOS.IsDisposed)
                {
                    ucPOS = new UserControl_Pos();
                }
                ShowUserControl(ucPOS);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusDatetime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            
        }

        private void Index_Load(object sender, EventArgs e)
        {

            if (!this.DesignMode)
            {
                statusDatetime.ForeColor = Color.Blue;
                timerdatetime.Start();
            }
        }
        
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Hiển thị hộp thoại xác nhận
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?",
                                                   "Xác nhận",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // 1. Đóng Form Index hiện tại
                

                // 2. Tìm FormLogin trong số các form đang mở bằng tên của nó ("FormLogin")
                Form loginForm = Application.OpenForms["FormLogin"];

                if (loginForm != null)
                {

                    CurrentUserSession.Clear();

                    ((FormLogin)loginForm).ResetPass();
                    // 3. Nếu tìm thấy, hiển thị nó trở lại
                    loginForm.Show();
                    this.Close();
                    
                }
                else
                {
                    // Trường hợp dự phòng nếu FormLogin đã bị đóng vì lý do nào đó
                    // thì thoát hoàn toàn ứng dụng.
                    Application.Exit();
                }
            }

        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerdatetime.Stop();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Hiển thị hộp thoại xác nhận để tăng trải nghiệm người dùng
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?",
                                                      "Xác nhận",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Nếu người dùng chọn "Yes", thoát hoàn toàn ứng dụng.
                    // Lệnh này sẽ đóng tất cả các form, kể cả FormLogin đang bị ẩn.
                    Application.Exit();
                }
                else
                {
                    // Nếu người dùng chọn "No", hủy hành động đóng form.
                    // Form sẽ không bị đóng lại.
                    e.Cancel = true;
                }
            }
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýKhôToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*step 1*/
            KhoHang kh = new KhoHang();
            ShowUserControl(kh);
        }

        private void quảnLýSảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*step 2*/

        }

        private void quảnLýDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*step 3*/
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*step 4*/
            frmquanlynv ff = new frmquanlynv();
            ShowUserControl(ff);
        }

        

        private void xemHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemVàChỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
