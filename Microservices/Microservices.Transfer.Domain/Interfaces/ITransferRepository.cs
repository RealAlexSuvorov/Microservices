using System;
using System.Collections.Generic;
using System.Text;
using Microservices.Transfer.Domain.Models;

namespace Microservices.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}