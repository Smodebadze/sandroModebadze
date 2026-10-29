using System.Xml.Linq;

namespace lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Username");

            string Namee = Console.ReadLine();

            Console.WriteLine("Email");

            string Email = Console.ReadLine();

            if (Namee == "Admin")
            {
                AdminUser admin = new(Namee, Email);
                Console.WriteLine(admin);
            }
            else
            {
                ClientUser client = new(Namee, Email);
                Console.WriteLine(client);
            }

          


        }
    }
}
