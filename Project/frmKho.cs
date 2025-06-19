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
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            Showkhohang();
        }
        private void Showkhohang()
        {
            DataTable dtkhohang = new DataTable();
            HAMXULY.Connect();
            string sqlkhohang = "SELECT * FROM VatTuTrongKho";
            if (HAMXULY.TruyVan(sqlkhohang, dtkhohang))
            {
                LuoiKhoHang.DataSource = dtkhohang;
                LuoiKhoHang.Columns[0].HeaderText = "Mã Hàng";
                LuoiKhoHang.Columns[0].Width = 150;
                LuoiKhoHang.Columns[1].HeaderText = "Tên hàng";
                LuoiKhoHang.Columns[1].Width = 200;
                LuoiKhoHang.Columns[2].HeaderText = "Đơn Vị Tính";
                LuoiKhoHang.Columns[2].Width = 200;
                LuoiKhoHang.Columns[3].HeaderText = "Số Tồn";
                LuoiKhoHang.Columns[3].Width = 200;

                LuoiKhoHang.EnableHeadersVisualStyles = false;
                LuoiKhoHang.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;

            }

        }

        private void LuoiKhoHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = LuoiKhoHang.CurrentRow.Cells["MaVatTu"].Value.ToString();
            txtTenHang.Text = LuoiKhoHang.CurrentRow.Cells["TenVatTu"].Value.ToString();
            txtSoTon.Text = LuoiKhoHang.CurrentRow.Cells["SoLuongTon"].Value.ToString();
            txtDVT.Text = LuoiKhoHang.CurrentRow.Cells["DonViTinh"].Value.ToString();
        }
       
        private void ThemHang()
        {
           
            if (txtTenHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
            }
            else if (txtSoTon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập sô lượng còn tồn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
            }
            else if (txtDVT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
            }    
            else
            {
                string SqlInsert = "INSERT INTO VatTuTrongKho(TenVatTu, DonViTinh, SoLuongTon) VALUES(N'" + txtTenHang.Text + "',N'"+txtDVT.Text+"','" + txtSoTon.Text + "')";
                try
                {
                    HAMXULY.Connect();
                    HAMXULY.RunSql(SqlInsert);
                    MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Showkhohang();
                    ResetText();
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pnlkho.Enabled = true;
            txtMaHang.Enabled = false;
            ResetText();
            txtMaHang.Focus();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
                ThemHang();
            else
                Suakhohang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pnlkho.Enabled = true;
            txtMaHang.Enabled = false;
            txtTenHang.SelectAll();
            txtSoTon.SelectAll();
            txtDVT.SelectAll();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void Suakhohang()
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
            }
            else if (txtTenHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
            }
            else if (txtSoTon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập sô lượng còn tồn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
            }
            else if (txtDVT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
            }
            else
            {
                string SqlUpdate = "UPDATE VatTuTrongKho SET " +
                                    "TenVatTu = N'" + txtTenHang.Text + "', " +
                                    "DonViTinh = N'" + txtDVT.Text + "', " +
                                    "SoLuongTon = " + txtSoTon.Text + " " + // Dùng .Text và không có dấu nháy cho số
                                    "WHERE MaVatTu = '" + txtMaHang.Text + "'";

                try
                {
                    HAMXULY.Connect();
                    HAMXULY.RunSql(SqlUpdate);
                    MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Showkhohang();
                    ResetText();
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                //thông báo chưa chọn chất liệu
                MessageBox.Show("Bạn chưa chọn mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                //xóa bằng lệnh sqldetele
                HAMXULY.Connect();
                string sqlDetele = "DELETE FROM VatTuTrongKho WHERE MaVatTu = '" + txtMaHang.Text + "'";
                if (MessageBox.Show("Bạn có chắc muốn xóa món hàng này ?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HAMXULY.RunSql(sqlDetele);
                    MessageBox.Show("Đã xóa thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //gọi ham show chât liệu
                Showkhohang();
                //xóa trên textbox
                ResetText();
                //ngắt kết nối
                HAMXULY.Disconnected();
            }

        }
        
    }
    
}
     
     
        
    
