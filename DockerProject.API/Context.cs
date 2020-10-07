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
            modelBuilder.Entity<Summary>().Property(m => m.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Summary>().HasData(new Summary[]
            {
                new Summary(1, "Freezing"), 
                new Summary(2, "Bracing"), 
                new Summary(3,"Chilly"), 
                new Summary(4,"Cool"), 
                new Summary(5,"Mild"), 
                new Summary(6,"Warm"), 
                new Summary(7,"Balmy"), 
                new Summary(8,"Hot"), 
                new Summary(9,"Sweltering"), 
                new Summary(10, "Scorching")
            });
        }
        
    }
}