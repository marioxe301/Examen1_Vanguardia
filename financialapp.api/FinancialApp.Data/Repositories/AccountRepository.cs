using FinancialApp.Core;
using FinancialApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialApp.Data.Repositories
{
    public class AccountRepository : IRepository<Account>
    {
        private readonly FinancialAppContext _context;
        public AccountRepository(FinancialAppContext context)
        {
            this._context = context;
        }

        public Account Add(Account T)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Account> All()
        {
            return _context.Account;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(Account account)
        {
            _context.Account.Update(account);
        }
    }
}
