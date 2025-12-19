namespace dars8;

internal class Program
{
    static List<int> Ages = new List<int>();
    static void Main(string[] args)
    {
        // CRUD

        while(true)
        {
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Read");

            Console.Write("Tanlang : ");
            int.TryParse(Console.ReadLine(), out int c);
            if(c == 1)
            {
                Console.Write("Yoshni kiriting : ");
                int.TryParse(Console.ReadLine(), out int yosh);
                CreateAge(yosh);
            }
            else if(c == 2)
            {
                Console.Write("Yoshni o'chirish : ");
                int.TryParse(Console.ReadLine(), out int yosh);
                DeleteAge(yosh);
            }
            else if(c == 3)
            {
                Console.Write("Eski Yoshni kiriting : ");
                int.TryParse(Console.ReadLine(), out int yosh1);
                Console.Write("Yangi Yoshni kiriting : ");
                int.TryParse(Console.ReadLine(), out int yosh2);
                UpdateAge(yosh1, yosh2);
            }
            else if(c == 4)
            {
                ReadAges();
            }
            Console.ReadKey();
            Console.Clear();
        }

    }

    static void CreateAge(int age)
    {
        Ages.Add(age);
    }

    static void DeleteAge(int age)
    {
        Ages.Remove(age);
    }

    static void UpdateAge(int oldAge, int newAge)
    {
        int index = Ages.IndexOf(oldAge);
        if (index != -1)
        {
            Ages[index] = newAge;
        }
    }

    static void ReadAges()
    {
        foreach (var age in Ages)
        {
            Console.WriteLine(age);
        }
        Console.WriteLine();
        
        
        
        
       // ------------- Task ref out -----------------------

       // namespace dars8;

    //internal class Program
    //{
      //  static void Main(string[] args)
      //  {
            // ref vs out
            // ref =>  Funksiya ketadigan ref ostidagi
            // o'zgarubchini qiymati bo'lishi shart

            // out => Funksiya ketadigan out ostidagi
            // o'zgarubchini qiymati funksiyani ichida o'zgarishi shart

            //int s;
            //int p;
            //int a = 5;
            //Do1(a, out s, out p);
            //Console.WriteLine(s);
            //Console.WriteLine(p);

           // int a;
           // int.TryParse(Console.ReadLine(), out a);
            //MyTryParse(Console.ReadLine(), out a);
            //int num = int.Parse(Console.ReadLine());

           // Console.WriteLine(a);
       // }

        //static bool MyTryParse(string s, out int a)
        //{
          //  a = 0;
          //  if(!s.All(c => char.IsDigit(c)))
           // {
            //    return false;
            //}

           // a = int.Parse(s);
           // return true;
           //}

        //static void Do1(int a, out int s, out int p)
        //{
         //   p = 4 * a;
          //  s = a * a;
       // }
    //}




   // ----------- Casting (Implicit, Explicit) -----------
    //
    //     namespace dars8;
    //
    // internal class Program
    // {
    //     static void Main(string[] args)
    //     {
            //32767
            //-32768

            // [-32768 : 32767]

            //Console.WriteLine(short.MaxValue);
            //Console.WriteLine(short.MinValue);

            //int num = -32769;
            //short num1 = (short)num;

            //Console.WriteLine(num1);


            // Casting 
            // * Implicit Casting (automatically) 
            // * Explicit Casting (manually)

            //int num1 = 12345;
            //long num2 = num1; // Implicit Casting

            //long num3 = 44444444444;
            //int num4 = (int)num3;

            //Console.WriteLine(num4);
    //     }
    //
    // }

    

    }
}