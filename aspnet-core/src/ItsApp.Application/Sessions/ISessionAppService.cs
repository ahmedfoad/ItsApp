using System.Threading.Tasks;
using Abp.Application.Services;
using ItsApp.Sessions.Dto;

namespace ItsApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
