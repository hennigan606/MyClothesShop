using MyClothesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace MyClothesShop.Controllers
{
    public class MensController : Controller
    {
        ProductDb _ProductDb = new ProductDb();

        // GET: Mens
        public ActionResult Index(int page = 1)
        {
            var model = _ProductDb.Products.Where(r => r.Section == 0).OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }

        public ActionResult Shoes(int page = 1)
        {
            var model = _ProductDb.Products.Where(r => r.Section == 0).Where(
                r => r.Category == 0).OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }

        public ActionResult Trousers(int page = 1)
        {
            var model = _ProductDb.Products.Where(r => r.Section == 0).Where(
                r => r.Category == (ProductCategory)1).OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }

        public ActionResult Jumpers(int page = 1)
        {
            var model = _ProductDb.Products.Where(r => r.Section == 0).Where(
                r => r.Category == (ProductCategory)2).OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }

        public ActionResult Jackets(int page = 1)
        {
            var model = _ProductDb.Products.Where(r => r.Section == 0).Where(
                r => r.Category == (ProductCategory)3).OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }

        public ActionResult Shirts(int page = 1)
        {
            var model = _ProductDb.Products.Where(r => r.Section == 0).Where(
                r => r.Category == (ProductCategory)5).OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }
    }
}