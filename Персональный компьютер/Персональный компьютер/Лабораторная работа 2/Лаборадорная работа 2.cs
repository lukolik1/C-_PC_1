
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Персональный_компьютер.Лабораторная_работа_2
{
    class Лаборадорная_работа_2
    {

        public static double Task_6(double X)
        {
            Console.Write("Введите значение x:");
            X = Convert.ToDouble(Console.ReadLine());

            double a = 0;

            for (int i = 0; X < 4; i++)
            {
                a = X - 10;
            }

            double b = 0;

            if (X >= -2)
            {
                b = Math.Abs(X);
            }
            else if(X < -2)
            {
                b = X + 7;
            }

            double Y = a + (2 * b);

            return Y;

        }



        public static int Task_1_1(int x, int y)
        {
            int summ = 0;
            int command = 0;

            Console.Write("Введите от 1 до 4:");
            command = Convert.ToInt32(Console.ReadLine());

            switch (command)
            {
                case 1: summ = x + y; return summ;
                case 2: summ = x - y; return summ;
                case 3: summ = x * y; return summ;
                case 4: if (y == 0) return -1;  else summ = x / y; return summ;
                default:Console.WriteLine("Операции не существует" + command); return -1;
            }

        }

        // a)
        public static void Task_1_2()
        {

            int a, b, c, d, x, x2;

            
            Console.Write("Введите число a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("x - любое число");
                    else
                        Console.WriteLine("Решений нет");
                }
                else
                {
                    x = -1 * c / b;
                    Console.WriteLine("Один корень x = " + x);
                }
            }
            else
            {
                d = Convert.ToInt32(Math.Pow(b, 2) - 4 * a * c);
                if (d == 0)
                {
                    x = (-1 * b + Convert.ToInt32(d)) / (2 * a);
                    Console.WriteLine("Один корень x = " + x);
                }
                else if (d < 0)
                    Console.WriteLine("Корней нет");
                else
                {
                    x = (-1 * b + Convert.ToInt32(Math.Sqrt(d))) / (2 * a);
                    x2 = (-1 * b - Convert.ToInt32(Math.Sqrt(d))) / (2 * a);

                    Console.WriteLine("x = " + x);
                    Console.WriteLine("x2 = " + x2);
                }
            }

            }


        // б)
        public static void Task_1_2_1()
        {

            int a, b, c;
            Console.Write("Введите значение a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение c:");
            c = Convert.ToInt32(Console.ReadLine());


            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("x - любое число");
                    else
                        Console.WriteLine("Решений нет");
                }
                else
                {
                    int x;
                    x = -1 * c / b;
                    Console.WriteLine("Один корень x = " + x);
                }
            }
            else
            {

                int D = 0;

                D = Convert.ToInt32(Math.Pow(b, 2)) - (4 * a * c);

                int root = D;

                if (D == 0)
                {
                    root = 0;
                }
                else if (D > 0)
                {
                    root = 1;
                }
                else if (D < 0)
                {
                    root = -1;
                }
                switch (root)
                {
                    case 0:

                        int x;
                        x = -b / (2 * a);
                        Console.WriteLine("Корень = " + x);


                        break;
                    case 1:

                        int x1, x2;

                        x1 = (-b - Convert.ToInt32(Math.Sqrt(D))) / 2 * a;

                        x2 = (-b + Convert.ToInt32(Math.Sqrt(D))) / 2 * a;

                        Console.WriteLine("Два корня =" + x1 + " " + x2);




                        break;
                    case -1:
                        Console.WriteLine("Нет корней !");
                        break;

                }
            }





        }


        public static void Task_1_3()
        {

            int a, b, c;
            Console.Write("Введите значение a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение c:");
            c = Convert.ToInt32(Console.ReadLine());

            if(a + b > c && a + c > b && b + c > a)
            {
                int k, l, h;
                Console.Write("Можно построить ");
                if (a < b) { k = a; l = b; }
                else { k = b; l = a; }
                if (l < c) h = c;
                else { h = l; l = c; }
                double t1 = h * h, t2 = k * k + l * l;
                if (Math.Abs(t1 - t2) < .0) Console.Write(" прямоугольный ");
                else if (t1 < t2) Console.Write(" остроугольный ");
                else Console.Write(" тупоугольный ");
                Console.WriteLine("треугольник");
            }
            else
                Console.WriteLine("Треугольник построить нельзя!");







        }


        public static void Task_1_4()
        {

            double x1, y1;
            Console.Write("Введите точку x:");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите точку y:");
            y1 = Convert.ToDouble(Console.ReadLine());


            
            


            double PointlnCircle = Math.Pow(Math.Pow(y1 - 0, 2) + Math.Pow(x1 - 1, 2), 2);

            if ((x1 >= y1) && (y1 >= -0.8) && (PointlnCircle <= 1))
            {
                Console.WriteLine($"Точка (\"{x1}\", \"{y1}\") не входит в область.");
            }
            else
            {
                Console.WriteLine($"Точка (\"{x1}\", \"{y1}\") входит в область.");
            }



           





        }


        public static void Task_10()
        {
            int x, a, b;
            Console.Write("Введите значение четерёх значного числа:");
            x = Convert.ToInt32(Console.ReadLine());

            a = (x % 10) + (x / 1000);

            b = ((x % 1000) / 10) + ((x % 100) / 10);

            if (a == b)
            {
                Console.WriteLine("\"Да\"");
            }
            else
            {
                Console.WriteLine("\"Нет\"");
            }
        }




        public static void Task_15()
        {
            int COMMAND;
            Console.Write("Введите от (0 до 9):");
            COMMAND = Convert.ToInt32(Console.ReadLine());

            switch (COMMAND)
            {
                case 0: Console.Write("zero"); break;
                case 1: Console.Write("one"); break;
                case 2: Console.Write("two"); break;
                case 3: Console.Write("three"); break;
                case 4: Console.Write("four"); break;
                case 5: Console.Write("five"); break;
                case 6: Console.Write("six"); break;
                case 7: Console.Write("seven"); break;
                case 8: Console.Write("eight"); break;
                case 9: Console.Write("nine"); break;
            }
        }



        public static void Task_18()
        {
            Console.WriteLine("*******Коробка********");

            int A, B, C;
            Console.Write("Введите сторону A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите сторону B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите сторну C:");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*******Посылка********");

            int F, R, G;
            Console.Write("Введите сторону F:");
            F = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите сторону R:");
            R = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите сторну G:");
            G = Convert.ToInt32(Console.ReadLine());

            if(A <= F && B <= R && C <= F)
            {
                Console.WriteLine("Упаковать можно");
            }
            else
            {
                Console.WriteLine("Упаковать нельзя");
            }


        }


        public static void Bonus_Task()
        {
            int N, M;


            Console.Write("Этажей:");
            N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Номер этажа:");
            M = Convert.ToInt32(Console.ReadLine());



            if (M % 3 >= 0)
            {
                int A = N / 3;
                Console.WriteLine("Квартильный номер №:" + " " + A);
            }
        }
    }
}