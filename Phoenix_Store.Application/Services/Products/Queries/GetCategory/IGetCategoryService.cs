using Microsoft.EntityFrameworkCore;
using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Products.Queries.GetCategory
{
    public interface IGetCategoryService
    {
        ResultDto<List<CategoriesDto>> Execute(long? parentId);
    }

    public class GetCategoryService : IGetCategoryService
    {
        private readonly IDataBaseContext _context;
        public GetCategoryService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<CategoriesDto>> Execute(long? parentId)
        {
            var categories = _context.Categories
                .Include(p => p.ParentCategory)
                .Include(p => p.SubCategories)
                .Where(p => p.ParentCategoryId == parentId)
                .ToList()
                .Select(p => new CategoriesDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Parent = p.ParentCategory != null ? new ParentCategoryDto
                    {
                        Id = p.ParentCategory.Id,
                        name = p.ParentCategory.Name
                    } : null,
                    HasChild=p.SubCategories.Count()>0 ? true : false
                }
                    ).ToList() ;
            return new ResultDto<List<CategoriesDto>>()
            {
                Data = categories,
                IsSuccess=true,
                Message="لیست با موفقیت برگشت داده شد"

            };
        }
    }

    public class CategoriesDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool HasChild{ get; set; }
        public ParentCategoryDto Parent { get; set; }

    }
    public class ParentCategoryDto
    {
        public long Id{ get; set; }
        public string name{ get; set; }
    }
}
