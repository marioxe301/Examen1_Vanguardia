using FinancialApp.Core;
using FinancialApp.Core.DataTransferModels;
using FinancialApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialApp.Services
{
    public class AccountService : IAccountService
    {
        private readonly IRepository<Account> _accountRepository;

        public AccountService(IRepository<Account> accountRepository)
        {
            this._accountRepository = accountRepository;
        }
        public ServiceResult<IEnumerable<AccountDataTransferObject>> GetAllAccounts()
        {
            var Accounts = _accountRepository.All().Select(x => new AccountDataTransferObject
            {
                Id = x.Id,
                Amount = x.Amount,
                Name = x.Name,
                Currency = x.Currency,
                ConversionRate = x.ConversionRate

            }).ToList();

            return ServiceResult<IEnumerable<AccountDataTransferObject>>.SuccessResult(Accounts);
        }
    }
}
