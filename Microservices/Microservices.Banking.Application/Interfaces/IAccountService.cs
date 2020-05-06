using System;
using System.Collections.Generic;
using System.Text;
using Microservices.Banking.Application.Models;
using Microservices.Banking.Domain.Models;

namespace Microservices.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
