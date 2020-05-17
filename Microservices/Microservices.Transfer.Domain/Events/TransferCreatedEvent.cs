using System;
using System.Collections.Generic;
using System.Text;
using Microservices.Domain.Core.Events;

namespace Microservices.Transfer.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public Guid From { get; }
        public Guid To { get; }
        public decimal Amount { get; }

        public TransferCreatedEvent(Guid from, Guid to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
