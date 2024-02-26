using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSendMail
{
    public static class AppConsts
    {

    }

    public static class MailConst
    {
        public const string KiLuongThang = "kiLuong";
        public const string HoTen = "hoTen";
        public const string DonVi = "donVi";
        public const string MaNhanVien = "maNhanVien";
        public const string ChucVu = "chucVu";
        public const string Email = "email";
        public const string SoTaiKhoan = "soTaiKhoan";
        public const string LuongCoBan = "luongCoBan";
        public const string PhuCapTrachNhiem = "phuCapTrachNhiem";
        public const string PhuCapThamNien = "phuCapThamNien";
        public const string AnGiuaCa = "anGiuaCa";
        public const string TongTienThemGio = "tongTienThemGio";
        public const string TienLamDem = "tienLamDem";
        public const string BaoHiemXaHoi = "baoHiemXaHoi";
        public const string BaoHiemYTe = "baoHiemYTe";
        public const string BaoHiemThatNghiep = "baoHiemThatNghiep";
        public const string ThueThuNhap = "thueThuNhap";
        public const string DoanPhi = "doanPhi";
        public const string ThucLinh = "thucLinh";
        public const string Logo = "[SIGNATURE_LOGO]";
        public const string Tong = "tong";

    }
    public static class MailUtils
    {
        public static string GetReplaceField(string field)
        {
            return string.Format("{{{{:{0}}}}}", field);
        }
    }
}
