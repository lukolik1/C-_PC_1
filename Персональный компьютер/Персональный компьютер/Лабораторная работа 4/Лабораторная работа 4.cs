using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Персональный_компьютер.Лабораторная_работа_4
{
    class Лабораторная_работа_4
    {
        // Внимание! Начертить с помощью программы Visio блок-схему,
        //соответствующую программному коду Примера 4.2.
        //Отчет по Лабораторной работе №4 должен включать:
        //1. Условие задачи из Примера 4.2.
        //2. Программный код этой задачи.
        //3. Блок-схему, соответствующую приведенному программному коду.
        //4. Скриншоты выполнения программы.




        void Task_1()
        {

            char c;

            Console.WriteLine("Введите сивол на русском языке(англиском): ");
            c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Символ {c} имеит номер в кодовой таблице {(int)c}");
            Console.ReadKey();




        }


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



        void Task_12()
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

                    star += "*";


                }
                string result = "";
                for (int i = 0; i < text.Length; i++)
                {
                    result += text[i] + star;
                }


                Console.WriteLine(result);
            }


            void Task_15()
            {

                
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


            void Task_26()
            {
                
                Console.WriteLine("Введите число: ");
                N = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите строку: ");
                string s = Convert.ToString(Console.ReadLine());

                if (s.Length > N)
                {
                    s = s.Substring(s.Length - N);
                    Console.WriteLine(s);
                }
                else if (s.Length < N)
                {
                    string point = "";
                    for (int i = 0; i <= 0; i++)
                    {

                        point += ".";


                    }
                    string result = "";

                    result = point + s;


                    Console.WriteLine(result);
                }

                Console.ReadLine();
            }


            void Task_31()
            {
                Console.WriteLine("Введите строку S: ");
                string S = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Введите строку SO: ");
                string SO = Convert.ToString(Console.ReadLine());

                bool subString = false;

                for (int i = 0; i < S.Length - SO.Length; i++)
                {
                    for (int j = 0; j < SO.Length; j++)
                    {
                        if (SO[j] != S[i + j])
                        {
                            subString = false;
                            break;
                        }
                        else
                            subString = true;
                        break;
                    }

                }
                if (subString == true)
                    Console.WriteLine("\nTRUE");
                else
                    Console.WriteLine("\nFALSE");

                Console.ReadLine();
            }


            void Task_37()
            {
                Console.WriteLine("Введите строку S: ");
                string S = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Введите строку S1: ");
                string S1 = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Введите строку S2: ");
                string S2 = Convert.ToString(Console.ReadLine());


                int index = S.Length - 1;

                while (!S.Substring(index, S.Length - index).Contains(S1) && index >= 0)
                {
                    index--;
                }

                S = S.Substring(0, index) + S.Substring(index, S.Length - index).Replace(S1, S2);

                Console.WriteLine("\n" + S);

                Console.ReadLine();
            }


            void Task_40()
            {

                Console.WriteLine("Введите строку: ");
                text = Convert.ToString(Console.ReadLine());


                string[] words = text.Split(' ');
                if (words.Length <= 2)
                    Console.WriteLine("   ");
                else
                    Console.WriteLine(words[words.Length - 1]);


                Console.ReadLine();


            }


            void Task_46()
            {
                Console.WriteLine("Введите строку (на русском): ");
                string S = Convert.ToString(Console.ReadLine());

                string[] slove = S.Split(' ');
                int[] Mass = new int[slove.Length];

                for (int i = 0; i < slove.Length; i++)
                {
                    if (slove[i] != " " && slove[i] != string.Empty)
                    {
                        Mass[i] = slove[i].Length;

                    }


                }

                int MAX = Mass.Min();

                Console.WriteLine("Максимальная длина: " + MAX);
                Console.ReadLine();
            }

            void Task_50()
            {
                Console.WriteLine("Введите строку (на русском): ");
                string S = Convert.ToString(Console.ReadLine());

                char[] chars = S.ToCharArray();

                for (int i = 0; i < S.Length / 2; i++)
                {
                    char ch = chars[i];
                    chars[i] = chars[S.Length - i - 1];
                    chars[S.Length - i - 1] = ch;
                }



                S = new string(chars);




                Console.WriteLine(S);

                Console.ReadLine();
            }

            void Task_54()
            {

                char[] glas = new char[] { 'А', 'О', 'У', 'Ы', 'Э', 'Е', 'Ё', 'И', 'Ю', 'Я' };

                char[] glas1 = new char[] { 'а', 'о', 'у', 'ы', 'э', 'е', 'ё', 'и', 'ю', 'я' };


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


            void Task_60()
            {
                
                Console.WriteLine("Введите путь к файлу: ");
                text = Convert.ToString(Console.ReadLine());

                string[] arr = text.Split('\\');

                int c = arr.Count();

                for (int i = 0; i < arr.Length; i++)
                {


                    if (c > 2)
                    {

                        Console.WriteLine(arr[i]);
                    }
                    else
                        Console.WriteLine("Введите пожалуйста: " + "\\");




                }



                Console.ReadKey();
            }


           


            void Task_65()
            {
                Console.WriteLine("Введите зашифрованную строку: ");
                string s = Console.ReadLine();

                Console.WriteLine("Введите первый расшифрованый символ: ");
                char c = Console.ReadKey().KeyChar;

                int k = s[0] - c;

                Console.WriteLine("\nКодовое смещение = " + k);

                Console.Write("Расшифрованная строка: \n{0}", string.Concat(s.Select(n => (char)(n - k)).ToArray()));

                Console.ReadLine();
            }


            void Bonus()
            {

                char[] glas = new char[] { 'А', 'О', 'У', 'Ы', 'Э', 'Е', 'Ё', 'И', 'Ю', 'Я' };
                char[] glas1 = new char[] { 'а', 'о', 'у', 'ы', 'э', 'е', 'ё', 'и', 'ю', 'я' };

                char[] sogl = new char[] { 'Б', 'В', 'Г', 'Д', 'Ж', 'З', 'Й', 'К', 'Л', 'М', 'Н', 'П', 'Р', 'С', 'Т', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ' };
                char[] sogl1 = new char[] { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };

                
                Console.WriteLine("Введите строку: ");
                text = Convert.ToString(Console.ReadLine());

                int max = int.MinValue;
                int max1 = int.MinValue;



                int ind = 0;
                int ind1 = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    for (int j = 0, l = 0; j < glas.Length && l < glas1.Length; j++, l++)
                    {
                        if (text[i] == glas[j] || text[i] == glas1[l] && text[i] > max)
                        {
                            ind++;
                            max = ind;
                        }
                    }


                    for (int j = 0, l = 0; j < sogl.Length && l < sogl1.Length; j++, l++)
                        if (text[i] == sogl[j] || text[i] == sogl1[l] && text[i] > max1)
                        {
                            ind1++;
                            max1 = ind1;
                        }



                }


                if (max > max1)
                {
                    Console.WriteLine("\n Количество букв равно {0}", max);

                }
                else if (max < max1)
                {
                    Console.WriteLine("\n Количество букв равно {0}", max1);
                }

                Console.ReadKey();
            }





        }
    }
}
