using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson18.Models
{
    internal class CarsClass
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"{Name},{Model},{Year},{Price},{Color}";
        }
    }
}
