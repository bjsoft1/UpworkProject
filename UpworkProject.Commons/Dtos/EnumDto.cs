namespace UpworkProject.Commons.Dtos
{
    public class EnumDto//<EnumClass> where EnumClass : Enum
    {
        public string DisplayName { get; set; }
        public int Id { get; set; }
    }
}
