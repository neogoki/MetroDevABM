using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using MetroDevABM.ClientTypes.Dto;

namespace MetroDevABM.ClientTypes
{
    public class ClientTypeAppService : MetroDevABMAppServiceBase, IClientTypeAppService
    {
        private readonly IRepository<ClientType> _ClientTypeRepository;
        protected string ErrorMessage { get; set; }
        public ClientTypeAppService(IRepository<ClientType> ClientTypeRepository)
        {
            _ClientTypeRepository = ClientTypeRepository;
        }

        public async Task<ListResultDto<ClientTypeListDto>> GetAll()
        {
            var ClientTypes = await _ClientTypeRepository
                .GetAllListAsync();

            return new ListResultDto<ClientTypeListDto>(
                ObjectMapper.Map<List<ClientTypeListDto>>(ClientTypes)
            );
        }

        public async System.Threading.Tasks.Task Create(CreateClientTypeInput input)
        {
            var ClientType = ObjectMapper.Map<ClientType>(input);
            await _ClientTypeRepository.InsertAsync(ClientType);
        }

        public async Task<ClientTypeDto> Get(int id)
        {
            var ClientType = await _ClientTypeRepository.GetAsync(id);
            return ObjectMapper.Map<ClientTypeDto>(ClientType);
        }

        public async Task Update(ClientTypeDto ClientType)
        {
            try
            {
                var itemDb = await _ClientTypeRepository.GetAsync(ClientType.Id);
                await _ClientTypeRepository.UpdateAsync(ObjectMapper.Map(ClientType, itemDb));
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
                var ClientType = await _ClientTypeRepository.GetAsync(id);
                await _ClientTypeRepository.DeleteAsync(ClientType);
            }
            catch (Exception ex)
            {
                ErrorMessage = L("ErrorAtDeleteInDB") + " [" + ex.Message + "]";
            }
        }
    }
}
