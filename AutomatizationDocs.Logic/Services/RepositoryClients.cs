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
                DTOAdress adress = new DTOAdress()
                {
                    Id = client.Id,
                    City = client.Adress.City,
                    NumberOfHouse = client.Adress.NumberOfHouse,
                    Streat = client.Adress.Streat
                };
                return new DTOClient
                {
                    Id = client.Id,
                    Name = client.FullName.FirstName,
                    Adress = adress,
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
            else
                return null;
        }

        public DTOClient FindByPaspportSeries(string pasportseries)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DTOClient> FindBySurname(string surname)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DTOClient> FindBySurnameName(string surname, string name)
        {
            throw new NotImplementedException();
        }
    }
}
