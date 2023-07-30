using Microsoft.Data.SqlClient;
using QLBanHangLibrary.Bussiness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangLibrary.DataAccess
{
    public class HangHoaDBContext: BaseDAL
    {
        private static HangHoaDBContext instance;
        private static readonly object instanceLock = new object();
        public HangHoaDBContext() { }

        public static HangHoaDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new HangHoaDBContext();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<HangHoa> GetHangHoaByKeyword(string tuKhoa)
        {
            IDataReader reader = null;
            string sql = "Select * from HangHoa where TenHangHoa like @TenHangHoa or GhiChu like @GhiChu";
            var parameters = new List<SqlParameter>();
            var hangHoas = new List<HangHoa>();
            try
            {
                parameters.Add(dataProvider.CreateParameter("@TenHangHoa", 200, "%" + tuKhoa + "%", DbType.String));
                parameters.Add(dataProvider.CreateParameter("@GhiChu", 500, "%" + tuKhoa + "%", DbType.String));
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, parameters.ToArray());
                while (reader.Read())
                {
                    hangHoas.Add(new HangHoa
                    {
                        MaHangHoa = reader.GetInt32(0),
                        TenHangHoa = reader.GetString(1),
                        SoLuong = reader.GetInt32(2),
                        DonGiaNhap = reader.GetDecimal(3),
                        DonGiaBan = reader.GetDecimal(4),
                        Anh = reader.GetString(5),
                        GhiChu = reader.GetString(6),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return hangHoas;
        }
        public IEnumerable<HangHoa> GetHangHoaList()
        {
            IDataReader reader = null;
            string sql = "Select * from HangHoa";
            var hangHoas = new List<HangHoa>();
            try
            {
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection);
                while (reader.Read())
                {
                    hangHoas.Add(new HangHoa
                    {
                        MaHangHoa = reader.GetInt32(0),
                        TenHangHoa = reader.GetString(1),
                        SoLuong = reader.GetInt32(2),
                        DonGiaNhap = reader.GetDecimal(3),
                        DonGiaBan = reader.GetDecimal(4),
                        Anh = reader.GetString(5),
                        GhiChu = reader.GetString(6),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return hangHoas;
        }
        public HangHoa GetHangHoaByID(int hangHoaID)
        {
            HangHoa hh = null;
            IDataReader reader = null;
            string sql = "Select * from HangHoa where MaHangHoa= @MaHangHoa";
            try
            {
                var param = dataProvider.CreateParameter("@MaHangHoa", 4, hangHoaID, DbType.Int32);
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, param);
                if (reader.Read())
                {
                    hh = new HangHoa
                    {
                        MaHangHoa = reader.GetInt32(0),
                        TenHangHoa = reader.GetString(1),
                        SoLuong = reader.GetInt32(2),
                        DonGiaNhap = reader.GetDecimal(3),
                        DonGiaBan = reader.GetDecimal(4),
                        Anh = reader.GetString(5),
                        GhiChu = reader.GetString(6),
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return hh;
        }
        public void AddNew(HangHoa hh)
        {
            try
            {
                HangHoa h = GetHangHoaByID(hh.MaHangHoa);
                if (h == null)
                {
                    string sql = "INSERT INTO HangHoa(TenHangHoa, SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu) Values(@TenHangHoa, @SoLuong, @DonGiaNhap, @DonGiaBan, @Anh, @GhiChu)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@TenHangHoa", 200, hh.TenHangHoa, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@SoLuong", 4, hh.SoLuong, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DonGiaNhap", 10, hh.DonGiaNhap, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@DonGiaBan", 10, hh.DonGiaBan, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@Anh", 50, hh.Anh, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@GhiChu", 500, hh.GhiChu, DbType.String));
                    dataProvider.Insert(sql, CommandType.Text, parameters.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Update(HangHoa hh)
        {
            try
            {
                HangHoa h = GetHangHoaByID(hh.MaHangHoa);
                if (h != null)
                {
                    string sql = "UPDATE HangHoa set TenHangHoa=@TenHangHoa, SoLuong=@SoLuong, DonGiaNhap=@DonGiaNhap, DonGiaBan=@DonGiaBan, Anh=@Anh, GhiChu=@GhiChu where MaHangHoa=@MaHangHoa";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MaHangHoa", 4, hh.MaHangHoa, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@TenHangHoa", 200, hh.TenHangHoa, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@SoLuong", 4, hh.SoLuong, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@DonGiaNhap", 10, hh.DonGiaNhap, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@DonGiaBan", 10, hh.DonGiaBan, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@Anh", 50, hh.Anh, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@GhiChu", 500, hh.GhiChu, DbType.String));
                    dataProvider.Update(sql, CommandType.Text, parameters.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Delete(int hangHoaID)
        {
            try
            {
                HangHoa k = GetHangHoaByID(hangHoaID);
                if (k != null)
                {
                    string sql = "DELETE HangHoa where MaHangHoa=@MaHangHoa";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MaHangHoa", 4, hangHoaID, DbType.Int32));
                    dataProvider.Delete(sql, CommandType.Text, parameters.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
