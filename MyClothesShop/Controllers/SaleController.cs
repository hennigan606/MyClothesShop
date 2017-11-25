using MyClothesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace MyClothesShop.Controllers
{
    public class SaleController : Controller
    {
        ProductDb _ProductDb = new ProductDb();

        // GET: Sale
        public ActionResult Index(int page = 1)
        {
            var model = _ProductDb.Products.Where(r => r.Section == (ProductSection)2)
                .OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }

        public ActionResult Mens(int page = 1)
        {
            var model = _ProductDb.Products.Where(r => r.Section == (ProductSection)2).Where(
                r => r.Gender == 0).OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }

        public ActionResult Womens(int page = 1)
        {
            var model = _ProductDb.Products.Where(r => r.Section == (ProductSection)2).Where(
                r => r.Gender == (Gender)1).OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }
    }
}