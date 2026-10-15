namespace lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            film film1 = new();


            film1.Title = "The Shawshank Redemption";
            film1.MainChar = "Andy Dufresne";
            film1.Director = "Frank Darabont";
            film1.ReleaseDate = 1994;
            film1.Rating = 9.3;


            film1.info();
            film1.release();
            film1.rating();

            film film2 = new();

            film2.Title = "Inception";
            film2.MainChar = "cobb";
            film2.Director = "Christopher Nolan";
            film2.ReleaseDate = 2010;
            film2.Rating = 8.8;

            film2.info();
            film2.release();
            film2.rating();

            film film3 = new();

            film3.Title = "The Green Mile";
            film3.MainChar = "Paul Edgecomb";
            film3.Director = "Frank Darabont";
            film3.ReleaseDate = 1999;
            film3.Rating = 8.6;

            film3.info();
            film3.release();
            film3.rating();

        }



    }
}

