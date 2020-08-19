using FinancialApp.Core;
using FinancialApp.Core.DataTransferModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialApp.Services
{
    public interface IAccountService
    {
        public ServiceResult<IEnumerable<AccountDataTransferObject>> GetAllAccounts();
    }
}
