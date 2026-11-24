using Lesson18.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lesson18.Repositories
{
    internal class FileManager
    {
        string path = @"C:\Users\Sandro\source\repos\sandroModebadze\Lesson18\Data\Cars.txt";

        public List<CarsClass> GetAllCars()
        {
            List<CarsClass> carsList = new();

            var read = File.ReadAllLines(path);

            foreach (var item in read)
            {
                var Chopped = item.Split(",");

                CarsClass CarCl = new();

                CarCl.Name = Chopped[0];
                CarCl.Model = Chopped[1];
                CarCl.Year = int.Parse(Chopped[2]);
                CarCl.Price = int.Parse(Chopped[3]);
                CarCl.Color = Chopped[4];

                carsList.Add(CarCl);
            }

            return carsList;
        }

        public void AddCar(CarsClass car)
        {
            File.AppendAllText(path, car.ToString() + Environment.NewLine);
        }

        public void ShowAllCars()
        {
            var cars = GetAllCars();

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }

        public CarsClass FindCar(string name)
        {
            var cars = GetAllCars();

            var car = cars.FirstOrDefault(u => u.Name == name);

            return car;
        }
    }
}