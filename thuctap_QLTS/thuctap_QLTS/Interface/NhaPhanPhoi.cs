using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thuctap_QLTS.Interface
{
    interface NhaPhanPhoi
    {
         int MaNpp { get; set; }
         string TenNpp { get; set; }
         string ViTri { get; set; }
         int? Sdt { get; set; }
         int? Xoa { get; set; }
         int? MaNsx { get; set; }
    }
}
