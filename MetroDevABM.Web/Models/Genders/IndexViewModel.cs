using MetroDevABM.Genders.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetroDevABM.Web.Models.Genders
{
    public class IndexViewModel
    {
        public IReadOnlyList<GenderListDto> Genders { get; }

        public IndexViewModel(IReadOnlyList<GenderListDto> genders)
        {
            Genders = genders;
        }

    }
}