using System;
using System.Collections.Generic;

namespace thuctap_QLTS.Models
{
    public partial class Taisan
    {
        public int MaTs { get; set; }
        public string TenTs { get; set; }
        public int? GiaTien { get; set; }
        public DateTime? NgayMua { get; set; }
        public int? HanSuDung { get; set; }
        public string MoTa { get; set; }
        public string BanQuyen { get; set; }
        public int? Xoa { get; set; }
        public int? MaTt { get; set; }
        public int? MaNpp { get; set; }
        public int? MaKhauHao { get; set; }
        public int? MaMucDich { get; set; }
        public int? MaPk { get; set; }
        public int? MaLoai { get; set; }

        public Nhaphanphoi MaKhauHao1 { get; set; }
        public Khauhaotaisan MaKhauHaoNavigation { get; set; }
        public Phieukiem MaPkNavigation { get; set; }
        public Trangthai MaTtNavigation { get; set; }
        public Mucdichsudung XoaNavigation { get; set; }
        public Loaitaisan Loaitaisan { get; set; }
    }
}
