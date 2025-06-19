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
    public partial class InvoiceControl : UserControl
    {
        private List<Product> products = new List<Product>();
        public InvoiceControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            dgvProducts.DataSource = new BindingSource { DataSource = products };

            dgvProducts.Columns["CodeProduct"].HeaderText = "Mã Hàng";
            dgvProducts.Columns["NameProduct"].HeaderText = "Tên Hàng";
            dgvProducts.Columns["Quantity"].HeaderText = "Số Lượng";
            dgvProducts.Columns["UnitPrice"].HeaderText = "Giá";
            dgvProducts.Columns["CodeProduct"].Visible = false;
        }

        private void InvoiceControl_Load(object sender, EventArgs e)
        {
            
        }
        public void AddProduct(string code ,string name, int quantity, int unitPrice)
        {
            var product = new Product
            {
                CodeProduct = code,
                NameProduct = name,
                Quantity = quantity,
                UnitPrice = unitPrice
            };

            products.Add(product);
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;

            int total = products.Sum(p => p.TotalPrice);
            lblTotal.Text = $"Tổng tiền: {total:N0} VNĐ";
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
