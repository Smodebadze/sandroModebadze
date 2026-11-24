using Lesson18.Models;
using Lesson18.Repositories;
using System;

namespace Lesson18.Menus
{
    internal class MainMenu
    {
        private readonly FileManager _fileManager;

        public MainMenu(FileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public void ShowMainMenu()
        {
            string choose = "";

            while (choose != "0")
            {
                Console.WriteLine("1. Add Car");
                Console.WriteLine("2. Show All Cars");
                Console.WriteLine("3. Find Car");
                Console.WriteLine("0. Exit");

                choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        AddCar();
                        break;

                    case "2":
                        _fileManager.ShowAllCars();
                        break;

                    case "3":
                        Find();
                        break;

                    case "0":
                        break;

                    default:
                        Console.WriteLine("Invalid value - enter 1, 2, 3 or 0");
                        break;
                }
            }
        }

        private void AddCar()
        {
            CarsClass car = new();

            Console.WriteLine("Enter Make");
            car.Name = Console.ReadLine();
            Console.WriteLine("Enter Model");
            car.Model = Console.ReadLine();
            Console.WriteLine("Enter Year");
            car.Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price");
            car.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Color");
            car.Color = Console.ReadLine();
            _fileManager.AddCar(car);

            Console.WriteLine("Car added");
        }

        private void Find()
        {
            Console.WriteLine("Enter Make");
            string name = Console.ReadLine();

            var car = _fileManager.FindCar(name);

            if (car == null)
            {
                Console.WriteLine("Car not found");
            }
            else
            {
                Console.WriteLine(car);
            }
        }
    }
}