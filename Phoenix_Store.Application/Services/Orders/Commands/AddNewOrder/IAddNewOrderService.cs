using Microsoft.EntityFrameworkCore;
using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using Phoenix_Store.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Orders.Commands.AddNewOrder
{
    public interface IAddNewOrderService
    {
        ResultDto Execute(RequestAddNewOrderDto request);
    }
    public class AddNewOrderService : IAddNewOrderService
    {
        private readonly IDataBaseContext _context;
        public AddNewOrderService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto Execute(RequestAddNewOrderDto request)
        {
            var user=_context.Users.Find(request.UserID);
            var requestPay = _context.RequestPays.Find(request.RequestPayId);
            var cart = _context.Carts.Include(p => p.CartItems)
                .ThenInclude(p=>p.Product)
                .Where(p=>p.Id==request.CartId).FirstOrDefault();

            requestPay.IsPay = true;
            requestPay.PayDate = DateTime.Now;
            requestPay.Authority =request.Authority;
            requestPay.RefId = request.RefId;

            cart.Finished = true;

            Order order = new Order()
            {
                Address="",
                User=user,
                RequestPay=requestPay,
                OrderState=OrderState.Processing
            };
            _context.Orders.Add(order);

            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (var item in cart.CartItems)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    Count=item.Count,
                    Order=order,
                    Price=item.Product.Price,
                    Products=item.Product,
                };
                orderDetails.Add(orderDetail);
            }
            _context.OrderDetails.AddRange(orderDetails);
            _context.SaveChanges();

            return new ResultDto() 
            {
                IsSuccess=true
            };

        }

    }

    public class RequestAddNewOrderDto
    {
        public long CartId { get; set; }
        public long RequestPayId { get; set; }
        public long UserID { get; set; }
        public string Authority { get; set; }
        public long RefId { get; set; } = 0;
    }
}
