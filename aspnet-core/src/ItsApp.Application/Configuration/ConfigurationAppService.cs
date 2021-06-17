using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ItsApp.Configuration.Dto;

namespace ItsApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ItsAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
