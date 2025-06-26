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

        private int? _maHoaDonDeXem;
        /*public FormHD(List<Product> danhSachSanPham, decimal discountAmount)
        {
            InitializeComponent();
            this._danhSachSanPham = danhSachSanPham;
            this._discountAmount = discountAmount;
            
        }*/
        public FormHD(int maHoaDon)
        {
            InitializeComponent();
            // Gán mã hóa đơn nhận được vào biến của chúng ta
            this._maHoaDonDeXem = maHoaDon;
            this._namenv = CurrentUserSession.HoVaTen;
        }
        private void FormHD_Load(object sender, EventArgs e)
        {

            string queryTongHop = @"
                    SELECT 
                    hd.TongTien, 
                    nd.HoVaTen AS TenNhanVien,
                    hd.NgayTaoHoaDon, -- Thêm dòng này
                    ISNULL(CASE
                        WHEN km.LoaiGiamGia = 'Percentage' THEN (hst.SubTotal * km.GiaTriGiam / 100)
                        WHEN km.LoaiGiamGia = 'FixedAmount' THEN km.GiaTriGiam
                        ELSE 0 
                    END, 0) AS SoTienDaGiam
                FROM dbo.HoaDon hd
                    INNER JOIN dbo.NguoiDung nd ON hd.MaNguoiDung = nd.MaNguoiDung
                    LEFT JOIN dbo.KhuyenMai km ON hd.MaKhuyenMai = km.MaKhuyenMai
                    LEFT JOIN (SELECT MaHoaDon, SUM(SoLuong * DonGia) AS SubTotal FROM dbo.ChiTietHoaDon GROUP BY MaHoaDon) AS hst 
                        ON hd.MaHoaDon = hst.MaHoaDon
                    WHERE hd.MaHoaDon = @maHD;";

            DataTable dtTongHop = new DataTable();
            List<ReportParameter> parameters = new List<ReportParameter>();

            if (HAMXULY.TruyVan(queryTongHop, dtTongHop, new SqlParameter("@maHD", this._maHoaDonDeXem)))
            {
                if (dtTongHop.Rows.Count > 0)
                {
                    DataRow info = dtTongHop.Rows[0];
                    decimal soTienGiam = Convert.ToDecimal(info["SoTienDaGiam"]);
                    string tenNV = info["TenNhanVien"].ToString();

                    DateTime ngayTao = Convert.ToDateTime(info["NgayTaoHoaDon"]);

                    // Tạo các parameter để gửi cho report
                    parameters.Add(new ReportParameter("GiamGia", soTienGiam.ToString("N0")));
                    parameters.Add(new ReportParameter("TenNV", tenNV));
                    parameters.Add(new ReportParameter("NgayGio", ngayTao.ToString("dd/MM/yyyy HH:mm:ss")));
                    // Bạn có thể thêm các parameter khác như pTongTien, pThue... nếu cần
                }
            }

            // --- LẤY DỮ LIỆU CHI TIẾT SẢN PHẨM CHO BẢNG ---
            string queryChiTiet = @"
                    SELECT sp.TenSanPham, cthd.SoLuong, cthd.DonGia, (cthd.SoLuong * cthd.DonGia) AS TotalPrice
                    FROM dbo.ChiTietHoaDon cthd
                    INNER JOIN dbo.SanPham sp ON cthd.MaSanPham = sp.MaSanPham
                    WHERE cthd.MaHoaDon = @maHD;";

            DataTable dtSanPham = new DataTable();
            HAMXULY.TruyVan(queryChiTiet, dtSanPham, new SqlParameter("@maHD", this._maHoaDonDeXem));
            MessageBox.Show("Mã Hóa Đơn là: '"+this._maHoaDonDeXem+"' để lấy chi tiết các sản phẩm");
            // Nạp dữ liệu vào Report
            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", dtSanPham);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(parameters); // Gán danh sách parameter

            // Refresh report
            this.reportViewer1.RefreshReport();
            /*
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
                ReportDataSource rds = new ReportDataSource("DataSet1", dtSanPham);
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
            this.reportViewer1.RefreshReport();*/
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
