using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Entities.Concrete
{
    public class Course
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public bool Description { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
