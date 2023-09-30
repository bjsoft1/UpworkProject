using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpworkProject.Repositories.Database;

namespace UpworkProject.Services
{
    public interface IBaseAppService
    {
        Task<bool> CurrentUnitSaveChangeAsync();
    }
    public class BaseAppService : IBaseAppService
    {
        protected readonly ProjectDatabaseContext _database;
        public BaseAppService(ProjectDatabaseContext database)
        {
            _database = database;
        }
        public async Task<bool> CurrentUnitSaveChangeAsync()
        {
            return await _database.SaveChangesAsync() > 0;
        }
    }
}
