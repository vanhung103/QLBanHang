using QLBanHangLibrary.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangLibrary.Repository
{
    public interface IHangHoaRepository
    {
        IEnumerable<HangHoa> GetHangHoas();
        IEnumerable<HangHoa> GetHangHoaByKeyword(string keyword);
        HangHoa GetHangHoaByID(int hangHoaId);
        void InsertHangHoa(HangHoa hangHoa);
        void UpdateHangHoa(HangHoa hangHoa);
        void DeleteHangHoa(int hangHoaId);
    }
}
