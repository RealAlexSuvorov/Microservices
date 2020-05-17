using System;
using System.Collections.Generic;
using Microservices.Transfer.Domain.Models;

namespace Microservices.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
