using DataAccess.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class MmorpgContext:DbContext
    {
        //connectionString
        private readonly string connectionString = "server=localhost;database=MmorpgDB;Trusted_Connection=true;TrustServerCertificate=true;";

        //Tablo
        public DbSet<Silah> Silahlar {  get; set; }

        //OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        //OnModelCreating

    }
}
