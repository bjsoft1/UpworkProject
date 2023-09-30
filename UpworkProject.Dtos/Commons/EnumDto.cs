namespace UpworkProject.Dtos.Commons
{
    public class EnumDto<EnumClass> where EnumClass : Enum
    {
        public EnumClass Value { get; set; }
        public string DisplayName { get; set; }
        public int Id { get; set; }
    }
}
