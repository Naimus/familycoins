using familycoins.Models;
using Microsoft.EntityFrameworkCore;

namespace familycoins.Data
{
    public class FamilyCoinsDbContext : DbContext
    {
        public FamilyCoinsDbContext(DbContextOptions<FamilyCoinsDbContext> options)
            : base(options)
        {
    
        }
    
        public DbSet<FamilyMember> FamilyMembers { get; set; }
        public DbSet<FamilyPointsTransaction> Transactions {get; set;}
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FamilyMember>().HasData(
                new FamilyMember() { Id = 1, Name = "Eric", FamilyCoinsScore=500, Details="Eric" },
                new FamilyMember() { Id = 2, Name = "Adri", FamilyCoinsScore=500, Details="Adri"   }
            );
            modelBuilder.Entity<FamilyPointsTransaction>().HasData(
                new FamilyPointsTransaction() { Id=1, TypeOfTransaction=FamilyPointsTransactionType.FAMILYACTIVITY, Name="No Hacer Caso", Details = "", points = -100 },
                new FamilyPointsTransaction() { Id=2, TypeOfTransaction=FamilyPointsTransactionType.FAMILYACTIVITY, Name="No Hacer Caso 2", Details = "", points = -100 }
            );
        }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlite("Data Source=FamilyCoins.db;");
        // }
    }
}