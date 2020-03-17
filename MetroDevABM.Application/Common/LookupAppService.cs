using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using MetroDevABM.ClientTypes;
using MetroDevABM.Genders;

namespace MetroDevABM.Common
{
    public class LookupAppService : MetroDevABMAppServiceBase, ILookupAppService
    {
        private readonly IRepository<Gender, int> _GenderRepository;
        private readonly IRepository<ClientType, int> _ClienTypeRepository;

        public LookupAppService(IRepository<Gender, int> genderRepository, IRepository<ClientType, int> clienTypesRepository)
        {
            _GenderRepository = genderRepository;
            _ClienTypeRepository = clienTypesRepository;
        }

        public async Task<ListResultDto<ComboboxItemDto>> GetGenderComboboxItems()
        {
            var people = await _GenderRepository.GetAllListAsync();
            return new ListResultDto<ComboboxItemDto>(
                people.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.Title)).ToList()
            );
        }

        public async Task<ListResultDto<ComboboxItemDto>> GetClientTypeComboboxItems()
        {
            var people = await _ClienTypeRepository.GetAllListAsync();
            return new ListResultDto<ComboboxItemDto>(
                people.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.Title)).ToList()
            );
        }
    }
}
