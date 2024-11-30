using MentorProject.Configs;
using MentorProject.Entities.AppdbContextEntity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MentorProject.Context
{
    public class AppDbContext: DbContext  //DbContext-databazani temsil edir
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly); //reflectiondan gedir tapir getirir
           // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
           // modelBuilder.ApplyConfiguration(new SchoolConfiguration()); //

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(x => x.Name).IsRequired()
                                       .HasMaxLength(100);
                entity.Property(x=>x.Surname).IsRequired()
                                             .HasMaxLength(100);
                entity.Property(x=>x.Email).IsRequired()
                                           .HasMaxLength(100);
  
            });
            modelBuilder.Entity<Student>()
                               .HasOne(x => x.School)
                               .WithMany(x => x.Students)
                               .HasForeignKey(x => x.SchoolId)
                               .OnDelete(DeleteBehavior.Cascade);

            
           


           
        }
    }
}

 
