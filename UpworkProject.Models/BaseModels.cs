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
        public EDataStatus Status { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
