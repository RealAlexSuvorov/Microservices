using System;
using System.Collections.Generic;
using System.Text;
using Microservices.Banking.Application.Models;
using Microservices.Banking.Domain.Commands;
using Microservices.Domain.Core.Bus;
using Microservices.Transfer.Application.Interfaces;
using Microservices.Transfer.Domain.Interfaces;
using Microservices.Transfer.Domain.Models;

namespace Microservices.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository transferRepository;
        private readonly IEventBus bus;

        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            this.transferRepository = transferRepository;
            this.bus = bus;
        }
        
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return transferRepository.GetTransferLogs();
        }
    }
}
