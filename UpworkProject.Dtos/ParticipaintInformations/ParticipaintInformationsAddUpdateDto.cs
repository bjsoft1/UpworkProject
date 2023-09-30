using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpworkProject.Dtos.ParticipaintInformations
{
    public class ParticipaintInformationsAddUpdateDto
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public List<string> Hobbies { get; set; }
        public DateTime? CurrentDateTime { get; set; }
        public DateTime? CurrentDate { get; set; }
        public DateTime? CurrentTime { get; set; }
        public string Message { get; set; }
    }
}
