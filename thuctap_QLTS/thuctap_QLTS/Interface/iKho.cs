﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thuctap_QLTS.Interface
{
    interface iKho
    {
         int MaKho { get; set; }
         string TenKho { get; set; }
         string ViTri { get; set; }
         int? Sdt { get; set; }
         int? Xoa { get; set; }
    }
}
