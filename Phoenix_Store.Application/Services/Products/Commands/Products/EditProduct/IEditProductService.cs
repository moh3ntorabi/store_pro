using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using Phoenix_Store.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Products.Commands.Products.EditProduct
{
    public interface IEditProductService
    {
        ResultDto Execute(RequestEditProductDto request);
    }
    public class EditProductService: IEditProductService
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        public EditProductService(IDataBaseContext context
            , IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public ResultDto Execute(RequestEditProductDto request)
        {
            var category = _context.Categories.Find(request.CategoryId);
            var product = _context.Products.Find(request.ProductId);
            if (product == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "محصول یافت نشد"
                };
            }
            product.Name = request.Name;
            product.Brand = request.Brand;
            product.Category = category;
            product.Price = request.Price;
            product.Inventory = request.Inventory;
            product.Description = request.Description;
            product.Displayed = request.Displayed;
            product.UpdateTime = DateTime.Now;
            List<ProductImage> productImages = new List<ProductImage>();
            foreach (var item in request.Images)
            {
                var uploadedResult = UploadFile(item);
                productImages.Add(new ProductImage
                {
                    Product = product,
                    Src = uploadedResult.FileNameAddress,

                });
            }
            _context.ProductImages.AddRange(productImages);

            List<ProductFeature> productFeatures = new List<ProductFeature>();
            foreach (var item in request.Features)
            {
                productFeatures.Add(new ProductFeature
                {
                    DisplayName = item.Display,
                    Value = item.Value,
                    Product = product,
                });
            }
            _context.ProductFeatures.AddRange(productFeatures);
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "محصول ویرایش شد."
            };
        }
            private UploadDto UploadFile(IFormFile file)
            {
                if (file != null)
                {
                    string folder = $@"images\ProductImages\";
                    var uploadsRootFolder = Path.Combine(_environment.WebRootPath, folder);
                    if (!Directory.Exists(uploadsRootFolder))
                    {
                        Directory.CreateDirectory(uploadsRootFolder);
                    }


                    if (file == null || file.Length == 0)
                    {
                        return new UploadDto()
                        {
                            Status = false,
                            FileNameAddress = "",
                        };
                    }

                    string fileName = DateTime.Now.Ticks.ToString() + file.FileName;
                    var filePath = Path.Combine(uploadsRootFolder, fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    return new UploadDto()
                    {
                        FileNameAddress = folder + fileName,
                        Status = true,
                    };
                }
                return null;
            }

        }
    
    public class RequestEditProductDto
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public long CategoryId { get; set; }
        public bool Displayed { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }

        public List<IFormFile> Images { get; set; }
        public List<AddProduct_Feature> Features { get; set; }
    }
    public class UploadDto
    {
        public long Id { get; set; }
        public bool Status { get; set; }
        public string FileNameAddress { get; set; }
    }
    public class AddProduct_Feature
    {
        public string Display { get; set; }
        public string Value { get; set; }
    }
}
