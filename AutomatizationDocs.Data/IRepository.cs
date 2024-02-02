
namespace AutomatizationDocs.Data
{
    public interface IRepository<T>
    {
        public void Create(T item);

        public T? FindId (Guid id);

        public void Update(T item);
        public void Delete(Guid id);

        public IEnumerable<T> GetAll();

        public void Save();

    }
}
