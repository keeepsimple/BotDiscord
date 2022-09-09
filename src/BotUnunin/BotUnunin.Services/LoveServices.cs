using BotUnunin.Data.Infrastructure;
using BotUnunin.Models;
using BotUnunin.Services.BaseServices;

namespace BotUnunin.Services
{
    public class LoveServices : BaseServices<Love>, ILoveServices
    {
        public LoveServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}