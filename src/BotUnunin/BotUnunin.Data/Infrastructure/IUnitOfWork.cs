using BotUnunin.Data.Infrastructure.Repositories;
using BotUnunin.Models;

namespace BotUnunin.Data.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        UnuninContext UnuninContext { get; }

        Task<int> SaveChangesAsync();

        ICoreRepository<T> CoreRepository<T>() where T : class;

        #region Master Data

        ICoreRepository<Love> LoveRepository { get; }

        ICoreRepository<ImageOfUs> ImageOfUsRepository { get; }

        #endregion
    }
}
