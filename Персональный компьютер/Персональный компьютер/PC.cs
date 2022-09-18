using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Персональный_компьютер.Hellp;
using Персональный_компьютер.Лабораторная_работа_1;

namespace Персональный_компьютер
{
    class PC
    {
       static public void Disck()
        {
            

            Console.WriteLine("Добро пожаловать");
            Console.WriteLine("Подождите пока загрузится образ диска 2 секунды.");
            Thread.Sleep(2000);

            string command;
            do
            {
               

                Console.Write("Введите команту (для выхода из диска введите команду exit) \n (для подсказки какие комманты существуют введите hellp)\n (для для очиски консоли clear):");
                command = Console.ReadLine();

              switch(command)
                {
                    case "hellp": hellp.Hellp(); break;
                    case "clear": Console.Clear(); break;

                    case "Task1":  Лабораторка_1.Triangle_1(); break;
                    case "Task2": Лабораторка_1.Triangle_2(); break;
                    case "Task3": Лабораторка_1.Circle_3(); break;
                    case "Task4": Лабораторка_1.Cubes_4(); break;

                    case "Task5": Console.WriteLine("Растояние между точек:" + Лабораторка_1.Point_5(1, 2, 3, 4)); break;
                    case "Task6": Лабораторка_1.Calculation_6(); break;
                    case "Task7": Лабораторка_1.Cubes1_7(); break;

                    case "Task8": Лабораторка_1.Triangle2_8(); break;
                    case "Task9": Лабораторка_1.Circle1_9(); break;

                    case "Task10": Лабораторка_1.Triangle3_10(); break;
                    case "Task11": Лабораторка_1.Triangle5_11(); break;
                    case "Task12": Лабораторка_1.Pairing_12(); break;

                    case "Task13": Лабораторка_1.Conus_13(); break;
                    case "Task14": Лабораторка_1.Numbers_14(); break;
                    case "Task15": Лабораторка_1.Time_15(); break;

                    case "Task16": Лабораторка_1.Massa_17(); break;
                    case "Task17": Лабораторка_1.Triangle4_16(); break;

                    case "Task18": Лабораторка_1.Progression_18(); break;
                    case "Task19": Лабораторка_1.Days_19(); break;
                    case "Task20": Лабораторка_1.Electricity_20(); break;
                    
                }



            } while (command != "exit");
        }






    }
}
