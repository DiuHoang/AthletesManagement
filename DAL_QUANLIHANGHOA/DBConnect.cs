using System.Data.SqlClient;

namespace DAL_QUANLIHANGHOA
{
    public class DBConnect
    {
        protected SqlConnection conString = new SqlConnection(@"Data Source=PNVD125;Initial Catalog=QLVanDongVien;Integrated Security=True");
    }
}
