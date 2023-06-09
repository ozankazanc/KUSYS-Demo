﻿using KUSYS.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace KUSYS.Entities.Concrete
{
    public class Student : EntityBase, IEntity
    {
        public DateTime StartDate { get; set; }
        public string AcademicLevel { get; set; }
        public int PersonId { get; set; }
        public int DepartmentId { get; set; }
        public Person Person { get; set; }
        public Department Department { get; set; }
    }
}
