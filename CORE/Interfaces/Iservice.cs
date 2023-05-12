namespace CORE.Interfaces;

public interface Iservice<T>
{
    public Task<T> add(T obj);
    public Task<List<T>> Get();
    public Task<T> GetById(int id);
    public Task<T> Put(T obj);
    public Task Delete(T obj);
}