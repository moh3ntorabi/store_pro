using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Products.Commands.Categories.RemoveCategory
{
    public interface IDeleteCategoryService
    {
        ResultDto Execute(long CategoryId);
    }
    public class DeleteCategoryService : IDeleteCategoryService
    {
        private readonly IDataBaseContext _context;
        public DeleteCategoryService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long CategoryId)
        {
            var category = _context.Categories.Find(CategoryId);
            if (category == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "دسته بندی یافت نشد"
                };
            }
            category.RemoveTime = DateTime.Now;
            category.IsRemoved = true;
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "دسته بندی حذف شد"
            };
        }
    }
}
