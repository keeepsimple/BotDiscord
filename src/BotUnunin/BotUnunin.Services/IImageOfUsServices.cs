using BotUnunin.Models;
using BotUnunin.Services.BaseServices;

namespace BotUnunin.Services
{
    public interface IImageOfUsServices : IBaseServices<ImageOfUs>
    {
        Task<IEnumerable<ImageOfUs>> GetImageByLoveId(int id);
    }
}