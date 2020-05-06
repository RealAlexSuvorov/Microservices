using System;
using System.Collections.Generic;
using System.Text;
using Microservices.Banking.Data.Context;
using Microservices.Banking.Domain.Interfaces;
using Microservices.Banking.Domain.Models;

namespace Microservices.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            this.ctx = ctx;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return ctx.Accounts;
        }
    }
}
