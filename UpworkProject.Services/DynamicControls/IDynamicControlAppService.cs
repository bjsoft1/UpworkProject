
using UpworkProject.Dtos.DynamicControls;
using UpworkProject.Models.DynamicControls;

namespace UpworkProject.Services.DynamicControls
{
    public interface IDynamicControlAppService : IBaseAppService
    {
        Task<DynamicControl> AddDyanmicControl(DynamicControlAddUpdateDto addUpdateDto);
        Task<DynamicControl> UpdateDyanmicControl(int id,DynamicControlAddUpdateDto addUpdateDto);
        Task<bool> DeleteDyanmicControl(int id);
    }
}
