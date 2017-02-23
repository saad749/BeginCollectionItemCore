using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeginCollectionItemCoreDemo.ViewModels;

namespace BeginCollectionItemCoreDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(OrderModel model)
        {
            if (!ModelState.IsValid) return BadRequest();



            return View("Index");
        }

        [AjaxOnly]
        [ResponseCache(NoStore = true, Duration = 0)]
        public IActionResult NewItem()
        {
            return PartialView("_CollectionPartial", new OrderItemModel());
        }

        [AjaxOnly]
        [ResponseCache(NoStore = true, Duration = 0)] // Fixes IE response caching behaviour that causes incorrect GUID propagation
        public IActionResult NewDiscount(string containerPrefix)
        {
            ViewData["ContainerPrefix"] = containerPrefix;
            return PartialView("_NestedCollectionPartial", new DiscountModel());
        }
    }
}
