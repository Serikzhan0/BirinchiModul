namespace _3dars;

internal class Program
{
    static void Main(string[] args)
    {

        Console.Write("1 chis son : ");
        var num1 = int.Parse(Console.ReadLine());

        Console.Write("2 chis son : ");
        var num2 = int.Parse(Console.ReadLine());

        var num1Counter = 0;
        var num2Counter = 0;

        for (var i = 1; i <= num1; i++)
        {
            if (num1 % i == 0)
            {
                num1Counter++;
            }
        }

        for (var i = 1; i <= num2; i++)
        {
            if (num2 % i == 0)
            {
                num2Counter++;
            }
        }

        if (num1Counter == 2 && num2Counter == 2)
        {
            Console.WriteLine(num1 + num2);
        }
        else
        {
            Console.WriteLine(num1 * num2);
        }

        Main(args);





        // tub sonlar

        //Console.Write("Son kiriting : ");
        //var num = int.Parse(Console.ReadLine()); // 24
        //var counter = 0;

        //for(var i = 1; i <= num; i++)
        //{
        //    if(num % i == 0)
        //    {
        //        counter++;
        //    }
        //}

        //Console.Write($"{counter}  ");

        //if(counter == 2)
        //{
        //    Console.WriteLine("Tub");
        //}
        //else
        //{
        //    Console.WriteLine("Tub emas");
        //}

        //Main(args);



        // 24 => 




        // debugging

        //Console.Write("3 xonali son kiriting : ");
        //int num = int.Parse(Console.ReadLine());   
        //// 452
        //int r1 = num / 1 % 10;
        //int r2 = num / 10 % 10;
        //int r3 = num / 1000 % 10;

        //int res = r1+ r2 + r3;

        //Console.WriteLine($"Result : {res}");



        // compile time vs run time

        // var vs dynamic

        //dynamic num = 10;

        //num = "salom";

        //num = 57;

        //var num = 8;

        //var text = "salom";

        //text = "fcdngh";

        //var check = true;










        // do while

        //do
        //{
        //    Console.WriteLine("1");
        //    Console.WriteLine("2");
        //}
        //while (true);



        // foreach

        //string[] fruits = { "olma", "Banan", "anor", "Behi", "Nok", "Shaftoli" };

        //foreach (string fruit in fruits)
        //{
        //    int counter = 0;
        //    foreach (char ch in fruit)
        //    {
        //        if (ch == 'a' || ch == 'u'|| ch == 'i'|| ch == 'o'|| ch == 'e')
        //        {
        //            counter++;
        //        }
        //    }
        //    Console.WriteLine($"{fruit} : {counter}");
        //}







        //Random random = new Random();
        //int randomNumber = random.Next(1, 100);

        //int counter = 0;

        //while (true) // break
        //{
        //    Console.Write("Son kiriting : ");
        //    int num = int.Parse(Console.ReadLine());
        //    ++counter;
        //    if (num == randomNumber)
        //    {
        //        Console.WriteLine("Urra Urra");
        //        break;
        //    }

        //    if (counter == 6)
        //    {
        //        Console.WriteLine("Game over");
        //        Console.WriteLine($"Siz topolmagan son : {randomNumber}");
        //        break;
        //    }

        //    if (num > randomNumber)
        //    {
        //        Console.WriteLine("Kichikroq son kiriting");
        //    }

        //    else if (num < randomNumber)
        //    {
        //        Console.WriteLine("Kattaroq son kiriting");
        //    }
        //}



        // WHILE

        //int i = 1;

        //while(i <= 10)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}




        /* barcha 3 xonali sonlar ichidan
         * hamma raqammi toq sonlar 
         * ekranga chiqaring
         * hamma raqami toq sonlarga misol pastda
         * 157, 335, 799, 751, 571, 333, 111, 597
         */






        //for(int i = 100; i <= 999; i++)
        //{
        //    int r1 = i / 1 % 10;
        //    int r2 = i / 10 % 10;
        //    int r3 = i / 100 % 10;

        //    if (r1 % 2 != 0 && r2 % 2 != 0 && r3 % 2 != 0)
        //    {
        //        Console.Write($"{i}, ");
        //    }
        //}


        // Loops (for, while, do while, foreach)

        //Console.Write("1 chi sonni kiriting : ");
        //int num1 = int.Parse(Console.ReadLine());

        //Console.Write("2 chi sonni kiriting : ");
        //int num2 = int.Parse(Console.ReadLine());
        //// 16 5
        //for(int i = num1; i <= num2; i++)
        //{
        //    if (i % 3 == 0)
        //    {
        //        Console.Write($"{i}, ");
        //    }
        //}
        //Console.WriteLine();
        //for (int i = num1; i >= num2; i--)
        //{
        //    if (i % 3 == 0)
        //    {
        //        Console.Write($"{i}, ");
        //    }
        //}




        //for(int i = 100; i <= 200; i++)
        //{
        //    if(i % 2 == 0)
        //    {
        //        Console.Write($"{i}, ");
        //    }
        //}






        //int num = 55;

        //if(10 <= num && num <= 99)
        //{
        //    Console.WriteLine("Ikki xonali");
        //}

        /* Funksiya ichidagi o'zgaruvchilar kichik harda bo'lsin CamelCase (intValue)
         * {} alohida qatorda bo'lsin
         *
         *
         */
        
        
        // HOMEWORK 
        
        
        // Console.WriteLine("QIYIN");
        //
        // // 1
        // int a =
        //     int.Parse(Console.ReadLine());
        // int b =
        //     int.Parse(Console.ReadLine());
        // int c =
        //     int.Parse(Console.ReadLine());
        // int d =
        //     int.Parse(Console.ReadLine());
        //
        // int sums = a + b + c + d;
        // Console.WriteLine(sums);
        //
        //
        // // 2
        // float e =
        //     float.Parse(Console.ReadLine());
        // float f =
        //     float.Parse(Console.ReadLine());
        // float g =
        //     float.Parse(Console.ReadLine());
        //
        // float average = (e + f + g) / 3;
        // Console.WriteLine(average);
        //
        //
        // float k =
        //     float.Parse(Console.ReadLine());
        // float l =
        //     float.Parse(Console.ReadLine());
        // float m =
        //     float.Parse(Console.ReadLine());
        // float n =
        //     float.Parse(Console.ReadLine());
        // float p =
        //     float.Parse(Console.ReadLine());
        //
        // float averagee = (k + l + m + n + p) / 5;
        // Console.WriteLine(averagee);
        //
        //
        // // 3
        // float o =
        //     float.Parse(Console.ReadLine());
        // float q =
        //     float.Parse(Console.ReadLine());
        // float r =
        //     float.Parse(Console.ReadLine());
        // float t =
        //     float.Parse(Console.ReadLine());
        // float u =
        //     float.Parse(Console.ReadLine());
        // float v =
        //     float.Parse(Console.ReadLine());
        // float x =
        //     float.Parse(Console.ReadLine());
        // float y =
        //     float.Parse(Console.ReadLine());
        //
        // float averag = (o + q + r + t + u + v + x + y) / 8;
        // Console.WriteLine(averag);
        //
        //
        // // 4 
        // int firstnumber = int.Parse(Console.ReadLine());
        // int secondnumber = int.Parse(Console.ReadLine());
        //
        // int temp = firstnumber;
        // firstnumber = secondnumber;
        // secondnumber = temp;
        //
        // Console.WriteLine(firstnumber);
        // Console.WriteLine(secondnumber);
        //
        //
        // // 5 
        // int minutes =
        //     int.Parse(Console.ReadLine());
        // int seconds = minutes * 60;
        // Console.WriteLine(seconds);
        //
        //
        // // 6 
        // int hours = int.Parse(Console.ReadLine());
        // int secondss = hours * 3600;
        // Console.WriteLine(secondss);
        //
        // // 7
        // int days = int.Parse(Console.ReadLine());
        // int minutess = days * 24 * 60;
        // Console.WriteLine(minutess);
        //
        // // 8 
        // int minute = int.Parse(Console.ReadLine());
        // int hour = minute / 60;
        // Console.WriteLine(hour);
        //
        //
        // // 9
        // int minut = int.Parse(Console.ReadLine());
        // int day = minut / (24 * 60);
        // Console.WriteLine(day);
        //
        // Console.WriteLine("JUDA QIYIN MASALALAR");
        //
        //
        //
        // // 1
        // {
        //     int age = int.Parse(Console.ReadLine());
        //     int birthYear = 2024 - age;
        //     Console.WriteLine(birthYear);
        // }
        //
        //
        // // 2
        // {
        //     int number = int.Parse(Console.ReadLine());
        //     int bigger = number + 1;
        //     int smaller = number - 1;
        //     Console.WriteLine(bigger);
        //     Console.WriteLine(smaller);
        // }
        //
        //
        // // 3
        // {
        //     int number = int.Parse(Console.ReadLine());
        //     int bigger10 = number + 10;
        //     int smaller15 = number - 15;
        //     Console.WriteLine(bigger10);
        //     Console.WriteLine(smaller15);
        // }
        //
        // // 4
        // {
        //     int aa = int.Parse(Console.ReadLine());
        //     int bb = int.Parse(Console.ReadLine());
        //
        //     int sum = aa + bb;
        //     int diff = aa - bb;
        //     int product = aa * bb;
        //     double division = (double)aa / bb;
        //
        //     Console.WriteLine(sum);
        //     Console.WriteLine(diff);
        //     Console.WriteLine(product);
        //     Console.WriteLine(division);
        // }
        //
        // // 5
        // {
        //     int number = int.Parse(Console.ReadLine());
        //
        //     int x3 = number * 3;
        //     int x4 = number * 4;
        //     int x5 = number * 5;
        //
        //     Console.WriteLine(x3);
        //     Console.WriteLine(x4);
        //     Console.WriteLine(x5);
        // }
            
           
        // 1
        //   int n1 = int.Parse(Console.ReadLine());
        //   Console.WriteLine(n1 % 10);
        //
        //   // 2
        //   int n2 = int.Parse(Console.ReadLine());
        //   Console.WriteLine((n2 / 10) % 10);
        //
        //   // 3
        //   int n3 = int.Parse(Console.ReadLine());
        //   Console.WriteLine(n3 / 100);
        //
        //   // 4
        //   int n4 = int.Parse(Console.ReadLine());
        //   Console.WriteLine((n4 / 1000) % 10);
        //
        //   // 5
        //   int n5 = int.Parse(Console.ReadLine());
        //   Console.WriteLine((n5 / 100) % 10);
        //
        //   // 6
        //   int n6 = int.Parse(Console.ReadLine());
        //   int sum6 = n6 / 100 + (n6 / 10) % 10 + n6 % 10;
        //   Console.WriteLine(sum6);
        //
        //   // 7
        //   int n7 = int.Parse(Console.ReadLine());
        //   int prod7 = (n7 / 100) * ((n7 / 10) % 10) * (n7 % 10);
        //   Console.WriteLine(prod7);
        //
        //   // 8
        //   int n8 = int.Parse(Console.ReadLine());
        //   Console.WriteLine((n8 / 10) * (n8 % 10));
        //
        //   // 9
        //   int n9 = int.Parse(Console.ReadLine());
        //   int sum9 = n9 / 10000 + (n9 / 1000) % 10 + (n9 / 100) % 10 + (n9 / 10) % 10 + n9 % 10;
        //   Console.WriteLine(sum9);
        //
        //   // 10
        //   int n10 = int.Parse(Console.ReadLine());
        //   int rev10 = (n10 % 10) * 100 + ((n10 / 10) % 10) * 10 + (n10 / 100);
        //   Console.WriteLine(rev10);
        //
        //   // 11
        //   int n11 = int.Parse(Console.ReadLine());
        //   int a11 = n11 / 100;
        //   int b11 = (n11 / 10) % 10;
        //   int c11 = n11 % 10;
        //   Console.WriteLine(a11 * 100 + c11 * 10 + b11);
        //
        //   // 12
        //   int n12 = int.Parse(Console.ReadLine());
        //   int a12 = n12 / 100;
        //   int b12 = (n12 / 10) % 10;
        //   int c12 = n12 % 10;
        //   Console.WriteLine(b12 * 100 + a12 * 10 + c12);
        //
        //   // 13
        //   int n13 = int.Parse(Console.ReadLine());
        //   int a13 = n13 / 1000;
        //   int b13 = (n13 / 10) % 10;
        //   int c13 = (n13 / 100) % 10;
        //   int d13 = n13 % 10;
        //   Console.WriteLine(b13 * 1000 + c13 * 100 + a13 * 10 + d13);
        //
        //   // 14
        //   int gb14 = int.Parse(Console.ReadLine());
        //   Console.WriteLine(gb14 * 1024);
        //
        //   // 15
        //   int gb15 = int.Parse(Console.ReadLine());
        //   Console.WriteLine(gb15 * 1024L * 1024 * 1024 * 8);
        //
        //   // 16
        //   int gb16 = int.Parse(Console.ReadLine());
        //   Console.WriteLine((double)gb16 / 1024);
        //
        //   // 17
        //   int gb17 = int.Parse(Console.ReadLine());
        //   Console.WriteLine(gb17 / 2);
        //
        //   // 18
        //   int gb18 = int.Parse(Console.ReadLine());
        //   Console.WriteLine(gb18 / 5);
        //
        //   // 19
        //   int n19 = int.Parse(Console.ReadLine());
        //   int a19 = n19 / 100;
        //   int rest19 = n19 % 100;
        //   Console.WriteLine(rest19 * 10 + a19);
        //
        //  // 20
        //  int n20 = int.Parse(Console.ReadLine());
        //  int a20 = n20 % 10;
        //  int rest20 = n20 / 10;
        // Console.WriteLine(a20 * 100 + rest20);
        //
        
        
        
        // 1. 
        // int x1 = int.Parse(Console.ReadLine());
        // int x1_2 = x1 * x1;
        // int x1_4 = x1_2 * x1_2;
        // Console.WriteLine("1) 4 даража: " + x1_4);
        //
        // // 2. 
        // int x2 = int.Parse(Console.ReadLine());
        // int x2_2 = x2 * x2;
        // int x2_3 = x2_2 * x2;
        // int x2_6 = x2_3 * x2_3;
        // Console.WriteLine("2) 6 даража: " + x2_6);
        //
        // // 3. 
        // int x3 = int.Parse(Console.ReadLine());
        // int x3_2 = x3 * x3;
        // int x3_4 = x3_2 * x3_2;
        // int x3_8 = x3_4 * x3_4;
        // Console.WriteLine("3) 8 даража: " + x3_8);
        //
        // // 4. 
        // int kun4 = int.Parse(Console.ReadLine());
        // int soat4 = int.Parse(Console.ReadLine());
        // int jamiSoat4 = kun4 * 24 + soat4;
        // Console.WriteLine("4) Jami soat: " + jamiSoat4);
        //
        // // 5. 
        // int hafta5 = int.Parse(Console.ReadLine());
        // int soat5 = int.Parse(Console.ReadLine());
        // int jamiKun5 = hafta5 * 7 + soat5 / 24;
        // Console.WriteLine("5) Jami kun: " + jamiKun5);
        //
        // // 6. 
        // int soat6 = int.Parse(Console.ReadLine());
        // int minut6 = int.Parse(Console.ReadLine());
        // int jamiSekund6 = soat6 * 3600 + minut6 * 60;
        // Console.WriteLine("6) Jami sekund: " + jamiSekund6);
        //
        // // 7.
        // int bayt7 = int.Parse(Console.ReadLine());
        // int kb7 = bayt7 / 1024;
        // Console.WriteLine("7) Kilobayt: " + kb7);
        //
        // // 8. 
        // double tezlik8 = 750;
        // double hajmGB8 = 1.8;
        // double hajmKB8 = hajmGB8 * 1024 * 1024;
        // double sekund8 = hajmKB8 / tezlik8;
        // Console.WriteLine("8) Sekundda uzatiladi: " + sekund8);
        //
        // // 9. 
        // int dollar9 = int.Parse(Console.ReadLine());
        // int evro9 = int.Parse(Console.ReadLine());
        // int som9 = dollar9 * 12600 + evro9 * 14500;
        // Console.WriteLine("9) Jami som: " + som9);
        //
        // // 10. 
        // int x10 = int.Parse(Console.ReadLine());
        // int x10_2 = x10 * x10;
        // int x10_4 = x10_2 * x10_2;
        // int x10_8 = x10_4 * x10_4;
        // int x10_10 = x10_8 * x10_2;
        // Console.WriteLine("10) 10 даража: " + x10_10);
        //
        // // 11. 
        // int sahifa11 = 720;
        // int qator11 = 50;
        // int belgi11 = 152;
        // int bayt11 = sahifa11 * qator11 * belgi11;
        // double mb11 = bayt11 / (1024.0 * 1024.0);
        // Console.WriteLine("11) Kitob hajmi (MB): " + mb11);
        //
        // // 12. 
        // int N12 = int.Parse(Console.ReadLine());
        // double daq12 = 2.5;
        // double soz12 = (N12 * daq12) / 5;
        // Console.WriteLine("12) So‘zlar soni: " + soz12);
        //
        // // 13. 
        // int a13 = int.Parse(Console.ReadLine());
        // int b13 = int.Parse(Console.ReadLine());
        // a13 = a13 + b13;
        // b13 = a13 - b13;
        // a13 = a13 - b13;
        // Console.WriteLine("13) Yangi a: " + a13 + ", Yangi b: " + b13);
        //
        // // 14. 
        // int A14 = int.Parse(Console.ReadLine());
        // int B14 = int.Parse(Console.ReadLine());
        // int C14 = int.Parse(Console.ReadLine());
        // int temp14 = A14;
        // A14 = B14;
        // B14 = C14;
        // C14 = temp14;
        // Console.WriteLine("14) Yangi A, B, C: " + A14 + " " + B14 + " " + C14);
        //
        // // 15. Патрик даёт Джулии
        // double patrik15 = double.Parse(Console.ReadLine());
        // double julia15 = double.Parse(Console.ReadLine());
        // double ber15 = (patrik15 - julia15) / 2;
        // Console.WriteLine("15) Patrik berishi kerak: " + ber15);
        //
        // // 16. Км + метры в дм
        // int km16 = int.Parse(Console.ReadLine());
        // int m16 = int.Parse(Console.ReadLine());
        // int dm16 = km16 * 10000 + m16 * 10;
        // Console.WriteLine("16) Jami dm: " + dm16);
        //
        // // 17. 
        // int x17 = int.Parse(Console.ReadLine());
        // int x17_2 = x17 * x17;       
        // int x17_3 = x17_2 * x17;     
        // int x17_6 = x17_3 * x17_3;  
        // int x17_12 = x17_6 * x17_6;  
        // int x17_15 = x17_12 * x17_3; 
        // Console.WriteLine("17) 15 даража: " + x17_15);
        //
        // // 18. 
        // int a18 = int.Parse(Console.ReadLine());
        // int b18 = int.Parse(Console.ReadLine());
        // int c18 = int.Parse(Console.ReadLine());
        // int d18 = int.Parse(Console.ReadLine());
        // int jamiStul = a18 * b18 * c18 * d18;
        // int jamiPart = jamiStul / 2;
        // Console.WriteLine("18) Jami part: " + jamiPart);
        //
        // // 19. 
        // int soat19 = int.Parse(Console.ReadLine());
        // int minut19 = int.Parse(Console.ReadLine());
        // int sekund19 = int.Parse(Console.ReadLine());
        // int jamiMinut19 = soat19 * 60 + minut19 + sekund19 / 60;
        // Console.WriteLine("19) Jami minut: " + jamiMinut19);
        //
        // // 20. 
        // double X20 = double.Parse(Console.ReadLine());
        // double Y20 = double.Parse(Console.ReadLine());
        // double A20 = double.Parse(Console.ReadLine());
        // double B20 = double.Parse(Console.ReadLine());
        // double qimmat20 = (B20 / Y20) - (A20 / X20);
        // Console.WriteLine("20) 1 kg shokolad qimmatligi: " + qimmat20);
        //
        
        
        // // 1 
        // for (var i = 1; i <= 20; i++)
        // {
        //         Console.WriteLine(i);
        // }
        
        
        // 2
        // for (var i = 25; i <= 100; i++)
        // {
        // Console.WriteLine(i);    
        // }
        
        // 3
        // for (var i = 12; i <= 200; i++)
        // {
        //     Console.WriteLine(i);
        // }
        
        // 4
        // for (var i = 15; i >= 2; i--)
        // {
        //     Console.WriteLine(i);
        // }
        
        // 5 
        // for (var i = 120; i >= 23; i--)
        // {
        //     Console.WriteLine(i);
        // }
        
        
        // 6
        // for (var i = 10; i <= 50; i++)
        // {
        //     if (i % 2 != 0)
        //         Console.WriteLine(i);
        // }

        
        // 7
        // for (var i = 120; i <= 250; i++)
        // {
        //     if(i % 2 == 0)
        //         { 
        //             Console.WriteLine(i);
        //         }
        // }
        
        
        // 8
        // for (var i = 50; i <= 100; i++)
        // {
        //     if (i % 2 != 0)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }
        
        
        // 9
        // for (var i = 20; i <= 80; i++)
        // {
        //     if (i % 2 == 0)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }
        
        
        // 10
        // int a = 10;
        // int b = 50;
        //
        // for (var i = a; i <= b; i++)
        // {
        //     if (i % 5 == 0)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }
        
        
        // 11
        // int a1 = 19;
        // int b1 = 80;
        //
        // for (var i = a1; i <= b1; i++)
        // {
        //     if (i % 4 == 0 && i % 7 == 0)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }

        
        // 12
        // var a3 = 13;
        // var b3 = 20;
        //
        // var count = 0;
        // for (var i = a3; i <= b3; i++)
        // {
        //     if (i % 8 == 0)
        //     {
        //         count++;
        //     }
        //
        //     {
        //         Console.WriteLine("8 ga karrali sonlarni miqdori, "  + count++);
        //     }
        // }
        
        
        // 13
        // var a2 = 15;
        // var b2 = 30;
        //
        // for (var i = a2; i <= b2; i--)
        // {
        //     if (i % 9 == 0 && i % 4 == 0) ;
        // }
        //
        // {
        //     Console.WriteLine(b2);
        // }
        
        
        // 14 
        int sum = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)   // toq son
            {
                sum += i;
            }
        }

        Console.WriteLine("Yig'indi: " + sum);
        
        



        
    }

    }
