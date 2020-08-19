using FinancialApp.Core;
using FinancialApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialApp.Data.Repositories
{
    public class TransactionRepository : IRepository<Transaction>
    {
        private readonly FinancialAppContext _context;
        public TransactionRepository( FinancialAppContext context)
        {
            this._context = context;
        }
        public Transaction Add(Transaction transaction)
        {
            _context.Add(transaction);
            return transaction;
        }

        public IQueryable<Transaction> All()
        {
            return _context.Transaction;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Update(Transaction T)
        {
            throw new NotImplementedException();
        }
    }
}
