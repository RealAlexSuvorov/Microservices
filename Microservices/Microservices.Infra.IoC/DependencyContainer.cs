using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Microservices.Banking.Application.Interfaces;
using Microservices.Banking.Application.Services;
using Microservices.Banking.Data.Context;
using Microservices.Banking.Data.Repository;
using Microservices.Banking.Domain.CommandHandlers;
using Microservices.Banking.Domain.Commands;
using Microservices.Banking.Domain.Interfaces;
using Microservices.Domain.Core.Bus;
using Microservices.Infra.Bus;
using Microservices.Transfer.Application.Interfaces;
using Microservices.Transfer.Application.Services;
using Microservices.Transfer.Data.Context;
using Microservices.Transfer.Data.Repository;
using Microservices.Transfer.Domain.EventHandlers;
using Microservices.Transfer.Domain.Events;
using Microservices.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            // Domain Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            // Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            // Application services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            // Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}