using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Id3Cleaner
{
    public class GreatestCommonLeftSubstringFinder
    {
        /// <summary>
        /// Returns the greatest common left substring of all the provided string or empty string if no such substring exits or no items were provided
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public static string FindGreatestCommonLeftSubstring(IEnumerable<string> items)
        {
            if (items is null || !items.GetEnumerator().MoveNext())
                return "";

            string result = "";

            //Keep trying greater and greater substrings, till we find one that does not occur at the beginning of one of the items
            string first = items.First();
            for (int i = 0; i < first.Length; ++i)
            {
                if (items.Any(str => str[i] != first[i]))
                {
                    return result;
                }
                result += first[i];
            }
            return result;
        }
    }
}
