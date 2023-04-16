using KUSYS.Data.Abstract;
using KUSYS.Entities.Concrete;
using KUSYS.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace KUSYS.Data.Concrete.EntityFramework.Repositories
{
    public class EFPersonRepository : EfEntityRepositoryBase<Person>, IStudentRepository
    {
        public EFPersonRepository(DbContext context) : base(context)
        {

        }
    }
}
