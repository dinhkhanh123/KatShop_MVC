using AspNetCoreHero.ToastNotification.Abstractions;
using KatShop.Helpper;
using KatShop.Models;
using KatShop.ModelViews;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using KatShop.Extension;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using AspNetCoreHero.ToastNotification.Notyf;
using System.Security.Policy;

namespace KatShop.Controllers
{
   // [Authorize]
    [AllowAnonymous]
    public class AccountsController : Controller
    {
        private readonly katshopContext _context;
        public INotyfService _notyfService { get; }
        public AccountsController(katshopContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidatePhone(string Phone)
        {
            try
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Phone.ToLower() == Phone.ToLower());
                if (khachhang != null)
                    return Json(data: "Số điện thoại : " + Phone + "đã được sử dụng");

                return Json(data: true);

            }
            catch
            {
                return Json(data: true);
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidateEmail(string Email)
        {
            try
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.ToLower() == Email.ToLower());
                if (khachhang != null)
                    return Json(data: "Email : " + Email + " đã được sử dụng");
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }
        }
        [Route("tai-khoan-cua-toi.html", Name = "Dashboard")]
        public IActionResult Dashboard(string retuntUrl)
        {
            var taikhoanID = HttpContext.Session.GetString("CusId");
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CusId == Convert.ToInt32(taikhoanID));

