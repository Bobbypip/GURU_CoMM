using GURU_CoMM.Entities;
using Microsoft.EntityFrameworkCore;

namespace GURU_CoMM
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var pet1 = new Pet()
            {
                Id = 1,
                Name = "Luffy"
            };
            var pet2 = new Pet()
            {
                Id = 2,
                Name = "Ronny"
            };
            var pet3 = new Pet()
            {
                Id = 3,
                Name = "Senpai"
            };

            modelBuilder.Entity<Pet>().HasData(pet1);
            modelBuilder.Entity<Pet>().HasData(pet2);
            modelBuilder.Entity<Pet>().HasData(pet3);
        }

        public DbSet<Pet> Pets { get; set; }
    }
}
