using MetroDevABM.ClientTypes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroDevABM.Web.Models.ClientTypes
{
    public class IndexViewModel
    {
        public IReadOnlyList<ClientTypeListDto> ClientTypes { get; }

        public IndexViewModel(IReadOnlyList<ClientTypeListDto> clientTypes)
        {
            ClientTypes = clientTypes;
        }

    }
}