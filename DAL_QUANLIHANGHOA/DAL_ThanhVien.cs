using DTO_QUANLIHANGHOA;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QUANLIHANGHOA
{
    public class DAL_ThanhVien : DBConnect
    {
        public DataTable GetThanhVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM thanhvien", conString);
            DataTable dtMatHang = new DataTable();
            da.Fill(dtMatHang);
            return dtMatHang;
        }

        public bool ThemThanhVien(DTO_ThanhVien thanhVien)
        {
            try
            {
                conString.Open();
                string SQL = string.Format("insert into thanhvien (MaThanhVien, HoTen, NgaySinh, GioiTinh, SoThich, DiaChi, Quyenhan, DonVi, DienThoai) values(N'{0}',N'{1}',CAST(N'{2}' AS Date), {3}, N'{4}' , N'{5}', N'Không', N'Không', N'000')", thanhVien.MaThanhVien, thanhVien.HoTen, thanhVien.NgaySinh, thanhVien.GioiTinh, thanhVien.SoThich, thanhVien.DiaChi);
                SqlCommand cmd = new SqlCommand(SQL, conString);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                conString.Close();
            }
            return false;
        }
    }
}