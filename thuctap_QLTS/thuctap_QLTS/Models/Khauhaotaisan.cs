using System;
using System.Collections.Generic;

namespace thuctap_QLTS.Models
{
    public partial class Khauhaotaisan
    {
        public Khauhaotaisan()
        {
            Taisan = new HashSet<Taisan>();
        }

        public int MaKhauHao { get; set; }
        public string TenKhauHao { get; set; }
        public DateTime? NamKhauHao { get; set; }
        public int? GiaTriNguyenGia { get; set; }
        public double? HeSoKhauHao { get; set; }
        public int? GiaTriKhauHaoNam { get; set; }
        public int? GiaTriConLaiSauNam { get; set; }
        public int? Xoa { get; set; }

        public ICollection<Taisan> Taisan { get; set; }
    }
}
