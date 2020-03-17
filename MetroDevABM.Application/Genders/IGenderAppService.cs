using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MetroDevABM.Genders.Dto;

namespace MetroDevABM.Genders
{
    public interface IGenderAppService : IApplicationService
    {
        Task<ListResultDto<GenderListDto>> GetAll();
        Task Create(CreateGenderInput input);
        Task<GenderDto> Get(int id);
        Task Update(GenderDto gender);
        Task Delete(int id);
    }
}