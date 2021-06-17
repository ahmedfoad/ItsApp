using System.Threading.Tasks;
using ItsApp.Configuration.Dto;

namespace ItsApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
