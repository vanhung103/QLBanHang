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
    public class NhanVienDBContext : BaseDAL
    {
        private static NhanVienDBContext instance;
        public static readonly object instanceLock = new object();
        public NhanVienDBContext() { }
        public static NhanVienDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new NhanVienDBContext();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<NhanVien> GetNhanVienByKeyword(string tuKhoa)
        {
            IDataReader reader = null;
            string sql = "SELECT * FROM NhanVien WHERE TenNhanVien LIKE @TenNhanVien OR DiaChi LIKE @DiaChi";
            var parameters = new List<SqlParameter>();
            var nhanViens = new List<NhanVien>();
            try
            {
                parameters.Add(dataProvider.CreateParameter("@TenNhanVien", 200, "%" + tuKhoa + "%", DbType.String));
                parameters.Add(dataProvider.CreateParameter("@DiaChi", 200, "%" + tuKhoa + "%", DbType.String));
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, parameters.ToArray());
                while (reader.Read())
                {
                    nhanViens.Add(new NhanVien
                    {
                        MaNhanVien = reader.GetInt32(0),
                        TenNhanVien = reader.GetString(1),
                        DiaChi = reader.GetString(3),
                        DienThoai = reader.GetString(4),
                        GioiTinh = reader.GetBoolean(2),
                        NgaySinh = reader.GetDateTime(5)
                    });
                }
            }
            catch ( Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return nhanViens;
        }
        public IEnumerable<NhanVien> GetNhanVienList()
        {
            IDataReader reader = null;
            string sql = "SELECT * FROM NhanVien";
            var nhanViens = new List<NhanVien>();
            try
            {
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection);
                while (reader.Read())
                {
                    nhanViens.Add(new NhanVien
                    {
                        MaNhanVien = reader.GetInt32(0),
                        TenNhanVien = reader.GetString(1),
                        DiaChi = reader.GetString(3),
                        DienThoai = reader.GetString(4),
                        GioiTinh = reader.GetBoolean(2),
                        NgaySinh = reader.GetDateTime(5)
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
            return nhanViens;
        }
        public NhanVien GetNhanVienByID(int nhanVienID)
        {
            NhanVien nv = null;
            IDataReader reader = null;
            string sql = "Select * from NhanVien where MaNhanVien= @MaNhanVien";
            try
            {
                var param = dataProvider.CreateParameter("@MaNhanVien", 4, nhanVienID, DbType.Int32);
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, param);
                if (reader.Read())
                {
                    nv = new NhanVien
                    {
                        MaNhanVien = reader.GetInt32(0),
                        TenNhanVien = reader.GetString(1),
                        DiaChi = reader.GetString(3),
                        DienThoai = reader.GetString(4),
                        GioiTinh = reader.GetBoolean(2),
                        NgaySinh = reader.GetDateTime(5)
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
            return nv;
        }
        public void AddNew(NhanVien nv)
        {
            try
            {
                NhanVien k = GetNhanVienByID(nv.MaNhanVien);
                if (k == null)
                {
                    string sql = "INSERT INTO NhanVien(TenNhanVien, DiaChi, DienThoai, GioiTinh, NgaySinh) Values(@TenNhanVien, @DiaChi, @DienThoai, @GioiTinh, @NgaySinh)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@TenNhanVien", 200, nv.TenNhanVien, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DiaChi", 200, nv.DiaChi, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DienThoai", 50, nv.DienThoai, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@GioiTinh", 1, nv.GioiTinh, DbType.Boolean));
                    parameters.Add(dataProvider.CreateParameter("@NgaySinh", 20, nv.NgaySinh, DbType.DateTime));
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
        public void Update(NhanVien nv)
        {
            try
            {
                NhanVien n = GetNhanVienByID(nv.MaNhanVien);
                if (n != null)
                {
                    string sql = "UPDATE NhanVien set TenNhanVien=@TenNhanVien, DiaChi=@DiaChi, DienThoai=@DienThoai, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh where MaNhanVien=@MaNhanVien";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MaNhanVien", 4, nv.MaNhanVien, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@TenNhanVien", 200, nv.TenNhanVien, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DiaChi", 200, nv.DiaChi, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DienThoai", 50, nv.DienThoai, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@GioiTinh", 50, nv.GioiTinh, DbType.Boolean));
                    parameters.Add(dataProvider.CreateParameter("@NgaySinh", 50, nv.NgaySinh, DbType.DateTime));
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

        public void Delete(int nhanVienID)
        {
            try
            {
                NhanVien k = GetNhanVienByID(nhanVienID);
                if (k != null)
                {
                    string sql = "DELETE NhanVien where MaNhanVien=@MaNhanVien";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MaNhanVien", 4, nhanVienID, DbType.Int32));
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
