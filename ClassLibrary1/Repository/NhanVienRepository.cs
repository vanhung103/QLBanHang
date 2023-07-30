using QLBanHangLibrary.Bussiness;
using QLBanHangLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangLibrary.Repository
{
    public class NhanVienRepository : INhanVienRepository
    {
        public IEnumerable<NhanVien> GetNhanViens() => NhanVienDBContext.Instance.GetNhanVienList();
        public IEnumerable<NhanVien> GetNhanVienByKeyword(string keyword) => NhanVienDBContext.Instance.GetNhanVienByKeyword(keyword);
        public NhanVien GetNhanVienByID(int nhanVienId) => NhanVienDBContext.Instance.GetNhanVienByID(nhanVienId);
        public void InsertNhanVien(NhanVien nhanVien) => NhanVienDBContext.Instance.AddNew(nhanVien);
        public void UpdateNhanVien(NhanVien nhanVien) => NhanVienDBContext.Instance.Update(nhanVien);
        public void DeleteNhanVien(int nhanVienId) => NhanVienDBContext.Instance.Delete(nhanVienId);
    }
}
