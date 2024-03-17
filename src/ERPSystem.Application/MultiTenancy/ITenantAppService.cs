using Abp.Application.Services;
using ERPSystem.MultiTenancy.Dto;

namespace ERPSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

