using DAL_QUANLIHANGHOA;
using DTO_QUANLIHANGHOA;
using System.Data;

namespace BUS_QUANLIHANGHOA
{
    public class BUS_ThanhVien
    {
        DAL_ThanhVien dalThanhVien = new DAL_ThanhVien();

        public DataTable GetThanhVien()
        {
            return dalThanhVien.GetThanhVien();
        }

        public bool ThemThanhVien(DTO_ThanhVien thanhVien)
        {
            return dalThanhVien.ThemThanhVien(thanhVien);
        }
    }
}
