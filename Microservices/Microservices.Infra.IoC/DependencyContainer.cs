using System;
using System.Collections.Generic;
using System.Text;
using Microservices.Banking.Application.Interfaces;
using Microservices.Banking.Application.Services;
using Microservices.Banking.Data.Context;
using Microservices.Banking.Data.Repository;
using Microservices.Banking.Domain.Interfaces;
using Microservices.Domain.Core.Bus;
using Microservices.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            // Application services
            services.AddTransient<IAccountService, AccountService>();

            // Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
