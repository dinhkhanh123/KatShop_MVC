using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KatShop.Models;
using PagedList.Core;
using KatShop.Helpper;
using System.IO;
using AspNetCoreHero.ToastNotification.Abstractions;
using AspNetCoreHero.ToastNotification.Notyf;

namespace KatShop.Areas_Admin_Controllers_
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly katshopContext _context;
        public INotyfService _notifyService { get; }

        public ProductController(katshopContext context, INotyfService notyfService)
        {
            _context = context;
            _notifyService = notyfService;
        }

        // GET: Product
        public IActionResult Index(int? page, int CatId = 0)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;

            List<Product> lsProducts = new List<Product>();

            if (CatId != 0)
            {
                lsProducts = _context.Products.AsNoTracking()
                                            .Where(p => p.CatId == CatId)
                                            .Include(x => x.Cat)
                                            .OrderByDescending(x => x.ProductId)
                                            .ToList();
            }
            else
            {
                lsProducts = _context.Products.AsNoTracking()
                               .Include(x => x.Cat)
                               .OrderByDescending(x => x.ProductId).ToList();


            }
           

            PagedList<Product> models = new PagedList<Product>(lsProducts.AsQueryable(), pageNumber, pageSize);

            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName");

            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }

        public IActionResult Filtter(int CatId = 0)
        {
            var url = $"/Admin/Product?CatId={CatId}";
            if (CatId == 0)
            {
                url = $"/Admin/Product";
            }
            return Json(new { status = "success", redirectUrl = url });
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Cat)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,ShortDesc,Description,CatId,Price,Discount,Thumb,Thumb1,Thumb2,Thumb3,Video,DateCreated,DateModified,BestSaller,HomeFlag,Active,Tags,Title,Alias,MetaDesc,MetaKey,UnitslnStock")] Product product, Microsoft.AspNetCore.Http.IFormFile fThumb, Microsoft.AspNetCore.Http.IFormFile fThumb1, Microsoft.AspNetCore.Http.IFormFile fThumb2, Microsoft.AspNetCore.Http.IFormFile fThumb3)
        {
            if (ModelState.IsValid)
            {
                product.ProductName = Utilities.ToTitleCase(product.ProductName);
                if (fThumb != null)
                {
                    string extension = Path.GetExtension(fThumb.FileName);
                    string image = Utilities.SEOUrl(product.ProductName) + extension;
                    product.Thumb = await Utilities.UploadFile(fThumb, @"products", image.ToLower());
                }
                if (fThumb1 != null)
                {
                    string extension = Path.GetExtension(fThumb1.FileName);
                    string image = Utilities.SEOUrl(product.ProductName) + "1" + extension;
                    product.Thumb1 = await Utilities.UploadFile(fThumb1, @"products", image.ToLower());
                }
                if (fThumb2 != null)
                {
                    string extension = Path.GetExtension(fThumb2.FileName);
                    string image = Utilities.SEOUrl(product.ProductName) + "2" + extension;
                    product.Thumb2 = await Utilities.UploadFile(fThumb2, @"products", image.ToLower());
                }
                if (fThumb3 != null)
                {
                    string extension = Path.GetExtension(fThumb3.FileName);
                    string image = Utilities.SEOUrl(product.ProductName) + "3" + extension;
                    product.Thumb3 = await Utilities.UploadFile(fThumb3, @"products", image.ToLower());
                }
                if (string.IsNullOrEmpty(product.Thumb)) product.Thumb = "default.jpg";
                if (string.IsNullOrEmpty(product.Thumb1)) product.Thumb1 = "default.jpg";
                if (string.IsNullOrEmpty(product.Thumb2)) product.Thumb2 = "default.jpg";
                if (string.IsNullOrEmpty(product.Thumb3)) product.Thumb3 = "default.jpg";
                product.Alias = Utilities.SEOUrl(product.ProductName);
                product.DateModified = DateTime.Now;
                product.DateCreated = DateTime.Now;

                _context.Add(product);
                await _context.SaveChangesAsync();
                _notifyService.Success("Thêm mới thành công");
                return RedirectToAction(nameof(Index), "Product", new { area = "Admin" });
            }
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
            return View(product);
        }
        //public async Task<IActionResult> Create([Bind("ProductId,ProductName,ShortDesc,Description,CatId,Price,Discount,Thumb,Video,DateCreated,DateModified,BestSaller,HomeFlag,Active,Tags,Title,Alias,MetaDesc,MetaKey,UnitslnStock")] Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(product);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
        //    return View(product);
        //}

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,ShortDesc,Description,CatId,Price,Discount,Thumb,Video,DateCreated,DateModified,BestSaller,HomeFlag,Active,Tags,Title,Alias,MetaDesc,MetaKey,UnitslnStock,Thumb1,Thumb2,Thumb3")] Product product, Microsoft.AspNetCore.Http.IFormFile fThumb, Microsoft.AspNetCore.Http.IFormFile fThumb1, Microsoft.AspNetCore.Http.IFormFile fThumb2, Microsoft.AspNetCore.Http.IFormFile fThumb3)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    product.ProductName = Utilities.ToTitleCase(product.ProductName);
                    if (fThumb != null)
                    {
                        string extension = Path.GetExtension(fThumb.FileName);
                        string image = Utilities.SEOUrl(product.ProductName) + extension;
                        product.Thumb = await Utilities.UploadFile(fThumb, @"products", image.ToLower());
                    }
                    if (fThumb1 != null)
                    {
                        string extension = Path.GetExtension(fThumb1.FileName);
                        string image = Utilities.SEOUrl(product.ProductName) + "1" + extension;
                        product.Thumb1 = await Utilities.UploadFile(fThumb1, @"products", image.ToLower());
                    }
                    if (fThumb2 != null)
                    {
                        string extension = Path.GetExtension(fThumb2.FileName);
                        string image = Utilities.SEOUrl(product.ProductName) + "2" + extension;
                        product.Thumb2 = await Utilities.UploadFile(fThumb2, @"products", image.ToLower());
                    }
                    if (fThumb3 != null)
                    {
                        string extension = Path.GetExtension(fThumb3.FileName);
                        string image = Utilities.SEOUrl(product.ProductName) + "3" + extension;
                        product.Thumb3 = await Utilities.UploadFile(fThumb3, @"products", image.ToLower());
                    }
                    if (string.IsNullOrEmpty(product.Thumb)) product.Thumb = "default.jpg";
                    if (string.IsNullOrEmpty(product.Thumb1)) product.Thumb1 = "default.jpg";
                    if (string.IsNullOrEmpty(product.Thumb2)) product.Thumb2 = "default.jpg";
                    if (string.IsNullOrEmpty(product.Thumb3)) product.Thumb3 = "default.jpg";
                    product.Alias = Utilities.SEOUrl(product.ProductName);
                    product.DateModified = DateTime.Now;

                    _context.Update(product);
                    _notifyService.Success("Cập nhật thành công");
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), "Product", new { area = "Admin" });
            }
            ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
            return View(product);
        }
        //public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,ShortDesc,Description,CatId,Price,Discount,Thumb,Video,DateCreated,DateModified,BestSaller,HomeFlag,Active,Tags,Title,Alias,MetaDesc,MetaKey,UnitslnStock")] Product product)
        //{
        //    if (id != product.ProductId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(product);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ProductExists(product.ProductId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["DanhMuc"] = new SelectList(_context.Categories, "CatId", "CatName", product.CatId);
        //    return View(product);
        //}

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //Product product = _context.Products.Where(p => p.ProductId == id).FirstOrDefault();
            //return PartialView("_DeleteProductPartialView", product);


            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Cat)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            _notifyService.Success("Xóa thành công");
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
