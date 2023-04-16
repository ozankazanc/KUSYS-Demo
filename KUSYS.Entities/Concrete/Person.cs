using KUSYS.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace KUSYS.Entities.Concrete
{
    public class Person : EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<Student> Students { get; set; }
    }
}
