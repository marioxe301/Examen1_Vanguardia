﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialApp.Core.DataTransferModels
{
    public class AccountDataTransferObject
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public double Amount { get; set; }

        public string Currency { get; set; }

        public double ConversionRate { get; set; }
    }
}
