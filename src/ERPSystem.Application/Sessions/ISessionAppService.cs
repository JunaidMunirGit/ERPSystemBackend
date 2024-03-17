using System.Threading.Tasks;
using Abp.Application.Services;
using ERPSystem.Sessions.Dto;

namespace ERPSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
