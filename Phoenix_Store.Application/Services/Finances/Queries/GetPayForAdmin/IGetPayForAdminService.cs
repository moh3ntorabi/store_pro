using Microsoft.EntityFrameworkCore;
using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Finances.Queries.GetPayForAdmin
{
    public interface IGetPayForAdminService
    {
        ResultDto<List<PayDto>> Execute();
    }
    public class GetPayForAdminService : IGetPayForAdminService
    {
        private readonly IDataBaseContext _context;
        public GetPayForAdminService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<PayDto>> Execute()
        {

            var pays=_context.RequestPays
                .Include(p=>p.User)
                .ToList()
                .Select(p=>new PayDto
                {
                    Amount=p.Amount,
                    Guid=p.Guid,
                    Authority=p.Authority,
                    Id=p.Id,
                    PayDate=p.PayDate,
                    IsPay=p.IsPay,
                    RefId=p.RefId,
                    UserId=p.UserId,
                    UserName=p.User.FullName,
                }).ToList();
            return new ResultDto<List<PayDto>>()
            {
                Data = pays,
                IsSuccess = true
            };
        }
    }

    public class PayDto
    {
        public long Id { get; set; }
        public Guid Guid { get; set; }
        public string UserName { get; set; }
        public long UserId { get; set; }
        public bool IsPay { get; set; }
        public int Amount { get; set; }
        public DateTime? PayDate { get; set; }
        public string Authority { get; set; }
        public long RefId { get; set; } = 0;
    }
}
