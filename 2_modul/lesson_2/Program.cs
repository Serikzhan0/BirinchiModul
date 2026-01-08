// namespace lesson_2;
//
// internal class Program
// {
//     static List<Book> Books = new List<Book>();
//     static void Main(string[] args)
//     {
//         DataSeed();
//
//         var books = BookPages(5);
//
//
//         var book = GetMaxPagedBook();
//         // var book = GetMaxPricedBook();
//         // Console.WriteLine(book.Price);
//
//     }
//
//     static List<Book> BookPages(decimal pages)
//     {
//         var expensiveBooks = new List<Book>();
//
//         foreach(var book in Books)
//         {
//             if(book.PageCount > pages)
//             {
//                 expensiveBooks.Add(book);
//             }
//         }
//
//         return expensiveBooks;
//     }
//     
//     
//     static Book GetMaxPagedBook()
//     {
//         Book book = Books[0];
//
//         foreach(var b in Books)
//         {
//             if(book.PageCount < b.PageCount)
//             {
//                 book = b;
//             }
//         }
//
//         return book;
//     }
//     
//     
//
//
//     static void DataSeed()
//     {
//         Books.Add(new Book()
//         {
//             BookId = Guid.NewGuid(),
//             Title = "The Great Gatsby",
//             Author = "F. Scott Fitzgerald",
//             Price = 10.99m,
//             Description = "A novel set in the Jazz Age that tells the story of Jay Gatsby's unrequited love for Daisy Buchanan.",
//             Created = DateTime.Now,
//             Genre = "Classic",
//             PageCount = 180
//         });
//
//         Books.Add(new Book()
//         {
//             BookId = Guid.NewGuid(),
//             Title = "Sariq Devni Minib",
//             Author = "Xudoyberdi To'xtaboyev",
//             Price = 5.99m,
//             Description = "Legenda",
//             Created = DateTime.Now,
//             Genre = "Fantasy",
//             PageCount = 270
//         });
//
//         Books.Add(new Book()
//         {
//             BookId = Guid.NewGuid(),
//             Title = "Harry Poter",
//             Author = "Opa",
//             Price = 15.99m,
//             Description = "Legenda 2",
//             Created = DateTime.Now,
//             Genre = "Fantasy",
//             PageCount = 870
//         });
//     }
// }





// Homework


using lesson_2.Models;
using lesson_2.Services;

namespace lesson_2;

internal class Program
{
    static void Main(string[] args)
    {
        //  CAR 
        Car car1 = new Car()
        {
            Brand = "BMW",
            Model = "X5",
            Year = 2022,
            Color = "Black",
            Price = 45000
        };

        Car car2 = new Car()
        {
            Brand = "Toyota",
            Model = "Camry",
            Year = 2020,
            Color = "White",
            Price = 28000
        };

        CarService carService = new CarService();

        var car1Id = carService.AddCar(car1);
        var car2Id = carService.AddCar(car2);

        carService.DeleteCar(car1Id);

        var cars = carService.GetAllCars();


        //  SCHOOL
        School school1 = new School()
        {
            Name = "School №1",
            Address = "Tashkent",
            StudentsCount = 800,
            TeachersCount = 60,
            Director = "Aliyev A.A"
        };

        School school2 = new School()
        {
            Name = "School №15",
            Address = "Samarkand",
            StudentsCount = 650,
            TeachersCount = 50,
            Director = "Karimov B.B"
        };

        SchoolService schoolService = new SchoolService();

        var school1Id = schoolService.AddSchool(school1);
        var school2Id = schoolService.AddSchool(school2);

        schoolService.DeleteSchool(school2Id);

        var schools = schoolService.GetAllSchools();
        
        
        
        Console.WriteLine("Cars:");
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Brand} {car.Model} | {car.Year} | {car.Color} | {car.Price}");
        }

        Console.WriteLine("\nSchools:");
        foreach (var school in schools)
        {
            Console.WriteLine($"{school.Name} | {school.Address} | Students: {school.StudentsCount}");
        }

        Console.ReadLine(); 
    }
}