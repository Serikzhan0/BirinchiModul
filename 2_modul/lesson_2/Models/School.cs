namespace lesson_2.Models;

public class School

{
    public Guid SchoolId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public int StudentsCount { get; set; }
    public int TeachersCount { get; set; }
    public string Director { get; set; }
}
