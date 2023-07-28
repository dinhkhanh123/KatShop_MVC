using System;
using System.Collections.Generic;

#nullable disable

namespace KatShop.Models
{
    public partial class Discount
    {
        public int Id { get; set; }
        public string CodeDiscount { get; set; }
        public int? PriceDiscount { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool Ative { get; set; }
    }
}
