using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArc.Persistence.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<OnionArcDbContext>
    {
        public OnionArcDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OnionArcDbContext>();
            builder.UseSqlServer("Server=.;Database=OnionArc;Trusted_Connection=True;");
            return new OnionArcDbContext(builder.Options);
        }
    }
}
