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
        public string user;
        public string codeUser;
        public string codeRole;
        UserControl_Pos ucPOS ;
        public Index(string nameuser,string codeuser,string coderole)
        {
            InitializeComponent();
            statusUser.Text = "Xin Chào '"+nameuser+"'";
            this.user = nameuser;
            this.codeRole = coderole;
            this.codeUser = codeuser;
            PhanQuyen();
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
                quảnLýKhoToolStripMenuItem.Enabled = false;
                quảnLýSảnPhẩmToolStripMenuItem.Enabled = false;
            }
        }
        private void ShowUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();             // Xóa những control hiện tại (ẩn tất cả)
            uc.Dock = DockStyle.Fill;               // Cho UserControl chiếm hết panel
            pnlContent.Controls.Add(uc);             // Thêm control mới vào sân khấu
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (ucPOS == null || ucPOS.IsDisposed)
            {
                // Nếu chưa có, hoặc đã bị hủy thì TẠO MỚI MỘT LẦN DUY NHẤT
                ucPOS = new UserControl_Pos();
            }

            // Luôn luôn hiển thị cái ucPOS duy nhất đó
            ShowUserControl(ucPOS);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusDatetime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            
        }

        private void Index_Load(object sender, EventArgs e)
        {
           
            statusDatetime.ForeColor = Color.Blue;
            timerdatetime.Start();
        }
        
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhoHang kh = new KhoHang();
            kh.ShowDialog();
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
                this.Close();

                // 2. Tìm FormLogin trong số các form đang mở bằng tên của nó ("FormLogin")
                Form loginForm = Application.OpenForms["FormLogin"];

                if (loginForm != null)
                {
                    ((FormLogin)loginForm).ResetLoginForm();
                    // 3. Nếu tìm thấy, hiển thị nó trở lại
                    loginForm.Show();
                    
                }
                else
                {
                    // Trường hợp dự phòng nếu FormLogin đã bị đóng vì lý do nào đó
                    // thì thoát hoàn toàn ứng dụng.
                    Application.Exit();
                }
            }
        }
    }
}
