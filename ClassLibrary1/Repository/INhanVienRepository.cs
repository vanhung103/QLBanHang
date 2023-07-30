using QLBanHangLibrary.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangLibrary.Repository
{
    public interface INhanVienRepository
    {
        IEnumerable<NhanVien> GetNhanViens();
        IEnumerable<NhanVien> GetNhanVienByKeyword(string keyword);
        NhanVien GetNhanVienByID(int nhanVienId);
        void InsertNhanVien(NhanVien nhanVien);
        void UpdateNhanVien(NhanVien nhanVien);
        void DeleteNhanVien(int nhanVienId);

    }
}
