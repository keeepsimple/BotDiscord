using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BotUnunin.Data.Infrastructure.Repositories
{
    public interface ICoreRepository<Entity>
    {
        Task<Entity> GetByIdAsync(int id);

        Task AddAsync(Entity entity);

        void Delete(Entity entity);

        IQueryable<Entity> GetQuery();

        IQueryable<Entity> GetQuery(Expression<Func<Entity, bool>> where);

        void Update(Entity entity);
    }
}
