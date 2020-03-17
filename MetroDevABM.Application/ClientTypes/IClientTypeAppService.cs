using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MetroDevABM.ClientTypes.Dto;

namespace MetroDevABM.ClientTypes
{
    public interface IClientTypeAppService : IApplicationService
    {
        Task<ListResultDto<ClientTypeListDto>> GetAll();
        Task Create(CreateClientTypeInput input);
        Task<ClientTypeDto> Get(int id);
        Task Update(ClientTypeDto ClientType);
        Task Delete(int id);
    }
}