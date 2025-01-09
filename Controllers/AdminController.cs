using Folio.ModelsModels;
using Microsoft.AspNetCore.Mvc;

namespace Folio.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(AdminModel model){
            string kullaniciAdi = model.Kadi;
            string sifre = model.Sifre;
            if(!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre)){
                if(sifre.Length < 8){
                    ModelState.AddModelError("Sifre","Şifre 8 karakterden az olamaz");
                }
                else{
                    //Database den kontrol sağlanacak alan
                }
            }

            return View(model);
        }
    }
}
