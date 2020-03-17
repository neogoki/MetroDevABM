using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDevABM.Genders.Dto
{
    [AutoMapTo(typeof(Gender))]
    public class CreateGenderInput
    {
        [Required]
        [MaxLength(Gender.MaxTitleLength)]
        public string Title { get; set; }
    }
}
