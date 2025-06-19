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


                        lbl.Tag = new Product()
                        {
                            NameProduct = dr["TenSanPham"].ToString(),
                            Quantity = 1,
                            UnitPrice = dr["DonGia"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DonGia"])

                        };
                        lbl.Size = new Size(100, 60);
                        lbl.BorderStyle = BorderStyle.FixedSingle;

                        lbl.TextAlign = ContentAlignment.MiddleCenter;

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
            Label lbl = sender as Label;

            if (lbl != null)
            {
                // Ví dụ: Hiển thị tên sản phẩm ra MessageBox
                

                // Hoặc lấy mã sản phẩm
                string maSP =lbl.Name;
                if (lbl != null && lbl.Tag is Product product)
                {
                    InvoiceControl ud = new InvoiceControl();
                    ud.AddProduct(maSP, product.NameProduct, product.Quantity, product.UnitPrice) ;
                    MessageBox.Show("đã thêm");
                }
                // Nếu bạn có thêm thông tin trong Tag thì lấy ra như sau:
                // var data = clickedLabel.Tag;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flpnlProduct_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
