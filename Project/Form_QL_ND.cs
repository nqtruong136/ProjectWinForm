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
        //debug int count = 0;
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
            dgvQLND.DataSource = null;
            dgvQLND.Rows.Clear();
            string query = "Select NguoiDung.*, VaiTro.TenVaiTro from NguoiDung Inner Join VaiTro On NguoiDung.MaVaiTro = VaiTro.MaVaiTro";
            DataTable dt = new DataTable();
            if (HAMXULY.TruyVan(query, dt))
            {
                //debug int dem = 1;
                foreach (DataRow row in dt.Rows)
                {
                    // cho nay debug MessageBox.Show("Chạy Lần '"+count +"' với stt: '"+dem+"'  Status is: '"+ row["TrangThaiHoatDong"] .ToString()+ "'");
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
                    // debug dem++;
                    if (row["TrangThaiHoatDong"].ToString() == "True")
                    {

                        dgvQLND.Rows[sodong].Cells[7].Style.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        dgvQLND.Rows[sodong].Cells[7].Style.BackColor = Color.Red;
                    }

                }
                // debug count++;
            }
        }

        private void dgvQLND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvQLND_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maND = dgvQLND.Rows[e.RowIndex].Cells["MaNguoiDung"].Value.ToString();
                //MessageBox.Show("Mã Hóa Đơn Là: '"+maHoaDonDuocChon+"'");
                // Chỉ truyền vào một số int, C# sẽ tự động gọi constructor thứ hai
                Form_QL_ND_CT ct = new Form_QL_ND_CT(maND);
                ct.ShowDialog();
                Refeshh();
            }
        }
    }
}
