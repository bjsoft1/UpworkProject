using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpworkProject.Dtos;
using UpworkProject.Dtos.DynamicControls;

namespace UpworkProject.Repositories.DynamicControls
{
    public interface IDynamicControlsRepositories : IBaseRepositories
    {
        Task<PaggedResultDto<DynamicControlAddUpdateDto>> GetDynamicControlPaginationListing(PaginationParameterDto paginationParameterDto);
        Task<List<DynamicControlAddUpdateDto>> GetDynamicControlListing();
        Task<DynamicControlAddUpdateDto?> GetDynamicControlDetails(int id);
    }
}
