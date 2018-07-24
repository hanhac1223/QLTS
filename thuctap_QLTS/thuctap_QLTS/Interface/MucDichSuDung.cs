using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thuctap_QLTS.Interface
{
    interface MucDichSuDung
    {
         int MaMucDich { get; set; }
         string TenMucDich { get; set; }
         string MoTa { get; set; }
         int? Xoa { get; set; }
    }
}
