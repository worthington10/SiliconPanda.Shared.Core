using System.Threading.Tasks;
using SiliconPanda.Shared.Core.Types;

namespace SiliconPanda.Shared.Core.Convention
{
    public interface ILogger
    {
        Task WriteLineToLogAsync(string log);

        Task WriteLineToLogAsync(string log, LogType type);
    }
}
