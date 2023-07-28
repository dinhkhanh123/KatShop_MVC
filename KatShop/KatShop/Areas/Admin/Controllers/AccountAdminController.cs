using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System;
using AspNetCoreHero.ToastNotification.Abstractions;
using KatShop.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using KatShop.Areas.Admin.Models;
using System.Security.Cryptography;
using System.Text;
using KatShop.Extension;

namespace KatShop.Areas_Admin_Controllers_
{
    [Area("Admin")]
    [Authorize]
    public class AccountAdminController : Controller
    {
        private readonly katshopContext _context;
        public INotyfService _notyfService { get; }
        public AccountAdminController(katshopContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("login.html",Order = 1, Name = "Login")]
        [Route("admin", Order = 2)]
        public IActionResult AdminLogin(string returnUrl = null)
        {
            var taikhoanID = HttpContext.Session.GetString("AccountId");
            if (taikhoanID != null) return RedirectToAction("Index", "Home", new { Area = "Admin" });
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("login.html", Name = "Login")]
        public async Task<IActionResult> AdminLogin(LoginViewModel model, string returnUrl = null)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Account kh = _context.Accounts
                    .Include(p => p.Role)
                    .SingleOrDefault(p => p.Email.ToLower() == model.UserName.ToLower().Trim());

                    if (kh == null)
                    {
                        _notyfService.Error("Thông tin đăng nhập chưa chính xác");
                    }
                    string salt = kh.Salt; // Lấy giá trị salt từ cơ sở dữ liệu

                    string hashedPassword = (model.Password.Trim() + salt.Trim()).ToMD5(); // Mã hóa mật khẩu nhập vào bằng MD5
                    //string pass = (model.Password.Trim());
                    //// + kh.Salt.Trim()
                    if (kh.Password.Trim() != hashedPassword)
                    {
                        _notyfService.Error("Thông tin đăng nhập chưa chính xác");
                        return View(model);
                    }
                    //đăng nhập thành công

                    //ghi nhận thời gian đăng nhập
                    kh.LastLogin = DateTime.Now;
                    _context.Update(kh);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Đăng nhập thành công");


                    var taikhoanID = HttpContext.Session.GetString("AccountId");
                    //identity
                    //luuw seccion Makh
                    HttpContext.Session.SetString("AccountId", kh.AccountId.ToString());

                    //identity
                    var userClaims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, kh.FullName),
                        new Claim(ClaimTypes.Email, kh.Email),
                        new Claim("AccountId", kh.AccountId.ToString()),
                        new Claim("RoleId", kh.RoleId.ToString()),
                        new Claim(ClaimTypes.Role, kh.Role.RoleName)
                    };
                    var grandmaIdentity = new ClaimsIdentity(userClaims, "User Identity");
                    var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
                    await HttpContext.SignInAsync(userPrincipal);



                    return RedirectToAction("Index", "Home", new { Area = "Admin" });
                }
            }
            catch
            {
                return RedirectToAction("AdminLogin", "AccountAdmin", new { Area = "Admin" });
            }
            return RedirectToAction("AdminLogin", "AccountAdmin", new { Area = "Admin" });
        }
        [Route("logout.html", Name = "Logout")]
        public IActionResult AdminLogout()
        {
            try
            {
                HttpContext.SignOutAsync();
                HttpContext.Session.Remove("AccountId");
                return RedirectToAction("AdminLogin", "AccountAdmin", new { Area = "Admin" });
            }
            catch
            {
                return RedirectToAction("AdminLogin", "AccountAdmin", new { Area = "Admin" });
            }
        }
        [Route("not-found.html", Name = "AccessDenied")]
        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}
