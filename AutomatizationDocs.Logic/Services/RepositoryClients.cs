using AutomatizationDocs.Logic.IServices;

using AutomatizationDocs.Logic.DTOModels.Clients;
using AutomatizationDocs.Data.Entity.Client;
using AutomatizationDocs.Data;

namespace AutomatizationDocs.Logic.Services
{
    public class RepositoryClients : IRepositoryClients
    {
        private readonly IEnumerable<Client> _clients;
        public RepositoryClients(IRepository<Client> repository) 
        {
            _clients = repository.GetAll();
        }
        public DTOClient? FindByIDCode(ushort id)
        {
            var client = _clients.FirstOrDefault(c => c.IdNumber.Number == id.ToString());
            if (client != null)
            {

                return MapClient(client);
            }
            else
                return null;
        }

        public DTOClient? FindByPaspportSeries(string pasportseries)
        {
            var client = _clients.FirstOrDefault(c => c.Passport.Series == pasportseries);
            if (client != null)
            {

                return MapClient(client);
            }
            else
                return null;
        }

        public IEnumerable<DTOClient>? FindBySurname(string lastname)
        {
            var clients = _clients.Where(c => c.FullName.LastName == lastname);
            if (clients != null)
            {
                List<DTOClient> dTOClients = new List<DTOClient>(); 
                foreach (var client in clients) 
                {
                    dTOClients.Add(MapClient(client));
                }
                return dTOClients;
            }
            else
                return null;
        }

        public IEnumerable<DTOClient>? FindBySurnameName(string lastname, string name)
        {
            var clients = _clients.Where(c => c.FullName.LastName == lastname && c.FullName.FirstName == name);
            if (clients != null)
            {
                List<DTOClient> dTOClients = new List<DTOClient>();
                foreach (var client in clients)
                {
                    dTOClients.Add(MapClient(client));
                }
                return dTOClients;
            }
            else
                return null;
        }
        private DTOClient MapClient(Client client) 
        {
            return new DTOClient
            {
                Id = client.Id,
                Name = client.FullName.FirstName,
                Adress = new DTOAdress()
                {
                    Id = client.Id,
                    City = client.Adress.City,
                    NumberOfHouse = client.Adress.NumberOfHouse,
                    Streat = client.Adress.Streat
                },
                IdentityUser = client.IdentityUser,
                IdNumber = new DTOIdNumber { Id = client.Id, Number = client.IdNumber.Number },
                LastName = client.FullName.LastName,
                OtherConnections = client.OtherConnections,
                Passport = new DTOPassport()
                {
                    Id = client.Passport.Id,
                    Date = client.Passport.Date,
                    DateOfBirth = client.Passport.DateOfBirth,
                    Organization = client.Passport.Organization,
                    Number = client.Passport.Number,
                    Series = client.Passport.Series
                }
            };
        }
    }
}
