using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using KatShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;

namespace KatShop.Controllers
{
    [AllowAnonymous]
    public class SearchController : Controller
    {
        private readonly katshopContext _context;

        public SearchController(katshopContext context)
        {
            _context = context;
        }

        // GET: /<controller>/


        [HttpGet]
        public IActionResult FindProduct(string keyword)
        {
            // Thực hiện logic tìm kiếm sản phẩm dựa trên từ khóa (keyword)
            // Ví dụ: gọi đến service hoặc truy vấn cơ sở dữ liệu để lấy danh sách sản phẩm phù hợp với từ khóa
       

            if (!string.IsNullOrEmpty(keyword))
            {
               List<Product> products = new List<Product>();
                products = _context.Products.AsNoTracking()
                    .Where(x => x.ProductName.Contains(keyword) && x.Active == true)
                    .OrderByDescending(x => x.ProductName)
                    .ToList();

             ViewBag.keyword = keyword;
             
                return PartialView("ListProduct", products);
            }

            return PartialView("ListProduct", null);
        }



        // GET: /<controller>/
        //[HttpPost]
        //public IActionResult FindProduct(string keyword)
        //{
        //    List<Product> ls = new List<Product>();
        //    if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
        //    {
        //        return PartialView("ListProductsSearchPartial", null);
        //    }
        //    ls = _context.Products.AsNoTracking()
        //                          .Where(x => x.ProductName.Contains(keyword))
        //                          .OrderByDescending(x => x.ProductName)
        //                          .ToList();
        //    if (ls == null)
        //    {
        //        return PartialView("ListProductsSearchPartial", null);
        //    }
        //    else
        //    {
        //        return PartialView("ListProductsSearchPartial", ls);
        //    }
        //}

    }
}
