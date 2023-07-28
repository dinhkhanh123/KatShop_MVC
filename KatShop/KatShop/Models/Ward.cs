﻿using System;
using System.Collections.Generic;

#nullable disable

namespace KatShop.Models
{
    public partial class Ward
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string FullName { get; set; }
        public string FullNameEn { get; set; }
        public string CodeName { get; set; }
        public string DistrictCode { get; set; }
        public int? AdministrativeUnitId { get; set; }

        public virtual AdministrativeUnit AdministrativeUnit { get; set; }
        public virtual District DistrictCodeNavigation { get; set; }
    }
}