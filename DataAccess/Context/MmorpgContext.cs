using DataAccess.Data;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class MmorpgContext:DbContext
    {
        //connectionString
        private readonly string connectionString = "server=localhost;database=MmorpgDB;Trusted_Connection=true;TrustServerCertificate=true;";

        //Tablo
        public DbSet<Weapon> Weapons {  get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Race> Races { get; set; }

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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Character Data
            modelBuilder.Entity<Character>().HasData(CharacterData.Characters);

            //Race Data
            modelBuilder.Entity<Race>().HasData(RaceData.Races);

            //Weapon Data
            modelBuilder.Entity<Weapon>().HasData(WeaponData.Weapons);

            base.OnModelCreating(modelBuilder);
        }
    }
}
