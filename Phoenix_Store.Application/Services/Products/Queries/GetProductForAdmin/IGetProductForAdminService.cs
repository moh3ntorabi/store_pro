using Microsoft.EntityFrameworkCore;
using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common;
using Phoenix_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Products.Queries.GetProductForAdmin
{
    public interface IGetProductForAdminService
    {
        ResultDto<ProductForAdminDto> Execute(int Page = 1, int Pagesize = 20);
    }
    public class GetProductForAdminService : IGetProductForAdminService
    {
        private readonly IDataBaseContext _context;
        public GetProductForAdminService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ProductForAdminDto> Execute(int Page = 1, int Pagesize = 20)
        {
            int rowCount = 0;
            var products = _context.Products
                .Include(p => p.Category)
                .ToPaged(Page, Pagesize, out rowCount)
                .Select(p => new ProductsFormAdminList_Dto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.Category.Name,
                    Brand = p.Brand,
                    Description = p.Description,
                    Price = p.Price,
                    Inventory = p.Inventory,
                    Displayed = p.Displayed
                }).ToList();
            return new ResultDto<ProductForAdminDto>
            {
                Data = new ProductForAdminDto
                {
                    Products=products,
                    PageSize=Pagesize,
                    RowCount=rowCount,
                    CurrentPage=Page
                },
                IsSuccess=true,
                Message=""
            };
        }
    }

    public class ProductForAdminDto
    {
        public int RowCount { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public List<ProductsFormAdminList_Dto> Products { get; set; }
    }
    public class ProductsFormAdminList_Dto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }
        public bool Displayed { get; set; }
    }
}
