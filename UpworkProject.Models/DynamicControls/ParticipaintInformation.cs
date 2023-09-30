
namespace UpworkProject.Models.DynamicControls
{
    public class ParticipaintInformation : BaseModel<int>
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string Hobbies { get; set; }
        //public List<string> Hobbies { get; set; }
        //public string HobbiesSerialized
        //{
        //    get => Hobbies != null ? string.Join(',', Hobbies) : "";
        //    set => Hobbies = value?.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList() ?? new List<string>();
        //}
        public DateTime? CurrentDateTime { get; set; }
        public DateTime? CurrentDate { get; set; }
        public DateTime? CurrentTime { get; set; }
        public string Message { get; set; }
    }
}
