using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace Project
{
    public partial class Form_QL_ND_CT : Form
    {
        string maND;
        public Form_QL_ND_CT(string ma)
        {
            InitializeComponent();
            ViewPanel(pnlEdit, false);
            maND = ma;
        }


        private void ViewPanel(Panel pnl, Boolean luachon)
        {
            if (luachon)
            {
                pnl.Enabled = true;
            }
            else { pnl.Enabled = false; }
        }
        private void ResettxtEdit()
        {
            txtEma.Text = "";
            txtEten.Text = "";
            txtEdc.Text = "";
            txtEdt.Text = "";
            txtEtk.Text = "";
            txtEmk.Text = "";
            rdoNV.AutoCheck = true;
        }
        private void PnlRightView(bool luachon)
        {
            if (luachon)
            {
                ViewPanel(pnlCT_TK,true);
                ViewPanel(pnlCT_TT,true);
            }
            else
            {
                ViewPanel(pnlCT_TK, false);
                ViewPanel(pnlCT_TT, false);
            }
        }
        private void PnlLeftView(bool luachon)
        {
            if (luachon)
            {
                ViewPanel(pnlEdit, true);
                
            }
            else
            {
                ViewPanel(pnlEdit, false);
                
            }
        }

        private void GetFromRightToLeft(bool yes)
        {
            if (yes)
            {
                txtEma.Text = maND;
                txtEten.Text = txtTen.Text;
                txtEdc.Text = txtDC.Text;
                txtEdt.Text = txtSDT.Text;
                txtEtk.Text = txtTK.Text;
                txtEmk.Text = txtMK.Text;
                if (txtVT.Text == "Admin")
                {
                    /*MessageBox.Show("admin '"+txtVT.Text+"'");*/
                    rdoAD.Checked = true;
                }
                if (txtVT.Text.Trim() == "Quản lý")
                {
                    //MessageBox.Show("QL   '" + txtVT.Text + "'");
                    rdoQL.Checked = true;

                }
                else
                {
                    //MessageBox.Show("NV   '" + txtVT.Text + "'");
                    rdoNV.Checked = true;
                }
                
            }
            else
            {

            }
        }

        private int KTvaiTro()
        {
            if (rdoAD.Checked){
                //MessageBox.Show("AD");
                return 0;
            }
            if (rdoQL.Checked)
            {
                //MessageBox.Show("QL");
                return 1;
            }
            //MessageBox.Show("NV");
            return 2;
        }

        private void FillTextBox(string ma)
        {
            string query = "Select NguoiDung.*, VaiTro.TenVaiTro from NguoiDung Inner Join VaiTro On NguoiDung.MaVaiTro = VaiTro.MaVaiTro Where MaNguoiDung = @ma ";
            SqlParameter pa = new SqlParameter("@ma",ma);
            DataTable dt = new DataTable();
            if (HAMXULY.TruyVan(query,dt,pa))
            {
                foreach (DataRow row in dt.Rows)
                {
                    txtTen.Text = row["HoVaTen"].ToString();
                    txtDC.Text = row["DiaChi"].ToString();
                    txtSDT.Text = row["SoDienThoai"].ToString();
                    txtVT.Text = row["TenVaiTro"].ToString();
                    txtTK.Text = row["TenDangNhap"].ToString();
                    txtMK.Text = row["MatKhauMaHoa"].ToString();
                }
            }
        }
        private void Form_QL_ND_CT_Load(object sender, EventArgs e)
        {
            FillTextBox(maND);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnLua_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled==true)
            {
                string ma = txtEma.Text;
                string hoten = txtEten.Text;
                string diachi = txtEdc.Text;
                string sdt = txtEdc.Text;
                string tk = txtEtk.Text;
                string mk = txtEmk.Text;
                string vt = KTvaiTro().ToString();
                

                string query = "INSERT INTO NguoiDung (TenDangNhap, MatKhauMaHoa, HoVaTen, SoDienThoai, DiaChi, MaVaiTro, TrangThaiHoatDong) VALUES (@tk, @mk, @ten, @sdt, @diachi, @vt, '0'); ";
                SqlParameter[] pa = new SqlParameter[6]
                {
                    new SqlParameter("@tk",tk),
                    new SqlParameter("@mk",mk),
                    new SqlParameter("@ten",hoten),
                    new SqlParameter("@sdt",sdt),
                    new SqlParameter("@diachi",diachi),
                    new SqlParameter("@vt",vt)
                };
                int affect = HAMXULY.ThucThiLenhCoThamSo(query,pa);
                if (affect > 0)
                {
                    MessageBox.Show("Thêm Thành Công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại");
                }

                
            }
            if (btnEdit.Enabled==true)
            {
                string ma = txtEma.Text;
                string hoten = txtEten.Text;
                string diachi = txtEdc.Text;
                string sdt = txtEdc.Text;
                string tk = txtEtk.Text;
                string mk = txtEmk.Text;
                string vt= KTvaiTro().ToString();


                string query = "UPDATE NguoiDung SET TenDangNhap = @tk, MatKhauMaHoa = @mk, HoVaTen = @ten, SoDienThoai = @sdt, DiaChi = @diachi, MaVaiTro = @vt WHERE MaNguoiDung = @maND; ";
                SqlParameter[] pa = new SqlParameter[7]
                {
                    new SqlParameter("@tk", tk),
                    new SqlParameter("@mk", mk),
                    new SqlParameter("@ten", hoten),
                    new SqlParameter("@sdt", sdt),
                    new SqlParameter("@diachi", diachi),
                    new SqlParameter("@vt", vt),
                    new SqlParameter("@maND", ma)
                };
                int affect = HAMXULY.ThucThiLenhCoThamSo(query, pa);
                if (affect > 0)
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                    DangXuat();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập Nhật Thất Bại");
                }
                Refreshh();
            }
        }
        private void Refreshh() {
            ResettxtEdit();
            FillTextBox(maND);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResettxtEdit();
            PnlLeftView(false);
            PnlRightView(true);
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnEdit.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResettxtEdit();
            PnlRightView(false);
            PnlLeftView(true);
            btnXoa.Enabled = false;
            btnEdit.Enabled = false;
            txtEma.Focus();
            btnLuu.Enabled = true;
            txtEma.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ResettxtEdit();
            PnlRightView(false);
            PnlLeftView(true);
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtEma.Focus();
            btnLuu.Enabled = true;
            GetFromRightToLeft(true);
            //txtEma.Enabled = false;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DangXuat();
            
        }
        private void DangXuat()
        {
            string query = "Update NguoiDung Set TrangThaiHoatDong = 0 Where MaNguoiDung=@ma";
            SqlParameter qp = new SqlParameter("@ma", maND);
            int result = HAMXULY.ThucThiLenhCoThamSo(query, qp);
            if (result > 0)
            {
                MessageBox.Show("Bạn đã Đăng Xuất Tài Khoản Thành Công");
            }
            else
            {
                MessageBox.Show("Đăng Xuất Thất Bại");
            }
            this.Close();
        }
    }
}
