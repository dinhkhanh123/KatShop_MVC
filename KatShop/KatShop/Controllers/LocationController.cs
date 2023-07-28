using System.Linq;
using KatShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace KatShop.Controllers
{
	public class LocationController : Controller
	{
        private readonly katshopContext _context;
        public LocationController(katshopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
		{
			return View();
		}

        public IActionResult QuanHuyenList(string CodeProvice)
        {
            var QuanHuyens = _context.Districts
                             .Where(x => x.ProvinceCode == CodeProvice)
                             .OrderBy(x => x.Name)
                             .ToList();
            return Json(QuanHuyens);
        }

        public IActionResult PhuongXaList(string CodeDistrict)
        {
            var PhuongXas = _context.Wards
                             .Where(x => x.DistrictCode == CodeDistrict)
                             .OrderBy(x => x.Name)
                             .ToList();
            return Json(PhuongXas);
        }
    }
}
