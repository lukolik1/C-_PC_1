using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Персональный_компьютер.Лабораторная_работа_5
{
    class Лабораторная_работа_5
    {

        void Task_6()
        {
            Random random = new Random();
            int[] A = new int[15];

            int a = 0; int b = 0;




            Console.WriteLine("Чётные элементы:");

            Console.WriteLine("\t \t \t Нечётные элементы:");

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(1, 100);


                if (A[i] % 2 != 0)
                {
                    int[] L = new int[15];
                    L[a] = A[i];







                    Console.WriteLine("\t \t \t \t " + L[a]);



                }
                else
                {
                    int[] F = new int[15];
                    F[b] = A[i];


                    Console.WriteLine("\t" + F[b]);
                }









            }



            Console.ReadLine();
        }

        void Task_10()
        {

            Random random = new Random();
            int[] M = new int[15];

            int a = 0;






            for (int i = 1; i < M.Length; i++)
            {
                M[i] = random.Next(1, 100);



            }

            Array.Sort(M);


            a = M[0] + M[1] + M[2];

            Console.WriteLine("Сумма минимальных элементов массива:" + a);

            Console.ReadKey();
        }




        void Task_15()
        {
            const int ROWS = 5;
            const int COLS = 5;



            int[,] A = new int[ROWS, COLS];
            int[] A1 = new int[ROWS];
            int[] A3 = new int[ROWS];
            int[,] A2 = new int[ROWS, COLS];


            Random random = new Random();

            int tempmax1 = 0;


            Console.WriteLine("  Изначальный массив:");



            for (int i = 0; i < 5; i++)
            {


                for (int j = 0; j < 5; j++)
                {
                    A[i, j] = random.Next(-50, 50);


                    Console.Write("  " + A[i, j]);


                    if(A[i, j] > 0)
                    {
                        //Вывод A[i]
                    }
                    else
                    {
                        // Вывод сообщения
                    }
                }


                Console.WriteLine();


            }



            


            Console.WriteLine();
            Console.WriteLine();



            for (int i = 0; i < ROWS; i++)
            {
                int tempmax = A[4, 0];
                for (int j = 0; j < COLS; j++)
                {
                    if (A[4, j] < tempmax)
                    {
                        tempmax = A[4, j];

                    }
                }

                Console.WriteLine(tempmax);

                tempmax1 = tempmax;

            }




            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("  Итоговый массив:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    A2[i, j] = tempmax1 + A[0, i];

                    Console.Write("  " + A2[i, j]);
                }

                Console.WriteLine();

            }





            Console.ReadKey();

        }
    }
}


















