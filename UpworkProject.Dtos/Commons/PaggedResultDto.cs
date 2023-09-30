using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpworkProject.Dtos
{
    public class PaggedResultDto<TEntity> where TEntity : class
    {
        public List<TEntity> Results { get; set; } = new List<TEntity>();
        public int TotalCount { get; set; }
    }
    public class PaginationParameterDto
    {
        public int MaxCount { get; set; } = 10;
        public int SkipCount { get; set; } = 0;
        public string SearchKeyword { get; set; }
        public string SortType { get; set; } = "des";
        public string OrderBy { get; set; }
        public bool IsAdvanceFilter { get; set; }
    } 
}
