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
    public partial class Form_QL_ND : Form
    {
        public Form_QL_ND()
        {
            InitializeComponent();
        }

        private void Form_QL_ND_Load(object sender, EventArgs e)
        {
            Refeshh();
        }
        private void Refeshh()
        {
            dgvQLND.Rows.Clear();
            string query = "Select NguoiDung.*, VaiTro.TenVaiTro from NguoiDung Inner Join VaiTro On NguoiDung.MaVaiTro = VaiTro.MaVaiTro";
            DataTable dt = new DataTable();
            if (HAMXULY.TruyVan(query, dt))
            {
                foreach (DataRow row in dt.Rows)
                {
                    int sodong = dgvQLND.Rows.Add(
                        row["MaNguoiDung"], /*chua sua*/
                        row["TenDangNhap"],
                        row["MatKhauMaHoa"],
                        row["HoVaTen"],
                        row["SoDienThoai"],
                        row["DiaChi"],
                        row["TenVaiTro"],
                        row["TrangThaiHoatDong"]

                    );
                    
                    if (row["TrangThaiHoatDong"].ToString() == "True")
                    {
                        dgvQLND.Rows[sodong].Cells[7].Style.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        dgvQLND.Rows[sodong].Cells[7].Style.BackColor = Color.Red;
                    }

                }
            }
        }

        private void dgvQLND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
