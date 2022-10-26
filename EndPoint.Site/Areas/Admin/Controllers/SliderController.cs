using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phoenix_Store.Application.Services.HomePages.AddNewSlider;
using Phoenix_Store.Application.Services.HomePages.Commands.RemoveSlider;
using Phoenix_Store.Application.Services.HomePages.Queries.GetSlidersForAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly IAddNewSliderService _addNewSliderService;
        private readonly IGetSlidersForAdminService _getSlidersForAdmin;
        private readonly IRemoveSliderService _removeSlider;
        public SliderController(IAddNewSliderService addNewSliderService,
            IGetSlidersForAdminService getSlidersForAdmin,
            IRemoveSliderService removeSlider)
        {
            _addNewSliderService = addNewSliderService;
            _getSlidersForAdmin = getSlidersForAdmin;
            _removeSlider = removeSlider;
        }
        public IActionResult Index()
        {
            return View(_getSlidersForAdmin.Execute().Data);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(IFormFile file,string link)
        {
            _addNewSliderService.Execute(file, link);
            return View();
        }
        
        [HttpPost]
        public IActionResult Delete(long SliderId)
        {
            return Json(_removeSlider.Execute(SliderId));
        }
    }
}
