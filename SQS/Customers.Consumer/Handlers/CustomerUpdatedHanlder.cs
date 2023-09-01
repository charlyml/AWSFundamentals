using Customers.Consumer.Messages;
using MediatR;

namespace Customers.Consumer.Handlers;

public class CustomerUpdatedHanlder : IRequestHandler<CustomerUpdated>
{
    private readonly ILogger<CustomerCreatedHandler> _logger;

    public CustomerUpdatedHanlder(ILogger<CustomerCreatedHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(CustomerUpdated request, CancellationToken cancellationToken)
    {
        _logger.LogInformation(request.GitHubUserName);

        return Unit.Task;
    }
}
