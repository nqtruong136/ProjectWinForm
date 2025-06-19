using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Project
{
    public partial class UserControl_Pos_Cate : UserControl
    {
        
        public UserControl_Pos_Cate()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public void LoadDataTheoDanhMuc(string danhMuc)
        {
            HAMXULY.Connect();
            DataTable dt = new DataTable();
            string query = "select * from SanPham where MaDanhMuc='"+danhMuc+"'";
            // Giả sử dùng danh sách mẫu
            
            try
            {
                if (HAMXULY.TruyVan(query, dt))
                {
                    flpnlProduct.Controls.Clear(); // Xóa món cũ
                    foreach (DataRow dr in dt.Rows)
                    {
                        Label lbl = new Label();
                        lbl.Text = dr["TenSanPham"].ToString();

                        lbl.Name = dr["MaSanPham"].ToString();
                        lbl.Click += new EventHandler(lbl_Click);

                        flpnlProduct.Controls.Add(lbl);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
            

            
        }
        private void lbl_Click(object sender, EventArgs e)
        {
            // Ép kiểu sender về Label
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // Ví dụ: Hiển thị tên sản phẩm ra MessageBox
                MessageBox.Show("Bạn vừa click vào sản phẩm: " + clickedLabel.Text);

                // Hoặc lấy mã sản phẩm
                string maSP = clickedLabel.Name;

                // Nếu bạn có thêm thông tin trong Tag thì lấy ra như sau:
                // var data = clickedLabel.Tag;
            }
        }
    }
}
