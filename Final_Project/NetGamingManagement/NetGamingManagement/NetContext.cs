using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetGamingManagement
{
    public class NetContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= DESKTOP-GAVOHHD;Database=NetDB_EFCore;MultipleActiveResultSets=true;Trusted_Connection=true;Integrated Security=true");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
