using SiliconPanda.Shared.Core.Settings;

namespace SiliconPanda.Shared.Core.Filters
{
    public class PageFilter
    {
        public PageFilter()
        {
            Page = Contants.DEFAULT_FIRST_PAGE;
            Take = Contants.DEFAULT_PAGE_SIZE;
        }

        public int Page { get; set; }

        public int Take { get; set; }
    }
}
