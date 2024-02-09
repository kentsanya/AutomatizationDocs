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
            CreateMap<Client, DTOClient>()
                .ForMember(dest=>dest.Name, opt=>opt.MapFrom(sor=>sor.FullName.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(sor => sor.FullName.LastName));
            CreateMap<Passport, DTOPassport>();
        }
    }
}
