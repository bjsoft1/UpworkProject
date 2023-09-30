using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UpworkProject.Models.DynamicControls;

namespace UpworkProject.Services.Database
{
    public class ProjectDatabaseContext : DbContext
    {
        public ProjectDatabaseContext(DbContextOptions<ProjectDatabaseContext> options) : base(options)
        {
     
        }
        
        public DbSet<DynamicControl> DynamicControls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DynamicControl>(entity =>
            {
                entity.ToTable(nameof(DynamicControls));
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).UseIdentityColumn(seed: 1, increment: 1);
                entity.Property(e => e.OrderNumber).IsRequired();
                entity.Property(e => e.ControlIdentity).IsRequired();
                entity.Property(e => e.LabelDate).IsRequired();
                entity.Property(e => e.OptionsSerialized).HasColumnName("Options");
            });

        }
    }
}
