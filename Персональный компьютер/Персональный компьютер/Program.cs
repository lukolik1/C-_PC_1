using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace Персональный_компьютер
{
    static public class Program
    {

        const string Player1Chance = "Ходит Игрок 1: ";
        const string Player2Chance = "Ходит Игрок 2: ";
        const string WhoIsWho = "Игрок 1: X и Игрок 2: О";
        const string SorryNotEmpty = "Извините клетка {0} уже занята {1}";
        const string PleaseWait = "Подождите 2 секунды и продолжим...";
        const string RepeatInput = "Некорректный ввод! Введите число от 1 до 9 !";
        const string TheWinnerIS = "Игрок {0} победил!";

        const string NobodyWin = " Ничья!";
        const char Xmark = 'X'; //метка на поле "крестик"
        const char Omark = 'O'; //метка - "нолик
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; //по умолчанию ходит первый игрок
        static int choice;
        static int flag = 0;



        static void Main(string[] args)
        {

            do
            {
                Console.Clear();// Каждый раз в начале цикла очищаем экран консоли
                Console.WriteLine(WhoIsWho + "\n");//выводим статус строку

                Board();// вызываем функцию Board для прорисовки игрового поля

                Console.WriteLine();

                /******** тут будет располагаться код основной логики игры
                *********************************************************/
                flag = CheckWin();// вызываем функцию CheckWin для проверки кто победил


                if (player % 2 == 0)//проверяем чей ход и выводим сообщение
                    Console.Write(Player2Chance);
                else Console.Write(Player1Chance);

                //Вводим ход пользователя (номер клетки) и проверяем на корректность
                bool success = int.TryParse(Console.ReadLine(), out choice);
                if (!success || choice < 1 || choice > 9)
                {
                    Console.WriteLine(RepeatInput);
                    Thread.Sleep(2000);
                    //не корректный ввод - игнорируем
                    continue;
                }
                //проверяем введенную пользователем клетку, а вдруг она занята?
                if (arr[choice] != Xmark && arr[choice] != Omark)
                {
                    //если ходит Игрок 2, то отмечаем клетку О, иначе отмечаем Х
                    if (player % 2 == 0) arr[choice] = Omark;
                    else arr[choice] = Xmark;
                    player++; //предоставляем ход следующему Игроку
                }
                else
                //Если в выбранной позиции уже есть нолик или крестик, сообщаем об этом,
                // далее ждем 2 секунды и перегружаем опять игровую доску
                {
                    Console.WriteLine(SorryNotEmpty, choice, arr[choice]);
                    Console.WriteLine(PleaseWait); Thread.Sleep(2000); //ждем 2 сек.
                }
            }while (flag != 1 && flag != -1);            



        }




        private static void Board()
        {
            Console.WriteLine(" | | ");
            Console.WriteLine(" {0} | {1} | {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine(" | | ");
            Console.WriteLine(" {0} | {1} | {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine(" | | ");
            Console.WriteLine(" {0} | {1} | {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine(" | | ");
        }





        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Проверяем первую строку
            if (arr[1] == arr[2] && arr[2] == arr[3]) return 1;
            //Проверяем вторую строку
            else if (arr[4] == arr[5] && arr[5] == arr[6]) return 1;
            //Проверяем третью строку
            else if (arr[7] == arr[8] && arr[8] == arr[9]) return 1;
            #endregion
            #region vertical Winning Condtion
            //Проверяем первый столбец
            else if (arr[1] == arr[4] && arr[4] == arr[7]) return 1;
            //Проверяем второй столбец
            else if (arr[2] == arr[5] && arr[5] == arr[8]) return 1;
            //Проверяем третий столбец
            else if (arr[3] == arr[6] && arr[6] == arr[9]) return 1;
            #endregion
            #region Diagonal Winning Condition
            //проверяем главную диагональ
            else if (arr[1] == arr[5] && arr[5] == arr[9]) return 1;
            //проверяем вторую диагональ
            else if (arr[3] == arr[5] && arr[5] == arr[7]) return 1;
            #endregion
            #region Checking For Draw
            else
            {
                for (int i = 1; i < 10; i++)//проходим по игровому полю
                                            //если есть не занятые клетки - игра продолжается
                    if (arr[i] != Xmark && arr[i] != Omark) return 0;

                return -1; // все клетки поля заполнены - ничья!
            }
            #endregion
        }













    }













}

















