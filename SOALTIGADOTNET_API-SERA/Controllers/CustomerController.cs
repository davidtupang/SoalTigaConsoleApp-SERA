using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SOALTIGADOTNET_API_SERA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] SOALTIGADOTNET_MEDIATOR_SERA.CreateCustomerCommand command)
        {

            var customerId = await _mediator.Send(command);


            var response = new SOALTIGADOTNET_EFCORE_SERA.ApiResponse<int>
            {
                Message = "Customer created successfully",
                TransactionId = Guid.NewGuid().ToString(),
                Data = customerId
            };

            return Ok(response);
        }
    }
}