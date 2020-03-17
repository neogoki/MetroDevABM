using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MetroDevABM.EntityFramework;

namespace MetroDevABM.Genders.Dto
{
    [AutoMapTo(typeof(Gender)), AutoMapFrom(typeof(Gender))]
    public class GenderDto : EntityDto
    {
        [Required]
        [StringLength(Gender.MaxTitleLength)]
        public string Title{ get; set; }

    }
}
