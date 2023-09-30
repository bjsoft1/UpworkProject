using Microsoft.EntityFrameworkCore;
using UpworkProject.Repositories.Database;
using UpworkProject.Repositories.DynamicControls;
using UpworkProject.Services.DynamicControls;
using UpworkProject.Services.ParticipaintInformations;

namespace UpworkProject.Web.Extensions
{
    public static class ConfigurationExtensions
    {
        public static void ProjectConfigurations(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ProjectDatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services
                .AddScoped<IDynamicControlAppService, DynamicControlAppService>()
                .AddScoped<IDynamicControlsRepositories, DynamicControlsRepositories>()
                .AddScoped<IParticipaintInformationsAppService, ParticipaintInformationsAppService>()
                ;
        }
    }
}
