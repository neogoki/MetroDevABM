using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MetroDevABM.EntityFramework;

namespace MetroDevABM.ClientTypes.Dto
{
    [AutoMapTo(typeof(ClientType)), AutoMapFrom(typeof(ClientType))]
    public class ClientTypeDto : EntityDto
    {
        [Required]
        [StringLength(ClientType.MaxTitleLength)]
        public string Title{ get; set; }
        [MaxLength(ClientType.MaxDescriptionLength)]
        public string Description { get; set; }

    }
}
