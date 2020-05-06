using System;
using System.Collections.Generic;
using System.Text;
using Microservices.Domain.Core.Commands;

namespace Microservices.Banking.Domain.Commands
{
    public abstract class TransferCommand : Command
    {
        public Guid From { get; protected set; }
        public Guid To { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
