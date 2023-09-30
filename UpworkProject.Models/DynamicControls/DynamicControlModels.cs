using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UpworkProject.Commons.EnumClass;

namespace UpworkProject.Models.DynamicControls
{
    public class DynamicControl : BaseModel<int>
    {
        public int? Id { get; set; }
        public int OrderNumber { get; set; }
        [Required]
        public string ControlIdentity { get; set; }
        [Required]
        public string LabelDate { get; set; }
        public EDynamicControlTypes ControlType { get; set; }
        public string Options { get; set; }
    }
}
