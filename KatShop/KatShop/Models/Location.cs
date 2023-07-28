using System;
using System.Collections.Generic;

#nullable disable

namespace KatShop.Models
{
    public partial class Location
    {
        public int LocaId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Slug { get; set; }
        public string NameWithType { get; set; }
        public string PathWithType { get; set; }
        public int? ParentCode { get; set; }
        public int? Levels { get; set; }
    }
}
