
namespace lesson16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new();
            Dictionary<string, int> dict = new();

            dict.Add("saba", 21);
            dict.Add("gio", 26);


            Console.WriteLine("Enter student name and score");



            string name = Console.ReadLine();
            int score = int.Parse(Console.ReadLine());


            while (dict.Keys.Contains(name))
            {
                Console.WriteLine("This name already exists Enter another name and score");
                name = Console.ReadLine();
                score = int.Parse(Console.ReadLine());
            }


            dict.Add(name, score);
            list.Add(name);

            Console.WriteLine("Enter a name to search");


            string logName = Console.ReadLine();



            if (dict.ContainsKey(logName))
            {
                Console.WriteLine(dict[logName]);

            }

            else
            {
                Console.WriteLine("Error");
            }


            Console.WriteLine("Update your Score");
            string update = Console.ReadLine();

            if (dict.Keys.Contains(update)) {
                Console.WriteLine("update score");
                int NewScore = int.Parse(Console.ReadLine());

                dict[update] = NewScore;

            }
            else
            {
                Console.WriteLine("Student not found");
            }



            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

        }
    }
}
