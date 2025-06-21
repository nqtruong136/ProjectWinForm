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
