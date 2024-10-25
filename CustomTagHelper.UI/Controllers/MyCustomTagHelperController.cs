using Microsoft.AspNetCore.Mvc;

namespace CustomTagHelper.UI.Controllers
{
    public class MyCustomTagHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Giris(string kullaniciAdi)
        {
            if(kullaniciAdi == "admin")
            {
                ViewBag.Message = "Hoşgeldiniz";
                return View("Giris");
            }
            ViewBag.Message = "Kullanıcı adı hatalı";
            return View("GirisYap");
        }

    }
}
