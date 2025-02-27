using Hafta3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hafta3.Controllers
{
    public class YazarlarController : Controller
    {
        public IActionResult Index()
        {
            var YazarListesi = new List<Yazarlar>
            {

                new Yazarlar{No=1,Ad="MEHMET AKİF",Soyad="ERSOY",Adres="KONYA"},
                new Yazarlar{No=2,Ad="SAİT FAİK",Soyad = "ABASIYANIK", Adres = "İSTANBUL"},
                new Yazarlar{No=2,Ad="NAZIM",Soyad = "HİKMET", Adres = "ANKARA"}
            };


            return View(YazarListesi);
        }
    }
}
