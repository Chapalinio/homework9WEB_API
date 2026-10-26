namespace homework9WEB_API.Repositories;

public interface IRepository<T>
{
    void Add(T data);
    void Remove(int id);
    List<T> GetAll();
    T GetById(int id);
}