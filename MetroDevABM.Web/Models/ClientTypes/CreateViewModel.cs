using MetroDevABM.ClientTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetroDevABM.Web.Models.ClientTypes
{
    public class CreateViewModel
    {
        [Required]
        [MaxLength(ClientType.MaxTitleLength)]
        public string Title { get; set; }
    }
}