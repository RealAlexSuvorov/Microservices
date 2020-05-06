using System;
using System.Collections.Generic;
using System.Text;
using Microservices.Banking.Domain.Models;

namespace Microservices.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
