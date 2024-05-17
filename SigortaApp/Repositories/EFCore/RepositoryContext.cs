using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Repositories.EFCore.Config;

namespace Repositories.EFCore
{
    public class RepositoryContext : DbContext // aslında DbContext

    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Policies> Policies { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<PolicyUser> PolicyUser { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PolicyUserConfig());
            modelBuilder.ApplyConfiguration(new PoliciesConfig());
            modelBuilder.ApplyConfiguration(new TransactionsConfig());
            modelBuilder.ApplyConfiguration(new UsersConfig());

        }
    }
}
