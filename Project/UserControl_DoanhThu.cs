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

namespace Project
{
    public partial class UserControl_DoanhThu : UserControl
    {
        public UserControl_DoanhThu()
        {
            InitializeComponent();
        }

        private void UserControl_DoanhThu_Load(object sender, EventArgs e)
        {
            
            var options = new Dictionary<string, int?>();
            options.Add("Tất cả hình thức", null); // Lựa chọn "không gì hết" sẽ có giá trị NULL
            options.Add("Tiền mặt", 1);
            options.Add("Chuyển khoản", 2);

            // Gán danh sách này cho ComboBox
            cboHinhThucThanhToan.DataSource = new BindingSource(options, null);
            cboHinhThucThanhToan.DisplayMember = "Key";
            cboHinhThucThanhToan.ValueMember = "Value";

            cboflterHTTT.DataSource = new BindingSource(options, null);
            cboflterHTTT.DisplayMember = "Key";
            cboflterHTTT.ValueMember = "Value";
            LoadNhanVienComboBox(this.cboNguoiTao);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void LoadHoaDonData(int? maNguoiDung, DateTime? tuNgay, DateTime? denNgay, int? hinhThucThanhToan)
        {
            dgvHoaDon.Rows.Clear();

            string query = @"
        SELECT hd.MaHoaDon, nd.HoVaTen, hd.NgayTaoHoaDon, hd.TongTien
        FROM dbo.HoaDon AS hd
        INNER JOIN dbo.NguoiDung AS nd ON hd.MaNguoiDung = nd.MaNguoiDung
        WHERE
            (@maNguoiDung IS NULL OR hd.MaNguoiDung = @maNguoiDung)
            AND (@tuNgay IS NULL OR hd.NgayTaoHoaDon >= @tuNgay)
            AND (@denNgay IS NULL OR hd.NgayTaoHoaDon < @denNgay)
            AND (@hinhThucTT IS NULL OR hd.HinhThucThanhToan = @hinhThucTT)
        ORDER BY hd.MaHoaDon DESC;";

            DataTable dt = new DataTable();

            // Chuẩn bị các tham số
            SqlParameter paramMaNV = new SqlParameter("@maNguoiDung", maNguoiDung.HasValue ? (object)maNguoiDung.Value : DBNull.Value);
            SqlParameter paramTuNgay = new SqlParameter("@tuNgay", tuNgay.HasValue ? (object)tuNgay.Value : DBNull.Value);
            SqlParameter paramDenNgay = new SqlParameter("@denNgay", denNgay.HasValue ? (object)denNgay.Value : DBNull.Value);
            SqlParameter paramHinhThucTT = new SqlParameter("@hinhThucTT", hinhThucThanhToan.HasValue ? (object)hinhThucThanhToan.Value : DBNull.Value);

            if (HAMXULY.TruyVan(query, dt, paramMaNV, paramTuNgay, paramDenNgay, paramHinhThucTT))
            {
                foreach (DataRow row in dt.Rows)
                {
                    string formattedDate = Convert.ToDateTime(row["NgayTaoHoaDon"]).ToString("dd/MM/yyyy HH:mm:ss");
                    dgvHoaDon.Rows.Add(
                        row["MaHoaDon"],
                        row["HoVaTen"],
                        formattedDate,
                        row["TongTien"]
                    );
                }
                dgvHoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }


        // Đặt hàm này trong Form của bạn
        private void LoadNhanVienComboBox(ComboBox cboNguoiTao)
        {
            string query = "SELECT MaNguoiDung, HoVaTen FROM dbo.NguoiDung WHERE TrangThaiHoatDong = 1 ORDER BY HoVaTen";
            DataTable dtNhanVien = new DataTable();

            if (HAMXULY.TruyVan(query, dtNhanVien))
            {
                // Thêm một lựa chọn "Tất cả" vào đầu danh sách
                DataRow allRow = dtNhanVien.NewRow();
                allRow["MaNguoiDung"] = 0; // Dùng ID 0 hoặc một số âm để đại diện cho "Tất cả"
                allRow["HoVaTen"] = "Tất cả nhân viên";
                dtNhanVien.Rows.InsertAt(allRow, 0);

                // Gán dữ liệu cho ComboBox
                cboNguoiTao.DataSource = dtNhanVien;
                cboNguoiTao.DisplayMember = "HoVaTen";
                cboNguoiTao.ValueMember = "MaNguoiDung";
            }
        }

        // Gọi hàm này trong sự kiện Load của Form
        

        private void cboHinhThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHinhThucThanhToan.SelectedItem == null)
            {
                return;
            }

            // === PHẦN SỬA LỖI ===

            // 1. Lấy ra toàn bộ item được chọn. Nó là một KeyValuePair<string, int?>.
            var selectedKVP = (KeyValuePair<string, int?>)cboHinhThucThanhToan.SelectedItem;
            string temp = cboHinhThucThanhToan.Text;
            lblHT.Text = temp;
            // 2. Từ item đó, chỉ lấy ra phần Value (là int? hoặc null)
            int? hinhThucTT_Value = selectedKVP.Value;

            // 2. Chuẩn bị câu lệnh SQL và Parameter
            string query = @"
        WITH HoaDonSubTotal AS (
            SELECT MaHoaDon, SUM(SoLuong * DonGia) AS SubTotal FROM dbo.ChiTietHoaDon GROUP BY MaHoaDon
        )
        SELECT 
            ISNULL(SUM(hd.TongTien), 0) AS TongDoanhThu,
            ISNULL(SUM(hst.SubTotal - hd.TongTien), 0) AS SoTienDaKhuyenMai
        FROM 
            dbo.HoaDon hd
        LEFT JOIN 
            HoaDonSubTotal hst ON hd.MaHoaDon = hst.MaHoaDon
        WHERE
            (@hinhThucTT IS NULL OR hd.HinhThucThanhToan = @hinhThucTT)";

            // Tạo parameter. Nếu người dùng chọn "Tất cả", giá trị sẽ là DBNull.Value (tương đương NULL trong SQL)
            SqlParameter param = new SqlParameter("@hinhThucTT", hinhThucTT_Value.HasValue ? (object)hinhThucTT_Value.Value : DBNull.Value);

            // 3. Thực thi truy vấn
            DataTable dtResult = new DataTable();
            if (HAMXULY.TruyVan(query, dtResult, param)) // Dùng hàm TruyVan đã cải tiến
            {
                // 4. Lấy kết quả và cập nhật các Label
                if (dtResult.Rows.Count > 0)
                {
                    DataRow resultRow = dtResult.Rows[0];
                    decimal tongDoanhThu = Convert.ToDecimal(resultRow["TongDoanhThu"]);
                    decimal soTienDaKM = Convert.ToDecimal(resultRow["SoTienDaKhuyenMai"]);

                    // Giả sử 2 Label kết quả của bạn tên là lblSoTienKM và lblTongDoanhThu
                    lblTongDoanhThu.Text = tongDoanhThu.ToString("N0"); // Format số cho đẹp
                    lblSoTienKM.Text = soTienDaKM.ToString("N0");
                }
            }
            else
            {
                // Xử lý trường hợp không có dữ liệu hoặc có lỗi
                lblSoTienKM.Text = "0";
                lblTongDoanhThu.Text = "0";
            }
        }

