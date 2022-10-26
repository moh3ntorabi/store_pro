using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.HomePages.Commands.RemoveSlider
{
    public interface IRemoveSliderService
    {
        ResultDto Execute(long SliderId);
    }

    public class RemoveSliderService : IRemoveSliderService
    {
        private readonly IDataBaseContext _context;
        public RemoveSliderService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long SliderId)
        {
            var slider=_context.Sliders.Find(SliderId);
            if (slider == null)
            {
                return new ResultDto
                {
                    IsSuccess =false,
                    Message ="اسلایدر یافت نشد"
                };
            }
            slider.RemoveTime = DateTime.Now;
            slider.IsRemoved = true;
            _context.SaveChanges();
            return new ResultDto
            {
                IsSuccess = true,
                Message = "اسلایدر حذف شد"
            };
        }
    }

}
