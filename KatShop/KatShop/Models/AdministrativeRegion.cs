using System;
using System.Collections.Generic;

#nullable disable

namespace KatShop.Models
{
    public partial class AdministrativeRegion
    {
        public AdministrativeRegion()
        {
            Provinces = new HashSet<Province>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string CodeName { get; set; }
        public string CodeNameEn { get; set; }

        public virtual ICollection<Province> Provinces { get; set; }
    }
}
