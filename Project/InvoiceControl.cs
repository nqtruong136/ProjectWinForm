using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Project
{
    public partial class InvoiceControl : UserControl
    {
        private Random rand = new Random();

        // Các màu nguồn (đang hiển thị) và màu đích (sẽ chuyển tới)
        private Color sourceColor1, targetColor1;
        private Color sourceColor2, targetColor2;

        // Các màu hiện tại được tính toán trong mỗi bước chuyển
        private Color currentColor1, currentColor2;
        private Color sourceTextColor, targetTextColor, currentTextColor;

        // Quản lý tiến trình animation
        private int animationDuration = 1500; // Thời gian chuyển màu: 2000ms = 2 giây
        private int totalSteps;
        private int currentStep = 0;

        public List<Product> products = new List<Product>();
        public InvoiceControl()
        {
            
            InitializeComponent();
            
            this.Dock = DockStyle.Fill;
            AddDeleteButtonColumn();
            dgvProducts.DataSource = new BindingSource { DataSource = products };
            set_start_title_grid();
            dgvProducts.RowHeadersVisible = false;

            // 2. GỌI HÀM SET TIÊU ĐỀ CỘT DỮ LIỆU
            set_start_title_grid();

            // 3. THÊM CỘT NÚT XÓA MỚI
            

            lblTotal.Text = "";
        }
        private void AddDeleteButtonColumn()
        {
            // Tạo một đối tượng cột kiểu nút bấm
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();

            // --- Thiết lập các thuộc tính cho cột ---

            // Tên định danh cho cột để gọi trong code
            deleteColumn.Name = "colDelete";

            // Chữ hiển thị trên tiêu đề của cột
            deleteColumn.HeaderText = "Thao tác";

            // Chữ hiển thị trên TẤT CẢ các nút trong cột này
            deleteColumn.Text = "Xóa";

            // Thuộc tính quan trọng: Yêu cầu tất cả các ô nút bấm trong cột
            // đều sử dụng giá trị của thuộc tính 'Text' ở trên ("Xóa")
            deleteColumn.UseColumnTextForButtonValue = true;

            // Set độ rộng cho cột
            deleteColumn.Width = 60;

            // Thêm cột đã tạo vào DataGridView
            dgvProducts.Columns.Add(deleteColumn);
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
            totalSteps = animationDuration / timerColorChange.Interval;

            // Khởi tạo màu nền ban đầu
            sourceColor1 = this.BackColor;
            targetColor1 = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            sourceColor2 = this.BackColor;
            targetColor2 = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

            // KHỞI TẠO MÀU CHỮ BAN ĐẦU
            // Tính độ sáng trung bình của màu đích
            double avgBrightness = (GetBrightness(targetColor1) + GetBrightness(targetColor2)) / 2.0;

            // Quyết định màu chữ ban đầu
            targetTextColor = (avgBrightness > 130) ? Color.Black : Color.White;
            sourceTextColor = targetTextColor; // Ban đầu cho màu nguồn và đích giống nhau
            currentTextColor = targetTextColor;

            timerColorChange.Start();
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
            lblTotal.Text = "";
            int total = products.Sum(p => p.TotalPrice);
            Console.WriteLine(total);
            lblTotal.Text = total.ToString();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy chỉ số cột và dòng đang được nhấn
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            // Đảm bảo người dùng không nhấn vào tiêu đề (rowIndex < 0)
            if (rowIndex < 0) return;

            // KIỂM TRA: Chỉ thực hiện hành động nếu người dùng nhấn vào CỘT NÚT XÓA
            // mà chúng ta đã tạo (có tên là "colDelete")
            if (dgvProducts.Columns[columnIndex].Name == "colDelete")
            {
                // Lấy tên sản phẩm để hiển thị trong thông báo
                string productName = products[rowIndex].NameProduct;

                // Hiển thị hộp thoại xác nhận (giống như trước)
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sản phẩm '{productName}' khỏi hóa đơn?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Nếu người dùng chọn "Yes"
                if (result == DialogResult.Yes)
                {
                    // Xóa sản phẩm khỏi danh sách products tại vị trí của dòng đã nhấn
                    products.RemoveAt(rowIndex);

                    // Cập nhật lại DataGridView
                    RefreshGrid();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void lblThanhToan_Click (object sender, EventArgs e)
        {
            bool hasData = false;
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (!row.IsNewRow)
                {
                    hasData = true;
                    break;
                }
            }
            if (hasData)
            {
                
            }
            else{
                MessageBox.Show("Chưa Có Sản Phẩm Được Thêm Vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        public Label lblInvoice
        {
            get { return lblThanhToan; }
            set { lblThanhToan = value; }
        }

        private void timerColorChange_Tick(object sender, EventArgs e)
        {
            if (currentStep <= totalSteps)
            {
                double progress = (double)currentStep / totalSteps;
                progress = progress * progress * (3.0 - 2.0 * progress); // Dùng Easing Function cho mượt

                // Nội suy màu nền (như cũ)
                currentColor1 = BlendColor(sourceColor1, targetColor1, progress);
                currentColor2 = BlendColor(sourceColor2, targetColor2, progress);

                // NỘI SUY MÀU CHỮ
                currentTextColor = BlendColor(sourceTextColor, targetTextColor, progress);

                currentStep++;
                lblThanhToan.Invalidate();
            }
            else
            {
                // Khi animation cũ kết thúc, chuẩn bị cho animation mới
                currentStep = 0;

                // Màu nền: đích cũ -> nguồn mới
                sourceColor1 = targetColor1;
                sourceColor2 = targetColor2;
                targetColor1 = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                targetColor2 = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                // MÀU CHỮ: quyết định màu đích mới và bắt đầu chuyển đổi
                sourceTextColor = currentTextColor; // Màu nguồn là màu cuối cùng của lần trước
                double avgBrightness = (GetBrightness(targetColor1) + GetBrightness(targetColor2)) / 2.0;
                targetTextColor = (avgBrightness > 130) ? Color.Black : Color.White; // Quyết định màu đích mới
            }
        }
        private Color BlendColor(Color source, Color target, double progress)
        {
            int r = (int)(source.R + (target.R - source.R) * progress);
            int g = (int)(source.G + (target.G - source.G) * progress);
            int b = (int)(source.B + (target.B - source.B) * progress);
            return Color.FromArgb(r, g, b);
        }
        private int GetBrightness(Color c)
        {
            // Dùng công thức tính độ sáng tiêu chuẩn (luminance)
            return (int)Math.Sqrt(
               c.R * c.R * .241 +
               c.G * c.G * .691 +
               c.B * c.B * .068);
        }
        private void lblThanhToan_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                lblThanhToan.ClientRectangle,
                currentColor1,
                currentColor2,
                45f))
            {
                e.Graphics.FillRectangle(brush, lblThanhToan.ClientRectangle);
            }

            // Dùng màu chữ đã được nội suy
            TextRenderer.DrawText(
                e.Graphics,
                lblThanhToan.Text,
                lblThanhToan.Font,
                lblThanhToan.ClientRectangle,
                currentTextColor, // <-- THAY ĐỔI Ở ĐÂY
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
