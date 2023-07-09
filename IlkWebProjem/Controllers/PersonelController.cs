using IlkWebProjem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IlkWebProjem.Controllers
{
    public class PersonelController : Controller // : gives inheritence to personelcontroller
    {
        public IActionResult Index()
        {
            Personel p1 = new Personel() { Ad = "Selami", Soyad = "Sahin", Departman = "Muzik", Aktif = true };
            return View(p1);
        }
    }
}
