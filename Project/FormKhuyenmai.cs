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
    public partial class FormKhuyenmai : Form
    {
        public FormKhuyenmai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlKhuyenMai.Enabled = false;
            ResetText();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;

        }
        private void Sua()
        {
            if (txtMaKM.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenKM.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khuyến mãi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtBD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtKT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtGiatrigiam.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá trị giảm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtLoaiGg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập loại giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMota.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string sqlUpdate = "UPDATE KhuyenMai SET TenKhuyenMai = N'" + txtTenKM.Text + "', MoTa = N'" + txtMota.Text + "', NgayBatDau = '" + txtBD.Text + "', NgayKetThuc = '" + txtKT.Text + "', GiaTriGiam = '" + txtGiatrigiam.Text + "', LoaiGiamGia = '" + txtLoaiGg.Text + "' WHERE MaKhuyenMai = '" + txtMaKM.Text + "'";
                try
                {
                    HAMXULY.Connect();
                    HAMXULY.RunSql(sqlUpdate);
                    MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowKM();
                    ResetText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormKhuyenmai_Load(object sender, EventArgs e)
        {
            ShowKM();
        }
        private void ShowKM()
        {
            DataTable dtKhuyenMai = new DataTable();
            HAMXULY.Connect();
            string sqlKhuyenMai = "SELECT MaKhuyenMai, TenKhuyenMai, MoTa, NgayBatDau, NgayKetThuc, GiaTriGiam, LoaiGiamGia FROM KhuyenMai";
            if (HAMXULY.TruyVan(sqlKhuyenMai, dtKhuyenMai))
            {
                LuoiKM.DataSource = dtKhuyenMai;
                LuoiKM.Columns[0].HeaderText = "Mã khuyến mãi";
                LuoiKM.Columns[0].Width = 150;
                LuoiKM.Columns[1].HeaderText = "Tên khuyến mãi";
                LuoiKM.Columns[1].Width = 200;
                LuoiKM.Columns[2].HeaderText = "Mô tả khuyến mãi";
                LuoiKM.Columns[2].Width = 200;
                LuoiKM.Columns[3].HeaderText = "Ngày bắt đầu";
                LuoiKM.Columns[3].Width = 200;
                LuoiKM.Columns[4].HeaderText = "Ngày kết thúc";
                LuoiKM.Columns[4].Width = 200;
                LuoiKM.Columns[5].HeaderText = "Giảm giá (%)";
                LuoiKM.Columns[5].Width = 200;
                LuoiKM.Columns[6].HeaderText = "Loại giảm giá";
                LuoiKM.Columns[6].Visible = false;
                LuoiKM.EnableHeadersVisualStyles = false;
                LuoiKM.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
            }
        }

        private void LuoiKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKM.Text = LuoiKM.CurrentRow.Cells["MaKhuyenMai"].Value.ToString();
            txtTenKM.Text = LuoiKM.CurrentRow.Cells["TenKhuyenMai"].Value.ToString();
            txtBD.Text = LuoiKM.CurrentRow.Cells["NgayBatDau"].Value.ToString();
            txtKT.Text = LuoiKM.CurrentRow.Cells["NgayKetThuc"].Value.ToString();
            txtGiatrigiam.Text = LuoiKM.CurrentRow.Cells["GiaTriGiam"].Value.ToString();
            txtLoaiGg.Text = LuoiKM.CurrentRow.Cells["LoaiGiamGia"].Value.ToString() + "%";
            txtMota.Text = LuoiKM.CurrentRow.Cells["MoTa"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKM.Enabled = false;
            pnlKhuyenMai.Enabled = true;
            ResetText();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            Them();



        }
        private void Them()
        {
            if (txtTenKM.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khuyến mãi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtBD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtKT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtGiatrigiam.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá trị giảm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtLoaiGg.Text == "")
            {
                MessageBox.Show("Vui lòng nhập loại giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMota.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string sqlInsert = "INSERT INTO KhuyenMai (TenKhuyenMai, MoTa, NgayBatDau, NgayKetThuc, GiaTriGiam, LoaiGiamGia) VALUES (N'" + txtTenKM.Text + "', N'" + txtMota.Text + "', '" + txtBD.Text + "', '" + txtKT.Text + "', '" + txtGiatrigiam.Text + "', '" + txtLoaiGg.Text + "')";
                try
                {
                    HAMXULY.Connect();
                    HAMXULY.RunSql(sqlInsert);
                    MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowKM();
                    ResetText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }







        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
                Them();
            else
                Sua();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xoa();

        }
        private void Xoa()
        {
            txtMaKM.Enabled = true;
            if (txtMaKM.Text == "")
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sqlDelete = "DELETE FROM KhuyenMai WHERE MaKhuyenMai = '" + txtMaKM.Text + "'";
                if (MessageBox.Show("Bạn có chắc muốn xóa khuyến mãi này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HAMXULY.Connect();
                    HAMXULY.RunSql(sqlDelete);
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowKM();
                    ResetText();
                    HAMXULY.Disconnected();
                }
            }
        }
    }
}


