using MetroDevABM.Genders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetroDevABM.Web.Models.Genders
{
    public class CreateViewModel
    {
        [Required]
        [MaxLength(Gender.MaxTitleLength)]
        public string Title { get; set; }
    }
}