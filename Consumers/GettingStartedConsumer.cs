using Microsoft.Extensions.Logging;

namespace Company.Consumers
{
    using System.Threading.Tasks;
    using MassTransit;
    using Contracts;

    public class GettingStartedConsumer :
        IConsumer<HelloMessage>
    {
    readonly ILogger<GettingStartedConsumer> _logger;

    public GettingStartedConsumer(ILogger<GettingStartedConsumer> logger) {
      _logger = logger;
    }

    public Task Consume(ConsumeContext<HelloMessage> context)
        {
          _logger.LogInformation("Hellp {Name}", context.Message.Name);
          return Task.CompletedTask;
        }
    }
}