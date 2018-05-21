using System.Threading.Tasks;
using JiraDashboard.Configuration.Dto;

namespace JiraDashboard.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
