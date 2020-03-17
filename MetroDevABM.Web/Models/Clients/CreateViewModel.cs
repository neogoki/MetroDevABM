using Abp.AutoMapper;
using MetroDevABM.Clients;
using MetroDevABM.Genders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroDevABM.Web.Models.Clients
{
    [AutoMapTo(typeof(Client))]
    public class CreateViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int ClientTypeId { get; set; }
        public int GenderId { get; set; }
        public List<SelectListItem> Genders { get; set; }
        public List<SelectListItem> ClientTypes { get; set; }

        public CreateViewModel(List<SelectListItem> genders, List<SelectListItem> clientTypes)
        {
            Genders = genders;
            ClientTypes = clientTypes;

        }
    }
}