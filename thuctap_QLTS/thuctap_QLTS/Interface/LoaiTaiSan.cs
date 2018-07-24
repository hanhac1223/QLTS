using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thuctap_QLTS.Interface
{
    interface LoaiTaiSan
    {
         int MaLoai { get; set; }
         string TenLoai { get; set; }
         int? Xoa { get; set; }
    }
}
