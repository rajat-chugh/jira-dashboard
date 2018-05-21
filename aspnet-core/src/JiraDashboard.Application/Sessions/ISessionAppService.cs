using System.Threading.Tasks;
using Abp.Application.Services;
using JiraDashboard.Sessions.Dto;

namespace JiraDashboard.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
