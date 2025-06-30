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
        private bool xacnhandongform = false;
        private ToolStripMenuItem currentActiveMenuItem = null;
        private ToolStripMenuItem currentActiveMenuItemchild = null;

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
        
        // Đặt hàm này trong class Index.cs
        private ToolStripMenuItem GetTopLevelMenuItem(ToolStripMenuItem menuItem)
        {
            if (menuItem == null)
            {
                return null;
            }

            // Nếu Owner của menuItem là MenuStrip, thì nó chính là mục cấp cao nhất
            if (menuItem.Owner is MenuStrip)
            {
                return menuItem;
            }

            // Nếu không, đi tìm cha của nó (OwnerItem) và lặp lại quá trình
            // OwnerItem chính là ToolStripMenuItem cha chứa menu con này
            ToolStripMenuItem parentItem = menuItem.OwnerItem as ToolStripMenuItem;
            while (parentItem != null && !(parentItem.Owner is MenuStrip))
            {
                parentItem = parentItem.OwnerItem as ToolStripMenuItem;
            }

            return parentItem;
        }

        private void SetActiveMenuItem(ToolStripMenuItem clickedMenuItem)
        {
            // 1. Từ mục menu vừa được click, tìm ra mục cha cấp cao nhất của nó
            ToolStripMenuItem topLevelParent = GetTopLevelMenuItem(clickedMenuItem);

            // Nếu không tìm thấy (trường hợp hiếm) thì không làm gì cả
            if (topLevelParent == null) return;

            // 2. Chỉ thay đổi màu sắc nếu mục cha cấp cao nhất này KHÁC với mục đang active hiện tại
            if (currentActiveMenuItem != topLevelParent)  // coi thử cái current đang chạy có khác với cái cha của thằng đang được chọn hay không, nếu khác thì có nghĩa là tui đang chọn cái khác với cha á 
            {
                // 2a. Reset màu của mục đang active cũ (nếu có)
                if (currentActiveMenuItem != null)  
                {
                    currentActiveMenuItem.BackColor = SystemColors.Control;


                }
                
                

                // 2b. Tô màu cho mục cha cấp cao nhất của menu vừa click
                topLevelParent.BackColor = Color.LightSkyBlue; 
                // 2c. Cập nhật lại biến, gán mục cha này làm mục active mới
                currentActiveMenuItem = topLevelParent;
                if (clickedMenuItem != topLevelParent)  // cái này để có nghĩa là nếu lúc đầu tui đã nhấn bán hàng rồi thì khi chuyển sang doanh thu thì nó sẽ tô màu cái click
                {
                    clickedMenuItem.BackColor = Color.Aqua;
                    currentActiveMenuItemchild = clickedMenuItem;
                }
                currentActiveMenuItemchild = clickedMenuItem; // cái này để gán curent child bằng những cái đã click á, hong có truy ra cha


            }
            else // nếu không khác thì nghĩa là tui đang chọn các thằng con trong menu á
            {
                
                if (currentActiveMenuItemchild != clickedMenuItem)  // cái này tui sẽ coi cái curent con hiện tại đang ở đâu, nếu nó khác với những gì tui đang bấm trong khu vực con thì nó sẽ xóa màu cái curent chill đó
                {
                    //MessageBox.Show("Đã bên trong curentActive và reset cái cũ, cái đang chọn '" + clickedMenuItem.Text + "', cái trước đó '" + currentActiveMenuItemchild.Text + "'");
                    currentActiveMenuItemchild.BackColor = SystemColors.Control;
                }
                clickedMenuItem.BackColor = Color.Aqua;  // tô lại màu
                currentActiveMenuItemchild = clickedMenuItem;
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
                quảnLýNgườiDùngToolStripMenuItem.Enabled = false;
            }
            else // Mặc định là Nhân viên
            {
                quảnLýToolStripMenuItem.Enabled = false;
                báoCáoToolStripMenuItem.Enabled = false;
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
            SetActiveMenuItem(toolStripMenuItem1);
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
            toolStripMenuItem1.PerformClick();

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

                    
                    if (HAMXULY.UpdateStatus(CurrentUserSession.MaNguoiDung.ToString(), "0") > 0)
                    {
                        //MessageBox.Show("Cập Nhật Trạng Thái Thành Công '"+ CurrentUserSession.MaNguoiDung.ToString() + "'");
                    }
                    
                    CurrentUserSession.Clear();
                    ((FormLogin)loginForm).ResetPass();
                    // 3. Nếu tìm thấy, hiển thị nó trở lại
                    loginForm.Show();
                    xacnhandongform = false;
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
            if (xacnhandongform)
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
                    timerdatetime.Stop();
                    if (HAMXULY.UpdateStatus(CurrentUserSession.MaNguoiDung.ToString(), "0") > 0)
                    {
                        CurrentUserSession.Clear();
                    }
                    
                    Application.Exit();
                }
                else
                {
                    // Nếu người dùng chọn "No", hủy hành động đóng form.
                    // Form sẽ không bị đóng lại.
                    e.Cancel = false;
                }
            }
            else
            {
                // chia ra 2 cách đóng form dựa trên tắt form và đăng xuất, cách đây là tắt form
                timerdatetime.Stop();
                if (HAMXULY.UpdateStatus(CurrentUserSession.MaNguoiDung.ToString(), "0") > 0)
                {
                    //MessageBox.Show("Cập Nhật Trạng Thái Thành Công '" + CurrentUserSession.MaNguoiDung.ToString() + "'");
                }

                //Application.Exit();
            }
           
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýKhôToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*step 1*/
            SetActiveMenuItem(quảnLýKhôToolStripMenuItem);
            KhoHang kh = new KhoHang();
            ShowUserControl(kh);
        }

        private void quảnLýSảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*step 2*/

        }

        private void quảnLýDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveMenuItem(quảnLýDoanhThuToolStripMenuItem);
            UserControl_DoanhThu us = new UserControl_DoanhThu();
            ShowUserControl(us);
            /*step 3*/
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*step 4*/
            SetActiveMenuItem(quảnLýNhânViênToolStripMenuItem);
            frmquanlynv ff = new frmquanlynv();
            ShowUserControl(ff);
        }

        

        private void xemHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveMenuItem(báoCáoToolStripMenuItem);

            // Mở Form báo cáo. Dùng Show() để nó hiện ra một cửa sổ riêng.
            FormBaoCaoDoanhThu formBaoCao = new FormBaoCaoDoanhThu();
            formBaoCao.ShowDialog();
        }

        private void xemVàChỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoiMK fd = new FormDoiMK();
            DialogResult result = fd.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Nếu thành công, thực hiện đăng xuất
                // Đoạn code này giống hệt code trong nút đăng xuất của bạn


                Form loginForm = Application.OpenForms["FormLogin"];
                if (loginForm != null)
                {
                    loginForm.Show();
                }

                this.Close();
            }
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_QL_ND fm = new Form_QL_ND();
            fm.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timmerCheckStatus_Tick(object sender, EventArgs e)
        {
            int kt = HAMXULY.CheckStatus(CurrentUserSession.MaNguoiDung.ToString());
            Console.WriteLine("Biến KT trong Timmer: '"+kt+"'");
            if (kt == 0)
            {
                timerdatetime.Stop();
                timmerCheckStatus.Stop();
                MessageBox.Show("Bạn đã bị đăng xuất");
                
                Form loginForm = Application.OpenForms["FormLogin"];
                if (loginForm != null)
                {



                    
                    CurrentUserSession.Clear();
                    ((FormLogin)loginForm).ResetPass();
                    // 3. Nếu tìm thấy, hiển thị nó trở lại
                    loginForm.Show();
                    xacnhandongform = false;
                    this.Close();

                }
                
            }

        }
    }
}
