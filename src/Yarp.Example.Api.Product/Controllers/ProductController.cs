using Microsoft.AspNetCore.Mvc;
using Yarp.Example.Api.Product.Models.Customer.Response;

namespace Yarp.Example.Api.Product.Controllers;

[ApiController]
[Route("api/v1/products")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var returnModel = new List<GetProductResponse>()
        {
            new GetProductResponse
            {
                Id = 1,
                Name = "iPhone X"
            },
            new GetProductResponse
            {
                Id = 2,
                Name = "iPhone 11"
            },
            new GetProductResponse
            {
                Id = 3,
                Name = "iPhone 12"
            }
        };

        return Ok(returnModel);
    }
}