using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.HomePages.Commands.RemoveAddHomePageImages
{
    public interface IRemoveHomePageImages
    {
        ResultDto Execute(long PageImageId);
    }

    public class RemoveHomePageImages : IRemoveHomePageImages
    {
        private readonly IDataBaseContext _context;
        public RemoveHomePageImages(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long PageImageId)
        {
            var pageImage = _context.HomePageImages.Find(PageImageId);
            if (pageImage == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "تصویر یافت نشد"
                };
            }
            pageImage.RemoveTime = DateTime.Now;
            pageImage.IsRemoved = true;
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "تصویر حذف شد"
            };
        }
    }
}
