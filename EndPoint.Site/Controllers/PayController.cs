using Dto.Payment;
using EndPoint.Site.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Phoenix_Store.Application.Services.Carts;
using Phoenix_Store.Application.Services.Finances.Commands.AddRequestPay;
using Phoenix_Store.Application.Services.Finances.Queries.GetRequestPay;
using Phoenix_Store.Application.Services.Orders.Commands.AddNewOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZarinPal.Class;

namespace EndPoint.Site.Controllers
{
    [Authorize("Customer")]
    public class PayController : Controller
    {
        private readonly IAddRequestPayService _addRequestPay;
        private readonly ICartService _cartService;
        private readonly IGetRequestPayService _getRequestPay;
        private readonly IAddNewOrderService _addNewOrder;
        private readonly CookiesManager _cookiesManager;
        private readonly Payment _payment;
        private readonly Authority _authority;
        private readonly Transactions _transactions;
        public PayController(IAddRequestPayService addRequestPay,
            ICartService cartService,
            IGetRequestPayService getRequestPay,
            IAddNewOrderService addNewOrder)
        {
            _addRequestPay = addRequestPay;
            _cartService = cartService;
            _cookiesManager = new CookiesManager();
            _getRequestPay = getRequestPay;
            _addNewOrder = addNewOrder;
            var expose = new Expose();
            _payment = expose.CreatePayment();
            _authority = expose.CreateAuthority();
            _transactions = expose.CreateTransactions();
        }
        public async Task<IActionResult> Index()
        {
            long? UserId = ClaimUtility.GetUserId(User);
            var cart = _cartService.GetMyCart(_cookiesManager.GetBrowserId(HttpContext),UserId);
            if (cart.Data.SumAmount > 0)
            {
               var requestPay= _addRequestPay.Execute(cart.Data.SumAmount, UserId.Value);

                var result = await _payment.Request(new DtoRequest()
                {
                    Mobile = "09121112222",
                    CallbackUrl = $"https://localhost:44354/Pay/Verify?guid={requestPay.Data.guid}",
                    Description = "پرداخت فاکتور شماره:"+requestPay.Data.RequestPayId,
                    Email = requestPay.Data.Email,
                    Amount = requestPay.Data.Amount,
                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
                }, ZarinPal.Class.Payment.Mode.sandbox);
                return Redirect($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");
            }
            else
            {
                return RedirectToAction("Index","Cart");
            }
            return View();
        }
        public async Task<IActionResult> Verify(Guid guid, string authority, string status)
        {
            var requestPay = _getRequestPay.Execute(guid);
            var verification = await _payment.Verification(new DtoVerification
            {
                Amount = requestPay.Data.Amount,
                MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                Authority = authority
            }, Payment.Mode.sandbox);

            long? userId = ClaimUtility.GetUserId(User);
            var cart = _cartService.GetMyCart(_cookiesManager.GetBrowserId(HttpContext), userId);
            if (verification.Status==100)
            {
                _addNewOrder.Execute(new RequestAddNewOrderDto
                {
                    CartId=cart.Data.CartId,
                    UserID=userId.Value,
                    RequestPayId=requestPay.Data.RequestPayId
                });
                return RedirectToAction("Index", "Orders");
            }
            else
            {

            }
            return View();

        }
    }
}
