using FinancialApp.Core;
using FinancialApp.Core.DataTransferModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialApp.Services
{
    public interface ITransactionService
    {
        public ServiceResult<TransactionDataTransferObject> Add(TransactionDataTransferObject transaction);
        public ServiceResult<TransactionDataTransferObject> GetAllTransactionById(long id);
    }
}
