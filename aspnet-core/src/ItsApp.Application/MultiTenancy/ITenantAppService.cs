using Abp.Application.Services;
using ItsApp.MultiTenancy.Dto;

namespace ItsApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

