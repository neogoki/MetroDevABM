using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;

namespace MetroDevABM.ClientTypes.Dto
{
    [AutoMapFrom(typeof(ClientType))]
    public class ClientTypeListDto : EntityDto
    {
        public string Title { get; set; }
        public string Description { get; set; }

    }
}