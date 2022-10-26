using EndPoint.Site.Utilities;
using Microsoft.AspNetCore.Mvc;
using Phoenix_Store.Application.Services.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.ViewComponents
{
    public class Basket:ViewComponent
    {
        private readonly ICartService _cartService;
        private readonly CookiesManager _cookiesManager;
        public Basket(ICartService cartService)
        {
            _cartService = cartService;
            _cookiesManager = new CookiesManager();
        }
        public IViewComponentResult Invoke()
        {
            var userId = ClaimUtility.GetUserId(HttpContext.User);
            return View(viewName: "Basket", _cartService.GetMyCart(_cookiesManager.GetBrowserId(HttpContext),userId).Data);
        }
    }
}
