using System;
using System.Collections.Generic;

#nullable disable

namespace KatShop.Models
{
    public partial class Province
    {
        public Province()
        {
            Customers = new HashSet<Customer>();
            Districts = new HashSet<District>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string FullName { get; set; }
        public string FullNameEn { get; set; }
        public string CodeName { get; set; }
        public int? AdministrativeUnitId { get; set; }
        public int? AdministrativeRegionId { get; set; }

        public virtual AdministrativeRegion AdministrativeRegion { get; set; }
        public virtual AdministrativeUnit AdministrativeUnit { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}
