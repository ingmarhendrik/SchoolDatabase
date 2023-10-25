using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Class
    {
        [Key]
        public Guid Id { get; set; }
        public string ClassName { get; set; }
        public List<Student> Students { get; set; }

    }
}