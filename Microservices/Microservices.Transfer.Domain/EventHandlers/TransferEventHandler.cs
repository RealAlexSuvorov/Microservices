using System.Threading.Tasks;
using Microservices.Domain.Core.Bus;
using Microservices.Transfer.Domain.Events;

namespace Microservices.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler: IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHandler()
        {
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}