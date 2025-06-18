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
                        flpnlProduct.Controls.Add(lbl);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
            

            
        }
    }
}
