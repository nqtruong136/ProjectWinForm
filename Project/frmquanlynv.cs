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
    public partial class frmquanlynv : UserControl
    {
        public frmquanlynv()
        {
            InitializeComponent();
        }

        private void frmquanlynv_Load(object sender, EventArgs e)
        {
            ShowNhanVien();
        }
        private void ShowNhanVien()
        {
            DataTable dtNhanvien = new DataTable();
            HAMXULY.Connect();
            string sqlNhanvien = "SELECT * FROM NguoiDung";
            if (HAMXULY.TruyVan(sqlNhanvien, dtNhanvien))
            {
                Luoinhanvien.DataSource = dtNhanvien;
                Luoinhanvien.Columns[0].HeaderText = "Mã người dùng";
                Luoinhanvien.Columns[0].Width = 50;
                Luoinhanvien.Columns[1].HeaderText = "Tên đăng nhập";
                Luoinhanvien.Columns[1].Width = 100;
                Luoinhanvien.Columns[2].HeaderText = "Mật khẩu";
                Luoinhanvien.Columns[2].Width = 100;
                Luoinhanvien.Columns[3].HeaderText = "Họ và tên";
                Luoinhanvien.Columns[3].Width = 100;
                Luoinhanvien.Columns[4].HeaderText = "Địa chỉ";
                Luoinhanvien.Columns[4].Width = 100;
                Luoinhanvien.Columns[5].HeaderText = "Số điện thoại";
                Luoinhanvien.Columns[5].Width = 100;
                Luoinhanvien.Columns[6].HeaderText = "Mã vai trò";
                Luoinhanvien.Columns[6].Width = 100;
                Luoinhanvien.Columns[7].HeaderText = "Trạng thái hoạt động";
                Luoinhanvien.Columns[7].Width = 100;








                Luoinhanvien.EnableHeadersVisualStyles = false;
                Luoinhanvien.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaND.Text = Luoinhanvien.CurrentRow.Cells["MaNguoiDung"].Value.ToString();
            txtTen.Text = Luoinhanvien.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            txtMK.Text = Luoinhanvien.CurrentRow.Cells["MatKhauMaHoa"].Value.ToString();
            txtHTen.Text = Luoinhanvien.CurrentRow.Cells["HoVaTen"].Value.ToString();
            txtDiaChi.Text = Luoinhanvien.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = Luoinhanvien.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            cboMVT.Text = Luoinhanvien.CurrentRow.Cells["MaVaiTro"].Value.ToString();
            txtTT.Text = Luoinhanvien.CurrentRow.Cells["TrangThaiHoatDong"].Value.ToString();
            string MaVaiTro, sql;
            MaVaiTro = Luoinhanvien.CurrentRow.Cells["MaVaiTro"].Value.ToString();
            sql = "SELECT TenVaiTro FROM VaiTro WHERE MaVaiTro=N'" + MaVaiTro + "'";
            cboMVT.Text = HAMXULY.GetFieldValues(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaND.Enabled = false;
            panel1.Enabled = true;
            ResetText();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

        }
        private void Them()
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if (txtMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMK.Focus();
                return;
            }
            if (txtHTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHTen.Focus();
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            if (cboMVT.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMVT.Focus();
                return;
            }
            else
            {
                string sqlInsert = "INSERT INTO NguoiDung (TenDangNhap, MatKhauMaHoa, HoVaTen, DiaChi, SoDienThoai, MaVaiTro, TrangThaiHoatDong) VALUES (N'" + txtTen.Text + "', N'" + txtMK.Text + "', N'" + txtHTen.Text + "', N'" + txtDiaChi.Text + "', '" + txtSDT.Text + "', N'" + cboMVT.Text + "', N'1')";
                try
                {
                    HAMXULY.Connect();
                    HAMXULY.RunSql(sqlInsert);
                    MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowNhanVien();
                    ResetText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Xoa();


        }
        private void Xoa()
        {
            if (txtMaND.Text == "")
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string sqlDelete = "DELETE FROM NguoiDung WHERE MaNguoiDung = '" + txtMaND.Text + "'";
                try
                {
                    HAMXULY.Connect();
                    HAMXULY.RunSql(sqlDelete);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowNhanVien();
                    ResetText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sua();

        }
        private void Sua()
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if (txtMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMK.Focus();
                return;
            }
            if (txtHTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHTen.Focus();
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            if (cboMVT.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMVT.Focus();
                return;
            }
            else
            {
                string sqlUpdate = "UPDATE NguoiDung SET TenDangNhap = N'" + txtTen.Text + "', MatKhauMaHoa = N'" + txtMK.Text + "', HoVaTen = N'" + txtHTen.Text + "', DiaChi = N'" + txtDiaChi.Text + "', SoDienThoai = '" + txtSDT.Text + "', MaVaiTro = N'" + cboMVT.Text + "' WHERE MaNguoiDung = '" + txtMaND.Text + "'";
                try
                {
                    HAMXULY.Connect();
                    HAMXULY.RunSql(sqlUpdate);
                    MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowNhanVien();
                    ResetText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
