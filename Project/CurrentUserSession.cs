using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class CurrentUserSession
    {
        // Dùng private set để chỉ có thể gán giá trị từ bên trong lớp này
        public static int MaNguoiDung { get; private set; }
        public static string HoVaTen { get; private set; }
        public static int MaVaiTro { get; private set; }
        public static string TenDangNhap { get; private set; }

        // Phương thức để gán thông tin khi đăng nhập thành công
        public static void SetCurrentUser(int maNguoiDung, string hoVaTen, int maVaiTro, string tenDangNhap)
        {
            MaNguoiDung = maNguoiDung;
            HoVaTen = hoVaTen;
            MaVaiTro = maVaiTro;
            TenDangNhap = tenDangNhap;
        }

        // Phương thức để xóa thông tin khi đăng xuất
        public static void Clear()
        {
            MaNguoiDung = 0;
            HoVaTen = string.Empty;
            MaVaiTro = 0;
            TenDangNhap = string.Empty;
        }
    }
}
