using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BeginCollectionItemCoreDemo.ViewModels;

namespace BeginCollectionItemCoreDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Submit(OrderModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Message = "Invalid Input";
                return View("Index", model);
            }
            model.Message = "Submitted Successfully!";
            return View("Index", model);
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
