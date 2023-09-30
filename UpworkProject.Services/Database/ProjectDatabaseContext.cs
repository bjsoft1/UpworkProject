using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UpworkProject.Commons.EnumClass;
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
        private void SeedingDate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DynamicControl>().HasData(GetDynamicControls());
        }


        private List<DynamicControl> GetDynamicControls()
        {
            return new List<DynamicControl>
            {
                new DynamicControl { ControlIdentity = "FullName", ControlType = EDynamicControlTypes.TextBox, LabelDate = "What is your name?", OrderNumber = 1, Status = EDataStatus.Active},
                new DynamicControl { ControlIdentity = "Gender", ControlType = EDynamicControlTypes.RadioButton, LabelDate = "What is your gender?", OrderNumber = 2, Status = EDataStatus.Active},
                new DynamicControl { ControlIdentity = "Hobbies", ControlType = EDynamicControlTypes.CheckBox, LabelDate = "What is your hobbies?", OrderNumber = 3, Status = EDataStatus.Active},
            };
        }
    }
}
