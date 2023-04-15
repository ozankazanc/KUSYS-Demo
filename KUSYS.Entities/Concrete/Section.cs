using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Entities.Concrete
{
    public class Section
    {
        public Semester Semester { get; set; }
        public int Year { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public enum Semester
    {
        Fall = 1,
        Spring = 2
    }
}
