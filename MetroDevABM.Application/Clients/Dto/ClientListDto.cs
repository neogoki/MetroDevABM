using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;

namespace MetroDevABM.Clients.Dto
{
    [AutoMapFrom(typeof(Client))]
    public class ClientListDto : EntityDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ClientTypeTitle { get; set; }
        public string GenderTitle { get; set; }

    }
}