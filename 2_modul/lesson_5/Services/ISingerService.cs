using lesson_5.Models;

namespace lesson_5.Services
{
    public interface ISingerService

    {
    Guid AddSinger(Singer singer);

    bool UpdateSinger(Singer singer);

    bool DeleteSinger(Guid singerId);

    Singer? GetSingerById(Guid singerId);

    List<Singer> GetAllSingers();
    }
}