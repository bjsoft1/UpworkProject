using UpworkProject.Commons.Dtos;
using UpworkProject.Commons.EnumClass;

namespace UpworkProject.Dtos.DynamicControls
{
    public class DynamicControlAddUpdateDto
    {
        public int OrderNumber { get; set; }
        public string ControlIdentity { get; set; }
        public string LabelDate { get; set; }
        public EDynamicControlTypes ControlType { get; set; }
        public EnumDto? ControlTypeDto { get; set; }
        public List<string>? Options { get; set; }
    }
}
