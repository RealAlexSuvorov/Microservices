using System;
using System.Collections.Generic;
using System.Text;
using Microservices.Banking.Application.Interfaces;
using Microservices.Banking.Domain.Interfaces;
using Microservices.Banking.Domain.Models;

namespace Microservices.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }
    }
}
