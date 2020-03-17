using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MetroDevABM.Clients.Dto
{
    [AutoMapTo(typeof(Client))]
    public class CreateClientInput
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int ClientTypeId { get; set; }
        public int GenderId { get; set; }

    }
}
