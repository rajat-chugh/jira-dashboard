using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JiraDashboard.MultiTenancy.Dto;

namespace JiraDashboard.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
