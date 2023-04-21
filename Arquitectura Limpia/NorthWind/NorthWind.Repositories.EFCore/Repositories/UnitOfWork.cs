using NorthWind.Entities.Interfaces;
using NorthWind.Repositories.EFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Repositories.EFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly NorthWindContext Context;
        public UnitOfWork(NorthWindContext context) =>
            Context = context;
        public Task<int> SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }
    }
}
