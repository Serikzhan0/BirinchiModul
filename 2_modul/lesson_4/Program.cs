using lesson_4.Models;

class Program
{
    static void Main()
    {
        Teacher teacher = new Teacher("Ali");
        teacher.Teach();

        Student student = new Student("Bek");
        student.Study();
    }
}