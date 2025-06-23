using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Project
{
    public partial class FormHD : Form
    {
        private string _namenv;
        private decimal _discountAmount;
        private List<Product> _danhSachSanPham;
        public FormHD(List<Product> danhSachSanPham, decimal discountAmount)
        {
            InitializeComponent();
            this._danhSachSanPham = danhSachSanPham;
            this._discountAmount = discountAmount;
            this._namenv = CurrentUserSession.HoVaTen;
        }

        private void FormHD_Load(object sender, EventArgs e)
        {

            this.reportViewer1.LocalReport.DataSources.Clear();

            // Bước 2: Tạo nguồn dữ liệu mới từ danh sách của bạn
            ReportDataSource rds = new ReportDataSource("Product_DataSet", _danhSachSanPham);
            ReportParameter[] parameters = new ReportParameter[2];
            
            parameters[0] = new ReportParameter("GiamGia", _discountAmount.ToString("N0"));
            parameters[1] = new ReportParameter("TenNV", _namenv.ToString());
            
            // Bước 3: Thêm nguồn dữ liệu vào report
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(parameters);
            // Bước 4: Làm mới lại report MỘT LẦN ở cuối cùng để hiển thị dữ liệu
            this.reportViewer1.RefreshReport();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
