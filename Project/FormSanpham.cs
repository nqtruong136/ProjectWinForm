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
namespace Project
{
    public partial class FormSanpham : Form
    {
        public FormSanpham()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void FormSanpham_Load(object sender, EventArgs e)
        {
            ShowSanPham();
        }
        private void ShowSanPham()
        {
            DataTable dtSanPham = new DataTable();
            HAMXULY.Connect();
            string sqlSanpham = "SELECT MaSanPham, TenSanPham, DonGia, MoTa, ChiTiet, MaDanhMuc FROM SanPham";
            if (HAMXULY.TruyVan(sqlSanpham, dtSanPham))
            {
                LuoiSP.DataSource = dtSanPham;
                LuoiSP.Columns[0].HeaderText = "Mã sản phẩm";
                LuoiSP.Columns[0].Width = 150;
                LuoiSP.Columns[1].HeaderText = "Tên sản phẩm";
                LuoiSP.Columns[1].Width = 200;
                LuoiSP.Columns[2].HeaderText = "Đơn giá";
                LuoiSP.Columns[2].Width = 100;
                LuoiSP.Columns[3].HeaderText = "Mô tả";
                LuoiSP.Columns[3].Width = 300;
                LuoiSP.Columns[4].HeaderText = "Chi tiết";
                LuoiSP.Columns[4].Width = 300;
                LuoiSP.Columns[5].HeaderText = "Mã danh mục";
                LuoiSP.Columns[5].Visible = false; // Ẩn cột MaDanhMuc

                LuoiSP.EnableHeadersVisualStyles = false;
                LuoiSP.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;

            }
        }

        private void LuoiSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = LuoiSP.CurrentRow.Cells["MaSanPham"].Value.ToString();
            txtTenSP.Text = LuoiSP.CurrentRow.Cells["TenSanPham"].Value.ToString();
            txtDGia.Text = LuoiSP.CurrentRow.Cells["DonGia"].Value.ToString();
            txtMoTa.Text = LuoiSP.CurrentRow.Cells["MoTa"].Value.ToString();
            txtCtiet.Text = LuoiSP.CurrentRow.Cells["ChiTiet"].Value.ToString();
            string MaDanhMuc, sql;
            MaDanhMuc = LuoiSP.CurrentRow.Cells["MaDanhMuc"].Value.ToString();
            sql = "SELECT TenDanhMuc FROM DanhMuc WHERE MaDanhMuc=N'" + MaDanhMuc + "'";
            CobMaDM.Text = HAMXULY.GetFieldValues(sql);

        }

        private void CobMaDM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
