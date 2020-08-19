using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialApp.Core.DataTransferModels
{
    public class TransactionDataTransferObject
    {
        public long Id { get; set; }

        public long AccountId { get; set; }

        public double Amount { get; set; }

        public string Description { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}
