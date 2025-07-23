using CodeFirstRelation.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<UserEntity>Users { get; set; }

        public DbSet<PostEntity> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PatikaCodeFirstDb2;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //İlişkileri tanımlama 
            modelBuilder.Entity<PostEntity>()
                .HasOne(p => p.User) //Her postun yalnızca bir usera aittir.
                .WithMany(u => u.Posts) //Bir userın birden fazla postu olabilir.
                .HasForeignKey(p => p.UserId); //Postların yazarı UserId ile belirlenir 
        }
    }
}
