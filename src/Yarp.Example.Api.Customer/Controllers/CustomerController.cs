using Microsoft.AspNetCore.Mvc;
using Yarp.Example.Api.Customer.Models.Customer.Response;

namespace Yarp.Example.Api.Customer.Controllers;

[ApiController]
[Route("api/v1/customers")]
public class CustomerController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var returnModel = new List<GetCustomerResponse>()
        {
            new GetCustomerResponse
            {
                Id = 1,
                Name = "Murat"
            },
            new GetCustomerResponse
            {
                Id = 2,
                Name = "Ahmet"
            },
            new GetCustomerResponse
            {
                Id = 3,
                Name = "Mehmet"
            }
        };

        return Ok(returnModel);
    }
}