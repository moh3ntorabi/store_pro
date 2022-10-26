using Microsoft.EntityFrameworkCore;
using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common;
using Phoenix_Store.Common.Dto;
using System;
using System.Linq;

namespace Phoenix_Store.Application.Services.Products.Queries.GetProductForSite
{
    public class GetProductForSiteService : IGetProductForSiteService
    {
        private readonly IDataBaseContext _context;
        public GetProductForSiteService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultProductForSiteDto> Execute(Ordering ordering, string SearhKey, long? CatId, int Page, int pageSize)
        {
            int totalRow = 0;
            var productQuery = _context.Products
                .Include(p => p.ProductImages).AsQueryable();
                if (CatId!= null)
                {
                    productQuery = productQuery.Where(p => p.CategoryId == CatId || p.Category.ParentCategoryId == CatId).AsQueryable();
                }
            if (!string.IsNullOrWhiteSpace(SearhKey))
            {
                productQuery = productQuery.Where(p =>p.Name.Contains(SearhKey)||p.Brand.Contains(SearhKey)).AsQueryable();
            }

            switch (ordering)
            {
                case Ordering.notOrder:
                    productQuery = productQuery.OrderByDescending(p=>p.Id).AsQueryable();
                    break;
                case Ordering.MostVisited:
                    productQuery = productQuery.OrderByDescending(p => p.ViewCount).AsQueryable();
                    break;
                case Ordering.BestSelling:
                    break;
                case Ordering.MostPopular:
                    break;
                case Ordering.TheNewest:
                    productQuery = productQuery.OrderByDescending(p => p.Id).AsQueryable();
                    break;
                case Ordering.Cheapest:
                    productQuery = productQuery.OrderBy(p => p.Price).AsQueryable();
                    break;
                case Ordering.MostExpensive:
                    productQuery = productQuery.OrderByDescending(p => p.Price).AsQueryable();
                    break;
                default:
                    break;
            }


            var products=productQuery.ToPaged(Page,10,out totalRow);
            Random rd = new Random();
            return new ResultDto<ResultProductForSiteDto>
            {
                Data = new ResultProductForSiteDto
                {
                    TotalRow = totalRow,
                    Products = products.Select(p => new ProductForSiteDto
                    {
                        Id = p.Id,
                        Stars = rd.Next(1, 5),
                        ImageSrc = p.ProductImages.FirstOrDefault().Src,
                        Title = p.Name,
                        Price = p.Price
                    }).ToList(),
                },
                IsSuccess = true,
                Message = ""
            };
        }
    }
}
