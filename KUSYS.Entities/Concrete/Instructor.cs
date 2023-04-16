using KUSYS.Shared.Entities.Abstract;
using System;

namespace KUSYS.Entities.Concrete
{
    public class Instructor : EntityBase, IEntity
    {
        public DateTime StartDate { get; set; }
        public int PersonId { get; set; }
        public int DepartmantId { get; set; }
        public Person Person { get; set; }
        public Department Department { get; set; }
    }
}
