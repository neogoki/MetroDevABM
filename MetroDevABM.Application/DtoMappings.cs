using AutoMapper;
using MetroDevABM.Clients;
using MetroDevABM.Clients.Dto;
using MetroDevABM.ClientTypes;
using MetroDevABM.ClientTypes.Dto;
using MetroDevABM.Genders;
using MetroDevABM.Genders.Dto;
using System;

namespace MetroDevABM
{
    internal static class DtoMappings
    {
        public static void Map(IMapperConfigurationExpression mapper)
        {
            //I specified mapping for AssignedPersonId since NHibernate does not fill Task.AssignedPersonId
            //If you will just use EF, then you can remove ForMember definition.
            mapper.CreateMap<Gender, GenderDto>()
                .ReverseMap()
                .ForMember(m => m.Id, c => c.Ignore());
            mapper.CreateMap<Gender, GenderListDto>();

            mapper.CreateMap<ClientType, ClientTypeDto>()
                .ReverseMap()
                .ForMember(m => m.Id, c => c.Ignore());
            mapper.CreateMap<ClientType, ClientTypeListDto>();
            
            mapper.CreateMap<Client, ClientDto>()
                .ReverseMap()
                .ForMember(m => m.Id, c => c.Ignore());
            mapper.CreateMap<Client, ClientListDto>();
        }
    }
}
