using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phoenix_Store.Application.Services.HomePages.AddHomePageImages;
using Phoenix_Store.Application.Services.HomePages.Commands.RemoveAddHomePageImages;
using Phoenix_Store.Application.Services.HomePages.Queries.GetHomePageImagesForAdmin;
using Phoenix_Store.Domain.Entities.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomePageImagesController : Controller
    {
        private readonly IAddHomePageImagesService _addHomePageImagesService;
        private readonly IGetHomePageImagesForAdmin _homePageImagesForAdmin;
        private readonly IRemoveHomePageImages _removeHomePageImages;
        public HomePageImagesController(IAddHomePageImagesService addHomePageImagesService
            , IGetHomePageImagesForAdmin homePageImagesForAdmin
            , IRemoveHomePageImages removeHomePageImages)
        {
            _addHomePageImagesService = addHomePageImagesService;
            _homePageImagesForAdmin = homePageImagesForAdmin;
            _removeHomePageImages = removeHomePageImages;
        }
        public IActionResult Index()
        {
            return View(_homePageImagesForAdmin.Execute().Data);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(IFormFile file, string Link, ImageLocation imageLocation)
        {
            _addHomePageImagesService.Execute(new RequestAddHomePageImages
            {
                Link = Link,
                File = file,
                ImageLocation = imageLocation
            });
            return View();
        }
        [HttpPost]
        public IActionResult Delete(long PageImageId)
        {
            return Json(_removeHomePageImages.Execute(PageImageId));
        }

    }
}
