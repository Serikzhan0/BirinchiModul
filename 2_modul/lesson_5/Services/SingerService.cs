using lesson_5.Models;

namespace lesson_5.Services;

public class SingerService : ISingerService
{
    private List<Singer> Singers;

    public SingerService()
    {
        Singers = new List<Singer>();
    }

    public Guid AddSinger(Singer singer)
    {
        singer.SingerId = Guid.NewGuid();
        Singers.Add(singer);
        return singer.SingerId;
    }

    // public bool DeleteSinger(Guid singerId)
    // {
    //     for (int i = 0; i < Singers.Count; i++)
    //     {
    //         if (Singers[i].SingerId == singerId)
    //         {
    //             Singers.RemoveAt(i);
    //             return true;
    //         }
    //     }
    //     return false;
    // }
    
    public bool DeleteSinger(Guid singerId)
    {
        return Singers.RemoveAll(s => s.SingerId == singerId) > 0;
    }

    public List<Singer> GetAllSingers()
    {
        return Singers;
    }

    public Singer? GetSingerById(Guid singerId)
    {
        foreach (var singer in Singers)
        {
            if (singer.SingerId == singerId)
            {
                return singer;
            }
        }
        return null;
    }

    public bool UpdateSinger(Singer updatingSinger)
    {
        foreach (var singer in Singers)
        {
            if (singer.SingerId == updatingSinger.SingerId)
            {
                singer.Name = updatingSinger.Name;
                singer.Genre = updatingSinger.Genre;
                singer.Age = updatingSinger.Age;
                singer.AlbumsCount = updatingSinger.AlbumsCount;
                return true;
            }
        }
        return false;
    }
}