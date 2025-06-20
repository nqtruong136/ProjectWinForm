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
    public partial class KhoHang : Form
    {
        public KhoHang()
        {
            InitializeComponent();
        }
        private void ShowKhohang()
        {
            DataTable dtKhohang = new DataTable();
            HAMXULY.Connect();
            string sqlKhohang = "SELECT * FROM VatTuTrongKho";
            if (HAMXULY.TruyVan(sqlKhohang, dtKhohang))
            {
                LuoiKho.DataSource = dtKhohang;
                LuoiKho.Columns[0].HeaderText = "Mã hàng";
                LuoiKho.Columns[0].Width = 150;
                LuoiKho.Columns[1].HeaderText = "Tên hàng";
                LuoiKho.Columns[1].Width = 200;
                LuoiKho.Columns[3].HeaderText = "Số tồn";
                LuoiKho.Columns[3].Width = 200;
                LuoiKho.Columns[2].HeaderText = "Đơn vị tính";
                LuoiKho.Columns[2].Width = 150;

                LuoiKho.EnableHeadersVisualStyles = false;
                LuoiKho.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void KhoHang_Load(object sender, EventArgs e)
        {
            ShowKhohang();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            txtMahang.Enabled = false;
            pnlKho.Enabled = true;
            ResetText();
            bntXoa.Enabled = false;
            bntSua.Enabled = false;
        }
        private void ThemHang()
        {
            if (txtTenhang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenhang.Focus();
            }
            else if (txtDVT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDVT.Focus();
            }
            else if (txtSoton.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Số lượng tồn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoton.Focus();
            }
            else
            {
                string SqlInsert = "INSERT INTO VatTuTrongKho(TenVatTu, DonViTinh, SoLuongTon) VALUES(N'" + txtTenhang.Text + "',N'" + txtDVT.Text + "','" + txtSoton.Text + "')";
                try
                {
                    HAMXULY.Connect();
                    HAMXULY.RunSql(SqlInsert);
                    MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowKhohang();
                    ResetText();
                    bntXoa.Enabled = true;
                    bntSua.Enabled = true;
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }
            }


        }

        private void bntLuu_Click(object sender, EventArgs e)
        {

            if (bntThem.Enabled == true)
                ThemHang();
            else
                SuaKhohang();
        }
        

        private void bntSua_Click(object sender, EventArgs e)
        {
            pnlKho.Enabled = true;
            txtMahang.Enabled = false;
            txtTenhang.SelectAll();
            txtSoton.SelectAll();
            txtDVT.SelectAll();
            bntThem.Enabled = false;
            bntXoa.Enabled = false;
        }
        private void SuaKhohang()
        {
            if (txtTenhang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenhang.Focus();
            }
            else if (txtDVT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDVT.Focus();
            }
            else if (txtSoton.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tồn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoton.Focus();
            }
            else
            {

                string SqlUpdate = "UPDATE VatTuTrongKho SET TenVatTu = N'" + txtTenhang.Text + "', DonViTinh = N'" + txtDVT.Text + "', SoLuongTon = '" + txtSoton.Text + "' WHERE MaVatTu = '" + txtMahang.Text + "'";

                try
                {
                    HAMXULY.Connect();
                    HAMXULY.RunSql(SqlUpdate);
                    MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowKhohang();
                    ResetText();
                    bntXoa.Enabled = true;
                    bntThem.Enabled = true;
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            txtMahang.Enabled = true;
            if (txtMahang.Text == "")
            {
                //thông báo chưa chọn chất liệu
                MessageBox.Show("Bạn chưa chọn mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                //xóa bằng lệnh sqldetele
                HAMXULY.Connect();

                string sqlDetele = "DELETE FROM VatTuTrongKho WHERE MaVatTu = '" + txtMahang.Text + "'";

                if (MessageBox.Show("Bạn có chắc muốn xóa mặt hàng này ?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HAMXULY.RunSql(sqlDetele);
                    MessageBox.Show("Đã xóa thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //gọi ham show chât liệu
                ShowKhohang();
                //xóa trên textbox
                ResetText();
                //ngắt kết nối
                HAMXULY.Disconnected();
            }

        }

        private void bntDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            pnlKho.Enabled = true;
            txtMahang.Enabled = true;
            txtTenhang.Focus();
            bntThem.Enabled = true;
            bntXoa.Enabled = true;
            bntSua.Enabled = true;
        }

        private void LuoiKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMahang.Text = LuoiKho.CurrentRow.Cells["MaVatTu"].Value.ToString();
            txtTenhang.Text = LuoiKho.CurrentRow.Cells["TenVatTu"].Value.ToString();
            txtDVT.Text = LuoiKho.CurrentRow.Cells["DonViTinh"].Value.ToString();
            txtSoton.Text = LuoiKho.CurrentRow.Cells["SoLuongTon"].Value.ToString();
        }
    }
    
    
}
