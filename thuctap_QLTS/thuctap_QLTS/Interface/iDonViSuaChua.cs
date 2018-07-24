using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thuctap_QLTS.Interface
{
    interface iDonViSuaChua
    {
         int MaDv { get; set; }
         string TenDv { get; set; }
         string DiaChi { get; set; }
         string Email { get; set; }
         int? Sdt { get; set; }
    }
}
