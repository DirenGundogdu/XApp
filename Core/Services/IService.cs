using System.Linq.Expressions;

namespace Core.Services;

public interface IService<T> where T : class
{

    #region Get
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();

    IQueryable<T> Where(Expression<Func<T, bool>> expression);
    Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
    #endregion


    #region Add
    Task<T> AddAsync(T entity);
    Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
    #endregion

    #region Update
    Task UpdateAsync(T entity);
    #endregion

    #region Delete
    Task RemoveAsync(T entity);
    Task RemoveRangeAsync(IEnumerable<T> entities);
    #endregion

}
