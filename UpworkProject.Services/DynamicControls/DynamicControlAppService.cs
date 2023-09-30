using UpworkProject.Commons.EnumClass;
using UpworkProject.Dtos.DynamicControls;
using UpworkProject.Models.DynamicControls;
using UpworkProject.Repositories.Database;

namespace UpworkProject.Services.DynamicControls
{
    public class DynamicControlAppService : BaseAppService, IDynamicControlAppService
    {
        public DynamicControlAppService(ProjectDatabaseContext databse) : base(databse) { }
        public async Task<DynamicControl> AddDyanmicControl(DynamicControlAddUpdateDto addUpdateDto)
        {
            var data = await _database.DynamicControls.AddAsync(new DynamicControl
            {
                ControlIdentity = addUpdateDto.ControlIdentity,
                ControlType = addUpdateDto.ControlType,
                CreationTime = DateTime.Now,
                LabelDate = addUpdateDto.LabelDate,
                Options = string.Join(",", addUpdateDto.Options ?? new List<string>()),
                OrderNumber = addUpdateDto.OrderNumber,
                Status = EDataStatus.Active,
            });

            return data.Entity;
        }
        public Task<DynamicControl> UpdateDyanmicControl(int id, DynamicControlAddUpdateDto addUpdateDto)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteDyanmicControl(int id)
        {
            throw new NotImplementedException();
        }
    }
}
