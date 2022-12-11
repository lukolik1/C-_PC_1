using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Персональный_компьютер.Лабораторная_работа_Вова
{
    class Лабораторная_работа4
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


        void Task_7()
        {
            string text;
            Console.WriteLine("Введите строку: ");
            text = Convert.ToString(Console.ReadLine());

            if (text.Length == 0)
            {
                Console.WriteLine("Введенная строка пустая!");
            }
            else
            {
                Console.WriteLine("Код первого символа: " + (int)text[0]);
                Console.WriteLine("Код последнего символа: " + (int)text[text.Length - 1]);
            }
        }



        void Task_15()
        {

            string text;
            Console.WriteLine("Введите строку: ");
            text = Convert.ToString(Console.ReadLine());


            int ind = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] >= 'a' && text[i] <= 'z') || (text[i] >= 'A' && text[i] <= 'Z'))
                    ind++;
                else if ((text[i] >= 'а' && text[i] <= 'я') || (text[i] >= 'А' && text[i] <= 'Я'))
                    ind++;

            }
            Console.WriteLine("\n Количество букв равно {0}", ind);
            Console.ReadKey();
        }

        void Task_18()
        {
            Console.WriteLine("Введите строку : ");
            string str = Convert.ToString(Console.ReadLine());

            char[] arr = str.ToCharArray();


            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsUpper(arr[i]))
                {
                    arr[i] = char.ToLower(arr[i]);
                }
                else if (char.IsLower(arr[i]))
                {
                    arr[i] = char.ToUpper(arr[i]);
                }
            }


            Console.WriteLine(arr);
            Console.ReadLine();
        }





        void Task_22()
        {
            string text;
            Console.WriteLine("Введите строку: ");
            text = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < text.Length; ++i)
            {
                if (text[i] < '0' || text[i] > '9')
                {
                    Console.WriteLine("Число введено некорректно");
                    Console.ReadLine();
                    break;


                }
                else
                {
                    int summ = 0;

                    for (int j = 0; j < text.Length; ++j)
                    {
                        summ += Convert.ToInt32(text[j]);
                    }

                    Console.WriteLine("Сумма равна: " + summ);
                    Console.ReadLine();
                    break;
                }
            }

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




        void Task_40()
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




        void Task_43()
        {
            char[] glas = new char[] { 'А' };

            char[] glas1 = new char[] { 'а' };

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




            void Task_53()
            {

                //string text;
                Console.WriteLine("Введите строку: ");
                text = Convert.ToString(Console.ReadLine());


                char[] signs1 = new char[] { '.', '?', '!', ',', ';', ':', '-', '(', ')', '<', '>', '\'', '\"' };

                


                int ind = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    for (int j = 0; j < signs1.Length; j++)
                    {

                        if (text[i] == signs1[j])
                            ind++;




                    }


                }

                Console.WriteLine("\n Количество знаков препинания равно {0}", ind);
                Console.ReadKey();
            }



            void Task_57()
            {

                //string text;
                Console.WriteLine("Введите строку: ");
                text = Convert.ToString(Console.ReadLine());

                string s;

                s = "";
                for (int i = 0; i < text.Length - 1; i++)
                {
                    if (text[i] == ' ' && text[i + 1] == ' ')
                        s = s + " ";
                    else
                        s = s + text[i];
                }

                Console.WriteLine("текст = " + s);

                Console.ReadLine();
            }


            void Task_63()
            {
                
                string text1 = "";
                byte i;

                Console.WriteLine("Введите строку: ");
                text = Convert.ToString(Console.ReadLine());

                for (i = 1; i < text.Length; i++)
                {
                    if (text[i] == 'Е')
                    {
                        char[] text2 = new char[] { 'Ж' };
                        text = Convert.ToString(text2[0]);
                    }
                    else if (text[i] == 'е')
                    {
                        char[] text2 = new char[] { 'ж' };
                        text = Convert.ToString(text2[0]);
                    }
                }

                for (i = 1; i < text.Length; i++)
                {
                    if ((text[i] >= 'А' || text[i] <= 'Ю' && text[i] != 'Ё'))
                    {

                        text1 = string.Concat(text.Select(x => (char)(x + 1)));



                    }
                    else if ((text[i] == 'Я'))
                    {
                        char[] text2 = new char[] { 'А' };
                        text1 = Convert.ToString(text2[0]);

                    }
                    else if ((text[i] >= 'а' || text[i] <= 'ю' && text[i] != 'ё'))
                    {

                        text1 = string.Concat(text.Select(x => (char)(x + 1)));
                    }
                    else if ((text[i] == 'я'))
                    {
                        char[] text2 = new char[] { 'а' };
                        text1 = Convert.ToString(text2[0]);
                    }


                }

                Console.WriteLine("Зашифрованная строка:");
                Console.Write(text1);

                Console.ReadLine();


                

            }



            void Task_68()
            {
                Console.WriteLine("Введите строку:");
                string str = Convert.ToString(Console.ReadLine()).ToLower();
                char tmp = ' ';
                bool flag = true;

                Console.WriteLine(str);

                for (int i = 0; i < str.Length; i++)
                {
                    if (!(char.IsDigit(str[i])))
                    {
                        if (tmp <= str[i])
                        {
                            tmp = str[i];
                        }
                        else
                        {
                            Console.WriteLine("Последовательность нарушена на {0} символе в строке", i + 1);
                            flag = false;
                            break;
                        }
                    }
                }

                if (flag == true)
                {
                    Console.WriteLine("Последовательность алфавита НЕ нарушена");
                }

                Console.ReadKey();

            }

        }
    }
}
