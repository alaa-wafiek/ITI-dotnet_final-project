namespace GraduationITI.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }
        public string Prerequisite { get; set; }
        public int InstructorID { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }
}
