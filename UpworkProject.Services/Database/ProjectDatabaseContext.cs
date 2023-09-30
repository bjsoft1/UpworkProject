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
                entity.Property(e => e.Id).UseIdentityColumn(seed: 1, increment: 1).HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn); ;
                entity.Property(e => e.OrderNumber).IsRequired();
                entity.Property(e => e.ControlIdentity).IsRequired();
                entity.Property(e => e.LabelDate).IsRequired();
                entity.Property(e => e.OptionsSerialized).HasColumnName("Options");
            });

            this.SeedingDate(modelBuilder);
        }
        private void SeedingDate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DynamicControl>().HasData(GetDynamicControls());
        }


        private List<DynamicControl> GetDynamicControls()
        {
            return new List<DynamicControl>
            {
                new DynamicControl { Id = 1, ControlIdentity = "FullName", ControlType = EDynamicControlTypes.TextBox, LabelDate = "What is your name?", OrderNumber = 1, Status = EDataStatus.Active},
                new DynamicControl { Id = 2, ControlIdentity = "Gender", ControlType = EDynamicControlTypes.RadioButton, LabelDate = "What is your gender?", OrderNumber = 2, Status = EDataStatus.Active, Options = new List<string> { "Male", "Female" }},
                new DynamicControl { Id = 3, ControlIdentity = "Hobbies", ControlType = EDynamicControlTypes.CheckBox, LabelDate = "What is your hobbies?", OrderNumber = 3, Status = EDataStatus.Active, Options = new List<string> { "Music", "Movies" ,"Sports" } },
            };
        }
    }
}
