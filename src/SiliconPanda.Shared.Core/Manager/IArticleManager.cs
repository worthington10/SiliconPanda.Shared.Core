using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SiliconPanda.Shared.Core.Convention;
using SiliconPanda.Shared.Core.Filters;
using SiliconPanda.Shared.Domain.Dto;

namespace SiliconPanda.Shared.Core.Manager
{
    public interface IArticleManager : IManager
    {
        Task<Article> GetAsync(Guid siteId, Guid articleId);

        Task<IList<Article>> GetPagedListByUserAsync(Guid siteId, Guid userId,  PageFilter filter);

        Task<IList<Article>> GetByIdsAsync(Guid siteId, GetPublishedArticleFilter filter);
    }
}
