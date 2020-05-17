using System;
using System.Collections.Generic;
using System.Text;
using Microservices.Transfer.Data.Context;
using Microservices.Transfer.Domain.Interfaces;
using Microservices.Transfer.Domain.Models;

namespace Microservices.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext ctx;

        public TransferRepository(TransferDbContext ctx)
        {
            this.ctx = ctx;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return ctx.TransferLogs;
        }
    }
}
