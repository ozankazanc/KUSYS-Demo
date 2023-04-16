using KUSYS.Shared.Entities.Abstract;

namespace KUSYS.Entities.Concrete
{
    public class Section : EntityBase, IEntity
    {
        public int Semester { get; set; }
        public int Year { get; set; }
        public int Capacity { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }

    public enum Semester
    {
        Fall = 1,
        Spring = 2
    }
}
