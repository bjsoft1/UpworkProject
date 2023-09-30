using UpworkProject.Dtos.DynamicControls;
using UpworkProject.Dtos.ParticipaintInformations;
using UpworkProject.Models.DynamicControls;
using UpworkProject.Repositories.Database;

namespace UpworkProject.Services.ParticipaintInformations
{
    public class ParticipaintInformationsAppService : BaseAppService, IParticipaintInformationsAppService
    {
        public ParticipaintInformationsAppService(ProjectDatabaseContext databaseContext) : base(databaseContext) { }

        public async Task<ParticipaintInformation> AddParticipaintInformation(ParticipaintInformationsAddUpdateDto addUpdateDto)
        {
            var data = _database.ParticipaintInformations.AddAsync(new ParticipaintInformation
            {
                Country = addUpdateDto.Country,
                CreationTime = DateTime.Now,
                CurrentDate = addUpdateDto.CurrentDate,
                CurrentDateTime = addUpdateDto.CurrentDateTime,
                CurrentTime = addUpdateDto.CurrentTime,
                FullName = addUpdateDto.FullName,
                Gender = addUpdateDto.Gender,
                Hobbies = string.Join(',', addUpdateDto.Hobbies ?? new List<string>()),
                Message = addUpdateDto.Message,
                Status = Commons.EnumClass.EDataStatus.Active,
            });

            return data.Result.Entity;
        }

        public async Task<bool> DeleteParticipaintInformation(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ParticipaintInformation> UpdateParticipaintInformation(int id, ParticipaintInformationsAddUpdateDto addUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
