using Microsoft.EntityFrameworkCore;
using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using Phoenix_Store.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Orders.Queries.GetOrdersForAdmin
{
    public interface IGetOrdersForAdminService
    {
        ResultDto<List<OrdersDto>> Execute(OrderState orderState);
    }
    public class GetOrdersForAdminService : IGetOrdersForAdminService
    {
        private readonly IDataBaseContext _context;
        public GetOrdersForAdminService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<OrdersDto>> Execute(OrderState orderState)
        {
            var orders = _context.Orders
                .Include(p => p.OrderDetails)
                .Where(p => p.OrderState == orderState)
                .OrderByDescending(p => p.Id)
                .ToList().Select(p => new OrdersDto
                {
                    ProductCount = p.OrderDetails.Count,
                    OrderId=p.Id,
                    OrderState=p.OrderState,
                    RequestId=p.RequestPayId,
                    UserId=p.UserId,
                    InsertTime=p.InsertTime
                }).ToList();
            return new ResultDto<List<OrdersDto>>()
            {
                Data = orders,
                IsSuccess = true
            };
        }
    }

    public class OrdersDto
    {
        public long OrderId { get; set; }
        public DateTime InsertTime { get; set; }
        public long RequestId { get; set; }
        public long UserId { get; set; }
        public OrderState OrderState{ get; set; }
        public int ProductCount { get; set; }
    }
}
