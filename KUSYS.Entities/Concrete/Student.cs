using KUSYS.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KUSYS.Entities.Concrete
{
    public class Student : EntityBase,IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate{ get; set; }
        public string Address { get; set; }
    }
}
