using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UpworkProject.Commons.EnumClass;

namespace UpworkProject.Models.DynamicControls
{
    public class DynamicControl : BaseModel<int>
    {
        public int OrderNumber { get; set; }
        [Required]
        public string ControlIdentity { get; set; }
        [Required]
        public string LabelDate { get; set; }
        public EDynamicControlTypes ControlType { get; set; }
        [NotMapped]
        public List<string> Options { get; set; }
        public string OptionsSerialized
        {
            get => Options != null ? string.Join(',', Options) : "";
            set => Options = value?.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList() ?? new List<string>();
        }
    }
    //public class DynamicControlOption : BaseModel<int>
    //{
    //    [Required]
    //    public string OptionsName { get; set; }
    //    public DynamicControl DynamicControl { get; set; }
    //    public int DynamicControlId { get; set; }
    //}
}
