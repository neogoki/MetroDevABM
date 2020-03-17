using MetroDevABM.Clients.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroDevABM.Web.Models.Clients
{
    public class IndexViewModel
    {
        public IReadOnlyList<ClientListDto> Clients { get; }

        public IndexViewModel(IReadOnlyList<ClientListDto> clients)
        {
            Clients = clients;
        }

    }
}