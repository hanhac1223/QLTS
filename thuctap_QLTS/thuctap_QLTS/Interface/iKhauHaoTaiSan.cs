using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thuctap_QLTS.Interface
{
    interface iKhauHaoTaiSan
    {
         int MaKhauHao { get; set; }
         string TenKhauHao { get; set; }
         DateTime? NamKhauHao { get; set; }
         int? GiaTriNguyenGia { get; set; }
         double? HeSoKhauHao { get; set; }
         int? GiaTriKhauHaoNam { get; set; }
         int? GiaTriConLaiSauNam { get; set; }
         int? Xoa { get; set; }
    }
}
