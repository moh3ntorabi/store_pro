using Phoenix_Store.Application.Services.Products.Commands.Categories.AddNewCategory;
using Phoenix_Store.Application.Services.Products.Commands.Categories.EditCategory;
using Phoenix_Store.Application.Services.Products.Commands.Categories.RemoveCategory;
using Phoenix_Store.Application.Services.Products.Commands.Products.AddNewProduct;
using Phoenix_Store.Application.Services.Products.Commands.Products.EditProduct;
using Phoenix_Store.Application.Services.Products.Commands.Products.RemoveProduct;
using Phoenix_Store.Application.Services.Products.Commands.Products.RemoveProductFeature;
using Phoenix_Store.Application.Services.Products.Commands.Products.RemoveProductImage;
using Phoenix_Store.Application.Services.Products.Queries.GetAllCategories;
using Phoenix_Store.Application.Services.Products.Queries.GetCategory;
using Phoenix_Store.Application.Services.Products.Queries.GetProductDetailForAdmin;
using Phoenix_Store.Application.Services.Products.Queries.GetProductDetailForSite;
using Phoenix_Store.Application.Services.Products.Queries.GetProductForAdmin;
using Phoenix_Store.Application.Services.Products.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Interfaces.FacadPatterns
{
    public interface IProductFacad
    {
        /// <summary>
        /// Category
        /// </summary>
        AddNewCategoryService AddNewCategoryService { get; }
        DeleteCategoryService DeleteCategoryService { get; }
        EditCategoryService EditCategoryService { get; }
        IGetCategoryService GetCategoryService { get; }
        IGetAllCategoriesService GetAllCategoriesService { get; }
        /// <summary>
        /// Product 
        /// </summary>
        AddNewProductService AddNewProductService { get; }
        EditProductService EditProductService { get; }
        DeleteProductService DeleteProductService { get; }
        DeleteProductFeatureService DeleteProductFeatureService { get; }
        DeleteProductImageService DeleteProductImageService { get; }

        //EditProductService EditProductService { get; }
        IGetProductForAdminService GetProductForAdminService { get; }
        IGetProductDetailForAdminService GetProductDetailForAdminService { get; }
        IGetProductForSiteService GetProductForSiteService { get; }
        IGetProductDetailForSiteService GetProductDetailForSiteService { get; }
    }
}
