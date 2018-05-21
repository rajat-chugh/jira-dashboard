using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
//using JiraDashboard.Sessions.Dto;
using JiraDashboard.JiraFeatures.Dto;


namespace JiraDashboard.JiraFeatures
{
    public interface IJiraFeatureAppService : IApplicationService
    {
       // Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task <Backlog>  GetAll();

    }
}
