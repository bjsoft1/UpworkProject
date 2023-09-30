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
        public DbSet<ParticipaintInformation> ParticipaintInformations { get; set; }

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
            modelBuilder.Entity<ParticipaintInformation>(entity =>
            {
                entity.ToTable(nameof(ParticipaintInformations));
                entity.Property(e => e.Id).UseIdentityColumn(seed: 1, increment: 1).HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn); ;
                entity.Property(e => e.FullName).IsRequired(false);
                entity.Property(e => e.Gender).IsRequired(false);
                entity.Property(e => e.Country).IsRequired(false);
                entity.Property(e => e.HobbiesSerialized).HasColumnName("Hobbies");
                entity.Property(e => e.CurrentDateTime).IsRequired(false);
                entity.Property(e => e.CurrentDate).IsRequired(false);
                entity.Property(e => e.CurrentTime).IsRequired(false);
                entity.Property(e => e.Message).IsRequired(false);
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
                new DynamicControl { Id = 4, ControlIdentity = "Country", ControlType = EDynamicControlTypes.SelectionBox, LabelDate = "What is your country name?", OrderNumber = 4, Status = EDataStatus.Active, Options = new List<string>{"Nepal", "India", "China", "USA", "Korea", "Japan", "Pakistan"} },
                new DynamicControl { Id = 5, ControlIdentity = "CurrentDateTime", ControlType = EDynamicControlTypes.DateTimePicker, LabelDate = "What is your current date time?", OrderNumber = 5, Status = EDataStatus.Active},
                new DynamicControl { Id = 6, ControlIdentity = "CurrentDate", ControlType = EDynamicControlTypes.DatePicker, LabelDate = "What is your current date?", OrderNumber = 6, Status = EDataStatus.Active},
                new DynamicControl { Id = 7, ControlIdentity = "CurrentTime", ControlType = EDynamicControlTypes.TimePicker, LabelDate = "What is your current time?", OrderNumber = 7, Status = EDataStatus.Active},
                new DynamicControl { Id = 8, ControlIdentity = "Message", ControlType = EDynamicControlTypes.DescritionsBox, LabelDate = "What is your message for us?", OrderNumber = 8, Status = EDataStatus.Active},
            };
        }
    }
}
