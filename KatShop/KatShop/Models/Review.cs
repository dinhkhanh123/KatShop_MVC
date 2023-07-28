using System;
using System.Collections.Generic;

#nullable disable

namespace KatShop.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public int? Rating { get; set; }
        public DateTime? DateReview { get; set; }

        public virtual Product Product { get; set; }
    }
}
