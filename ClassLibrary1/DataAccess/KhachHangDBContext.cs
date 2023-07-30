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
    public class KhachHangDBContext : BaseDAL
    {
        private static KhachHangDBContext instance;
        private static readonly object instanceLock = new object();
        public KhachHangDBContext() { }
        public static KhachHangDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new KhachHangDBContext();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<KhachHang> GetKhachHangByKeyword(string tuKhoa)
        {
            IDataReader reader = null;
            string sql = "SELECT * FROM KhachHang where TenKhachHang LIKE @TenKhachHang OR DiaChi LIKE @DiaChi";
            var parameters = new List<SqlParameter>();
            var khachHangs = new List<KhachHang>();
            try
            {
                parameters.Add(dataProvider.CreateParameter("@TenKhachHang", 200, "%" + tuKhoa + "%", DbType.String));
                parameters.Add(dataProvider.CreateParameter("@DiaChi", 200, "%" + tuKhoa + "%", DbType.String));
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, parameters.ToArray());
                while (reader.Read())
                {
                    khachHangs.Add(new KhachHang
                    {
                        MaKhachHang = reader.GetInt32(0),
                        TenKhachHang = reader.GetString(1),
                        DiaChi = reader.GetString(2),
                        DienThoai = reader.GetString(3),
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
            return khachHangs;
        }

        public IEnumerable<KhachHang> GetKhachHangList()
        {
            IDataReader reader = null;
            string sql = "SELECT * FROM KhachHang";
            var khachHangs = new List<KhachHang>();
            try
            {
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection);
                while (reader.Read())
                {
                    khachHangs.Add(new KhachHang
                    {
                        MaKhachHang = reader.GetInt32(0),
                        TenKhachHang = reader.GetString(1),
                        DiaChi = reader.GetString(2),
                        DienThoai = reader.GetString(3),
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
            return khachHangs;
        }

        public KhachHang GetKhachHangByID(int khachHangID)
        {
            KhachHang kh = null;
            IDataReader reader = null;
            string sql = "SELECT * FROM KhachHang WHERE MaKhachHang= @MaKhachHang";
            try
            {
                var param = dataProvider.CreateParameter("@MaKhachHang", 4, khachHangID, DbType.Int32);
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, param);
                if (reader.Read())
                {
                    kh = new KhachHang
                    {
                        MaKhachHang = reader.GetInt32(0),
                        TenKhachHang = reader.GetString(1),
                        DiaChi = reader.GetString(2),
                        DienThoai = reader.GetString(3)
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
            return kh;
        }

        public void AddNew(KhachHang kh)
        {
            try
            {
                KhachHang k = GetKhachHangByID(kh.MaKhachHang);
                if (k == null)
                {
                    string sql = "INSERT INTO KhachHang(TenKhachHang, DiaChi, DienThoai) Values(@TenKhachHang, @DiaChi, @DienThoai)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@TenKhachHang", 200, kh.TenKhachHang, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DiaChi", 200, kh.DiaChi, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DienThoai", 50, kh.DienThoai, DbType.String));
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

        public void Update(KhachHang kh)
        {
            try
            {
                KhachHang k = GetKhachHangByID(kh.MaKhachHang);
                if (k != null)
                {
                    string sql = "UPDATE KhachHang SET TenKhachHang=@TenKhachHang, DiaChi=@DiaChi, DienThoai=@DienThoai WHERE MaKhachHang=@MaKhachHang";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MaKhachHang", 4, kh.MaKhachHang, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@TenKhachHang", 200, kh.TenKhachHang, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DiaChi", 200, kh.DiaChi, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DienThoai", 50, kh.DienThoai, DbType.String));
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

        public void Delete(int khachHangID)
        {
            try
            {
                KhachHang k = GetKhachHangByID(khachHangID);
                if (k != null)
                {
                    string sql = "DELETE KhachHang WHERE MaKhachHang=@MaKhachHang";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MaKhachHang", 4, khachHangID, DbType.Int32));
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
