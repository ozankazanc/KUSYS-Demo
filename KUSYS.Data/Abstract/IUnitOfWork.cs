using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Data.Abstract
{
    interface IUnitOfWork : IDisposable
    {
        public ICourseRepository Courses { get; }
        public IDepartmentRepository Departments { get; }
        public IEnrollmentRepository Enrollments { get; }
        public IInstructorRepository Instructor { get; }
        public IPersonRepository Person { get; }
        public ISectionRepository Section { get; }
        public IStudentRepository Student { get; }
        public void Save();

    }
}
