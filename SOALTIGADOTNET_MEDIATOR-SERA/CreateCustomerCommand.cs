using MediatR;

namespace SOALTIGADOTNET_MEDIATOR_SERA;

public class CreateCustomerCommand : IRequest<int>
{
    public string CustomerCode { get; set; }
    public string CustomerName { get; set; }
    public string customerAddress { get; set; }

}
