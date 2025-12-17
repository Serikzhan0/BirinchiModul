namespace lesson_5;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.Write("List lengthni kiriting : ");
        //var n = int.Parse(Console.ReadLine());

        //List<int> ints = new List<int>();

        //for(var i = 0; i < n; i++)
        //{
        //    Console.Write("List elementini kiriting : ");
        //    var num = int.Parse(Console.ReadLine());
        //    ints.Add(num);
        //}

        // Array vs List

        //List<int> nums = new List<int>();
        //nums.Add(4);
        //nums.Add(98);
        //nums.Add(22);
        //nums.Add(14);
        //nums.Add(45);
        //nums.Add(15);

        //foreach(int num in nums)
        //{
        //    Console.WriteLine(num);
        //}



        // List

        //List<string> res = GetIt();

        //res.Add("fdsfd"); // null

        //List<string> texts = new List<string>();
        //List<string> Texts;

        //texts.Add("G13");
        ////Texts.Add("G13"); // error : null

        //Texts = new List<string>();
        //Texts.Add("davay");




        //Array
        //int[] arr = new[] {3, 4}; // array
        //int[] arr1 = new int[5];
        //arr1[0] = 5;
        //arr1[1] = 7;
        //arr1[2] = 2;

        //Console.WriteLine(arr1.Count());
        //Console.WriteLine(arr1[0]);
        //Console.WriteLine(arr1[1]);
        //Console.WriteLine(arr1[2]);
        //Console.WriteLine(arr1[3]);
        //Console.WriteLine(arr1[4]);
        //Console.WriteLine(arr1[5]);


        //List<int> ints = new List<int>() { 3, 7, 8, 1 };
        //var res = IncreaseToTen(ints);
        //DisplayList(res);

        //List<int> ints = new List<int>() { 3, 5, 6, 5, 2, 5, 7 };
        //ints.Remove(3);
        //ints.RemoveAt(0);
        //DisplayList(ints);


        //List<string> strings = new List<string>() { "ds", "fd", "rr", "rr" };
        //strings.RemoveAt(0);
        //strings.Remove("fd");

        //Console.WriteLine(strings.Count());

        List<int> ints = new List<int>() { 2, 1, 5, 4, 3, 6 };

        ints.Sort();
        ints.Reverse();
        var res = ints.Contains(2);

        DisplayList(ints);



    }

    static List<int> GetEvenElements(List<int> nums)
    {
        for (var i = 0; i < nums.Count(); i++)
        {
            if (nums[i] % 2 != 0)
            {
                nums.RemoveAt(i);
                --i;
            }
        }

        return nums;
    }


    static void DisplayList(List<int> nums)
    {
        foreach (var a in nums)
        {
            Console.WriteLine(a);
        }
    }

    static List<int> IncreaseToTen(List<int> nums)
    {
        List<int> res = new List<int>();
        for (var i = 0; i < nums.Count(); i++)
        {
            res.Add(nums[i] + 10);
        }

        return res;
        
        
        //HOMEWORK
        
        // DRY : don't repeat yourself
        
        // "xboxy" => "yboyz"

        //Console.WriteLine(GetChangedXY("xboxy")); // 1.4.0.2

        // "hello" => "olleh"

        //Console.WriteLine(GetReversed("hello")); // 1.4.0.8

        //Console.WriteLine(IsPolindrome("kiyik")); // 1.4.0.10
        //Console.WriteLine(IsPolindrome("salom"));
        //Console.WriteLine(IsPolindrome("aka"));

        //Console.WriteLine(GetCountOfOK("oknok")); // 1.4.0.17


        // "salom nma gap g13 qale"
        // "" bo'sh string
        // "     " white space
    }


    static string GetTextBetweenFirtsTwoSpaces(string s)
    {
        var index1 = s.IndexOf(" ");
        var index2 = s.IndexOf(" ", index1 + 1);

        if(index1 == index2 || index2 == -1)
        {
            return string.Empty;
        }
        // "salom nma gap g13 qale"
        var res = s.Substring(index1 + 1, index2 - index1 - 1);
        return res;
    }

    static string RemoveSpaces(string s)
    {
        s = s.Replace(" ", "");

        return s;
    }

    static string GetDiff(string a, string b)
    {
        var diff = Math.Abs(a.Length - b.Length);

        if(a.Length > b.Length)
        {
            a = a.Remove(0, diff);
            return a + b;
        }

        b = b.Remove(0, diff);
        return a + b;
    }

    static string GetConCat(string a, string b)
    {
        // ok  da => okda
        // hello  kna => hellokna

        if (a[a.Length - 1] == b[0])
        {
            b = b.Remove(0, 1);
        }

        return a + b;
    }

    static string GetFirstTwo(string s)
    {
        return s.Substring(0, 2);
        // return s.Remove(3);
    }

    static int GetCountOfOK(string str)
    {
        // "oknok"
        var counter = 0;
        for(var i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == 'o' && str[i+1] == 'k')
            {
                ++counter;
            }
        }
        return counter;
    }


    static bool IsPolindrome(string str)
    {
        var res = string.Empty;

        for (var i = str.Length - 1; i >= 0; i--)
        {
            res = res + str[i];
        }

        return str == res;
    }

    static string GetReversed(string str)
    {
        // str = "hello"  res = "olleh"
        var res = string.Empty;


        for (var i = str.Length - 1; i >= 0; i--)
        {
            res = res + str[i];
        }

        //for(var i = 0; i < str.Length; i++)
        //{
        //    res = str[i] + res;
        //}

        return res;
    }


    static string GetChangedXY(string str)
    {
        var res = string.Empty;
        for (var i = 0; i < str.Length; i++)
        {
            if (str[i] == 'x')
            {
                res += 'y';
            }
            else if (str[i] == 'y')
            {
                res += 'z';
            }
            else
            {
                res += str[i];
            }
        }

        return res;


        //str = str.Replace('y', 'z');
        //str = str.Replace('x', 'y');
        //return str;
    }

}

