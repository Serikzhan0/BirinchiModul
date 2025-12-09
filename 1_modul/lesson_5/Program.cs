class Program
{
    static void Main(string[] args)
    {
        Console.Write("List lengthni kiriting :");
        var n = int.Parse(Console.ReadLine());

        List<int> ints = new List<int>();

        for (var i = 0; i < n; i++)
        {
            Console.Write("List elementini kiriting :");
            var num = int.Parse(Console.ReadLine());
            ints.Add(num);
        }

        Console.ReadKey();
    }
}