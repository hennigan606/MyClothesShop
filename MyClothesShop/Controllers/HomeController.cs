using MyClothesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace MyClothesShop.Controllers
{
    public class HomeController : Controller
    {
        ProductDb _ProductDb = new ProductDb();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string searchTerm = null, int page = 1)
        {
            searchTerm = HttpUtility.HtmlEncode(searchTerm);

            ViewBag.searchTerm = searchTerm;

            var model = _ProductDb.Products.Where(r => searchTerm == null || r.Name.Contains(searchTerm))
                .OrderBy(r => r.ProductID).ToPagedList(page, 3);

            return View(model);
        }
    }
}