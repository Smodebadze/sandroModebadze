namespace lesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new() { 13, 51, 32, 78, 23};

            nums.PrintArrayRev();
            Console.WriteLine("____________________");
            nums.GetFirstElement();
            Console.WriteLine("____________________");
            nums.GetLastElement();
            Console.WriteLine("____________________");
            Console.WriteLine(nums.ContainsElement(782)); ;
            Console.WriteLine("____________________");
            nums.CountElement();
            Console.WriteLine("____________________");
            nums.FindIndex(2);
        }
    }
}
