using MediatR;
using SOALTIGADOTNET_EFCORE_SERA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOALTIGADOTNET_MEDIATOR_SERA
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateCustomerCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer
            {
                CustomerCode = request.CustomerCode,
                CustomerName = request.CustomerName,

            };

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync(cancellationToken);

            return customer.CustomerId;
        }
    }
}
