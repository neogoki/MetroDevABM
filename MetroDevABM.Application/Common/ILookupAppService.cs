using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;

namespace MetroDevABM.Common
{
    public interface ILookupAppService : IApplicationService
    {
        Task<ListResultDto<ComboboxItemDto>> GetGenderComboboxItems();
        Task<ListResultDto<ComboboxItemDto>> GetClientTypeComboboxItems();
    }
}