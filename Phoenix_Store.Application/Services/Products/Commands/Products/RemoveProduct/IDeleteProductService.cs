using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Products.Commands.Products.RemoveProduct
{
    public interface IDeleteProductService
    {
        ResultDto Execute(long ProductId);
    }
    public class DeleteProductService : IDeleteProductService
    {
        private readonly IDataBaseContext _context;
        public DeleteProductService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long ProductId)
        {
            var product = _context.Products.Find(ProductId);
            if (product == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "محصول یافت نشد"
                };
            }
            product.RemoveTime = DateTime.Now;
            product.IsRemoved = true;
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "محصول حذف شد"
            };
        }
    }
}
