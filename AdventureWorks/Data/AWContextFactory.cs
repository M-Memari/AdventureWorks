using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AdventureWorks.Data
{
    public class AWContextFactory : IDesignTimeDbContextFactory<AdventureWorks2017Context>
    {
        public AdventureWorks2017Context CreateDbContext(string[] args)
        {
            var optionsBuilder =new DbContextOptionsBuilder<AdventureWorks2017Context>();
            var connectionString =
                @"Data Source=DESKTOP-BIHNGMS;Initial Catalog=AdventureWorks2017;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString, options => options.EnableRetryOnFailure());
            return new AdventureWorks2017Context(optionsBuilder.Options);
        }
    }
}
