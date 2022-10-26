using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using Phoenix_Store.Domain.Entities.HomePage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.HomePages.AddHomePageImages
{
    public interface IAddHomePageImagesService
    {
        ResultDto Execute(RequestAddHomePageImages request);
    }
    public class AddHomePageImagesService:IAddHomePageImagesService
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        public AddHomePageImagesService(IDataBaseContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public ResultDto Execute(RequestAddHomePageImages request)
        {
            var resultUpload = UploadFile(request.File);
            HomePageImages homePageImages = new HomePageImages()
            {
                Link = request.Link,
                ImageLocation = request.ImageLocation,
                Src = resultUpload.FileNameAddress
            };
            _context.HomePageImages.Add(homePageImages);
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,
            };
        }
        private UploadDto UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string folder = $@"images\HomePages\PageImages\";
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
        public class UploadDto
        {
            public long Id { get; set; }
            public bool Status { get; set; }
            public string FileNameAddress { get; set; }
        }
    }
    public class RequestAddHomePageImages
    {
        public IFormFile File{ get; set; }
        public string Link { get; set; }
        public ImageLocation ImageLocation { get; set; }
    }
}
