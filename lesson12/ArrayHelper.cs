using System;
using System.Collections.Generic;
using System.Text;

namespace lesson12
{
    internal class ArrayHelper
    {


        public static void PrintArrayRev<T>(T[] numbers)
        {
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void GetFirstElement<T>(T[] numbers)
        {
            Console.WriteLine(numbers[0]);
        }


        public static void GetLastElement<T>(T[] numbers)
        {
            Console.WriteLine(numbers[numbers.Length - 1]);
        }


     
        public static void ContainsElement<T>(T[] arr, T el)
        {
            foreach (var item in arr)
            {
                if (item.Equals(el))
                {
                    Console.WriteLine("true");
                    return;
                }
            }

            Console.WriteLine("false");
        }
        public static void CountElement<T>(T[] arr)
        {
            int i = 0;
            foreach (var item in arr)
            {
                i++;
            }

            Console.WriteLine(i);
        }







        public static void FindIndex<T>(T[] arr, T el)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(el))
                {
                    Console.WriteLine(arr[i]);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
        public static void Swap<T>(T[] arr, int el, int el2)
        {
            T temp = arr[el];
            arr[el] = arr[el2];
            arr[el2] = temp;

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }




    }
}
