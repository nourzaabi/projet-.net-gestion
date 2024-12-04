using System.Collections.Generic;
using System.Threading.Tasks;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();   // Ajoute cette méthode pour obtenir tous les éléments
    Task<T> GetByIdAsync(int id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}