                if (khachhang != null)
                {
                    var lsDonHang = _context.Orders
                        .Include(x => x.TransactStatus)
                        .AsNoTracking()
                        .Where(x => x.CusId == khachhang.CusId)
                        .OrderByDescending(x => x.OrderDate)
                        .ToList();

                    ViewBag.DonHang = lsDonHang;
                    khachhang.Ward = GetNameWard(khachhang.Ward);
                    khachhang.District = GetNameDistrict(khachhang.District);
                    khachhang.CodeProvince = GetNameProvice(khachhang.CodeProvince);

                    return View(khachhang);


                }
               
                
            }
            return RedirectToAction("Login");
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





        [HttpGet]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public IActionResult DangkyTaiKhoan()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public async Task<IActionResult> DangkyTaiKhoan(RegisterViewModel taikhoan)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string salt = Utilities.GetRandomKey();
                    Customer khachhang = new Customer
                    {
                        FullName = taikhoan.FullName,
                        Phone = taikhoan.Phone.Trim().ToLower(),
                        Email = taikhoan.Email.Trim().ToLower(),
                        Password = (taikhoan.Password + salt.Trim()).ToMD5(),
                        Active = true,
                        Salt = salt,
                        CreateDate = DateTime.Now
                    };
                    try
                    {
                        _context.Add(khachhang);
                        await _context.SaveChangesAsync();
                        //Lưu Session MaKh
                        HttpContext.Session.SetString("CusId", khachhang.CusId.ToString());
                        var taikhoanID = HttpContext.Session.GetString("CusId");

                        //Identity
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name,khachhang.FullName),
                            new Claim("CusId", khachhang.CusId.ToString())
                        };
                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        _notyfService.Success("Đăng ký thành công");
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                    catch
                    {
                        return RedirectToAction("DangkyTaiKhoan", "Accounts");
                    }
                }
                else
                {
                    return View(taikhoan);
                }
            }
            catch
            {
                return View(taikhoan);
            }
        }
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public IActionResult Login(string returnUrl = null)
        {
            var taikhoanID = HttpContext.Session.GetString("CusId");
            if (taikhoanID != null)
            {
                return RedirectToAction("Dashboard", "Accounts");
            }
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public async Task<IActionResult> Login(LoginViewModel customer, string returnUrl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isEmail = Utilities.IsValidEmail(customer.UserName);
                    if (!isEmail) return View(customer);

                    var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.Trim() == customer.UserName);

                    if (khachhang == null) return RedirectToAction("DangkyTaiKhoan");
                    string pass = (customer.Password + khachhang.Salt.Trim()).ToMD5();
                    if (khachhang.Password != pass)
                    {
                        _notyfService.Warning("Thông tin đăng nhập chưa chính xác");
                        return View(customer);
                    }
                    //kiem tra xem account co bi disable hay khong

                    if (khachhang.Active == false)
                    {
                        return RedirectToAction("ThongBao", "Accounts");
                    }

                    //Luu Session MaKh
                    HttpContext.Session.SetString("CusId", khachhang.CusId.ToString());
                    var taikhoanID = HttpContext.Session.GetString("CusId");

                    //Identity
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, khachhang.FullName),
                        new Claim("CusId", khachhang.CusId.ToString())
                    };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    _notyfService.Success("Đăng nhập thành công");
                    if (string.IsNullOrEmpty(returnUrl))
                    {
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }
                }
            }
            catch
            {
                return RedirectToAction("DangkyTaiKhoan", "Accounts");
            }
            return View(customer);
        }


       
        [Route("chinh-sua-thong-tin.html", Name = "ChinhSuaThongTin")]
        public IActionResult EditInfo()
        {
            var taikhoanID = HttpContext.Session.GetString("CusId");
            EditInfoVM model = new EditInfoVM();
            if (taikhoanID != null)
            {
                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CusId == Convert.ToInt32(taikhoanID));

                if (khachhang != null)
                {
                    if(khachhang.Avatar != null)
                    {
                        model.Avatar = khachhang.Avatar;
                    }
                    else
                    {
                        model.Avatar = null;
                    }
                    
                    
                    model.CusId = khachhang.CusId;
                    model.FullName = khachhang.FullName;
                    model.Email = khachhang.Email;
                    model.Phone = khachhang.Phone;
                    model.Address = khachhang.Address;
                    model.BirthDay = khachhang.Birthday;

                  

                    ViewData["lsTinhThanh"] = new SelectList(_context.Provinces.OrderBy(x => x.Code).ToList(), "Code", "Name");
                    return View(model);
                }

            }
            return RedirectToAction("Login");
        }




        public async Task<IActionResult> EditAccount(EditInfoVM info, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {

            var taikhoanID = HttpContext.Session.GetString("CusId");

            EditInfoVM model = new EditInfoVM();

            if (taikhoanID != null)
            {


                var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CusId == Convert.ToInt32(taikhoanID));

                //Xu ly Thumb
                if (fThumb != null)
                {
                    string extension = Path.GetExtension(fThumb.FileName);
                    string imageName = Utilities.SEOUrl(khachhang.FullName) + extension;
                    khachhang.Avatar = await Utilities.UploadFile(fThumb, @"customer", imageName.ToLower());
                }
                if (string.IsNullOrEmpty(khachhang.Avatar)) khachhang.Avatar = "default.jpg";
                model.CusId = khachhang.CusId;
                //model.FullName = khachhang.FullName;
                //model.Email = khachhang.Email;
                //model.Phone = khachhang.Phone;
                //model.Address = khachhang.Address;

                khachhang.FullName = info.FullName;
                khachhang.Email = info.Email;
                khachhang.Phone = info.Phone;
                khachhang.Address = info.Address;

                khachhang.Birthday = info.BirthDay;
                khachhang.CodeProvince = info.TinhThanh;
                khachhang.District = info.QuanHuyen;
                khachhang.Ward = info.PhuongXa;



                _context.Update(khachhang);
                _context.SaveChanges();
            }
            try
            {
                if (ModelState.IsValid)
                {
                    _notyfService.Success("Đổi thông tin thành công");
                  
                    return RedirectToAction("Index", "Checkout");

                    //cap nhat thong tin khach hang

                }
            }
            catch
            {
                ViewData["lsTinhThanh"] = new SelectList(_context.Provinces.OrderBy(x => x.Code).ToList(), "Code", "Name");
                return View(model);
            }
            ViewData["lsTinhThanh"] = new SelectList(_context.Provinces.OrderBy(x => x.Code).ToList(), "Code", "Name");
            return RedirectToAction("Dashboard", "Accounts");
        }

        [HttpGet]
        [Route("dang-xuat.html", Name = "DangXuat")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Remove("CusId");
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel model)
        {
            try
            {
                var taikhoanID = HttpContext.Session.GetString("CusId");
                if (taikhoanID == null)
                {
                    return RedirectToAction("Login", "Accounts");
                }
                if (ModelState.IsValid)
                {
                    var taikhoan = _context.Customers.Find(Convert.ToInt32(taikhoanID));
                    if (taikhoan == null) return RedirectToAction("Login", "Accounts");
                    var pass = (model.PasswordNow.Trim() + taikhoan.Salt.Trim()).ToMD5();
                    {
                        string passnew = (model.Password.Trim() + taikhoan.Salt.Trim()).ToMD5();
                        taikhoan.Password = passnew;
                        _context.Update(taikhoan);
                        _context.SaveChanges();
                        _notyfService.Success("Đổi mật khẩu thành công");
                        return RedirectToAction("Dashboard", "Accounts");
                    }
                }
            }
            catch
            {
                _notyfService.Error("Thay đổi mật khẩu không thành công");
                return RedirectToAction("Dashboard", "Accounts");
            }
            _notyfService.Error("Thay đổi mật khẩu không thành công");
            return RedirectToAction("Dashboard", "Accounts");
        }
    }
}






