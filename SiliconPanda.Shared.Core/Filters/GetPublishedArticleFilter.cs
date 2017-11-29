using System;
using System.Collections.Generic;

namespace SiliconPanda.Shared.Core.Filters
{
    public class GetPublishedArticleFilter : PageFilter
    {
        public IEnumerable<Guid> ExcludeArticleIds { get; set; }

        public IEnumerable<Guid> IncludeTagIds { get; set; }

        public IEnumerable<Guid> ExcludeTagIds { get; set; }
    }
}
