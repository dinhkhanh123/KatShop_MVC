using System;
using System.Collections.Generic;

#nullable disable

namespace KatShop.Models
{
    public partial class AutributePrice
    {
        public int AutributePriceId { get; set; }
        public int? AutributeId { get; set; }
        public int? ProductId { get; set; }
        public int? Price { get; set; }
        public bool Active { get; set; }

        public virtual Autribute Autribute { get; set; }
        public virtual Product Product { get; set; }
    }
}
