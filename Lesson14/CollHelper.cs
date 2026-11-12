using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson14
{
    internal static class CollHelper
    {
        public static List<T> IsGreater<T>(this IEnumerable<T> coll, Predicate<T> Logic) where T : IComparable<T>
        {
            List<T> list = new();

            if (coll == null)
            {
                return default;
            }

            foreach (var i in coll)
            {
                if (Logic(i))
                {
                    list.Add(i);
                }

            }
            return list;
        }


        public static T FirstOrDefault<T>(this IEnumerable<T> coll, Predicate<T> Logic) where T : IComparable<T>
        {
            T FirstFound;

            if (coll == null)
            {
                return default;
            }

            foreach (var i in coll)
            {
                if (Logic(i))
                {
                    FirstFound = i;
                    return FirstFound;
                }

            }
            return default;
        }






        public static bool Any<T>(this IEnumerable<T> coll, Predicate<T> Logic) where T : IComparable<T>
        {
            if (coll == null)
            {
                return false;
            }

            foreach (var i in coll)
            {
                if (Logic(i))
                {
                    return true;
                }

            }
            return false;
        }


        public static bool All<T>(this IEnumerable<T> coll, Predicate<T> Logic) where T : IComparable<T>
        {
            if (coll == null)
            {
                return false;
            }

            foreach (var i in coll)
            {
                if (!Logic(i))
                {
                    return false;
                }
            }
            return true;
        }


        public static int Count<T>(this IEnumerable<T> coll, Predicate<T> Logic) where T : IComparable<T>
        {
            int count = 0;

            if (coll == null)
            {
                return default;
            }

            foreach (var i in coll)
            {
                if (Logic(i))
                {
                    count++;
                }
            }
            return count;
        }



    }
}
