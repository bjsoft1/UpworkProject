using UpworkProject.Dtos.ParticipaintInformations;
using UpworkProject.Models.DynamicControls;

namespace UpworkProject.Services.ParticipaintInformations
{
    public interface IParticipaintInformationsAppService : IBaseAppService
    {
        Task<ParticipaintInformation> AddParticipaintInformation(ParticipaintInformationsAddUpdateDto addUpdateDto);
        Task<ParticipaintInformation> UpdateParticipaintInformation(int id, ParticipaintInformationsAddUpdateDto addUpdateDto);
        Task<bool> DeleteParticipaintInformation(int id);
    }
}
