using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KatShop.Models;
using KatShop.ModelViews;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace KatShop.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly katshopContext _context;

        public HomeController(ILogger<HomeController> logger, katshopContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewVM model = new HomeViewVM();

            var lsProducts = _context.Products.AsNoTracking()
               .Where(x => x.Active == true && x.BestSaller == true)
               .OrderByDescending(x => x.DateCreated)
               .ToList();

            var lsAllProducts = _context.Products.AsNoTracking()
               .Where(x => x.Active == true && x.HomeFlag == true)
               .OrderByDescending(x => x.DateCreated)
               .ToList();

            List<ProductHomeVM> lsProductViews = new List<ProductHomeVM>();
            var lsCats = _context.Categories
                .AsNoTracking()
                .Where(x => x.Published == true)
                .OrderByDescending(x => x.Ordering)
                .ToList();

            var lsHomeCats = _context.Categories
                .AsNoTracking()
                .Where(x => x.Published == true)
                .OrderByDescending(x => x.Ordering)
                .Take(4)
                .ToList();

            foreach (var item in lsCats)
            {
                ProductHomeVM productHome = new ProductHomeVM();
                productHome.category = item;
                productHome.lsProducts = lsProducts.Where(x => x.CatId == item.CatId).ToList();
                lsProductViews.Add(productHome);

             
                model.Products = lsProductViews;       
            }

            var Post = _context.Posts
                  .AsNoTracking()
                  .Where(x => x.Published == true && x.IsNewfeed == true)
                  .OrderByDescending(x => x.CreateDate)
                  .Take(3)
                  .ToList();

            ViewBag.AllProduct = lsAllProducts;
            ViewBag.NewProduct = lsProducts;
            model.Categories = lsHomeCats;
            model.Posts = Post;
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
