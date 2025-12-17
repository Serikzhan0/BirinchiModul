namespace dars6;

internal class Program
{
    static void Main(string[] args)
    {
        // Recursiya
        //Console.WriteLine(F(6));

        // F(6) = 6 + 15
        // F(5) = 5 + 10
        // F(4) = 4 + 6
        // F(3) = 3 + 3
        // F(2) = 2 + 1  
        // F(1) = 1 + 0

        Console.WriteLine(SummAB(4,8));
        Console.WriteLine(SummAB1(4,8));


    }

    static int SummAB1(int a, int b)
    {   // 4 8 => 4 5 6 7 8
        if (a == b - 1)
        {
            return 0;
        }
       
        return a + 1 + SummAB1(a + 1, b);
    }

    static int SummAB(int a, int b)
    {   // 4 8
        if (a == b)
        {
            return a;
        }

        return a + SummAB(a + 1, b);
    }

    // awkward
    static int F(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        return n * F(n - 1);


    }
}



////////  function default value //////////



    static void Main(string[] args)
    {
        // function default value

        var s = "foundation";
        Console.WriteLine(CustomSubstr(s, 1));
        Console.WriteLine(CustomSubstr(s, 2, 4));

    }

    static string CustomSubstr(string s, int startIndex, int len = 0)
    {
        if(len == 0)
        {
            len = s.Length;
        }
        var res = string.Empty;
        for (var i = startIndex; i < len; i++)
        {
            res += s[i];
        }

        return res;
    }

  




//////// OVERLOADING ////////
{
  
    
        // function overloading

        Console.WriteLine(GetMax(4,8));
        Console.WriteLine(GetMax(4,8,5));
        Console.WriteLine(GetMax("32", "54", "77"));
    }

    static int GetMax(int a, int b)
    {
        return Math.Max(a, b);
    }

    static int GetMax(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }
    
    static string GetMax(string a, string b, string c)
    {
        return a;
    }



{
    
    
        // function default value

        //Console.WriteLine(Add(3f, 4.5f));
        //Console.WriteLine(Add(3f, 4.5f, 3.5f));
        //Console.WriteLine(Add("11", "22"));

        //Console.WriteLine(Calculate(4, 5));
        //Console.WriteLine(Calculate(4, 5, 2));

        //Console.WriteLine(Multiplication(4));
        //Console.WriteLine(Multiplication(3,6));
        //Console.WriteLine(Multiplication(1,2,3));

    


    static int Multiplication(int a)
    {
        int res = 1;
        for(int i = 1; i <= a; i++)
        {
            res *= i;
        }

        return res;
    }

    static int Multiplication(int a, int b)
    {
        int res = 1;
        for(int i = a; i <= b; i++)
        {
            res *= i;
        }

        return res;
    }

    static int Multiplication(int a, int b, int c)
    {
        return a * b * c;   
    }





    static int Calculate(int a, int b)
    {
        return a + b;
    }
    static int Calculate(int a, int b, int c)
    {
        return a * b * c;
    }









    static float Add(float a, float b)
    {
        return a + b;
    }
    static float Add(float a, float b, float c)
    {
        return a + b + c;
    }
    static string Add(string a, string b)
    {
        return a + b;
    }


}




namespace lesoon_6
{
    internal class Program
    {
        // 1
        static float Add(float a, float b)
        {
            return a + b;
        }
        
        static float Add(float a, float b, float c)
        {
            return a + b + c; 
        }
        
        static string Add(string a, string b)
        {
            return a + b; 
        }
        
        // 2
        static void Repeat(int a, int b)
        {
            for(int i = 0; i < b;  i++)
            {
                Console.WriteLine(a);
            }
        }
        
        static void Repeat(int a )
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(a);
            }
        }
        
        // 3
        static int Calculate(int a, int b)
        {
            return a + b;
        }
        
        static int Calculate (int a, int b, int c)
        {
            return a * b * c;
        }
        
        
        // 4
        static int getAmountDigit(int a)
        {
            var help = $"{a}";
            var sum = 0;
        
            for(int i = 0; i < help.Count(); i++)
            {
                sum++;
            }
            return sum;
        }
        
        static int getAmountDigit(string a)
        {
            var sum = 0;
            for(int i = 0; i < a.Count(); i++)
            {
                if (char.IsDigit(a[i]))
                {
                    sum++;
                }
            }
        
            return sum;
        }
        
        
        
        // 5
        
        static int findMax(int a, int b, int c)
        {
           return Math.Max(Math.Max(a, b), c);
        }
        
        static int findMax(int a, int b, int c, int d)
        {
            return Math.Max(Math.Max(a, b), Math.Max(c, d));
        
        }
        
        static int findMax(int a, int b, int c, int d, int f)
        {
            return Math.Max(Math.Max(a, b), Math.Max(Math.Max(c, d), f ));
        
        }
        
        // 6
        static int Summa(int a, int b)
        {
            if(a == b)
            {
                return a;
            }
            return a + Summa( a + 1, b );
        }
        
        
        
        
        
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1f, 3.5f)); // 1
            Repeat(3); // 2
            Console.WriteLine(Calculate(1, 2, 3)); // 3
            Console.WriteLine(getAmountDigit("salo00m")); // 4
            Console.WriteLine(findMax(1, 2, 3)); // 5
            Console.WriteLine(Summa(2, 4)); // 6
        
            Console.WriteLine(Max(2, 3)); // 10
            Console.WriteLine(Abs(-4));// 11
            Console.WriteLine(Isuppper('A')); // 12
            Console.WriteLine(Isdigit('0')); // 14
            Console.WriteLine(Islower('s')); // 15
            Console.WriteLine(Pow(2, 3)); // 16
        
        }
        
        // 10
        
        static int Max(int a, int b)
        {
            var big = a;
        
            if(big < b)
            {
                big = b;
            }
            return big;
        }
        
        // 11
        static int Abs(int a)
        {
            if(a < 0)
            {
                return a + a * (-2);
            } 
            return a;
        }
        
        // 12
        static bool Isuppper(char belgi)
        {
            if (belgi >= 'A' && belgi <= 'Z')
            {
                 return true;
            }
            return false;
        }
        
        // 14
        
        static bool Isdigit(char belgi)
        {
            if(belgi >= '0' &&  belgi <='9')
            {
                return true;
            }
            return false;
        }
        
        // 15
        
        static bool Islower(char belgi)
        {
            if (belgi >= 'a' && belgi <= 'z')
            {
                return true;
            }
            return false;
        }
        

    }
}


