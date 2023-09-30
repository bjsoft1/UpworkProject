using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpworkProject.Commons.EnumClass;

namespace UpworkProject.Models
{
    public class BaseModel <Entity>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Entity Id { get; set; }
        public bool IsActive { get; set; }
        public EDataStatus Status { get; set; }
    }
}
