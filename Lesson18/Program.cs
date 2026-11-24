using Lesson18.Menus;
using Lesson18.Models;
using Lesson18.Repositories;

namespace Lesson18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileManager filem = new FileManager();

            MainMenu MainM = new MainMenu(filem);

            MainM.ShowMainMenu();
        }
    }
}