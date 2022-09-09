using BotUnunin.Data.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BotUnunin.Services.BaseServices
{
    public class BaseServices<T> : IBaseServices<T> where T : class
    {
        protected readonly IUnitOfWork _unitOfWork;

        public BaseServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public virtual async Task<int> AddAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            await _unitOfWork.CoreRepository<T>().AddAsync(entity);
            return await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _unitOfWork.CoreRepository<T>().GetByIdAsync(id);
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            _unitOfWork.CoreRepository<T>().Delete(entity);
            return await _unitOfWork.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            _unitOfWork.CoreRepository<T>().Delete(entity);
            return await _unitOfWork.SaveChangesAsync() > 0;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _unitOfWork.CoreRepository<T>().GetQuery().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _unitOfWork.CoreRepository<T>().GetByIdAsync(id);
        }

        public virtual async Task<bool> UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            _unitOfWork.CoreRepository<T>().Update(entity);
            return await _unitOfWork.SaveChangesAsync() > 0;
        }
    }
}
