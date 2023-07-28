using AspNetCoreHero.ToastNotification.Abstractions;
using KatShop.Extension;
using KatShop.Models;
using KatShop.ModelViews;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace KatShop.Controllers
{
    [AllowAnonymous]
    public class ShoppingCartController : Controller
    {
        private readonly katshopContext _context;
        public INotyfService _notyfService { get; }
        public ShoppingCartController(katshopContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        public List<CartItem> GioHang
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (gh == default(List<CartItem>))
                {
                    gh = new List<CartItem>();
                }
                return gh;
            }
        }

        [Route("/tin-tuc/cart.html",Order =2)]
        [Route("/cart.html",Order =1, Name = "Cart")]
        public IActionResult Index()
        {
            return View(GioHang);
        }

        [HttpPost]
        [Route("api/cart/add")]
        public IActionResult AddToCart(int productID, int? amount,int price)
        {
            List<CartItem> cart = GioHang;

            try
            {
                //Them san pham vao gio hang
                CartItem item = cart.SingleOrDefault(p => p.product.ProductId == productID);
                if (item != null) // da co => cap nhat so luong
                {
                    item.amount = item.amount + amount.Value;
                    //luu lai session
                    HttpContext.Session.Set<List<CartItem>>("GioHang", cart);
                }
                else
                {
                    Product sp = _context.Products.SingleOrDefault(p => p.ProductId == productID);
                    item = new CartItem
                    {
                        
                        amount = amount.HasValue ? amount.Value : 1,
                        price = price,
                        product = sp
                    };
                    cart.Add(item);//Them vao gio
                }

                //Luu lai Session
                HttpContext.Session.Set<List<CartItem>>("GioHang", cart);
                _notyfService.Success("Thêm sản phẩm thành công");
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }
        [HttpPost]
        [Route("api/cart/update")]
        public IActionResult UpdateCart(int productID, int? amount)
        {
            //Lay gio hang ra de xu ly
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            try
            {
                if (cart != null)
                {
                    CartItem item = cart.SingleOrDefault(p => p.product.ProductId == productID);
                    if (item != null && amount.HasValue) // da co -> cap nhat so luong
                    {
                        item.amount = amount.Value;
                    }
                    //Luu lai session
                    HttpContext.Session.Set<List<CartItem>>("GioHang", cart);
                }
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        [Route("api/cart/remove")]
        public ActionResult Remove(int productID)
        {

            try
            {
                List<CartItem> gioHang = GioHang;
                CartItem item = gioHang.SingleOrDefault(p => p.product.ProductId == productID);
                if (item != null)
                {
                    gioHang.Remove(item);
                }
                //luu lai session
                HttpContext.Session.Set<List<CartItem>>("GioHang", gioHang);
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        [Route("api/discount/check")]
        public IActionResult CheckDiscount(string discountCode)
        {
            try
            {
                // Lấy giỏ hàng từ Session để xử lý
                var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");

                var discount = _context.Discounts.FirstOrDefault(x => x.CodeDiscount == discountCode && x.Ative == true && x.ExpiryDate >= DateTime.Now);

                if (discount != null)
                {    
                    return Json(new { isValid = true, discountedPrice = discount.PriceDiscount });
                }
                else
                {
                    return Json(new { isValid = false });
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và trả về thông báo lỗi
                return Json(new { isValid = false, errorMessage = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult SaveTotalAll(int discountedPrice)
        {
            HttpContext.Session.SetInt32("discountedPrice", discountedPrice);
            return Json(new { isValid = false});
        }

        private decimal CalculateTotalPrice(List<CartItem> cart)
        {
            decimal totalPrice = 0;

            foreach (var item in cart)
            {
                totalPrice += item.amount * item.price;
            }

            return totalPrice;
        }
    }
}
