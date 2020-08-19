using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialApp.Core
{
    public interface IRepository <Entity>
    {
        Entity Add(Entity T);
        IQueryable<Entity> All();

        int SaveChanges();

        void Update(Entity T);

    }
}
