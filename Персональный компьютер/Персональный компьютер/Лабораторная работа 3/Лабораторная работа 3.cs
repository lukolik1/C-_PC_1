using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Персональный_компьютер.Лабораторная_работа_4
{
    class Лабораторная_работа_3
    {

        void Task_3_1()
        {
            double N, sum = 0;

            Console.Write("Введите N член: ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (N > 0)
            {
                for (int x = 1; x <= N; x++)
                {

                    sum = Math.Sqrt(x + 2) / x;


                    Console.WriteLine(" элемент массива под  №" + x + " " + "Каждое слагаемое  = " + sum);

                    sum = sum + sum;

                }

                Console.WriteLine("\n Итоговая cумма =  " + sum);
            }
            else
            {
                Console.WriteLine("Предела не сушествует! \n введите другое число");
            }


        }


        void Task_3_2_1()
        {




            double N, sum = 0, e = 0.001, x = 0;

            Console.Write("Введите  сумму N членов: ");
            N = Convert.ToInt32(Console.ReadLine());


            if (N <= 0)
            {
                Console.WriteLine("Так как в цикле есть числа фибоначи они не толжны быть нулём или отрицательными !");
            }
            else
            {
                int i = 1;

                while (i <= N)
                {

                    i++;
                    x = i;

                    i = i * i;

                    sum = Math.Pow(-1, i) / i;

                    if (0 < e && e < 1)
                    {
                        Console.WriteLine("\nКаждое слагаемое цикла: " + sum);

                        Console.WriteLine();
                    }


                    sum = sum + sum;

                    Console.WriteLine();

                }

                Console.WriteLine("количество шагов " + x + " " + "Каждое слагаемое цикла: " + sum);


            }







        }



        void Task_3_2_2()
        {


            double N, sum = 0, e = 0.001, x = 0;

            Console.Write("Введите  сумму N членов: ");
            N = Convert.ToInt32(Console.ReadLine());


            if (N <= 0)
            {
                Console.WriteLine("Так как в цикле есть числа фибоначи они не толжны быть нулём или отрицательными !");
            }
            else
            {
                int i = 1;
                do
                {
                    i++;
                    x = i;

                    i = i * i;

                    sum = Math.Pow(-1, i) / i;

                    if (0 < e && e < 1)
                    {
                        Console.WriteLine("\nКаждое слагаемое цикла: " + sum);

                        Console.WriteLine();
                    }
                    sum = sum + sum;

                    Console.WriteLine();


                } while (i <= N);

                Console.WriteLine("количество шагов " + x + " " + "Каждое слагаемое цикла: " + sum);

                Console.ReadLine();
            }








        }







        void Task_6()
        {
            double X = 5, Z, Y = 0;

            const double stepx = 0.5;


            for (int i = 1; i <= 10; i++)
            {
                X += stepx;
                Z = X / Math.Sqrt(i + X);
                Y = Z;

                Console.WriteLine("элемент массива под  №" + i + " " + "Каждое значение X = " + X + " " + "Значение Y=" + Y);

            }








        }



        void Task_10()
        {
            int N, sum = 0;

            Console.Write("Введите значение N:");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {


                if (i / 5 == 3)
                {
                    Console.WriteLine(" Натуральные чисел:" + i);


                    sum = sum + i;




                }


            }
            Console.WriteLine(" Сумма натуральных чисел:" + sum);




        }


        void Task_11()
        {
            int N = 0;

            Console.Write("Введите число:");
            N = Convert.ToInt32(Console.ReadLine());

            int v = N;
            while (true)
            {
                if (N % 2 == 0)
                {
                    v--;
                    if (v % 5 == 0)
                    {
                        Console.WriteLine(v);
                        break;
                    }
                }

            }
        }



        void Task_2()
        {
            int m, x = 0;





            Console.Write("Введите число:");
            m = Convert.ToInt32(Console.ReadLine());

            x = -6;
            while (x <= 10)
            {
                double y = Math.Sqrt(Math.Pow(x, 2) - Math.Pow(m, 2));
                Console.WriteLine("Значение x= " + x + " " + "Значение y= " + y);
                x = x + 2;
            }

            Console.ReadLine();
        }







        void Task_15()
        {
            int N;

            Console.Write("Введите натуральное число  N:");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(" Все делители натурального числа: " + i);
                }

            }
            Console.WriteLine("натурального число: " + N);
        }


        void Task_18()
        {
            int N;

            double x = 0;



            Console.Write("Введите число:");
            N = Convert.ToInt32(Console.ReadLine());



            if (N % 2 != 0)
            {
                for (int i = 0; i < N; i++)
                {
                    x++;
                    while (x <= N)
                    {
                        x = x + x;
                    }

                }

                x = x / N;
                Console.WriteLine($"среднее арифметическое целых числа  {N} составило: " + x);
            }
            else
            {
                Console.WriteLine($"Чётнное число {N} Введите другое число");
            }

        }


      


        void Bonus()
        {
            int N;

            Console.Write(" Введите число n:");
            N = Convert.ToInt32(Console.ReadLine());

            N = N * 2;

            Console.WriteLine($"Всего лап {N}");




            for (int i = N, j = 0; i >= 0; i = i - 2, j++, i--)
            {


                Console.WriteLine("Гуси" + "  " + "Кролик");
                Console.WriteLine($" {i}" + "      " + $"{j}");






            }
        }


        void Task_17()
        {
            int m, n, s = 0, s2 = 0;

            Console.WriteLine("Введите N:");
            n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите M:");
            m = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                s = s + n % 10;






            }

            s2 = s2 + s;

            Console.WriteLine("\nРезультат = " + s2);
            Console.ReadLine();
        }


    }
}
