using BotUnunin.Data.Infrastructure;
using BotUnunin.Models;
using BotUnunin.Services.BaseServices;
using Microsoft.EntityFrameworkCore;

namespace BotUnunin.Services
{
    public class ImageOfUsServices : BaseServices<ImageOfUs>, IImageOfUsServices
    {
        public ImageOfUsServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<IEnumerable<ImageOfUs>> GetImageByLoveId(int id)
        {
            return await _unitOfWork.ImageOfUsRepository.GetQuery(x => x.LoveId == id).ToListAsync();
        }
    }
}