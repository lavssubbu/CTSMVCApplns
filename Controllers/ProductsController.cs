using CTSTempDataDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CTSTempDataDemo.Controllers
{
    public class ProductsController : Controller
    {
        IEnumerable<Product> lstprods = new List<Product>()
        {
            new Product(){Id=1,Name="Saree",Price=6000,Category="Electronics"},
             new Product(){Id=1,Name="Saree",Price=6000,Category="Electronics"}
        };
        public IActionResult Index()
        {
            TempData["Prods"] = JsonConvert.SerializeObject(lstprods);
          //  TempData.Keep();
            return View(lstprods);
        }

        public IActionResult TempdataMthd()
        {
            if (TempData["Prods"] != null)
            {
                var prodData = JsonConvert.DeserializeObject<List<Product>>(TempData["Prods"].ToString());
                TempData.Keep("Prods");
                return View(prodData);
            }
           
            return View(new List<Product>());
        }

        public IActionResult TempdataMthd2()
        {
            if (TempData["Prods"] != null)
            {
                var prodData = JsonConvert.DeserializeObject<List<Product>>(TempData["Prods"].ToString());
                return View(prodData);
            }

            return View(new List<Product>());
        }
    }
}
