using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using MetroDevABM.Genders.Dto;

namespace MetroDevABM.Genders
{
    public class GenderAppService : MetroDevABMAppServiceBase, IGenderAppService
    {
        private readonly IRepository<Gender> _genderRepository;
        protected string ErrorMessage { get; set; }
        public GenderAppService(IRepository<Gender> genderRepository)
        {
            _genderRepository = genderRepository;
        }

        public async Task<ListResultDto<GenderListDto>> GetAll()
        {
            var genders = await _genderRepository
                .GetAllListAsync();

            return new ListResultDto<GenderListDto>(
                ObjectMapper.Map<List<GenderListDto>>(genders)
            );
        }

        public async System.Threading.Tasks.Task Create(CreateGenderInput input)
        {
            var gender = ObjectMapper.Map<Gender>(input);
            await _genderRepository.InsertAsync(gender);
        }

        public async Task<GenderDto> Get(int id)
        {
            var gender = await _genderRepository.GetAsync(id);
            return ObjectMapper.Map<GenderDto>(gender);
        }

        public async Task Update(GenderDto gender)
        {
            try
            {
                var itemDb = await _genderRepository.GetAsync(gender.Id);
                await _genderRepository.UpdateAsync(ObjectMapper.Map(gender, itemDb));
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
                var gender = await _genderRepository.GetAsync(id);
                await _genderRepository.DeleteAsync(gender);
            }
            catch (Exception ex)
            {
                ErrorMessage = L("ErrorAtDeleteInDB") + " [" + ex.Message + "]";
            }
        }
    }
}
