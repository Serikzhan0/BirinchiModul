namespace lesson_10;

internal class Program
{
    static void Main(string[] args)
    {

        Teacher teacher = new Teacher()
        {
            Fullname = "John Cena",
            Subject = "English",
            SchoolName = "33",
            Category = "Master",
            Education = "Higher english education",
            PhoneNumber = "+1 929 1770"
        };

        Console.WriteLine(teacher.Fullname);
        Console.WriteLine(teacher.PhoneNumber);
        Console.WriteLine(teacher.SchoolName);
        
        
        Teacher teacher1 = new Teacher();
        teacher1.Fullname = "Daniyar Petrov";
        teacher1.Subject = "Computer Science";
        teacher1.SchoolName = "Lyceum No. 3";
        teacher1.Category = "Junior";
        teacher1.Education = "Higher technical education";
        teacher1.PhoneNumber = "+7 747 1202";

        
        
        Country country1 = new Country()
        {
            CountryName = "Kazakhstan",
            Nation = "Kazakh",
            Population = 20445231,
            CountryCode = "KZ",
            FlaagColor = "Blue",
            Currency = "Tenge"
        };

        Console.WriteLine(country1.CountryName);
        Console.WriteLine(country1.Nation);
        Console.WriteLine(country1.Population);

        
        Country country2 = new Country();
        country2.CountryName = "SaudiArabia";
        country2.Nation = "Arab";
        country2.Population = 33091113;
        country2.FlaagColor = "Green";
        country2.Currency = "SaudiRiyal";


        Book book1 = new Book()
        {
            Title = "Mission accomplished.Happy life technolody",
            Author = "Margulan Seisembay",
            Pages = 384,
            Year = "2023",
            Price = "250000"
        };

        Console.WriteLine(book1.Title);
        Console.WriteLine(book1.Author);
        Console.WriteLine(book1.Pages);
        
        
        Book book2 = new Book();
        book2.Title = "Clean Code";
        book2.Author = "Robert Martin";
        book2.Pages = 464;
        book2.Year = "2008";
        book2.Price = "5000";


        Movie movie1 = new Movie()
        {
            MovieName = "Fight Club",
            Director = "David Fincher",
            ReleaseYear = 1999,
            Genre = "psychological thriller,drama and cult film",
            Rating = 8.8,
            Duration = 139,
        };

        Console.WriteLine(movie1.MovieName);
        Console.WriteLine(movie1.Director);
        Console.WriteLine(movie1.ReleaseYear);

        
        Movie movie2 = new Movie();
        movie2.MovieName = "Avatar";
        movie2.Director = "James Cameron";
        movie2.ReleaseYear = 2009;
        movie2.Genre = "Fantasy";
        movie2.Rating = 7.9;
        movie2.Duration = 162;


        Planet planet1 = new Planet()
        {
            Name = "Saturn",
            Type = "Gas Giant",
            Diameter = 120536,
            DistanceFromSun = 1430,
            Moons = 82,
        };

        Console.WriteLine(planet1.Name);
        Console.WriteLine(planet1.Type);
        Console.WriteLine(planet1.Diameter);
        
        
        Planet planet2 = new Planet();
        planet2.Name = "Mars";
        planet2.Type = "Rocky";
        planet2.Diameter = 6779;
        planet2.DistanceFromSun = 228; 
        planet2.Moons = 2;
        
    }
}