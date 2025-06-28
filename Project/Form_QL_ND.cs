using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
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
            dgvQLND.Rows.Clear();
            string query = "Select NguoiDung.*, VaiTro.TenVaiTro from NguoiDung Inner Join VaiTro On NguoiDung.MaVaiTro = VaiTro.MaVaiTro";
            DataTable dt = new DataTable();
            if (HAMXULY.TruyVan(query, dt))
            {
                foreach(DataRow row in dt.Rows)
                {
                    dgvQLND.Rows.Add(
                        row[""], /*chua sua*/
                        row[""],
                        row[""],
                        row[""],
                        row[""],
                        row[""],
                        row[""]

                    );
                }
            }
        }
    }
}
