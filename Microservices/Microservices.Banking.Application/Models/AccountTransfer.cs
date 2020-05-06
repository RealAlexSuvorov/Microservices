using System;
using System.Collections.Generic;
using System.Text;

namespace Microservices.Banking.Application.Models
{
    public class AccountTransfer
    {
        public Guid FromAccount { get; set; }
        public Guid ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
