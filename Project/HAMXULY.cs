using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    class HAMXULY
    {
        public static string connectionString = @"Data Source=172.25.173.248,1433;Initial Catalog=QLCK;User ID=hieu;Password=159753;TrustServerCertificate=True;";
        public static SqlConnection conn;
        public static void Connect()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=172.25.173.248,1433;Initial Catalog=QLCK;User ID=hieu;Password=159753;TrustServerCertificate=True;";
            conn.Open();    
        }   
        public static void Disconnected()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null; 
            }
        }

        public static bool ExecuteQueryWithParameters(string query, DataTable dataTable, params SqlParameter[] parameters)
        {
            // Sử dụng 'using' để đảm bảo kết nối luôn được đóng, kể cả khi có lỗi
            using (SqlConnection connection = new SqlConnection(@"Data Source=172.25.173.248,1433;Initial Catalog=QLCK;User ID=hieu;Password=159753;TrustServerCertificate=True;"))
            {
                // Sử dụng 'using' cho SqlCommand và SqlDataAdapter
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm danh sách các tham số vào command
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        try
                        {
                            // Mở kết nối
                            connection.Open();
                            // Đổ dữ liệu từ CSDL vào DataTable
                            adapter.Fill(dataTable);
                            return true; // Thực thi thành công
                        }
                        catch (Exception ex)
                        {
                            // Nếu có lỗi, hiển thị thông báo
                            MessageBox.Show("Đã xảy ra lỗi khi truy vấn cơ sở dữ liệu: " + ex.Message);
                            return false; // Thực thi thất bại
                        }
                        // 'using' sẽ tự động đóng kết nối ở đây
                    }
                }
            }
        }


        public static string GetUserPassword(int maNguoiDung)
        {
            string query = "SELECT MatKhauMaHoa FROM dbo.NguoiDung WHERE MaNguoiDung = @maND";
            DataTable dt = new DataTable();
            if (TruyVan(query, dt, new SqlParameter("@maND", maNguoiDung)))
            {
                return dt.Rows[0]["MatKhauMaHoa"].ToString();
            }
            return null;
        }

        public static bool UpdateUserPassword(int maNguoiDung, string matKhauMoi)
        {
            string query = "UPDATE dbo.NguoiDung SET MatKhauMaHoa = @matKhauMoi WHERE MaNguoiDung = @maND";

            SqlParameter paramPass = new SqlParameter("@matKhauMoi", matKhauMoi);
            SqlParameter paramId = new SqlParameter("@maND", maNguoiDung);

            // Dùng hàm ThucThiLenhCoThamSo mà chúng ta đã tạo (nó trả về số dòng bị ảnh hưởng)
            if (ThucThiLenhCoThamSo(query, paramPass, paramId) > 0)
            {
                return true;
            }
            return false;
        }

        public static int UpdateStatus(string ma, string Status)
        {
            string trangthai = (Status=="1") ? "1" : "0";
            string update = "Update NguoiDung Set TrangThaiHoatDong=@status Where MaNguoiDung = @ma";
            SqlParameter[] pa = new SqlParameter[2] {
                new SqlParameter("@status",trangthai),
                new SqlParameter("@ma", ma)
            };
            if (ThucThiLenhCoThamSo(update, pa)>0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static int ThucThiLenhCoThamSo(string query, params SqlParameter[] parameters)
        {
            // Chuỗi kết nối đến cơ sở dữ liệu (thay bằng chuỗi kết nối thực tế của bạn)
            string connectionString = @"Data Source=172.25.173.248,1433;Initial Catalog=QLCK;User ID=hieu;Password=159753;TrustServerCertificate=True;";

            // Sử dụng using để tự động giải phóng tài nguyên
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số vào lệnh nếu có
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        // Mở kết nối
                        connection.Open();
                        // Thực thi lệnh và trả về số dòng bị ảnh hưởng
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected;
                    }
                    catch (SqlException ex)
                    {
                        // Xử lý lỗi (có thể ghi log hoặc thông báo)
                        Console.WriteLine("Lỗi SQL: " + ex.Message);
                        return -1; // Trả về -1 để chỉ ra có lỗi
                    }
                    finally
                    {
                        // Đảm bảo đóng kết nối nếu nó đang mở
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }
        public static int LuuHoaDon(int maNguoiDung, decimal tongTien, int? maKhuyenMai, List<Product> danhSachSanPham,int httt)
        {
            // Sử dụng using để đảm bảo kết nối được đóng đúng cách
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Bắt đầu một transaction
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // === BƯỚC A: INSERT VÀO BẢNG HoaDon VÀ LẤY RA MaHoaDon VỪA TẠO ===

                    // 1. Chuẩn bị câu lệnh INSERT cho bảng HoaDon
                    //    SCOPE_IDENTITY() dùng để lấy ID tự tăng của dòng vừa được chèn vào.
                    string sqlInsertHoaDon = @"
                    INSERT INTO HoaDon (MaNguoiDung, NgayTaoHoaDon, TongTien, MaKhuyenMai, HinhThucThanhToan)
                    VALUES (@maNguoiDung, GETDATE(), @tongTien, @maKhuyenMai,@httt);
                    SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdHoaDon = new SqlCommand(sqlInsertHoaDon, connection, transaction);

                    // 2. Thêm các parameter
                    cmdHoaDon.Parameters.AddWithValue("@maNguoiDung", maNguoiDung);
                    cmdHoaDon.Parameters.AddWithValue("@tongTien", tongTien);
                    cmdHoaDon.Parameters.AddWithValue("@httt", httt);

                    // Xử lý parameter có thể NULL
                    if (maKhuyenMai.HasValue)
                    {
                        cmdHoaDon.Parameters.AddWithValue("@maKhuyenMai", maKhuyenMai.Value);
                    }
                    else
                    {
                        cmdHoaDon.Parameters.AddWithValue("@maKhuyenMai", DBNull.Value);
                    }

                    // 3. Thực thi và lấy về MaHoaDon mới
                    int newMaHoaDon = Convert.ToInt32(cmdHoaDon.ExecuteScalar());

                    // === BƯỚC B: INSERT VÀO BẢNG ChiTietHoaDon VỚI MaHoaDon VỪA LẤY ĐƯỢC ===

                    // 4. Lặp qua danh sách sản phẩm để insert vào ChiTietHoaDon
                    foreach (Product sp in danhSachSanPham)
                    {
                        string sqlInsertChiTiet = @"
                        INSERT INTO ChiTietHoaDon (MaHoaDon, MaSanPham, SoLuong, DonGia)
                        VALUES (@maHoaDon, @maSanPham, @soLuong, @donGia);";

                        SqlCommand cmdChiTiet = new SqlCommand(sqlInsertChiTiet, connection, transaction);
                        cmdChiTiet.Parameters.AddWithValue("@maHoaDon", newMaHoaDon);
                        cmdChiTiet.Parameters.AddWithValue("@maSanPham", Convert.ToInt32(sp.CodeProduct)); // Chú ý ép kiểu
                        cmdChiTiet.Parameters.AddWithValue("@soLuong", sp.Quantity);
                        cmdChiTiet.Parameters.AddWithValue("@donGia", sp.UnitPrice);

                        cmdChiTiet.ExecuteNonQuery();
                    }

                    // Nếu tất cả các lệnh trên không gây ra lỗi, xác nhận transaction
                    transaction.Commit();
                    return newMaHoaDon; // Trả về true báo hiệu thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message);
                    // Nếu có bất kỳ lỗi nào xảy ra, hủy bỏ toàn bộ transaction
                    transaction.Rollback();
                    return -1; // Trả về false báo hiệu thất bại
                }
            }
        }

        public static Boolean TruyVan(string query, DataTable dt)
        {
            
            Boolean kq = false;
            SqlDataAdapter da;

            try
            {
                da= new SqlDataAdapter(query,conn);
                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    kq = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(query);
                MessageBox.Show(ex.Message);

            }



            return kq;
        }

        public static bool TruyVan(string query, DataTable dt, params SqlParameter[] parameters)
        {
            // Lấy chuỗi kết nối từ nơi đã định nghĩa
            string connectionString = @"Data Source=172.25.173.248,1433;Initial Catalog=QLCK;User ID=hieu;Password=159753;TrustServerCertificate=True;";

            // Dùng 'using' để đảm bảo kết nối và các đối tượng khác được giải phóng đúng cách
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Thêm các tham số vào command nếu có
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    try
                    {
                        // Xóa dữ liệu cũ trong DataTable trước khi fill
                        dt.Clear();
                        // Đổ dữ liệu từ CSDL vào DataTable
                        adapter.Fill(dt);

                        // Chức năng cốt lõi: trả về true nếu DataTable có dòng, ngược lại trả về false
                        return dt.Rows.Count > 0;
                    }
                    catch (Exception ex)
                    {
                        // Nếu có lỗi, hiển thị thông báo và trả về false
                        MessageBox.Show("Lỗi khi thực hiện truy vấn: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        public static void RunSql(string query){
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã thực hiện thành công");

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            cmd.Dispose();
            
        }
        

    }
}
