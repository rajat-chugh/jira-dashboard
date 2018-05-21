using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JiraDashboard.Roles.Dto;
using JiraDashboard.Users.Dto;

namespace JiraDashboard.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
