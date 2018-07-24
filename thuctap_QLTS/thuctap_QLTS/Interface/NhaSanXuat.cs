using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thuctap_QLTS.Interface
{
    interface NhaSanXuat
    {
         int MaNsx { get; set; }
         string TeNsx { get; set; }
         string DiaChi { get; set; }
         int? Sdt { get; set; }
    }
}
