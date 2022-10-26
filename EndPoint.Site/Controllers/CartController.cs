using EndPoint.Site.Utilities;
using Microsoft.AspNetCore.Mvc;
using Phoenix_Store.Application.Services.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Controllers
{

    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly CookiesManager cookiesManager;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
            cookiesManager = new CookiesManager();
        }
        public IActionResult Index()
        {
            var userId = ClaimUtility.GetUserId(User);
            var resultGetList = _cartService.GetMyCart(cookiesManager.GetBrowserId(HttpContext), userId);
            return View(resultGetList.Data);
        }
        public IActionResult AddToCart(long ProductId)
        {

            _cartService.AddToCart(ProductId, cookiesManager.GetBrowserId(HttpContext));
            return RedirectToAction("Index");
        }
        public IActionResult Add(long cartItemId)
        {
            _cartService.Add(cartItemId);
            return RedirectToAction("Index");
        }
        public IActionResult LowOff(long cartItemId)
        {
            _cartService.LowOff(cartItemId);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Remove(long ProductId)
        {
            return Json(_cartService.RemoveFromCart(ProductId, cookiesManager.GetBrowserId(HttpContext)));

        }
    }
}
