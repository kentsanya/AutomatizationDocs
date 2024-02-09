using AutomatizationDocs.Logic.DTOModels.Clients;

namespace AutomatizationDocs.Logic.IServices
{
    public interface IRepositoryClients
    {
       public IEnumerable<DTOClient> FindBySurname(string surname);
       public IEnumerable<DTOClient> FindBySurnameName(string surname, string name);
       public DTOClient FindByIDCode(int id);
       public DTOClient FindByPaspportSeries(string pasportseries);
    }
}
