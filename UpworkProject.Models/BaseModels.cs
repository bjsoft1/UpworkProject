using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UpworkProject.Commons.EnumClass;

namespace UpworkProject.Models
{
    public class BaseModel <Entity>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Entity Id { get; set; }
        public bool IsActive { get; set; }
        public EDataStatus Status { get; set; }
    }
}
