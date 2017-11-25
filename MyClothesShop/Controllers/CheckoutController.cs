using MyClothesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyClothesShop.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        ProductDb _ProductDb = new ProductDb();

        // GET: Checkout
        public ActionResult Index()
        {
            var query = _ProductDb.Products.Where(x => x.BasketID == 1);

            var model = new List<Product>();
            foreach (var product in query)
            {
                model.Add(product);
            }

            return View(model);
        }

        public ActionResult PayNow()
        {
            return View();
        }
    }
}