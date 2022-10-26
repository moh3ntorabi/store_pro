using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using Phoenix_Store.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Products.Commands.Categories.EditCategory
{
    public interface IEditCategoryService
    {
        ResultDto Execute(RequestEditCategoryDto request);
    }
    public class EditCategoryService : IEditCategoryService
    {
        private readonly IDataBaseContext _context;
        public EditCategoryService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestEditCategoryDto request)
        {
            var category = _context.Categories.Find(request.CategoryId);
            if (category == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "دسته بندی یافت نشد"
                };
            }
            category.Name = request.Name;
            category.ParentCategory = GetParent(request.ParentId);
            category.UpdateTime = DateTime.Now;
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "ویرایش دسته بندی با موفقیت انجام شد"
            };
        }
        private Category GetParent(long? ParentId)
        {
            return _context.Categories.Find(ParentId);
        }
    }
    public class RequestEditCategoryDto
    {
        public long CategoryId { get; set; }
        public long ParentId { get; set; }
        public string Name { get; set; }
    }
    
}
