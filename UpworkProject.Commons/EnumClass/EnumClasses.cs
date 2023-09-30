using System.ComponentModel.DataAnnotations;

namespace UpworkProject.Commons.EnumClass
{
    public enum EDataStatus
    {
        [Display(Name = "Active")]
        Active = 0,
        [Display(Name = "Disabled")]
        Disabled = 1,
        [Display(Name = "Deleted")]
        Deleted = 2,
    }
    /// <summary>
    /// Display Value Used For Html input types
    /// </summary>
    public enum EDynamicControlTypes
    {
        [Display(Name = "text")]
        TextBox = 0,
        [Display(Name = "checkbox")]
        CheckBox = 1,
        [Display(Name = "radio")]
        RadioButton = 2,
        [Display(Name = "select")]
        SelectionBox = 3,
        [Display(Name = "datetime")]
        DateTimePicker = 4,
        [Display(Name = "date")]
        DatePicker = 5,
        [Display(Name = "time")]
        TimePicker = 6,
        [Display(Name = "textarea")]
        DescritionsBox = 7,
    }
}
