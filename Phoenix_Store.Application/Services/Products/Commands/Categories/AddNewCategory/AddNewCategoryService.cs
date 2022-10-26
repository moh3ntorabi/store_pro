using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Domain.Entities.Products;
using Phoenix_Store.Common.Dto;

namespace Phoenix_Store.Application.Services.Products.Commands.Categories.AddNewCategory
{
    public class AddNewCategoryService : IAddNewCategoryService
    {
        private readonly IDataBaseContext _context;
        public AddNewCategoryService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(long? ParentId, string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "نام دسته بندی را وارد کنید"
                };
            }
            Category category = new Category()
            {
                Name = Name,
                ParentCategory = GetParent(ParentId)
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "دسته بندی با موفقیت اضافه شد"
            };


        }
        private Category GetParent(long? ParentId)
        {
            return _context.Categories.Find(ParentId);
        }
    }
}
