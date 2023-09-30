using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpworkProject.Commons.EnumClass;
using UpworkProject.Commons.Extensions;
using UpworkProject.Dtos;
using UpworkProject.Dtos.DynamicControls;
using UpworkProject.Repositories.Database;

namespace UpworkProject.Repositories.DynamicControls
{
    public class DynamicControlsRepositories : BaseRepositories, IDynamicControlsRepositories
    {
        private readonly ProjectDatabaseContext _databse;
        public DynamicControlsRepositories(ProjectDatabaseContext databse)
        {
            _databse = databse;
        }

        public async Task<DynamicControlAddUpdateDto?> GetDynamicControlDetails(int id)
        {
            var data = await _databse.DynamicControls.FindAsync(id);
            if (data != null)
                return new DynamicControlAddUpdateDto
                {
                    ControlIdentity = data.ControlIdentity,
                    ControlType = data.ControlType,
                    ControlTypeDto = new Commons.Dtos.EnumDto
                    {
                        DisplayName = data.ControlType.GetDisplayValue()
                    },
                    LabelDate = data.LabelDate,
                    Options = data.Options?.Split(',').ToList(),
                    OrderNumber = data.OrderNumber,
                };
            return null;
        }

        public async Task<List<DynamicControlAddUpdateDto>> GetDynamicControlListing()
        {
            var data = await Task.FromResult(_databse.DynamicControls.Where(x=> (x.Status == EDataStatus.Active)).Select(x => new 
            {
                ControlIdentity = x.ControlIdentity,
                ControlType = x.ControlType,
                LabelDate = x.LabelDate,
                Options = x.Options,
                OrderNumber = x.OrderNumber,
            }).ToList());

            return data.Select(x => new DynamicControlAddUpdateDto
            {
                ControlIdentity = x.ControlIdentity,
                ControlType = x.ControlType,
                ControlTypeDto = EnumExtensions.GetValueDto(x.ControlType),
                LabelDate = x.LabelDate,
                Options = x.Options?.Split(',').ToList(),
                OrderNumber = x.OrderNumber,
            }).ToList();
        }
        public async Task<PaggedResultDto<DynamicControlAddUpdateDto>> GetDynamicControlPaginationListing(PaginationParameterDto paginationParameterDto)
        {
            var query = _databse.DynamicControls.Where(x => x.Status == EDataStatus.Active || x.Status == EDataStatus.Disabled);

            if (!paginationParameterDto.SearchKeyword.IsNullOrWhiteSpace())
                query = query.Where(x => x.ControlIdentity.Contains(paginationParameterDto.SearchKeyword.Trim()));
            var count = query.CountAsync();
            var data = await Task.FromResult(query.Select(x => new
            {
                ControlIdentity = x.ControlIdentity,
                ControlType = x.ControlType,
                LabelDate = x.LabelDate,
                Options = x.Options,
                OrderNumber = x.OrderNumber,
            }).Skip(paginationParameterDto.SkipCount).Take(paginationParameterDto.MaxCount).ToList());

            return new PaggedResultDto<DynamicControlAddUpdateDto>
            {
                TotalCount = count.Result,
                Results = data.Select(x => new DynamicControlAddUpdateDto
                {
                    ControlIdentity = x.ControlIdentity,
                    ControlType = x.ControlType,
                    ControlTypeDto = EnumExtensions.GetValueDto(x.ControlType),
                    LabelDate = x.LabelDate,
                    Options = x.Options?.Split(',').ToList(),
                    OrderNumber = x.OrderNumber,
                }).ToList()
            };
        }
    }
}
