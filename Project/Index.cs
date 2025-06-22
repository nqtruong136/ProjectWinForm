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

        UserControl_Pos ucPOS ;
        public Index(string nameuser)
        {
            InitializeComponent();
            statusUser.Text = "Xin Chào '"+nameuser+"'";
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

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
