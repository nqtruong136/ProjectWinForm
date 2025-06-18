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
    public partial class FormConnect : Form
    {
        public FormConnect()
        {
            InitializeComponent();
        }

        private void FormConnect_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=MACBOOK-PRO\SQLEXPRESS;Initial Catalog=QLCK;Persist Security Info=True;User ID=hieu;Encrypt=False"))
                {
                    conn.Open();
                    MessageBox.Show("✅ Kết nối thành công!", "Thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Kết nối thất bại!\n" + ex.Message, "Lỗi");
            }
        }
    }
}
