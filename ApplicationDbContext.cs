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

            public DbSet<Pet> Pets { get; set; }
    }
}
