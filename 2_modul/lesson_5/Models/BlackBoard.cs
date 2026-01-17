namespace lesson_5.Models;

public class BlackBoard
{
    public Guid BlackBoardId { get; set; }
    public string Name { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public bool IsActive { get; set; }
}