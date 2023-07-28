using System;
using System.Collections.Generic;

#nullable disable

namespace KatShop.Models
{
    public partial class Autribute
    {
        public Autribute()
        {
            AutributePrices = new HashSet<AutributePrice>();
        }

        public int AutributeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AutributePrice> AutributePrices { get; set; }
    }
}
