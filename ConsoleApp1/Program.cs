using System;

namespace MovieconsoleApp.NewDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MovieconsoleContext())
            {
                Console.WriteLine("Enter movie title please");
                string title = Console.ReadLine();
                Console.WriteLine("Enter movie category");
                string category = Console.ReadLine();
                Console.WriteLine("Enter movie year please");
                string year = Console.ReadLine();
                db.Movieconsoles.Add(new Movieconsoletbl { title = title });
                db.Movieconsoles.Add(new Movieconsoletbl { year = year });
                db.Movieconsoles.Add(new Movieconsoletbl { category_name = category });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All movies in database:");
                foreach (var Movieconsoletbl in db.Movieconsoles)
                {
                    Console.WriteLine("{0}",Movieconsoletbl.title+"{1}",Movieconsoletbl.year+"{1}",Movieconsoletbl.category_name);
                    Console.WriteLine();
                }
            }
        }
    }
}