using EndPoint.Site.Models;
using EndPoint.Site.Models.ViewModels.HomePages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phoenix_Store.Application.Interfaces.FacadPatterns;
using Phoenix_Store.Application.Services.Common.Queries.GetHomePageImages;
using Phoenix_Store.Application.Services.Common.Queries.GetSlider;
using Phoenix_Store.Application.Services.Products.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetSliderService _getSliderService;
        private readonly IGetHomePageImagesService _getHomePageImage;
        private readonly IProductFacad _productFacad;


        public HomeController(IGetSliderService getSliderService,
            IGetHomePageImagesService getHomePageImage,
            IProductFacad productFacad)
        {
            _getSliderService = getSliderService;
            _getHomePageImage = getHomePageImage;
            _productFacad = productFacad;
        }

        public IActionResult Index()
        {
            HomePagesViewModel homePages = new()
            {
                Sliders = _getSliderService.Execute().Data,
                PageImages = _getHomePageImage.Execute().Data,
                Mobile = _productFacad.GetProductForSiteService.Execute(Ordering.TheNewest,null,1,1,4).Data.Products,
                Camera=_productFacad.GetProductForSiteService.Execute(Ordering.TheNewest,null,3,1,5).Data.Products,
            };
            return View(homePages);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
