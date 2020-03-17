using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MetroDevABM.EntityFramework;

namespace MetroDevABM.Clients.Dto
{
    [AutoMapTo(typeof(Client)), AutoMapFrom(typeof(Client))]
    public class ClientDto : EntityDto
    {
        [Required]
        [MaxLength(Client.MaxStringLenght)]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        [Required]
        public int ClientTypeId { get; set; }
        [Required]
        public int GenderId { get; set; }

    }
}
