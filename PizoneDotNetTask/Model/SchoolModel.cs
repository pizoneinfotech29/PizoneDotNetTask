using System.Security.Claims;

namespace PizoneDotNetTask.Model
{
    public class SchoolModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int NoOfClass { get; set; }
        //public List<Class> Classes { get; set; }
    }
}
