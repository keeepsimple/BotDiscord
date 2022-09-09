using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BotUnunin.Data.Infrastructure.Repositories
{
    public class CoreRepository<Entity> : ICoreRepository<Entity> where Entity : class
    {
        protected readonly UnuninContext _context;
        private readonly DbSet<Entity> DbSet;

        public CoreRepository(UnuninContext context)
        {
            _context = context;
            //Find property with typeof(T) on dataContext
            var typeOfDbSet = typeof(DbSet<Entity>);
            foreach (var prop in context.GetType().GetProperties())
            {
                if (typeOfDbSet == prop.PropertyType)
                {
                    DbSet = prop.GetValue(context, null) as DbSet<Entity>;
                    break;
                }
            }

            if (DbSet == null)
            {
                DbSet = context.Set<Entity>();
            }
        }

        public async Task AddAsync(Entity entity)
        {
            await DbSet.AddAsync(entity);
        }

        public void Delete(Entity entity)
        {
            DbSet.Remove(entity);
        }

        public async Task<Entity> GetByIdAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public IQueryable<Entity> GetQuery()
        {
            return DbSet;
        }

        public IQueryable<Entity> GetQuery(Expression<Func<Entity, bool>> where)
        {
            return DbSet.Where(where);
        }

        public void Update(Entity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
