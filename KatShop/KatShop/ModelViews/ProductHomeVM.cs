using KatShop.Models;
using System.Collections.Generic;

namespace KatShop.ModelViews
{
	public class ProductHomeVM
	{
        public Category category { get; set; }
        public List<Product> lsProducts { get; set; }
    }
}
