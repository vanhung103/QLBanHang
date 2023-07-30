using QLBanHangLibrary.Bussiness;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangLibrary.DataAccess
{
    public class NguoiDungDBContext : BaseDAL
    {
        private static NguoiDungDBContext instance;
        private static readonly object instanceLock = new object();
        public NguoiDungDBContext() { }
        public static NguoiDungDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new NguoiDungDBContext();
                    }
                    return instance;
                }
            }
        }

        public NguoiDung GetInfo(string tenDangNhap, string matKhau)
        {
            NguoiDung nguoiDung = null;
            IDataReader reader = null;
            var parameters = new List<SqlParameter>();
            string sql = "SELECT * FROM NguoiDung WHERE TenDangNhap LIKE @TenDangNhap AND MatKhau LIKE @MatKhau";
            try
            {
                parameters.Add(dataProvider.CreateParameter("@TenDangNhap", 50, tenDangNhap, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@MatKhau", 50, matKhau, DbType.String));
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, parameters.ToArray());
                if (reader.Read())
                {
                    nguoiDung = new NguoiDung
                    {
                        TenDangNhap = reader.GetString(0),
                        MatKhau = reader.GetString(1)
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
            return nguoiDung;
        }
    }
}
