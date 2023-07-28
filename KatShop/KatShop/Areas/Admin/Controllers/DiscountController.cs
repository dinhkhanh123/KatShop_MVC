using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using KatShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using static System.Net.WebRequestMethods;

namespace KatShop.Areas.Admin.Controllers
{
    [Area("Admin")]
	public class DiscountController : Controller
	{
        private readonly katshopContext _context;
        public INotyfService _notyfService { get; }
        public DiscountController(katshopContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        public IActionResult Index()
		{
            var model = _context.Discounts.AsNoTracking().ToList();
            ViewBag.lsDiscount = model;
            return View();
        }


        // GET: Discount/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Discount/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CodeDiscount,PriceDiscount,DateCreate,ExpiryDate,Active")] Discount discount)
        {
            if (ModelState.IsValid)
            {
                discount.Ative = true;
                if (discount.CreateDate == null)
                {
                    discount.CreateDate = DateTime.Now;
                }
                _context.Add(discount);
                await _context.SaveChangesAsync();
                _notyfService.Success("Tạo mới thành công");
                
                return RedirectToAction(nameof(Index));
            }
            return View(discount);
        }

        [HttpPost]
        [Route("api/discount/updatestatus")]
        public IActionResult UpdateStatus(bool isChecked,int discountId)
        {
            // Lấy thông tin đối tượng Discount từ cơ sở dữ liệu dựa trên ID hoặc các thông tin khác
            var discount = _context.Discounts.FirstOrDefault(x => x.Id == discountId); // Thay thế bằng mã lấy thông tin Discount tương ứng

            if (discount != null)
            {
                // Cập nhật trạng thái của đối tượng Discount
                discount.Ative = isChecked;
                _context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                _notyfService.Success("Cập nhật trạng thái thành công");
                return RedirectToAction(nameof(Index));
            }
            else
            {               
                return RedirectToAction(nameof(Index)); // Trả về kết quả không tìm thấy đối tượng
            }
        }   

    }
}
