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
    public partial class FormBaoCaoDoanhThu : Form
    {
        public FormBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void FormBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            LoadNamComboBox();
            LoadBaoCao();
        }

        private void LoadBaoCao()
        {
            // Kiểm tra xem người dùng đã chọn năm hợp lệ chưa
            if (cboChonNam.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một năm để xem báo cáo.");
                return;
            }

            // Lấy năm được chọn từ ComboBox
            int selectedYear = Convert.ToInt32(cboChonNam.SelectedValue);

            // Nâng cấp câu lệnh SQL để nhận vào tham số @Nam
            string query = @"
        SELECT MONTH(NgayTaoHoaDon) AS Thang, SUM(TongTien) AS TongDoanhThu
        FROM dbo.HoaDon
        WHERE YEAR(NgayTaoHoaDon) = @Nam -- Lọc theo năm được chọn
        GROUP BY MONTH(NgayTaoHoaDon)
        ORDER BY Thang ASC;";

            DataTable dt = new DataTable();

            // Tạo và gán giá trị cho parameter @Nam
            SqlParameter paramNam = new SqlParameter("@Nam", selectedYear);

            // Lấy dữ liệu từ CSDL bằng hàm TruyVan đã cải tiến
            if (HAMXULY.TruyVan(query, dt, paramNam))
            {
                ReportParameter[] prm = new ReportParameter[1];
                prm[0] = new ReportParameter("Nam",selectedYear.ToString());
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                this.reportViewer1.LocalReport.SetParameters(prm);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
            }
            else
            {
                // Nếu không có dữ liệu cho năm đó, xóa dữ liệu cũ trên report
                this.reportViewer1.LocalReport.DataSources.Clear();
            }

            // Luôn làm mới ReportViewer để nó hiển thị kết quả mới
            this.reportViewer1.RefreshReport();
        }

        private void LoadNamComboBox()
        {
            // Câu lệnh này lấy ra các năm duy nhất có trong bảng hóa đơn và sắp xếp giảm dần
            string query = "SELECT DISTINCT YEAR(NgayTaoHoaDon) AS Nam FROM dbo.HoaDon ORDER BY Nam DESC";
            DataTable dtNam = new DataTable();

            if (HAMXULY.TruyVan(query, dtNam))
            {
                // Gán dữ liệu cho ComboBox
                cboChonNam.DataSource = dtNam;
                cboChonNam.DisplayMember = "Nam";
                cboChonNam.ValueMember = "Nam";
            }
        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cboChonNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChonNam.Focused)
            {
                LoadBaoCao();
            }
        }
    }
}
