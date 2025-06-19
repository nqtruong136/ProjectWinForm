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
    public partial class UserControl_Pos : UserControl
    {
        Dictionary<TabItemControl, InvoiceControl> tabMap = new Dictionary<TabItemControl, InvoiceControl>();
        TabItemControl currentActiveTab = null;
        private int tabCounter = 1;

        public UserControl_Pos()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void Cate2_Click(object sender, EventArgs e)
        {
            UserControl_Pos_Cate uc = new UserControl_Pos_Cate();
            uc.LoadDataTheoDanhMuc("2");
            ShowCategoryControl(uc);
        }

        private void Cate3_Click(object sender, EventArgs e)
        {
            UserControl_Pos_Cate uc = new UserControl_Pos_Cate();
            uc.LoadDataTheoDanhMuc("3");
            ShowCategoryControl(uc);
        }

        private void Cate1_Click(object sender, EventArgs e)
        {
            UserControl_Pos_Cate uc = new UserControl_Pos_Cate();
            uc.LoadDataTheoDanhMuc("1");
            ShowCategoryControl(uc);

        }

        private void Cate4_Click(object sender, EventArgs e)
        {
            UserControl_Pos_Cate uc = new UserControl_Pos_Cate();
            uc.LoadDataTheoDanhMuc("4");
            ShowCategoryControl(uc);
        }
        private void ShowCategoryControl(UserControl uc)
        {
            pnlCate.Controls.Clear();             // Xóa những control hiện tại (ẩn tất cả)
            uc.Dock = DockStyle.Fill;               // Cho UserControl chiếm hết panel
            pnlCate.Controls.Add(uc);             // Thêm control mới vào sân khấu
        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            var tabItem = new TabItemControl("HĐ " + tabCounter++);
            tabItem.Width = tabPanel.Width - SystemInformation.VerticalScrollBarWidth - 5;

            var invoice = new InvoiceControl();
            invoice.Dock = DockStyle.Fill;

            // Gán sự kiện
            tabItem.OnTabClick += (s, ev) => ShowTab(tabItem);
            tabItem.OnTabClose += (s, ev) => CloseTab(tabItem);

            tabPanel.Controls.Add(tabItem);
            tabMap[tabItem] = invoice;

            ShowTab(tabItem);

        }
        private void ShowTab(TabItemControl tab)
        {
            if (currentActiveTab != null)
                currentActiveTab.BackColor = SystemColors.Control;

            currentActiveTab = tab;
            currentActiveTab.BackColor = Color.LightBlue;

            pnlMainHD.Controls.Clear();
            pnlMainHD.Controls.Add(tabMap[tab]);
            UpdateTabNames();
        }
        private void CloseTab(TabItemControl tab)
        {
            if (tabMap.ContainsKey(tab))
            {
                // Nếu tab đang active thì xóa luôn khỏi panel
                if (currentActiveTab == tab)
                {
                    pnlMainHD.Controls.Clear();
                    currentActiveTab = null;
                }

                tabPanel.Controls.Remove(tab);
                tabMap.Remove(tab);
                UpdateTabNames();
            }
        }
        private void UpdateTabNames()
        {
            int index = 1;
            foreach (Control ctrl in tabPanel.Controls)
            {
                if (ctrl is TabItemControl tab)
                {
                    tab.TabButton.Text = $"HĐ {index++}";
                }
            }

            tabCounter = index; // Đảm bảo lần sau tạo tab là HĐ kế tiếp
        }


        private void pnlMainHD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pnlCate_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
