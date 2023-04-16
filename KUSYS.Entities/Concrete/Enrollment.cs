using KUSYS.Shared.Entities.Abstract;

namespace KUSYS.Entities.Concrete
{
    public class Enrollment : EntityBase, IEntity
    {
        public int StudentId { get; set; }
        public int SectionId { get; set; }
        public Student Student { get; set; }
        public Section Section { get; set; }
        public char Grade { get; set; }
    }
}
