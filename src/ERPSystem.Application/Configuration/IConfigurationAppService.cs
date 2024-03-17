using System.Threading.Tasks;
using ERPSystem.Configuration.Dto;

namespace ERPSystem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
