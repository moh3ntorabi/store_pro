using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.HomePages.Queries.GetSlidersForAdmin
{
    public interface IGetSlidersForAdminService
    {
        ResultDto<List<SlidersForAdminDto>> Execute();
    }
    public class GetSlidersForAdminService : IGetSlidersForAdminService
    {
        private readonly IDataBaseContext _context;
        public GetSlidersForAdminService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<SlidersForAdminDto>> Execute()
        {
            var sliders = _context.Sliders.OrderByDescending(p => p.Id).ToList().Select(
                p=>new SlidersForAdminDto
                {
                    Id=p.Id,
                    Src=p.Src,
                    Link=p.Link
                }).ToList();
            return new ResultDto<List<SlidersForAdminDto>>
            {
                Data = sliders,
                IsSuccess=true,
            };
        }
    }
    public class SlidersForAdminDto
    {
        public long Id { get; set; }
        public string Src { get; set; }
        public string Link { get; set; }
    }
}
