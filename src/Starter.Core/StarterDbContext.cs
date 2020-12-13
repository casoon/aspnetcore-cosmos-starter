using System;
using Microsoft.EntityFrameworkCore;
using Starter.Core.Entities;

namespace Starter.Core
{
    public class StarterDbContext : DbContext
    {
        public StarterDbContext() : base()
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
