using Microsoft.AspNetCore.Mvc;
using Yarp.Example.Api.Basket.Models.Basket.Response;

namespace Yarp.Example.Api.Customer.Controllers;

[ApiController]
[Route("api/v1/basket")]
public class BasketController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var returnModel = new GetBasketResponse
        {
            Items = new List<GetBasketResponse.Item>
            {
                new GetBasketResponse.Item
                {
                    Id = 1,
                    Name = "iPhone X",
                    ItemPrice = 100,
                    Quantity = 1,
                    Total = 100
                },
                new GetBasketResponse.Item
                {
                    Id = 2,
                    Name = "iPhone 11",
                    ItemPrice = 250,
                    Quantity = 2,
                    Total = 500
                },
            },
            Total = 600
        };

        return Ok(returnModel);
    }
}