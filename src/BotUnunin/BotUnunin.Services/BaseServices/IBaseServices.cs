namespace BotUnunin.Services.BaseServices
{
    public interface IBaseServices<T>
    {
        Task<int> AddAsync(T entity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(int id);

        Task<bool> DeleteAsync(T entity);

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();
    }
}
