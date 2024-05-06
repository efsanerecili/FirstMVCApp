using Microsoft.AspNetCore.Mvc;
using WebApplication3.Model;

namespace WebApplication3.Controllers
{
    public class DesignController : Controller
    {
        public IActionResult Index()
        {
            Furniture furniture1 = new Furniture()
            {
                Id = 1,
                Name = "Chair", 
                ImgURL = "img-3.png",
                Price = 1199.99
            };

            Furniture furniture2 = new Furniture()
            {
                Id = 2,
                Name = "Sofa",
                ImgURL = "img-4.png",
                Price = 1299.99
            };

            Furniture furniture3 = new Furniture()
            {
                Id = 3,
                Name = "Table",
                ImgURL = "img-5.png",
                Price = 1099.99
            };

            List<Furniture> furnitures = new List<Furniture>();

            furnitures.Add(furniture1);
            furnitures.Add(furniture2);
            furnitures.Add(furniture3);

            ViewBag.Furniture = furnitures;

            return View();
        }
    }
}
