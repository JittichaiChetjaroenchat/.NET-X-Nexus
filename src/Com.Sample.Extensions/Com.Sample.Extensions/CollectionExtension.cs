using System.Collections.Generic;
using System.Linq;

namespace Com.Sample.Extensions
{
    public static class CollectionExtension
    {
        public static bool IsEmpty<T>(this ICollection<T> sources)
        {
            return sources == null || sources.Count == 0;
        }

        public static bool IsEmpty<T>(this IEnumerable<T> sources)
        {
            return !sources?.Any() ?? true;
        }
    }
}