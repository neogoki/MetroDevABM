using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MetroDevABM.Clients.Dto;

namespace MetroDevABM.Clients
{
    public interface IClientAppService : IApplicationService
    {
        Task<ListResultDto<ClientListDto>> GetAll();
        Task Create(CreateClientInput input);
        Task<ClientDto> Get(int id);
        Task Update(ClientDto Client);
        Task Delete(int id);
    }
}