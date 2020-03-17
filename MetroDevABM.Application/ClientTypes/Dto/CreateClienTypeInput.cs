using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDevABM.ClientTypes.Dto
{
    [AutoMapTo(typeof(ClientType))]
    public class CreateClientTypeInput
    {
        [Required]
        [MaxLength(ClientType.MaxTitleLength)]
        public string Title { get; set; }
        [MaxLength(ClientType.MaxDescriptionLength)]
        public string Description { get; set; }
    }
}
