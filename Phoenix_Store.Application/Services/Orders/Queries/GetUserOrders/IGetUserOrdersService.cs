using Microsoft.EntityFrameworkCore;
using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using Phoenix_Store.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Orders.Queries.GetUserOrders
{
    public interface IGetUserOrdersService
    {
        ResultDto<List<GetUserOrdersDto>> Execute(long UserId);
    }
    public class GetUserOrdersService : IGetUserOrdersService
    {
        private readonly IDataBaseContext _context;
        public GetUserOrdersService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<GetUserOrdersDto>> Execute(long UserId)
        {
            var orders=_context.Orders
                .Include(p=>p.OrderDetails)
                .ThenInclude(p=>p.Products)
                .Where(p=>p.UserId==UserId)
                .OrderByDescending(p=>p.Id).ToList();
            return new ResultDto<List<GetUserOrdersDto>>()
            {
                Data = orders.Select(p => new GetUserOrdersDto
                {
                    OrderId = p.Id,
                    OrderState = p.OrderState,
                    RequestPayId = p.RequestPayId,
                    OrdersDetails = p.OrderDetails.Select(o => new OrdersDetailDto
                    {
                        Count = o.Count,
                        Price = o.Price,
                        OrderDetailId = o.Id,
                        ProductId = o.ProductId,
                        ProductName = o.Products.Name
                    }).ToList()
                }).ToList(),
                IsSuccess=true
            };
        }
    }

    public class GetUserOrdersDto
    {
        public long OrderId { get; set; }
        public OrderState OrderState { get; set; }
        public long RequestPayId { get; set; }
        public List<OrdersDetailDto> OrdersDetails { get; set; }
    }
    public class OrdersDetailDto
    {
        public long OrderDetailId { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }
}
