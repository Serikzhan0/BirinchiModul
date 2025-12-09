// namespace lesson_4;
//
// internal class Program
// {


// return type

    // static string RemoveDigits(string str) 
    // {
    //     // "S2L45trg8"
    //     for (var i = 0; i < str.Length; i++)
    //     {
    //         if (char.IsDigit(str[i]))
    //         {
    //             str = str.Remove(i, 1);
    //             i--;
    //         }
    //     }
    //     return str;
    // }


    // static int GetCountOfCapitalLetter(string s)
    // {
    //     int count = 0;
    //     for (var i = 0; i < s.Length; i++)
    //     {
    //         if (char.IsUpper(s[i]))
    //         {
    //             count++;
    //         }
    //     }
    //
    //     return count;
    // }




    // static void Main(string[] args)
    // {

        // var str = "Salom Dunyo! Hello World! G13 .net";
        //
        // Console.WriteLine(GetCountOfCapitalLetter(str));


        //var s = "Nma Gap";

        //var res = s.ToUpper();

        //Console.WriteLine(res); 
        //Console.WriteLine(s); 

        //var res = RemoveDigits("S2L45trg8");

        //Console.WriteLine(res);

        //char.IsLetter(); // harflikga tekshiradi
        //char.IsDigit(); // raqamlikka tekshiradi
        //char.IsWhiteSpace(); // bo'sh joyga tekshiradi
        //char.IsUpper(); // katta harfga tekshiradi
        //char.IsLower(); // kichik harfga tekshiradi



        //var str = ""; // string.Empty
        //var str1 = string.Empty;

        //if("" == string.Empty)
        //{
        //    Console.WriteLine("dskjfv");
        //}

        // IndexOf

        //string str = "Hello World World World";

        //var res1 = str.IndexOf("World");
        //var res2 = str.IndexOf("World", 7);
        //var res3 = str.IndexOf("jdfh");

        //Console.WriteLine(res1);
        //Console.WriteLine(res2);
        //Console.WriteLine(res3);





        // Trim

        //string str = "****Hello ** fd ** World*****";

        //var res = str.Trim('*');

        //Console.WriteLine(res);
        //Console.WriteLine(str);


        // Contains

        //string str = "Hello World World World";

        //var res = str.Contains("ds");

        //Console.WriteLine(res);



        // Remove

        //var str = "Uzbekiston";

        //var res = str.Remove(0,20);

        //Console.WriteLine(str);
        //Console.WriteLine(res);



        //string str = "G13 .net";

        //var len = str.Length;

        //Console.WriteLine(len);


        // 1. satr berilgan oxiridan 3 ta belgini ekranga chiqaring
        // TestCase
        // Input: "Foundation"  output: "ion"
        // Input: "davay"  output: "vay"

        //string str = "davay";

        //var res = str.Substring(str.Length - 3);
        //Console.WriteLine(res);



        // 2. satr berilgan oxiridan oxiridan 2 ta boshidan 2 ta 
        // olmasdan o'rtadagi belgilarni chiqaring
        // TestCase
        // Input: "Foundation"  output: "undati"
        // Input: "davay"  output: "v"


        //string str = "Foundation";

        //var res = str.Substring(2, str.Length - 4);
        //Console.WriteLine(res);

        // string

        //string text = "salom Hello g13";

        //// Substring

        //var res2 = text.Substring(0);

        //Console.WriteLine(res2);

        //var res1 = text.Substring(6, 5);
        //Console.WriteLine(res1);
        //Console.WriteLine(text);


        // HOMEWORK
        class Program
        {
            // 1.4. //1
            // static int Qoshish(int a, int b)
            // {
            //     return a + b;
            // }
            //
            // static void Main()
            // {
            //     int result = Qoshish(10, 5);
            //     Console.WriteLine(result); 
            // }


            // 1.4 //2
            // static string ReplaceXYZ(string str)
            // {
            //     string result = "";
            //
            //     foreach (char c in str)
            //     {
            //         if (c == 'x')
            //             result += 'y';
            //         else if (c == 'y')
            //             result += 'z';
            //         else
            //             result += c;
            //     }
            //
            //     return result;
            // }
            //
            // static void Main()
            // {
            //     Console.Write("Matn kiriting: ");
            //     string input = Console.ReadLine();
            //
            //     string output = ReplaceXYZ(input);
            //
            //     Console.WriteLine("Natija: " + output);
            //
            //     Console.ReadLine(); 


            //1.4 //3
            static int CountLowercase(string str)
            {
                int count = 0;
                foreach (char c in str)
                {
                    if (char.IsLower(c))
                        count++;
                }

                return count;
            }
            
            
                //1.4 //4
                static int CountOdds(int a, int b)
                {
                    int count = 0;
                    for (int i = a + 1; i < b; i++)
                        if (i % 2 != 0)
                            count++;
                    return count;
                }


                //1.4 //5
                static int CountDigits(int num)
                {
                    return Math.Abs(num).ToString().Length;
                }


                //1.4 //6
                static bool IsAllDigits(string str)
                {
                    foreach (char c in str)
                        if (!char.IsDigit(c))
                            return false;
                    return true;
                }


                //1.4 //7
                static bool IsPrime(int num)
                {
                    if (num <= 1) return false;
                    for (int i = 2; i <= Math.Sqrt(num); i++)
                        if (num % i == 0)
                            return false;
                    return true;
                }


                //1.4 //8
                static string ReverseString(string str)
                {
                    char[] arr = str.ToCharArray();
                    Array.Reverse(arr);
                    return new string(arr);
                }


                //1.4 //9
                static int CountSpaces(string str)
                {
                    int count = 0;
                    foreach (char c in str)
                        if (c == ' ')
                            count++;
                    return count;
                }


                //1.4 //10
                static bool IsPalindrome(string str)
                {
                    return str == ReverseString(str);
                }


                //1.4 //12
                static int CountDigitChars(string str)
                {
                    int count = 0;
                    foreach (char c in str)
                        if (char.IsDigit(c))
                            count++;
                    return count;
                }


                //1.4 //13
                static int CountUpperLetters(string str)
                {
                    int count = 0;
                    foreach (char c in str)
                        if (char.IsUpper(c))
                            count++;
                    return count;
                }


                //1.4 //14
                static bool IsAllUpper(string str)
                {
                    foreach (char c in str)
                        if (!char.IsUpper(c))
                            return false;
                    return true;
                }


                //1.4 //15
                static bool IsAllLower(string str)
                {
                    foreach (char c in str)
                        if (!char.IsLower(c))
                            return false;
                    return true;
                }


                //1.4 //16
                static string ToUpperAll(string str)
                {
                    return str.ToUpper();
                }


                //1.4 //17
                static int CountOk(string str)
                {
                    int count = 0;
                    for (int i = 0; i < str.Length - 1; i++)
                        if (str[i] == 'o' && str[i + 1] == 'k')
                            count++;
                    return count;
                }


                //1.4 //18
                static string ReplaceLowerWithStar(string str)
                {
                    string result = "";
                    foreach (char c in str)
                        result += char.IsLower(c) ? '*' : c;
                    return result;
                }


                //1.4 //19
                static string ToLowerAll(string str)
                {
                    return str.ToLower();
                }


                //1.4 //21
                static int CountAt(string str)
                {
                    int count = 0;
                    foreach (char c in str)
                        if (c == '@')
                            count++;
                    return count;
                }


                static void Main()
                {
                    // 3
                    Console.Write("Matn kiriting: ");
                    string input = Console.ReadLine();

                    int towercaseCount = CountLowercase(input);

                    Console.WriteLine("Natija: " + towercaseCount);

                    // 4
                    Console.WriteLine("4) Ikki son kiriting:");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(CountOdds(a, b));

                    // 5
                    Console.WriteLine("\n5) Son kiriting:");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine(CountDigits(num));

                    // 6
                    Console.WriteLine("\n6) String kiriting:");
                    string s = Console.ReadLine();
                    Console.WriteLine(IsAllDigits(s));

                    // 7
                    Console.WriteLine("\n7) Son kiriting:");
                    int p = int.Parse(Console.ReadLine());
                    Console.WriteLine(IsPrime(p));

                    // 8
                    Console.WriteLine("\n8) String kiriting:");
                    string r = Console.ReadLine();
                    Console.WriteLine(ReverseString(r));

                    // 9
                    Console.WriteLine("\n9) String kiriting:");
                    string sp = Console.ReadLine();
                    Console.WriteLine(CountSpaces(sp));

                    // 10
                    Console.WriteLine("\n10) String kiriting:");
                    string pal = Console.ReadLine();
                    Console.WriteLine(IsPalindrome(pal));

                    //  12
                    Console.WriteLine("\n12) String kiriting:");
                    string d = Console.ReadLine();
                    Console.WriteLine(CountDigitChars(d));

                    //  13
                    Console.WriteLine("\n13) String kiriting:");
                    string up = Console.ReadLine();
                    Console.WriteLine(CountUpperLetters(up));

                    //  14
                    Console.WriteLine("\n14) String kiriting:");
                    string allU = Console.ReadLine();
                    Console.WriteLine(IsAllUpper(allU));

                    //  15
                    Console.WriteLine("\n15) String kiriting:");
                    string allL = Console.ReadLine();
                    Console.WriteLine(IsAllLower(allL));

                    //  16
                    Console.WriteLine("\n16) String kiriting:");
                    string big = Console.ReadLine();
                    Console.WriteLine(ToUpperAll(big));

                    // 17
                    Console.WriteLine("\n17) String kiriting:");
                    string ok = Console.ReadLine();
                    Console.WriteLine(CountOk(ok));

                    //  18
                    Console.WriteLine("\n18) String kiriting:");
                    string star = Console.ReadLine();
                    Console.WriteLine(ReplaceLowerWithStar(star));

                    //  19
                    Console.WriteLine("\n19) String kiriting:");
                    string low = Console.ReadLine();
                    Console.WriteLine(ToLowerAll(low));

                    //  21
                    Console.WriteLine("\n21) String kiriting:");
                    string at = Console.ReadLine();
                    Console.WriteLine(CountAt(at));
                }
            }
        

            
        

    





        
        
        

            
        
    

 