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
                TransactionDate = transaction.TransactionDate,
                AccountId = transaction.AccountId
            };

            _transactionRepository.Add(transactionEntity);
            _transactionRepository.SaveChanges();
            transaction.Id = transactionEntity.Id;

            var account = _accountRepository.All().Where(x => x.Id == transaction.AccountId).FirstOrDefault();

            account.Amount += transaction.Amount;

            _accountRepository.Update(account);
            _accountRepository.SaveChanges();

            return ServiceResult<TransactionDataTransferObject>.SuccessResult(transaction);
     
        }
        
        public ServiceResult<IEnumerable<TransactionDataTransferObject>> GetAllTransaction()
        {
            var transactionList = _transactionRepository.All()
                .Select(x=> new TransactionDataTransferObject { 
                    AccountId = x.AccountId,
                    Description = x.Description,
                    Amount = x.Amount,
                    TransactionDate = x.TransactionDate,
                    Id = x.Id
                }).ToList();

            return ServiceResult<IEnumerable<TransactionDataTransferObject>>.SuccessResult(transactionList);
        }
    }
}
