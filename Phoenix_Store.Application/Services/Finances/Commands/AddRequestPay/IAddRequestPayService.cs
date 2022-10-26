﻿using Phoenix_Store.Application.Interfaces.Contexts;
using Phoenix_Store.Common.Dto;
using Phoenix_Store.Domain.Entities.Finances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Store.Application.Services.Finances.Commands.AddRequestPay
{
    public interface IAddRequestPayService
    {
        ResultDto<ResultRequestPayDto> Execute(int Amount, long UserId);
    }
    public class AddRequestPayService : IAddRequestPayService
    {
        private readonly IDataBaseContext _context;
        public AddRequestPayService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultRequestPayDto> Execute(int Amount, long UserId)
        {
            var user = _context.Users.Find(UserId);
            RequestPay requestPay=new RequestPay()
            {
                Amount=Amount,
                IsPay=false,
                Guid=Guid.NewGuid(),
                User=user
            };
            _context.RequestPays.Add(requestPay);
            _context.SaveChanges();
            return new ResultDto<ResultRequestPayDto>()
            {
                Data=new ResultRequestPayDto
                {
                    guid=requestPay.Guid,
                    Amount=requestPay.Amount,
                    Email=user.Email,
                    RequestPayId=requestPay.Id,
                },
                IsSuccess = true,
            };

        }
    }

    public class ResultRequestPayDto 
    {
        public Guid guid { get; set; }
        public int Amount { get; set; }
        public string Email { get; set; }
        public long RequestPayId { get; set; }
    }

}
