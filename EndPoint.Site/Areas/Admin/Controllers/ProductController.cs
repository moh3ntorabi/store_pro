using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Phoenix_Store.Application.Interfaces.FacadPatterns;
using Phoenix_Store.Application.Services.Products.Commands.Products.AddNewProduct;
using Phoenix_Store.Application.Services.Products.Commands.Products.EditProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IProductFacad _productFacad;
        public ProductController(IProductFacad productFacad)
        {
            _productFacad = productFacad;
        }
        public IActionResult Index(int Page = 1, int PageSize = 20)
        {
            return View(_productFacad.GetProductForAdminService.Execute(Page, PageSize).Data);
        }
        public IActionResult Detail(long Id)
        {
            return View(_productFacad.GetProductDetailForAdminService.Execute(Id).Data);
        }

        [HttpGet]
        public IActionResult AddNewProduct()
        {
            ViewBag.Categories = new SelectList(_productFacad.GetAllCategoriesService.Execute().Data, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult AddNewProduct(RequestAddnewProductDto request, List<AddNewProduct_Feature> Features)
        {
            List<IFormFile> images = new List<IFormFile>();
            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                var file = Request.Form.Files[i];
                images.Add(file);
            }
            request.Images = images;
            request.Features = Features;
            return Json(_productFacad.AddNewProductService.Execute(request));
        }

        [HttpGet]
        public IActionResult EditProduct(long ProductId)
        {
            var ProductDetail = _productFacad.GetProductDetailForAdminService.Execute(ProductId).Data;
            ViewBag.Categories = new SelectList(_productFacad.GetAllCategoriesService.Execute().Data, "Id", "Name");
            return View(ProductDetail);
        }
        [HttpPost]
        public IActionResult EditProduct(RequestEditProductDto request, List<AddProduct_Feature> Features)
        {
            List<IFormFile> images = new List<IFormFile>();
            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                var file = Request.Form.Files[i];
                images.Add(file);
            }
            request.Images = images;
            request.Features = Features;
            return Json(_productFacad.EditProductService.Execute(request));
        }

        [HttpPost]
        public IActionResult DeleteProduct(long ProductId)
        {
            return Json(_productFacad.DeleteProductService.Execute(ProductId));
        }

        [HttpPost]
        public IActionResult DeleteFeature(long FeatureId)
        {
            return Json(_productFacad.DeleteProductFeatureService.Execute(FeatureId));
        }
        [HttpPost]
        public IActionResult DeleteImage(long ImageId)
        {
            return Json(_productFacad.DeleteProductImageService.Execute(ImageId));
        }
    }
}
