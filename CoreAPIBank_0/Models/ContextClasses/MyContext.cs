using CoreAPIBank_0.Models.Entities;
using CoreAPIBank_0.Models.Seed;
using Microsoft.EntityFrameworkCore;

namespace CoreAPIBank_0.Models.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> opt) : base(opt) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

        public DbSet<UserCardInfo>  CardInfoes { get; set; }
    }
}
