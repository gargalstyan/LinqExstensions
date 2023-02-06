using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExstensions
{
    public static class Exstensions
    {
        public static bool MyAll<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {
            int count = 0;
            if (!collection.Any())
                return true;
            foreach (var item in collection)
            {
                if (condition(item))
                {
                    count++;
                }
            }
            if (count != collection.Count())
                return false;
            else
            {
                return true;
            }
        }
        public static bool MyAny<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {
            if (!collection.Any())
                return false;
            foreach (var item in collection)
            {
                if (condition(item))
                {
                    return true;
                }
            }
            return false;
        }
        public static T MySingle<T>(this IEnumerable<T> collection, Predicate<T> condition)
        {
            int count = 0;
            if (!collection.Any())
                throw new InvalidOperationException("No matching elements");
            T returnItem = default;
            foreach (var item in collection)
            {
                if (condition(item))
                {
                    returnItem = item;
                    count++;
                }
            }
            if (count == 1)
                return returnItem;
            else
                throw new InvalidOperationException("No matching elements");
        }
        public static IEnumerable<T> MyExcept<T>(this IEnumerable<T> firstCollection,IEnumerable<T> secondCollection)
        {
            T previousItem = default;
            foreach (var item1 in firstCollection)
            { int count = 0;
                if (item1.Equals(previousItem))
                    continue;
                foreach (var item2 in secondCollection)
                {
                    if (item1.Equals(item2))
                        count++;
                }
                if (count == 0)
                {
                    previousItem = item1;
                    yield return item1;
                }
            }
        }
        public static IEnumerable<T> MySkipWhile<T>(this IEnumerable<T> collection,Predicate<T> condition)
        {
            bool flag = true;
            foreach (var item in collection)
            {
                if (condition(item) && flag)
                    continue;
                if(flag)
                   flag = false;
                yield return item;
            }
        }
    }
}
