using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using MetroDevABM.Clients.Dto;

namespace MetroDevABM.Clients
{
    public class ClientAppService : MetroDevABMAppServiceBase, IClientAppService
    {
        private readonly IRepository<Client> _ClientRepository;
        protected string ErrorMessage { get; set; }
        public ClientAppService(IRepository<Client> ClientRepository)
        {
            _ClientRepository = ClientRepository;
        }

        public async Task<ListResultDto<ClientListDto>> GetAll()
        {
            var Clients = await _ClientRepository
                .GetAllListAsync();

            return new ListResultDto<ClientListDto>(
                ObjectMapper.Map<List<ClientListDto>>(Clients)
            );
        }

        public async System.Threading.Tasks.Task Create(CreateClientInput input)
        {
            var Client = ObjectMapper.Map<Client>(input);
            await _ClientRepository.InsertAsync(Client);
        }

        public async Task<ClientDto> Get(int id)
        {
            var Client = await _ClientRepository.GetAsync(id);
            return ObjectMapper.Map<ClientDto>(Client);
        }

        public async Task Update(ClientDto Client)
        {
            try
            {
                var itemDb = await _ClientRepository.GetAsync(Client.Id);
                await _ClientRepository.UpdateAsync(ObjectMapper.Map(Client, itemDb));
            }
            catch (Exception ex)
            {
                ErrorMessage = L("ErrorAtUpdateInDB") + " [" + ex.Message +"]";
            }
        }
        public async Task Delete(int id)
        {
            try
            {
                var Client = await _ClientRepository.GetAsync(id);
                await _ClientRepository.DeleteAsync(Client);
            }
            catch (Exception ex)
            {
                ErrorMessage = L("ErrorAtDeleteInDB") + " [" + ex.Message + "]";
            }
        }
    }
}
