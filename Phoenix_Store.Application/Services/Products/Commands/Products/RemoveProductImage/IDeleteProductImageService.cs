using Microsoft.AspNetCore.Hosting;
using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Products.Commands.Products.RemoveProductImage
{
    public interface IDeleteProductImageService
    {
        ResultDto Execute(long ImageId);
    }
    public class DeleteProductImageService: IDeleteProductImageService
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        public DeleteProductImageService(IDataBaseContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public ResultDto Execute(long ImageId)
        {
            var productImage=_context.ProductImages.Find(ImageId);
            if (productImage == null)
            {
                return new ResultDto 
                {
                    IsSuccess=false,
                };
            }
            var imageSrc=productImage.Src;
            var dirPath = Path.Combine(_environment.WebRootPath +"\\"+ imageSrc);
            File.Delete(dirPath);
            _context.ProductImages.Remove(productImage);
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true
            };
        }

    }
}
