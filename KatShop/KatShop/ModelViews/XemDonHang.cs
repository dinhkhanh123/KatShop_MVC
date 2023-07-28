using KatShop.Models;
using System.Collections.Generic;

namespace KatShop.ModelViews
{
    public class XemDonHang
    {
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }

        
    }
}
