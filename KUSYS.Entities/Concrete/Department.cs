using KUSYS.Shared.Entities.Abstract;

namespace KUSYS.Entities.Concrete
{
    public class Department : EntityBase, IEntity
    {
        public int Name { get; set; }
        public char Code { get; set; }   
    }
}
