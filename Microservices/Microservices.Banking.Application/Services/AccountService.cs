using System;
using System.Collections.Generic;
using System.Text;
using Microservices.Banking.Application.Interfaces;
using Microservices.Banking.Application.Models;
using Microservices.Banking.Domain.Commands;
using Microservices.Banking.Domain.Interfaces;
using Microservices.Banking.Domain.Models;
using Microservices.Domain.Core.Bus;

namespace Microservices.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;
        private readonly IEventBus bus;

        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            this.accountRepository = accountRepository;
            this.bus = bus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.TransferAmount
                );

            bus.SendCommand(createTransferCommand);
        }
    }
}
