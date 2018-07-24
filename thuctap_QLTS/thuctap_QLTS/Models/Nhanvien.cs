using System;
using System.Collections.Generic;

namespace thuctap_QLTS.Models
{
    public partial class Nhanvien
    {
        public int MaNv { get; set; }
        public string TenNv { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int? Xoa { get; set; }
        public int? MaCv { get; set; }
        public int? MaPb { get; set; }

        public Chucvu MaCvNavigation { get; set; }
        public Phongban MaPbNavigation { get; set; }
    }
}
