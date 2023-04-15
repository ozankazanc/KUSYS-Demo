using KUSYS.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProporties);
        IList<T> GetAll(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProporties);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
