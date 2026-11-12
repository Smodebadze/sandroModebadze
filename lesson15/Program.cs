namespace lesson15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>()
            {
             new Player("Sandro", 63, true),
             new Player("Giorgi", 87, true),
             new Player("Nika", 96, false),
             new Player("Luka", 34, false),
             new Player("Data", 43, false),
             new Player("Andria", 56, true),
             new Player("Giga", 78, true),
             new Player("Beka", 45, false),
             new Player("Tornike", 23, true)
            };

            var filtered = players.Where(x => x.Score > 0).OrderByDescending(x => x.Score);
            foreach (var item in filtered)
            {
                Console.WriteLine($"{item.Name} {item.Score}");
            }


            var active = players.Where(x => x.Active == true);
            foreach (var item in active)
            {
                Console.WriteLine($"{item.Name} {item.Active}");
            }

            var highest = players.Where(x => x.Score > 0).MaxBy(x => x.Score);
            Console.WriteLine($"{highest.Name} {highest.Score}");



            var activeHigh = players.Where(x => x.Score > 0).Where(x => x.Active == true).MaxBy(x => x.Score);
            Console.WriteLine($"{activeHigh.Name} {activeHigh.Score}");



        }
    }
}
