using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7
{
    internal class film
    {

        public string Title;
        public string Director;
        public string MainChar;
        public int ReleaseDate;
        public double Rating;


        public void info()
        {
            Console.WriteLine($"{Title} was directed by {Director} and the main character is {MainChar}");
        }

        public void rating()
        {
            Console.WriteLine($"{Title} is rated {Rating} on IMDB");
        }


        public void release()
        {
            Console.WriteLine($"{Title} was released in {ReleaseDate}");
        }


    }
}
