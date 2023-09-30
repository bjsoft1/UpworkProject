using Microsoft.EntityFrameworkCore;
using UpworkProject.Services.Database;

namespace UpworkProject.Web.Extensions
{
    public static class ConfigurationExtensions
    {
        public static void ProjectConfigurations(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ProjectDatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
