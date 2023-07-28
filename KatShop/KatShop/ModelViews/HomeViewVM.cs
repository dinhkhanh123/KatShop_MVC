using System.Collections.Generic;
using KatShop.Models;

namespace KatShop.ModelViews
{
    public class HomeViewVM
    {
        public List<Post> Posts { get; set; }
        public List<ProductHomeVM> Products { get; set; }
        public List<Category> Categories { get; set; }
       // public QuangCao quangcao { get; set; }
    }
}
