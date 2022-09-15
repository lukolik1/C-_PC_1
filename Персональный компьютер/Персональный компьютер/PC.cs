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
               

                Console.Write("Введите команту (для выхода из диска введите команду exit) \n (для подсказки какие комманты существуют введите hellp):");
                command = Console.ReadLine();

              switch(command)
                {
                    case "hellp": hellp.Hellp(); break;

                    case "Triangle":  Лабораторка_1.Triangle_1(); break;
                    case "Triangle1": Лабораторка_1.Triangle_2(); break;
                    case "Circle": Лабораторка_1.Circle_3(); break;
                    case "Cubes": Лабораторка_1.Cubes_4(); break;

                    case "Point": Console.WriteLine("Растояние между точек:" + Лабораторка_1.Point_5(1, 2, 3, 4)); break;
                    case "Calculation": Лабораторка_1.Calculation_6(); break;
                    case "Cubes1": Лабораторка_1.Cubes1_7(); break;

                    case "Triangle2": Лабораторка_1.Triangle2_8(); break;
                    case "Circle1": Лабораторка_1.Circle1_9(); break;

                    case "Triangle3": Лабораторка_1.Triangle3_10(); break;
                    case "Triangle5": Лабораторка_1.Triangle3_11(); break;
                    case "Pairing": Лабораторка_1.Pairing_12(); break;

                    case "Conus": Лабораторка_1.Conus_13(); break;
                    case "Numbers": Лабораторка_1.Numbers_14(); break;
                    case "Time": Лабораторка_1.Time_15(); break;

                    case "Massa": Лабораторка_1.Massa_17(); break;
                    case "Triangle4": Лабораторка_1.Triangle4_16(); break;

                    case "Progression": Лабораторка_1.Progression_18(); break;
                    case "Days": Лабораторка_1.Days_19(); break;
                    case "Electricity": Лабораторка_1.Electricity_20(); break;
                    
                }



            } while (command != "exit");
        }






    }
}
