using System;
using System.Collections.Generic;
using System.Text;

namespace Microservices.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(Guid from, Guid to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
