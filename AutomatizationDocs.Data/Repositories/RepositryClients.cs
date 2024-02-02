using AutomatizationDocs.Data.Entity.Client;
using AutomatizationDocs.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AutomatizationDocs.Data.Repositories
{
    public class RepositryClients : IRepository<Client>
    {
        private readonly AutomatizationDocsContext _context;

        public RepositryClients(AutomatizationDocsContext context) 
        {
            _context = context;
        }
        public void Create(Client item)
        {
            _context.Clients.Add(item);
        }

        public void Delete(Guid id)
        {
            var client = _context.Clients.FirstOrDefault(c => c.Id == id);
            if (client != null) 
            {
                _context.Clients.Remove(client);
            }
            
        }

        public Client? FindId(Guid id)
        {
            return _context.Clients.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients;
        }

        public void Update(Client item)
        {
            var client = _context.Clients.Find(item);
            if (client != null)
            {
                _context.Clients.Update(item);
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
