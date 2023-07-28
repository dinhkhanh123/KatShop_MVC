using System;
using KatShop.Models;

namespace KatShop.ModelViews
{
	public class CartItem
	{
        public Product product { get; set; }
        public int amount { get; set; }

        public int price { get; set; }
        public double TotalMoney => amount * price ;
        //product.Price.Value
    }
}
