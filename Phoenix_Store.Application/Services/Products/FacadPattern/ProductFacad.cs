using Microsoft.AspNetCore.Hosting;
using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Application.Interfaces.FacadPatterns;
using Phoenix_Store.Application.Services.Products.Commands.Products.AddNewProduct;
using Phoenix_Store.Application.Services.Products.Commands.Categories.AddNewCategory;
using Phoenix_Store.Application.Services.Products.Commands.Categories.RemoveCategory;
using Phoenix_Store.Application.Services.Products.Commands.Products.RemoveProduct;
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
using Phoenix_Store.Application.Services.Products.Commands.Categories.EditCategory;
using Phoenix_Store.Application.Services.Products.Commands.Products.RemoveProductFeature;
using Phoenix_Store.Application.Services.Products.Commands.Products.EditProduct;
using Phoenix_Store.Application.Services.Products.Commands.Products.RemoveProductImage;

namespace Phoenix_Store.Application.Services.Products.FacadPattern
{
    public class ProductFacad : IProductFacad

    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        public ProductFacad(IDataBaseContext context,IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        //////////CategoryService//////////
        
        private AddNewCategoryService _addNewCategory;
        public AddNewCategoryService AddNewCategoryService
        {
            get
            {
                return _addNewCategory = _addNewCategory ?? new AddNewCategoryService(_context);
            }
        }
        
        private DeleteCategoryService _deleteCategory;
        public DeleteCategoryService DeleteCategoryService
        {
            get
            {
                return _deleteCategory = _deleteCategory ?? new DeleteCategoryService(_context);
            }
        }
        private EditCategoryService _editCategory;
        public EditCategoryService EditCategoryService
        {
            get
            {
                return _editCategory = _editCategory ?? new EditCategoryService(_context);
            }
        }
        private IGetCategoryService _getCategoryService;
        public IGetCategoryService GetCategoryService
        {
            get
            {
                return _getCategoryService = _getCategoryService ?? new GetCategoryService(_context);
            }
        }
        private IGetAllCategoriesService _getAllCategories;
        public IGetAllCategoriesService GetAllCategoriesService
        {
            get
            {
                return _getAllCategories = _getAllCategories ?? new GetAllCategoriesService(_context);
            }
        }


        //////////ProductService//////////
        
        private AddNewProductService _addNewProduct;
        public AddNewProductService AddNewProductService
        {
            get
            {
                return _addNewProduct =_addNewProduct ?? new AddNewProductService(_context,_environment);
            }
        }
        private EditProductService _editProduct;
        public EditProductService EditProductService
        {
            get
            {
                return _editProduct = _editProduct ?? new EditProductService(_context,_environment);
            }
        }
        private DeleteProductService _deleteProduct;
        public DeleteProductService DeleteProductService
        {
            get
            {
                return _deleteProduct = _deleteProduct ?? new DeleteProductService(_context);
            }
        }
        private DeleteProductFeatureService _deleteProductFeature;
        public DeleteProductFeatureService DeleteProductFeatureService
        {
            get
            {
                return _deleteProductFeature = _deleteProductFeature ?? new DeleteProductFeatureService(_context);
            }
        }
        private DeleteProductImageService _deleteProductImage;
        public DeleteProductImageService DeleteProductImageService
        {
            get
            {
                return _deleteProductImage = _deleteProductImage ?? new DeleteProductImageService(_context,_environment);
            }
        }

        
        private IGetProductForAdminService _getProductForAdmin;
        public IGetProductForAdminService GetProductForAdminService
        {
            get
            {
                return _getProductForAdmin = _getProductForAdmin ?? new GetProductForAdminService(_context);
            }
        }
        private IGetProductDetailForAdminService _getProductDetailForAdmin;
        public IGetProductDetailForAdminService GetProductDetailForAdminService 
        {
            get
            {
                return _getProductDetailForAdmin = _getProductDetailForAdmin ?? new GetProductDetailForAdminService(_context);
            }
        }
        private IGetProductForSiteService _getProductForSite;
        public IGetProductForSiteService GetProductForSiteService
        {
            get
            {
                return _getProductForSite = _getProductForSite ?? new GetProductForSiteService(_context);
            }
        }
        private IGetProductDetailForSiteService _getProductDetailForSite;
        public IGetProductDetailForSiteService GetProductDetailForSiteService
        {
            get
            {
                return _getProductDetailForSite = _getProductDetailForSite ?? new GetProductDetailForSiteService(_context);
            }
        }

    }
}
