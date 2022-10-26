using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Finances.Queries.GetRequestPay
{
    public interface IGetRequestPayService
    {
        ResultDto<RequestPayDto> Execute(Guid guid);
    }
    public class GetRequestPayService : IGetRequestPayService
    {
        private readonly IDataBaseContext _context;
        public GetRequestPayService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<RequestPayDto> Execute(Guid guid)
        {
            var requestPay=_context.RequestPays.Where(p=>p.Guid==guid).FirstOrDefault();
            if (requestPay != null)
            {
                return new ResultDto<RequestPayDto>()
                {
                    Data =new RequestPayDto()
                    {
                        Amount=requestPay.Amount,
                        RequestPayId=requestPay.Id,
                    }
                };
            }
            else
            {
                throw new Exception ("RequestPay not Found");
            }
        }
    }

    public class RequestPayDto
    {
        public int Amount { get; set; }
        public long RequestPayId { get; set; }
    }
}
