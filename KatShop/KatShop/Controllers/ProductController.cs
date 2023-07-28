using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using KatShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;

namespace KatShop.Controllers
{
    [AllowAnonymous]
    public class ProductController : Controller
    {
        private readonly katshopContext _context;
        
        public ProductController(katshopContext context)
        {
            _context = context;
          
        }
        [Route("san-pham", Name = ("ShopProduct"))]

        public IActionResult Index(int? page, string sortBy)
        {
            try
            {
                var pageNumber = page == null || page <= 0 ? 1 : page.Value;
                var pageSize = 20;
                var lsProducts = _context.Products
                    .AsNoTracking()
                    .Where(x => x.Active == true);

                switch (sortBy)
                {
                    case "asc":
                        lsProducts = lsProducts.OrderBy(x => x.Price);
                        break;
                    case "desc":
                        lsProducts = lsProducts.OrderByDescending(x => x.Price);
                        break;
                    default:
                        lsProducts = lsProducts.OrderBy(x => x.DateCreated);
                        break;
                }

                var lsCat = _context.Categories.AsNoTracking().ToList();

                PagedList<Product> models = new PagedList<Product>(lsProducts, pageNumber, pageSize);

                ViewBag.Cat = lsCat;
                ViewBag.CurrentPage = pageNumber;

                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return PartialView("_ProductGrid", models);

                }

                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }




        [Route("danhmuc/{Alias}", Name = ("ListProduct"))]
        public IActionResult List(string Alias, int page = 1)
        {
            try
            {
                var pageSize = 10;
                var danhmuc = _context.Categories.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);

                var lsLists = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CatId == danhmuc.CatId)
                    .OrderByDescending(x => x.DateCreated);
                PagedList<Product> models = new PagedList<Product>(lsLists, page, pageSize);
                var lsCat = _context.Categories.AsNoTracking().ToList();

                ViewBag.Cat = lsCat;
                ViewBag.CurrentPage = page;
                ViewBag.CurrentCat = danhmuc;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }


        }

        [Route("/{Alias}-{id}.html", Name = ("ProductDetails"))]
        public async Task<IActionResult> DetailsAsync(int id)
        {        
            try
            {
           
                var reviews = _context.Reviews
                                 .Where(r => r.ProductId == id)
                                 .Take(3)
                                 .OrderByDescending(x => x.DateReview)
                                 .ToList();

                int totalReviews = _context.Reviews
                        .Where(r => r.ProductId == id)
                        .Count();
                ViewBag.TotalReviews = totalReviews;
                ViewBag.Reviews = reviews;
            }
            catch (Exception)
            {

                return RedirectToAction("Index", "Home");
            }
            try
            {
                var product = _context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductId == id);
                if (product == null)
                {
                    return RedirectToAction("Index");
                }
                var lsProduct = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CatId == product.CatId && x.ProductId != id && x.Active == true)
                    .Take(4)
                    .OrderByDescending(x => x.DateCreated)
                    .ToList();

              

                ViewBag.SanPham = lsProduct;
                return View(product);

              
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [HttpPost]
        public ActionResult AddReview(Review review)
        {
            try
            {
              //  var customer = _context.Customers.AsNoTracking().Where(c => c.CusId == review.)
                // Kiểm tra dữ liệu đánh giá hợp lệ
                if (ModelState.IsValid)
                {
                    // Lưu đánh giá vào cơ sở dữ liệu
                    using (var dbContext = new katshopContext())
                    {
                        review.DateReview = DateTime.Now;

                        dbContext.Reviews.Add(review);
                        dbContext.SaveChanges();
                    }

                    // Trả về kết quả thành công
                    return Json(new { success = true, message = "Đánh giá sản phẩm thành công!" });
                }
                else
                {
                    // Trả về kết quả lỗi nếu dữ liệu đánh giá không hợp lệ
                    return Json(new { success = false, message = "Dữ liệu đánh giá không hợp lệ!" });
                }
            }
            catch (Exception ex)
            {
                // Trả về kết quả lỗi nếu có lỗi xảy ra
                return Json(new { success = false, message = "Đã xảy ra lỗi khi đánh giá: " + ex.Message });
            }
        }
    }
}
