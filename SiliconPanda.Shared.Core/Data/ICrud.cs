using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiliconPanda.Shared.Core.Data
{
    public interface ICrud
    {
        Task<TEntity> FindAsync<TEntity>(Guid id) where TEntity : BaseEntity;
        Task<IEnumerable<TEntity>> QueryAsync<TEntity>(string sql, Type[] types, Func<object[], TEntity> map, object param = null) where TEntity : BaseEntity;
        Task<TEntity> InsertAsync<TEntity>(TEntity entity) where TEntity : BaseEntity;
        Task<int> UpdateAsync<TEntity>(TEntity entity) where TEntity : BaseEntity;
        Task<bool> DeleteAsync<TEntity>(Guid id) where TEntity : BaseEntity;
        Task<int> DeleteListAsync<TEntity>(object whereConditions) where TEntity : BaseEntity;
    }
}
