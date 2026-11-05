using System;
using System.Collections.Generic;
using System.Text;

namespace lesson13
{
    internal static class CollectionHelper
    {

        public static void PrintArrayRev<T>(this IEnumerable<T> coll)
        {
            foreach (T item in coll.Reverse())
            {
                Console.WriteLine(item);
            }
        }

        public static T GetFirstElement<T>(this IEnumerable<T> coll)
        {
            T num = default;
            foreach (T item in coll)
            {
                num = item;
                break;
            }
           return num;
        }


        public static T GetLastElement<T>(this IEnumerable<T> coll)
        {
            T num = default;
            foreach (T item in coll.Reverse())
            {
                num = item;
                break;
            }

           return num;
        }



        public static bool ContainsElement<T>(this IEnumerable<T> coll, T el)
        {
            foreach (var item in coll)
            {
                if (item.Equals(el))
                {
                    return true;
                }
            }

            return false;
        }

        public static int CountElement<T>(this IEnumerable<T> coll)
        {
            int i = 0;
            foreach (var item in coll)
            {
                i++;
            }

            return i ;
        }


        public static int FindIndex<T>(this IEnumerable<T> coll, T el)
        {
            int i = 0;

            foreach (var item in coll)
            {
                if (item.Equals(el))
                {
                    
                    return i;
                }

                i++;
            }

            return -1;
        }


      

    }
}
