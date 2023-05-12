namespace CORE.Interfaces;

public interface IRepository<T>
{
    public Task<T> Create(T obj);
    public Task<T> Update(T obj);
    public Task<List<T>> Get();
    public Task<T> GetById(int id);
    public Task DeleteById(int id);
    public Task Delete(T obj);

}
