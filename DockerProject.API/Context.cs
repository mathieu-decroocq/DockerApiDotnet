using Microsoft.EntityFrameworkCore;

namespace DockerProject.API
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {}
        
        public DbSet<Summary> Summaries { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Summary>().ToTable("Summary");
        }
        
    }
}