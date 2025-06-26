using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private int? _maHoaDonDeXem = null;
        public FormHD(List<Product> danhSachSanPham, decimal discountAmount)
        {
            InitializeComponent();
            this._danhSachSanPham = danhSachSanPham;
            this._discountAmount = discountAmount;
            this._namenv = CurrentUserSession.HoVaTen;
        }
        public FormHD(int maHoaDon)
        {
            InitializeComponent();
            // Gán mã hóa đơn nhận được vào biến của chúng ta
            this._maHoaDonDeXem = maHoaDon;
        }
        private void FormHD_Load(object sender, EventArgs e)
        {



            if (_maHoaDonDeXem.HasValue)
            {
                // === CHẾ ĐỘ XEM LẠI CHI TIẾT HÓA ĐƠN ===
                // _maHoaDonDeXem có giá trị, nghĩa là chúng ta cần đi lấy dữ liệu từ CSDL

                int maHD = _maHoaDonDeXem.Value;

                // 1. Lấy danh sách sản phẩm của hóa đơn đó
                string queryChiTiet = @"
                    SELECT sp.TenSanPham, cthd.SoLuong, cthd.DonGia, (cthd.SoLuong * cthd.DonGia) AS TotalPrice
                    FROM dbo.ChiTietHoaDon cthd
                    INNER JOIN dbo.SanPham sp ON cthd.MaSanPham = sp.MaSanPham
                    WHERE cthd.MaHoaDon = @maHD";

                DataTable dtSanPham = new DataTable();
                if(HAMXULY.TruyVan(queryChiTiet, dtSanPham, new SqlParameter("@maHD", maHD)))
                {
                    MessageBox.Show("Đổ dữ liệu thành công");
                }
                MessageBox.Show("Đang chạy chi tiết trong doanh thu");
                // 2. Lấy các thông tin tổng hợp của hóa đơn (nếu cần cho parameter)
                string queryTongHop = "SELECT TongTien FROM HoaDon WHERE MaHoaDon = @maHD";
                // ... thực thi query và lấy ra các giá trị ...
                // decimal tongTienThucTe = ...;
                // decimal tongTienHang = dtSanPham.AsEnumerable().Sum(row => row.Field<decimal>("TotalPrice"));
                // decimal giamGia = tongTienHang - tongTienThucTe;

                // 3. Nạp dữ liệu vào Report
                ReportDataSource rds = new ReportDataSource("Product_DataSet", dtSanPham);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);

                // 4. Gán các Parameter (ví dụ)
                // ReportParameter paramGiamGia = new ReportParameter("pGiamGia", giamGia.ToString("N0"));
                // this.reportViewer1.LocalReport.SetParameters(paramGiamGia);
            }
            else
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
