using AutomatizationDocs.Data.Entity.Client;
using Microsoft.EntityFrameworkCore;

namespace AutomatizationDocs.Data.Context
{
    public class AutomatizationDocsContext: DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Passport> Passports { get; set; }

        public DbSet<Adress> Adresses { get; set; }

        public DbSet<FullName> FullNames { get; set; }

        public DbSet<IdNumber> IdNumbers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ClientsDB;Trusted_Connection=True");
        }

    }
}
