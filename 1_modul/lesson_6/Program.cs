using System;

namespace lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Recursiya
            Console.WriteLine(SummAB(4, 8));
            Console.WriteLine(SummAB1(4, 8));

            var s = "foundation";
            Console.WriteLine(CustomSubstr(s, 1));
            Console.WriteLine(CustomSubstr(s, 2, 4));

            Console.WriteLine(GetMax(4, 8));
            Console.WriteLine(GetMax(4, 8, 5));
            Console.WriteLine(GetMax("32", "54", "77"));

            Console.WriteLine(Add(1f, 3.5f));
            Repeat(3);
            Console.WriteLine(Calculate(1, 2, 3));
            Console.WriteLine(getAmountDigit("salo00m"));
            Console.WriteLine(findMax(1, 2, 3));
            Console.WriteLine(Summa(2, 4));

            Console.WriteLine(Max(2, 3));
            Console.WriteLine(Abs(-4));
            Console.WriteLine(Isuppper('A'));
            Console.WriteLine(Isdigit('0'));
            Console.WriteLine(Islower('s'));
            Console.WriteLine(Pow(2, 3));
        }

        // ===== RECURSION =====
        static int SummAB(int a, int b)
        {
            if (a == b) return a;
            return a + SummAB(a + 1, b);
        }

        static int SummAB1(int a, int b)
        {
            if (a == b - 1) return 0;
            return a + 1 + SummAB1(a + 1, b);
        }

        static int F(int n)
        {
            if (n == 1) return 1;
            return n * F(n - 1);
        }

        // ===== DEFAULT VALUE =====
        static string CustomSubstr(string s, int startIndex, int len = 0)
        {
            if (len == 0) len = s.Length;
            var res = string.Empty;
            for (var i = startIndex; i < len; i++)
                res += s[i];
            return res;
        }

        // ===== OVERLOADING =====
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

        static void Repeat(int a)
        {
            for (int i = 0; i < a; i++)
                Console.WriteLine(a);
        }

        static void Repeat(int a, int b)
        {
            for (int i = 0; i < b; i++)
                Console.WriteLine(a);
        }

        static int Calculate(int a, int b)
        {
            return a + b;
        }

        static int Calculate(int a, int b, int c)
        {
            return a * b * c;
        }

        static int getAmountDigit(int a)
        {
            var help = $"{a}";
            var sum = 0;
            for (int i = 0; i < help.Length; i++)
                sum++;
            return sum;
        }

        static int getAmountDigit(string a)
        {
            var sum = 0;
            for (int i = 0; i < a.Length; i++)
                if (char.IsDigit(a[i])) sum++;
            return sum;
        }

        static int findMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        static int Summa(int a, int b)
        {
            if (a == b) return a;
            return a + Summa(a + 1, b);
        }

        static int Max(int a, int b)
        {
            var big = a;
            if (big < b) big = b;
            return big;
        }

        static int Abs(int a)
        {
            if (a < 0) return a + a * (-2);
            return a;
        }

        static bool Isuppper(char belgi)
        {
            return belgi >= 'A' && belgi <= 'Z';
        }

        static bool Isdigit(char belgi)
        {
            return belgi >= '0' && belgi <= '9';
        }

        static bool Islower(char belgi)
        {
            return belgi >= 'a' && belgi <= 'z';
        }

        static int Pow(int a, int b)
        {
            int res = 1;
            for (int i = 0; i < b; i++)
                res *= a;
            return res;
        }
    }
}

