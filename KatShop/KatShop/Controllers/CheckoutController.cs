using AspNetCoreHero.ToastNotification.Abstractions;
using KatShop.Helpper;
using KatShop.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using KatShop.ModelViews;
using KatShop.Extension;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace KatShop.Controllers
{
    [AllowAnonymous]
    public class CheckoutController : Controller
    {
        private readonly katshopContext _context;
        public INotyfService _notyfService { get; }
        public CheckoutController(katshopContext context, INotyfService notyfService)
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
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(string returnUrl = null)
        {
            //Lay gio hang ra de xu ly
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoanID = HttpContext.Session.GetString("CusId");
            
            MuaHangVM model = new MuaHangVM();
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CusId == Convert.ToInt32(taikhoanID));
                model.CusId = khachhang.CusId;
                model.FullName = khachhang.FullName;
                model.Email = khachhang.Email;
                model.Phone = khachhang.Phone;
                model.Address = khachhang.Address;

                model.TinhThanh = GetNameProvice(khachhang.CodeProvince);
                model.QuanHuyen = GetNameDistrict(khachhang.District); 
                model.PhuongXa = GetNameWard(khachhang.Ward);

             
                
              
                 ;

            }

            ViewData["lsTinhThanh"] = new SelectList(_context.Provinces.OrderBy(x => x.Code).ToList(), "Code", "Name");
            ViewBag.GioHang = cart;
          
            return View(model);
        }

        [HttpPost]
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(MuaHangVM muaHang)
        {
            //Lay ra gio hang de xu ly
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoanID = HttpContext.Session.GetString("CusId");
           

            MuaHangVM model = new MuaHangVM();

            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CusId == Convert.ToInt32(taikhoanID));
             
                    model.CusId = khachhang.CusId;
                    //model.FullName = khachhang.FullName;
                    //model.Email = khachhang.Email;
                    //model.Phone = khachhang.Phone;
                    //model.Address = khachhang.Address;

                     khachhang.FullName = muaHang.FullName;
                     khachhang.Email =muaHang.Email;
                     khachhang.Phone = muaHang.Phone;
                     khachhang.Address = muaHang.Address;

                model.TinhThanh = khachhang.CodeProvince;
                model.QuanHuyen = khachhang.District;
                model.PhuongXa = khachhang.Ward;

                     //khachhang.CodeProvince = muaHang.TinhThanh;
                     //khachhang.District = muaHang.QuanHuyen;
                     //khachhang.Ward = muaHang.PhuongXa;
                   
              
                
                _context.Update(khachhang);
                _context.SaveChanges();
            }
            try
            {
                if (ModelState.IsValid)
                {
                    var discountedPrice = HttpContext.Session.GetInt32("discountedPrice");
                    //Khoi tao don hang
                    Order donhang = new Order();

              
                    donhang.CusId = model.CusId;
                    donhang.Address = muaHang.Address;
                    donhang.CodeProvince = muaHang.TinhThanh;
                    donhang.District = muaHang.QuanHuyen;
                    donhang.Ward = muaHang.PhuongXa;

                    donhang.OrderDate = DateTime.Now;
                    donhang.TransactStatusId = 1;//Don hang moi
                    donhang.Deleted = false;
                    donhang.Paid = false;
                    donhang.Note = Utilities.StripHTML(model.Note);

                    var total = Convert.ToInt32(cart.Sum(x => x.TotalMoney));
                    if (discountedPrice.HasValue)
                    {
                        var discountPercentage = Convert.ToDouble(discountedPrice) / 100;
                        var totalDiscount = total * discountPercentage;
                        donhang.TotalMoney = (int?)(total - totalDiscount);
                    }
                    else
                     {
                        donhang.TotalMoney = total;
                    }


                    _context.Add(donhang);
                    _context.SaveChanges();

                    //tao danh sach don hang

                    foreach (var item in cart)
                    {
                        OrderDetail orderDetail = new OrderDetail();

                        orderDetail.OrderId = donhang.OrderId;
                        orderDetail.ProductId = item.product.ProductId;
                        orderDetail.Amount = item.amount;                      
                        orderDetail.TotalMoney = donhang.TotalMoney;
                        orderDetail.Price = item.product.Price;
                        orderDetail.CreateDate = DateTime.Now;
                        if (discountedPrice.HasValue)
                        {
                            orderDetail.Discount = discountedPrice;
                        }
                        _context.Add(orderDetail);
                    }
                    _context.SaveChanges();
                    //clear gio hang
                    HttpContext.Session.Remove("GioHang");
                    HttpContext.Session.Remove("discountedPrice");
                    //Xuat thong bao
                    _notyfService.Success("Đơn hàng đặt thành công");
                    //cap nhat thong tin khach hang
                    return RedirectToAction("Success");
                }
            }
            catch
            {
                ViewData["lsTinhThanh"] = new SelectList(_context.Provinces.OrderBy(x => x.Code).ToList(), "Code", "Name");
                ViewBag.GioHang = cart;
                return View(model);
            }

            ViewData["lsTinhThanh"] = new SelectList(_context.Provinces.OrderBy(x => x.Code).ToList(),"Code", "Name");
            ViewBag.GioHang = cart;
            return View(model);
        }




        [Route("dat-hang-thanh-cong.html", Name = "Success")]
        public IActionResult Success()
        {
            try
            {
                var taikhoanID = HttpContext.Session.GetString("CusId");
                if (string.IsNullOrEmpty(taikhoanID))
                {
                    return RedirectToAction("Login", "Accounts", new { returnUrl = "/dat-hang-thanh-cong.html" });
                }
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CusId == Convert.ToInt32(taikhoanID));
                var donhang = _context.Orders
                    .Where(x => x.CusId == Convert.ToInt32(taikhoanID))
                    .OrderByDescending(x => x.OrderDate)
                    .FirstOrDefault();
                MuaHangSuccessVM successVM = new MuaHangSuccessVM();
                successVM.FullName = khachhang.FullName;
                successVM.DonHangID = donhang.OrderId;
                successVM.Phone = khachhang.Phone;
                successVM.Address = khachhang.Address;
                successVM.PhuongXa = GetNameWard(khachhang.Ward);
                successVM.QuanHuyen = GetNameDistrict(khachhang.District);
                successVM.TinhThanh = GetNameProvice(khachhang.CodeProvince);
                return View(successVM);
            }
            catch
            {
                return View();
            }
        }
        public string GetNameWard(string idward)
        {
            try
            {
                var ward = _context.Wards.AsNoTracking().SingleOrDefault(x => x.Code == idward);
                if (ward != null)
                {
                    return ward.Name;
                }
            }
            catch
            {
                return string.Empty;
            }
            return string.Empty;
        }

        public string GetNameDistrict(string idistrict)
        {
            try
            {
                var district = _context.Districts.AsNoTracking().SingleOrDefault(x => x.Code == idistrict);
                if (district != null)
                {
                    return district.Name;
                }
            }
            catch
            {
                return string.Empty;
            }
            return string.Empty;
        }

        public string GetNameProvice(string idprovice)
        {
            try
            {
                var provice = _context.Provinces.AsNoTracking().SingleOrDefault(x => x.Code == idprovice);
                if (provice != null)
                {
                    return provice.Name;
                }
            }
            catch
            {
                return string.Empty;
            }
            return string.Empty;
        }
    }
}
