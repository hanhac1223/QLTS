using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thuctap_QLTS.Interface
{
    interface NhanVien
    {
         int MaNv { get; set; }
         string TenNv { get; set; }
         string GioiTinh { get; set; }
         string DiaChi { get; set; }
         string Email { get; set; }
         int? Xoa { get; set; }
         int? MaCv { get; set; }
         int? MaPb { get; set; }
    }
}