        private void chkApDungNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApDungNgay.Checked)
            {
                pnl_info_date.Visible = true;
            }
            else
            {
                pnl_info_date.Visible = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // --- PHẦN THAY ĐỔI ---
            // Lấy mã người dùng từ ComboBox thay vì lấy text
            int? maNguoiDung = null;
            if (cboNguoiTao.SelectedValue != null && Convert.ToInt32(cboNguoiTao.SelectedValue) > 0)
            {
                maNguoiDung = Convert.ToInt32(cboNguoiTao.SelectedValue);
            }
            // ----------------------

            // Phần lấy ngày tháng và hình thức thanh toán giữ nguyên
            DateTime? tuNgay = null;
            DateTime? denNgay = null;
            if (chkApDungNgay.Checked)
            {
                tuNgay = dtpTuNgay.Value.Date;
                denNgay = dtpDenNgay.Value.Date.AddDays(1);
            }
            var selectedKVP = (KeyValuePair<string, int?>)cboflterHTTT.SelectedItem;
            int? temp = selectedKVP.Value;
            int? hinhThucTT = null;
            if (temp != null && temp > 0)
            {
                hinhThucTT = temp;
            }

            // Gọi hàm load dữ liệu với các tham số đã được cập nhật
            LoadHoaDonData(maNguoiDung, tuNgay, denNgay, hinhThucTT);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maHoaDonDuocChon = Convert.ToInt32(dgvHoaDon.Rows[e.RowIndex].Cells["MaHoaDon"].Value);
                //MessageBox.Show("Mã Hóa Đơn Là: '"+maHoaDonDuocChon+"'");
                // Chỉ truyền vào một số int, C# sẽ tự động gọi constructor thứ hai
                FormHD reportForm = new FormHD(maHoaDonDuocChon);
                reportForm.ShowDialog();
            }
        }
    }
}
