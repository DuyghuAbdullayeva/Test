using MentorProject.Entities.Common;

namespace MentorProject.Entities.AppdbContextEntity
{
    public class Student:BaseEntity
    {
        public string Name {  get; set; }
        public string Surname { get; set; }
        public string Email {  get; set; }
        public int SchoolId {  get; set; }
        public School School { get; set; }
    }
}
