namespace Application.Persistence.Contracts;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetAsync(long id);
    Task<IReadOnlyList<T>> GetAsync();
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> Delete(T entity);
    Task<T> Delete(long id);

}