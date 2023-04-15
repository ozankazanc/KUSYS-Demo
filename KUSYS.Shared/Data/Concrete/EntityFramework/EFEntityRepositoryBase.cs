using KUSYS.Shared.Data.Abstract;
using KUSYS.Shared.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace KUSYS.Shared.Data.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<Tentity> : IEntityRepository<Tentity>
         where Tentity : class, IEntity, new()
    {
        protected readonly DbContext _context;
        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }
        public Tentity Add(Tentity entity)
        {
            _context.Set<Tentity>().Add(entity);
            return entity;
        }

        public void Delete(Tentity entity)
        {
            _context.Set<Tentity>().Remove(entity);
        }

        public IList<Tentity> GetAll(Expression<Func<Tentity, bool>> predicate = null, params Expression<Func<Tentity, object>>[] includeProporties)
        {
            IQueryable<Tentity> query = _context.Set<Tentity>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeProporties.Any())
            {
                foreach (var includeProperty in includeProporties)
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.ToList();
        }

        public Tentity Get(Expression<Func<Tentity, bool>> predicate, params Expression<Func<Tentity, object>>[] includeProporties)
        {
            IQueryable<Tentity> query = _context.Set<Tentity>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeProporties.Any())
            {
                foreach (var includeProperty in includeProporties)
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.SingleOrDefault();
        }

        public Tentity Update(Tentity entity)
        {
            _context.Set<Tentity>().Update(entity);
            return entity;
        }
    }
}
