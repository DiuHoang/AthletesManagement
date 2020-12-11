using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLIHANGHOA
{
    public class DTO_ThanhVien
    {
        private string maThanhVien;
        private string hoTen;
        private DateTime ngaySinh;
        private int gioiTinh;
        private string soThich;
        private string diaChi;

        public string MaThanhVien { get => maThanhVien; set => maThanhVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SoThich { get => soThich; set => soThich = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
