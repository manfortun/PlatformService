namespace PlatformService.DataAccess.Interfaces;

public interface IRepository<T>
{
    IEnumerable<T> GetAll();

    T? GetById(int id);

    void Insert(T entity);

    bool Save();
}
