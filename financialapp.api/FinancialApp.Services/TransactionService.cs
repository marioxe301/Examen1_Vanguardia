using FinancialApp.Core;
using FinancialApp.Core.DataTransferModels;
using FinancialApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialApp.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IRepository<Transaction> _transactionRepository;
        private readonly IRepository<Account> _accountRepository;

        public TransactionService(IRepository<Transaction> transactionRepository, IRepository<Account> accountRepository)
        {
            this._transactionRepository = transactionRepository;
            this._accountRepository = accountRepository;
        }
        
        public ServiceResult<TransactionDataTransferObject> Add(TransactionDataTransferObject transaction)
        {

            var transactionEntity = new Transaction
            {
                Description = transaction.Description,
                Amount = transaction.Amount,
                TransactionDate = transaction.TransactionDate
            };

            _transactionRepository.Add(transactionEntity);
            _transactionRepository.SaveChanges();
            transaction.AccountId = transactionEntity.AccountId;
            transaction.Id = transactionEntity.Id;

            var account = _accountRepository.All().Where(x => x.Id == transaction.AccountId).FirstOrDefault();

            account.Amount += transaction.Amount;

            _accountRepository.Update(account);
            _accountRepository.SaveChanges();

            return ServiceResult<TransactionDataTransferObject>.SuccessResult(transaction);
     
        }
        
        public ServiceResult<TransactionDataTransferObject> GetAllTransactionById(long id)
        {
            
        }
    }
}
