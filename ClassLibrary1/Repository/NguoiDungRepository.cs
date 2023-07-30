using QLBanHangLibrary.Bussiness;
using QLBanHangLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangLibrary.Repository
{
    public class NguoiDungRepository : INguoiDungRepository
    {
        public NguoiDung GetNguoiDungLogin(string TenDangNhap, string MatKhau) => NguoiDungDBContext.Instance.GetInfo(TenDangNhap, MatKhau);
    }
}
