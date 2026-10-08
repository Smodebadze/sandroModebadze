using System.Transactions;

namespace lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] transactions = { 120, -50, 300, -100, 80, -200, 500, -30, 150, -400 };

            int depositCount = 0;
            int withdrawalCount = 0;
            int depositsum = 0;
            int withdrawen = 0;

            foreach (var Tr in transactions)
            {
                if (Tr > 0)
                {
                    depositCount++;
                    depositsum = depositsum + Tr;
                }
                else
                {
                    withdrawalCount++;
                    withdrawen = withdrawen + Tr;
                }
            }

            Console.WriteLine($"Sum is {depositsum}");
            Console.WriteLine($"{depositCount} deposit and {withdrawalCount} withdrawal");
            Console.WriteLine($"deposited {depositsum} and widthrawen {withdrawen * -1}");


            if (depositsum + withdrawen > 0)
            {
                Console.WriteLine($"your balance is {depositsum + withdrawen}$");
            }
            else if (depositsum + withdrawen < 0)
            {
                Console.WriteLine($"you are {withdrawen * -1}$ in Debt");
            }
            else if (depositsum + withdrawen == 0)
            {
                Console.WriteLine("your balance is 0$");
            }
            else
            {
                Console.WriteLine("unknown error");
            }
        }
    }
}




//for (int i = 0; i < transactions.Length; i++)
//{
//    if (transactions[i] > 0)
//    {
//        depositCount++;
//        int x = deposited + transactions[i];
//        a = x;
//    }
//    else
//    {
//        withdrawalCount++;
//        int y = withdrawen + transactions[i];
//        b = y;
//    }

//}