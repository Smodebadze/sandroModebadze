using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = [1, 5, 23, 4, 12];

            ArrayHelper.PrintArrayRev(array);

            ArrayHelper.GetFirstElement(array);

            ArrayHelper.GetLastElement(array);

            ArrayHelper.ContainsElement(array, 12);

            ArrayHelper.CountElement(array);

            ArrayHelper.FindIndex(array, 2);

            ArrayHelper.Swap(array, 1, 3);
        }
    }
}
