using MyClothesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace MyClothesShop.Controllers
{
    public class WomensController : Controller
    {
        ProductDb _ProductDb = new ProductDb();

        // GET: Womens
        public ActionResult Index(int page = 1)
        {
            var model = _ProductDb.Products.Where(r => r.Section == (ProductSection)1)
                .OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }

        public ActionResult Shoes(int page = 1)
        {
            var model = _ProductDb.Products.Where(r => r.Section == (ProductSection)1).Where(
                r => r.Category == 0).OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }

        public ActionResult Trousers(int page = 1)
        {
            var model = _ProductDb.Products.Where(r => r.Section == (ProductSection)1).Where(
                r => r.Category == (ProductCategory)1).OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }

        public ActionResult Dresses(int page = 1)
        {
            var model = _ProductDb.Products.Where(r => r.Section == (ProductSection)1).Where(
                r => r.Category == (ProductCategory)4).OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }

        public ActionResult Tops(int page = 1)
        {
            var model = _ProductDb.Products.Where(r => r.Section == (ProductSection)1).Where(
                r => r.Category == (ProductCategory)6).OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }
    }
}