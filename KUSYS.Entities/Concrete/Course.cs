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
        public string Name { get; set; }
        public int Credit { get; set; }
        public int StudentCapacity { get; set; }
    }
}
