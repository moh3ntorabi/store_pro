using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Phoenix_Store.Application.Interfaces.FacadPatterns;
using Phoenix_Store.Application.Services.Products.Commands.Categories.EditCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoriesController : Controller
    {
        private readonly IProductFacad _productFacad;
        public CategoriesController(IProductFacad productFacad)
        {
            _productFacad = productFacad;
        }

        public IActionResult Index(long? parentId)
        {
            return View(_productFacad.GetCategoryService.Execute(parentId).Data);
        }
        [HttpGet]
        public IActionResult AddNewCategory(long? parentId, string parentName)
        {
            ViewBag.parentId = parentId;
            ViewBag.parentName = parentName;

            return View();
        }
        [HttpPost]
        public IActionResult Create(long? parentId, string Name)
        {
            var result = _productFacad.AddNewCategoryService.Execute(parentId, Name);
            return Json(result);
        }
        [HttpPost]
        public IActionResult Edit(long CategoryId, string Name)
        {
            return Json(_productFacad.EditCategoryService.Execute(new RequestEditCategoryDto{
                CategoryId = CategoryId,
                Name = Name
            }));
        }
        [HttpPost]
        public IActionResult Delete(long CategoryId)
        {
            return Json(_productFacad.DeleteCategoryService.Execute(CategoryId));
        }
    }
}

