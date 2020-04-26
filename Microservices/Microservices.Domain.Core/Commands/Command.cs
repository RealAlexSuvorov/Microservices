using System;
using System.Collections.Generic;
using System.Text;
using Microservices.Domain.Core.Events;

namespace Microservices.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
