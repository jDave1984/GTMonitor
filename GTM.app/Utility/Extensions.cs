using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace GTM.app.Utility
{
    public static class Extensions
    {
        public static IEnumerable<List<T>> Bucket<T>(this IEnumerable<T> rawItems, int numberOfBuckets)
        {
            for (var i = 0; i < (float) rawItems.Count() / numberOfBuckets; i++)
            {
                yield return rawItems.Skip(i * numberOfBuckets).Take(numberOfBuckets).ToList();
            }
        }
    }
}