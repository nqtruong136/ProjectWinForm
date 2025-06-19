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
            set_start_title_grid();
            
        }
        private void set_start_title_grid()
        {
            dgvProducts.Columns["CodeProduct"].HeaderText = "Mã Hàng";
            dgvProducts.Columns["NameProduct"].HeaderText = "Tên Hàng";
            dgvProducts.Columns["Quantity"].HeaderText = "Số Lượng";
            dgvProducts.Columns["UnitPrice"].HeaderText = "Giá";
            dgvProducts.Columns["TotalPrice"].HeaderText = "Tổng Giá";
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
            Product tempproduct = products.Find(p => p.CodeProduct == code);
            
            
            if (tempproduct!=null)
            {
                //MessageBox.Show("Da cập nhật quantity");
                tempproduct.Quantity += quantity;
                
            }
            else
            {
                products.Add(product);
                
            }
            /*foreach (var producte in products)
            {
                Console.WriteLine("Product:");
                Console.WriteLine($"  CodeProduct: {producte.CodeProduct}");
                Console.WriteLine($"  NameProduct: {producte.NameProduct}");
                Console.WriteLine($"  Quantity: {producte.Quantity}");
                Console.WriteLine($"  UnitPrice: {producte.UnitPrice}");
                Console.WriteLine($"  TotalPrice: {producte.TotalPrice}");
                Console.WriteLine(); // xuống dòng để dễ nhìn
            }*/
            RefreshGrid();
        }
        
        private void RefreshGrid()
        {
            dgvProducts.DataSource = null;
            
            dgvProducts.DataSource = products;
            set_start_title_grid();
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
