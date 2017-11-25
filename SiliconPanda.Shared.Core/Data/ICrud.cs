using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiliconPanda.Shared.Core.Data
{
    public interface ICrud
    {
        Task<TEntity> FindAsync<TEntity, TIdentifier>(TIdentifier id);

        Task<IQueryable<TEntity>> QueryAsync<TEntity>();

        Task<TEntity> InsertAsync<TEntity, TIdentifier>(TEntity entity);

        Task<int> UpdateAsync<TEntity>(TEntity entity);

        Task<bool> DeleteAsync<TEntity>(TEntity entity);

        Task<bool> DeleteAsync<TEntity, TIdentity>(TIdentity id);

        Task<IList<TEntity>> GetPagedAsync<TEntity>(IQueryable<TEntity> query, int page, int take);
    }
}
