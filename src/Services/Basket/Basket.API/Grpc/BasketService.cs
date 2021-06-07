using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.eShopOnContainers.Services.Basket.API.Model;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcBasket
{
    public class BasketService : Basket.BasketBase
    {
        private readonly IBasketRepository _repository;
        private readonly ILogger<BasketService> _logger;

        public BasketService(IBasketRepository repository, ILogger<BasketService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [AllowAnonymous]
        public override async Task<CustomerBasketResponse> GetBasketById(BasketRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Begin grpc call from method {Method} for basket id {Id}", context.Method, request.Id);

            var data = await _repository.GetBasketAsync(request.Id);

            if (data != null)
            {
                context.Status = new Status(StatusCode.OK, $"Basket with id {request.Id} do exist");
                _logger.LogInformation("Method \"MapToCustomerBasketResponse\" called from {Method}", context.Method);
                return MapToCustomerBasketResponse(data);
            }
            else
            {
                context.Status = new Status(StatusCode.NotFound, $"Basket with id {request.Id} do not exist");
            }
            _logger.LogInformation("Basket with id {request} do not exist. New \"CustomerBasketResponse\" will add the product to Basket",request.Id);
            return new CustomerBasketResponse();
        }

        public override async Task<CustomerBasketResponse> UpdateBasket(CustomerBasketRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Begin grpc call BasketService.UpdateBasketAsync for buyer id {Buyerid}", request.Buyerid);
            _logger.LogInformation("Method \"MapToCustomerBasket\" called from {Method}", context.Method);
            var customerBasket = MapToCustomerBasket(request);

            var response = await _repository.UpdateBasketAsync(customerBasket);

            if (response != null)
            {
                _logger.LogInformation("Method \"MapToCustomerBasketResponse\" called from {Method}", context.Method);
                return MapToCustomerBasketResponse(response);                
            }

            context.Status = new Status(StatusCode.NotFound, $"Basket with buyer id {request.Buyerid} do not exist");

            return null;
        }

        private CustomerBasketResponse MapToCustomerBasketResponse(CustomerBasket customerBasket)
        {
            var response = new CustomerBasketResponse
            {
                Buyerid = customerBasket.BuyerId
            };

            customerBasket.Items.ForEach(item => response.Items.Add(new BasketItemResponse
            {
                Id = item.Id,
                Oldunitprice = (double)item.OldUnitPrice,
                Pictureurl = item.PictureUrl,
                Productid = item.ProductId,
                Productname = item.ProductName,
                Quantity = item.Quantity,
                Unitprice = (double)item.UnitPrice
            }));

            _logger.LogInformation("Response from Method \"MapToCustomerBasketResponse\": {Response}", response);
            _logger.LogInformation("Method Execution \"MapToCustomerBasketResponse\" ends");
            return response;
        }

        private CustomerBasket MapToCustomerBasket(CustomerBasketRequest customerBasketRequest)
        {
            var response = new CustomerBasket
            {
                BuyerId = customerBasketRequest.Buyerid
            };

            customerBasketRequest.Items.ToList().ForEach(item => response.Items.Add(new BasketItem
            {
                Id = item.Id,
                OldUnitPrice = (decimal)item.Oldunitprice,
                PictureUrl = item.Pictureurl,
                ProductId = item.Productid,
                ProductName = item.Productname,
                Quantity = item.Quantity,
                UnitPrice = (decimal)item.Unitprice
            })); 

            _logger.LogInformation("Response from Method \"MapToCustomerBasket\": {Response}", response);
            _logger.LogInformation("Method Execution \"MapToCustomerBasket\" ends");
            return response;
        }
    }
}
