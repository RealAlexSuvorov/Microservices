﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microservices.Banking.Domain.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string AccountType { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
