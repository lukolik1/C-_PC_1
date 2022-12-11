using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Персональный_компьютер.Лабораторная_работа_Артём
{
    class Артём
    {

        void Task_4()
        {
            int N;
            Console.WriteLine("Введите число: ");
            N = Convert.ToInt32(Console.ReadLine());
            if (1 <= N && N <= 26)
            {
                string[] alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                int i = 0;
                while (i <= N - 1)
                {

                    i++;
                }
                Console.WriteLine($"Ладинский алфавит под номером {N} Скрывается заглваная буква {alphabet[i - 1]}");




            }
            else
            {
                Console.WriteLine("Введите другое число!");
            }

            Console.ReadLine();




        }


        void Task_9()
        {
            char c1 = Convert.ToChar(Console.ReadLine());
            char c2 = Convert.ToChar(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a / 2; i++)
            {
                Console.Write(c1);
                Console.Write(c2);
            }
            Console.ReadLine();
        }


        void Task_14()
        {


            char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            string text;
            Console.WriteLine("Введите строку: ");
            text = Convert.ToString(Console.ReadLine());


            int ind = 0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (text[i] == alphabet[j])
                        ind++;




                }


            }


            Console.WriteLine("\n Количество букв равно {0}", ind);
            Console.ReadKey();
        }



        void Task_19()
        {
            double z;
            string s;

            Console.Write("Введите число: ");
            s = Console.ReadLine();

            z = Convert.ToDouble(s);

            if (Convert.ToInt32(z) == z)
                Console.WriteLine("1");
            else if (Convert.ToInt32(z) != z)
                Console.WriteLine("2");
            else
                Console.WriteLine("0");


            Console.ReadLine();



        }



        void Task_24()
        {
            string binaryNumber = Console.ReadLine();

            int multiplier = 1;
            int converted = 0;
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                int t = Convert.ToInt16(binaryNumber[i].ToString());
                converted = converted + (t * multiplier);
                multiplier = multiplier * 2;
            }


            Console.WriteLine(converted);


            Console.ReadLine();





        }



        void Task_29()
        {
            string s, so, f = "";
            char c;

            Console.WriteLine("Введите строку S : ");
            s = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Введите строку SO : ");
            so = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Введите символ C: ");
            c = Convert.ToChar(Console.ReadLine());


            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                    f += so + c;
                else
                    f += s[i];
            }

            Console.WriteLine(f);
            Console.ReadLine();
        }



        void Task_34()
        {
            string s, so;

            Console.WriteLine("Введите строку S : ");
            s = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Введите строку для удаления (или символ) SO : ");
            so = Convert.ToString(Console.ReadLine());

            int index = s.LastIndexOf(so);

            if (index != -1)
            {
                Console.WriteLine(s.Remove(index, so.Length));
            }
            else
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }

        void Task_39()
        {
            string text;
            Console.WriteLine("Введите строку: ");
            text = Convert.ToString(Console.ReadLine());


            string[] words = text.Split(' ');
            if (words.Length <= 2)
                Console.WriteLine("   ");
            else
                Console.WriteLine(words[words.Length - 1]);


            Console.ReadLine();
        }


        void Task_44()
        {
            char[] glas = new char[] { 'А' };



            string text;
            Console.WriteLine("Введите строку: ");
            text = Convert.ToString(Console.ReadLine());


            int ind = 0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < glas.Length; j++)
                {
                    if (text[i] == glas[j] && glas[j] == 3)
                        ind++;




                }


            }


            Console.WriteLine("\n Количество букв равно {0}", ind);
            Console.ReadKey();
        }


        void Task_49()
        {
            string text;
            Console.WriteLine("Введите строку: ");
            text = Convert.ToString(Console.ReadLine());

            int N;
            Console.WriteLine("Введите число: ");
            N = Convert.ToInt32(Console.ReadLine());

            string star = "";

            if (N > 0)
            {
                for (int i = 1; i <= N; i++)
                {

                    star += ".";


                }
                string result = "";
                for (int i = 0; i < text.Length; i++)
                {
                    result += text[i] + star;
                }


                Console.WriteLine(result);

                Console.ReadLine();
            }


        }

        void Task_54()
        {

            char[] glas = new char[] { 'А', 'О', 'У', 'Ы', 'Э', 'Е', 'Ё', 'И', 'Ю', 'Я' };

            char[] glas1 = new char[] { 'а', 'о', 'у', 'ы', 'э', 'е', 'ё', 'и', 'ю', 'я' };

            string text;
            Console.WriteLine("Введите строку: ");
            text = Convert.ToString(Console.ReadLine());


            int ind = 0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < glas.Length && j < glas1.Length; j++)
                {
                    if (text[i] == glas[j] || text[i] == glas1[j])
                        ind++;




                }


            }


            Console.WriteLine("\n Количество букв равно {0}", ind);
            Console.ReadKey();
        }



        void Task_59()
        {
            var extension = System.IO.Path.GetExtension("abc.doc");



            Console.WriteLine(extension);
            Console.ReadLine();
        }


         void Task_69()
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            var result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '{') result++;
                if (str[i] == '}') result--;
                if (result < 0)
                    Console.WriteLine(i + 1);
            }
            if (result > 0)
                Console.WriteLine("-1");

            Console.WriteLine(result);
        }

        }
    }
