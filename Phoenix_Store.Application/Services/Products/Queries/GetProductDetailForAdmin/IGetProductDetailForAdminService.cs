using Microsoft.EntityFrameworkCore;
using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using Phoenix_Store.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Products.Queries.GetProductDetailForAdmin
{
    public interface IGetProductDetailForAdminService
    {
        ResultDto<ProductDetailForAdminDto> Execute(long Id);
    }
    public class GetProductDetailForAdminService : IGetProductDetailForAdminService
    {
        private readonly IDataBaseContext _context;
        public GetProductDetailForAdminService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ProductDetailForAdminDto> Execute(long Id)
        {
            var products = _context.Products
                .Include(p => p.Category)
                .ThenInclude(p => p.ParentCategory)
                .Include(p => p.ProductFeatures)
                .Include(p => p.ProductImages)
                .Where(p => p.Id == Id)
                .FirstOrDefault();
            return new ResultDto<ProductDetailForAdminDto>
            {
                Data = new ProductDetailForAdminDto
                {
                    Id = products.Id,
                    Name = products.Name,
                    Category = GetCategory(products.Category),
                    Brand = products.Brand,
                    Description = products.Description,
                    Price = products.Price,
                    Inventory = products.Inventory,
                    Displayed = products.Displayed,
                    Features = products.ProductFeatures.ToList().Select(p => new ProductsDetailFeatureDto
                    {
                        Id = p.Id,
                        Display = p.DisplayName,
                        Value = p.Value
                    }).ToList(),
                    Images = products.ProductImages.ToList().Select(p => new ProductsDetailImageDto
                    {
                        Id = p.Id,
                        Src = p.Src
                    }).ToList(),
                },
                IsSuccess = true,
                Message = ""
            };
        }
           private string GetCategory(Category category)
            {
                string result = category.ParentCategory != null ? $"{category.ParentCategory.Name}-"  :"";
                return result += category.Name;
            }
    }

    
    public class ProductDetailForAdminDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }
        public bool Displayed { get; set; }
        public List<ProductsDetailFeatureDto> Features { get; set; }             
        public List<ProductsDetailImageDto> Images { get; set; }             
    }
    public class ProductsDetailImageDto
    {
        public long Id { get; set; }
        public string Src { get; set; }

    }

    public class ProductsDetailFeatureDto
    {
        public long Id { get; set; }
        public string Display { get; set; }
        public string Value { get; set; }
    }
}
