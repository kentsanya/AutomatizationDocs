using AutoMapper;
using AutomatizationDocs.Data.Entity.Client;
using AutomatizationDocs.Logic.DTOModels.Clients;

namespace AutomatizationDocs.Logic.AutoMapper
{
    public class MappingProfile:Profile
    {
        //поля дто и поля модели данних отличаються количеством, но не типом..
        public MappingProfile() 
        {
            CreateMap<Client, DTOClient>();
            CreateMap<Passport, DTOPassport>();
        }
    }
}
