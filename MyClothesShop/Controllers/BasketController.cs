using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyClothesShop.Models;
using System.Data.Entity;

namespace MyClothesShop.Controllers
{
    public class BasketController : Controller
    {
        ProductDb _ProductDb = new ProductDb();

        // GET: Basket
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


        public ActionResult AddToBasket(int ProductID)
        {
            var product = _ProductDb.Products.Where(x => x.ProductID == ProductID).First();
            product.BasketID = 1;

            if (ModelState.IsValid)
            {
                _ProductDb.Entry(product).State = EntityState.Modified;
                _ProductDb.SaveChanges();
                return RedirectToAction("Index", "Basket");
            }
            return View();
        }


        public ActionResult RemoveFromBasket(int ProductID)
        {
            var product = _ProductDb.Products.Where(x => x.ProductID == ProductID).First();
            product.BasketID = 0;

            if (ModelState.IsValid)
            {
                _ProductDb.Entry(product).State = EntityState.Modified;
                _ProductDb.SaveChanges();
                return RedirectToAction("Index", "Basket");
            }
            return View();
        }
    }
}