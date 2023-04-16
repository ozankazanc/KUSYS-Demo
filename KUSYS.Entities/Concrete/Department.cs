using KUSYS.Shared.Entities.Abstract;
using System.Collections.Generic;

namespace KUSYS.Entities.Concrete
{
    public class Department : EntityBase, IEntity
    {
        public int Name { get; set; }
        public char Code { get; set; }   
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<Course> Courses { get; set; }
    }
}
