using BotUnunin.Data.Infrastructure.Repositories;
using BotUnunin.Models;

namespace BotUnunin.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UnuninContext _dbContext;
        public UnuninContext UnuninContext => _dbContext;

        public UnitOfWork(UnuninContext dbContext)
        {
            _dbContext = dbContext;
        }

        private ICoreRepository<Love> _loveRepository;
        public ICoreRepository<Love> LoveRepository => _loveRepository ?? new CoreRepository<Love>(_dbContext);

        private ICoreRepository<ImageOfUs> _imageOfUsRepository;
        public ICoreRepository<ImageOfUs> ImageOfUsRepository => _imageOfUsRepository ?? new CoreRepository<ImageOfUs>(_dbContext);

        public ICoreRepository<T> CoreRepository<T>() where T : class
        {
            return new CoreRepository<T>(_dbContext);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
