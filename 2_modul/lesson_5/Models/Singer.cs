namespace lesson_5.Models;

public class Singer
{
    public Guid SingerId { get; set; }
    
    public string Name { get; set; }
    
    public string Genre { get; set; }
    
    public int Age { get; set; }
    
    public int AlbumsCount { get; set; }
}