//public async Task<IActionResult> EditAccount(EditInfoVM info, Microsoft.AspNetCore.Http.IFormFile fThumb, string returnUrl)
//{
//    var taikhoanID = HttpContext.Session.GetString("CusId");

//    EditInfoVM model = new EditInfoVM();

//    if (taikhoanID != null)
//    {


//        var khachhang = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CusId == Convert.ToInt32(taikhoanID));

//        //Xu ly Thumb
//        if (fThumb != null)
//        {
//            string extension = Path.GetExtension(fThumb.FileName);
//            string imageName = Utilities.SEOUrl(khachhang.FullName) + extension;
//            khachhang.Avatar = await Utilities.UploadFile(fThumb, @"customer", imageName.ToLower());
//        }
//        if (string.IsNullOrEmpty(khachhang.Avatar)) khachhang.Avatar = "default.jpg";
//        model.CusId = khachhang.CusId;
//        //model.FullName = khachhang.FullName;
//        //model.Email = khachhang.Email;
//        //model.Phone = khachhang.Phone;
//        //model.Address = khachhang.Address;

//        khachhang.FullName = info.FullName;
//        khachhang.Email = info.Email;
//        khachhang.Phone = info.Phone;
//        khachhang.Address = info.Address;

//        khachhang.Birthday = info.BirthDay;
//        khachhang.CodeProvince = info.TinhThanh;
//        khachhang.District = info.QuanHuyen;
//        khachhang.Ward = info.PhuongXa;



//        _context.Update(khachhang);
//        _context.SaveChanges();
//    }
//    try
//    {
//        if (ModelState.IsValid)
//        {
//            _notyfService.Success("Đổi thông tin thành công");
//            if (!string.IsNullOrEmpty(returnUrl))
//            {
//                string redirectUrl = Url.Content("~/" + returnUrl);
//                return Redirect(redirectUrl);
//            }
//        }
//    }
//    catch
//    {
//        ViewData["lsTinhThanh"] = new SelectList(_context.Provinces.OrderBy(x => x.Code).ToList(), "Code", "Name");
//        return View(model);
//    }

//    ViewData["lsTinhThanh"] = new SelectList(_context.Provinces.OrderBy(x => x.Code).ToList(), "Code", "Name");
//    if (!string.IsNullOrEmpty(returnUrl))
//    {
//        string redirectUrl = Url.Content("~/" + returnUrl);
//        return Redirect(redirectUrl);
//    }
//    else
//    {
//        // Trả về trang mặc định nếu không có returnUrl
//        return RedirectToAction("Index", "Home");
//    }
//}