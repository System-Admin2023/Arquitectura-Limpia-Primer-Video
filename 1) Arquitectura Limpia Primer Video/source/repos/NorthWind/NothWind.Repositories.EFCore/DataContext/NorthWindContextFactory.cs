using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NothWind.Repositories.EFCore.DataContext
{
    class NorthWindContextFactory :
        IDesignTimeDbContextFactory<NorthWindContext>
    {
        public NorthWindContext CreateDbContext(string[] args)
        {
            var OptionBuilder =
                new DbContextOptionsBuilder<NorthWindContext>();
            OptionBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;database=NorthWindDB");
            return new NorthWindContext(OptionBuilder.Options);
        }
    }
}
