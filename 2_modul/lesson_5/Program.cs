using lesson_5;
using lesson_5.Services;
using lesson_5.Models;

namespace lesson_5;

internal class Program
{
    static void Main(string[] args)
    {
        //  Country
        ICountryService countryService = new CountryService();

        Country country = new Country()
        {
            CountryId = Guid.NewGuid(),
            Name = "MXM",
            Code = "KZ",
        };

        Guid countryId = countryService.AddCountry(country);

        Console.WriteLine(country.CountryId);
        Console.WriteLine(country.Name);
        Console.WriteLine(country.Code);

        //  BlackBoard
        IBlackBoardService blackBoardService = new BlackBoardServise();

        BlackBoard blackBoard = new BlackBoard()
        {
            BlackBoardId = Guid.NewGuid(),
            Name = "доска",
            Width = 120,
            Height = 80,
            IsActive = true
        };

        Guid boardId = blackBoardService.AddBlackBoard(blackBoard);

        Console.WriteLine(blackBoard.BlackBoardId);
        Console.WriteLine(blackBoard.Name);
        Console.WriteLine(blackBoard.Width);
        Console.WriteLine(blackBoard.Height);
        Console.WriteLine(blackBoard.IsActive);

        // Singer
        ISingerService singerService = new SingerService();

        Singer singer = new Singer()
        {
            SingerId = Guid.NewGuid(),
            Name = "John Doe",
            Genre = "Pop",
            Age = 30,
            AlbumsCount = 5
        };

        Guid singerId = singerService.AddSinger(singer);

        Console.WriteLine(singer.SingerId);
        Console.WriteLine(singer.Name);
        Console.WriteLine(singer.Genre);
        Console.WriteLine(singer.Age);
        Console.WriteLine(singer.AlbumsCount);
    }
}

    
