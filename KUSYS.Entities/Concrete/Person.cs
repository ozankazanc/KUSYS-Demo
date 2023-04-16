using KUSYS.Shared.Entities.Abstract;
using System;

namespace KUSYS.Entities.Concrete
{
    public class Person : EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
    }
}
