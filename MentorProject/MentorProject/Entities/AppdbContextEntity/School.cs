using MentorProject.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace MentorProject.Entities.AppdbContextEntity
{
    public class School:BaseEntity
    {
        [Required] 
        public string Name { get; set; }
        public string Number { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
