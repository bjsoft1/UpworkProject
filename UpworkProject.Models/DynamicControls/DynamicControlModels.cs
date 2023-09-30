using System.ComponentModel.DataAnnotations;
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
        public DynamicControlOption DynamicControlOptions { get; set; }
    }
    public class DynamicControlOption : BaseModel<int>
    {
        [Required]
        public string OptionsName { get; set; }
        public DynamicControl DynamicControl { get; set; }
        public int DynamicControlId { get; set; }
    }
}
