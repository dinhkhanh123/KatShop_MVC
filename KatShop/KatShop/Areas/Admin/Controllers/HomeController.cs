using System.Linq;
using System;
using AspNetCoreHero.ToastNotification.Abstractions;
using KatShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KatShop.Areas.Admin.Controllers
{
    [Area("Admin")]  
  
    [Route("admin.html", Order = 1, Name = "AdminIndex")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly katshopContext _context;

        public HomeController(katshopContext context)
        {
            _context = context;
           
        }

        public IActionResult Index()
        {

            try
            {
                int totalCustomers = _context.Customers.Count();
                ViewBag.TotalCustomers = totalCustomers;
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Đã xảy ra lỗi: " + ex.Message;
            }



            try
            {
                DateTime startDate = DateTime.Now.AddMonths(-1); // Lấy ngày tháng trước đó một tháng
                DateTime endDate = DateTime.Now; // Ngày hiện tại

                var totalOrder = _context.Orders.Count();

                var totalRevenue = _context.Orders
                    .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                    .Sum(o => o.TotalMoney);

                ViewBag.TotalRevenue = totalRevenue;
                ViewBag.TotalOrder = totalOrder;
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Đã xảy ra lỗi: " + ex.Message;
            }



            try
            {
                int totalPost = _context.Posts.Count();
                ViewBag.TotalPost = totalPost;
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Đã xảy ra lỗi: " + ex.Message;
            }



            return View();
        }

    }
}
