using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using Phoenix_Store.Domain.Entities.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.HomePages.Queries.GetHomePageImagesForAdmin
{
    public interface IGetHomePageImagesForAdmin
    {
        ResultDto<List<GetHomePageImagesDto>>  Execute();
    }
    public class GetHomePageImagesForAdmin : IGetHomePageImagesForAdmin 
    {
        private readonly IDataBaseContext _context;
        public GetHomePageImagesForAdmin(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<GetHomePageImagesDto>> Execute()
        {
            var homePageImage=_context.HomePageImages.OrderByDescending(p=>p.Id).ToList().Select(p=>new GetHomePageImagesDto 
            { 
                Id=p.Id,
                Link=p.Link,
                Src=p.Src,
                ImageLocation=p.ImageLocation,
            }).ToList();
            return new ResultDto<List<GetHomePageImagesDto>>
            {
                Data = homePageImage,
                IsSuccess = true
            };
        }
    }

    public class GetHomePageImagesDto
    {
        public long Id { get; set; }
        public string Link { get; set; }
        public string Src { get; set; }
        public ImageLocation ImageLocation { get; set; }
    }
}
