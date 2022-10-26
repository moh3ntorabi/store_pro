using Microsoft.AspNetCore.Mvc;
using Phoenix_Store.Application.Interfaces.FacadPatterns;
using Phoenix_Store.Application.Services.Products.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductFacad _productFacad;
        public ProductController(IProductFacad productFacad)
        {
            _productFacad = productFacad;
        }
        public IActionResult Index(Ordering ordering, string SearhKey,long? CatId=null,int page=1, int pageSize = 10)
        {
            return View(_productFacad.GetProductForSiteService.Execute(ordering, SearhKey, CatId, page, pageSize).Data);
        }
        public IActionResult Detail(long Id)
        {
            return View(_productFacad.GetProductDetailForSiteService.Execute(Id).Data);
        }
    }
}
