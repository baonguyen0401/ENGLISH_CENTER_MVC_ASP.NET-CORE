using ENGLISH_CENTER_MVC_ASP.NET_CORE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Controllers
{
    public class LoginController : Controller
    {
        private CheckLogin checklogin = new CheckLogin();
        // GET: LoginController
        public IActionResult Login()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult Login([Bind] NhanvienAccount nhanvienAccount)
        {
            int ketqua = checklogin.Login_Nhanvien_Check(nhanvienAccount);
            if(ketqua == 1)
            {
                TempData["msg"] = "Đăng Nhập Thành Công!!";
            }    
            else
            {
                TempData["msg"] = "Tài khoản hoặc mật khẩu không chính xác";
            }    
            return View();
        }
    }
}
