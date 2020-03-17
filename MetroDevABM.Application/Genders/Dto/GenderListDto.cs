using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;

namespace MetroDevABM.Genders.Dto
{
    [AutoMapFrom(typeof(Gender))]
    public class GenderListDto : EntityDto
    {
        public string Title { get; set; }

    }
}