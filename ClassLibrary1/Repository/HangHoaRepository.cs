using QLBanHangLibrary.Bussiness;
using QLBanHangLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangLibrary.Repository
{
    public class HangHoaRepository: IHangHoaRepository
    {
        public IEnumerable<HangHoa> GetHangHoas() => HangHoaDBContext.Instance.GetHangHoaList();
        public IEnumerable<HangHoa> GetHangHoaByKeyword(string keyword) => HangHoaDBContext.Instance.GetHangHoaByKeyword(keyword);
        public HangHoa GetHangHoaByID(int hangHoaId) => HangHoaDBContext.Instance.GetHangHoaByID(hangHoaId);
        public void InsertHangHoa(HangHoa hangHoa) => HangHoaDBContext.Instance.AddNew(hangHoa);
        public void UpdateHangHoa(HangHoa hangHoa) => HangHoaDBContext.Instance.Update(hangHoa);
        public void DeleteHangHoa(int hangHoaId) => HangHoaDBContext.Instance.Delete(hangHoaId);
    }
}
