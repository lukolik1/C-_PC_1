using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Персональный_компьютер.Лабораторная_работа_1
{
    class Лабораторка_1
    {
      static public  void Triangle_1()
        {
            try
            {

                int a, b;
                int S, P;

                Console.Write("Первую длину:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Вторую длину:");
                b = Convert.ToInt32(Console.ReadLine());

                Console.Clear();


                P = (a + b) * 2;
                S = a * b;

                Console.WriteLine("Периметр прямоугольного треугольника:\t {0}", P);
                Console.WriteLine("Площадь прямоугольного треугольника:\t {0}", S);
            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }
        }

        static public void Triangle_2()
        {
            try
            {




                const int pow = 2;

                double x1, y1, x2, y2, x3, y3;
                double A, C, B, P, P1, S;

                Console.WriteLine("Первые кординаты (x1,y1):");
                x1 = Convert.ToInt32(Console.ReadLine());
                y1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Вторые кординаты (x2, y2):");
                x2 = Convert.ToInt32(Console.ReadLine());
                y2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Третие кординаты (x3, y3):");
                x3 = Convert.ToInt32(Console.ReadLine());
                y3 = Convert.ToInt32(Console.ReadLine());


                A = Math.Sqrt(Math.Pow(x2 - x1, pow) + Math.Pow(y2 - y1, pow));
                B = Math.Sqrt(Math.Pow(x3 - x2, pow) + Math.Pow(y3 - y2, pow));
                C = Math.Sqrt(Math.Pow(x3 - x1, pow) + Math.Pow(y3 - y1, pow));

                P = A + B + C;

                P1 = P / 2;

                S = Math.Sqrt(P1 * (P1 - A) * (P1 - B) * (P1 - C));


                Console.Clear();

                Console.WriteLine("Площадь:\t {0}", S);
                Console.WriteLine("Перемитр:\t {0}", P);

            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }


        }



        static public void Circle_3()
        {
            try
            {

                const double pi = 3.1415926535;
                double R, P, S;
                Console.WriteLine("Введите произвольный радиус:");
                R = Convert.ToDouble(Console.ReadLine());

                P = 2 * pi * R;
                S = pi * R * R;


                Console.WriteLine("Площадь произвольного треугольника:{0}\t\t", S);
                Console.WriteLine("Периметр произвольного треугольника:{0}\t\t", P);

            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }

        }


        static public void Cubes_4()
        {
            try
            {
                double x, y;

                Console.Write("Введите первое число:");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Средние арифметическая:{0} \t ", (x + y) / 2);
                Console.WriteLine("Средние геометрическое:{0} \t ", Math.Sqrt(x * y));

            }
            catch (Exception)
            {

                Console.WriteLine("Ввод не удался!");


            }

        }


        static public int Point_5(int x, int y, int x1, int y1)
        {

            const int pow = 2;

            int L;

            L = Convert.ToInt32(Math.Sqrt(Math.Pow(x - x1, pow) + Math.Pow(y - y1, pow)) );

            return L;


        }
       

       


        static public void Calculation_6()
        {
            try
            {

                double result = 1;

                Console.Write("Введите первое число:");
                double x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число:");
                double y = Convert.ToInt32(Console.ReadLine());

                Console.Clear();




                Console.Write("Введите операцию:");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+": Console.WriteLine("Сумма:{0}",  (x + y)); break;
                    case "*": Console.WriteLine("Умножение:{0}",  (x * y)); break;
                    case "/":
                        if (y == 0)
                        {
                            Console.WriteLine("Извените на 0 делить нельзя !");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Деление:{0}", (x / y)); break;
                        }
                    case "-": Console.WriteLine("Разность:{0}", (x - y)); break;
                    case "^": for (int i = 0; i < y; i++) {  result *=  x;  }; Console.WriteLine("Возветение в степень:{0}", result ); break;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }


        }

        static public void Cubes1_7()
        {
            try
            {
                Console.Write("Введите ребро куба:");
                int a = Convert.ToInt32(Console.ReadLine());

                double S = a * a;
                double S_point = 6 * S;
                double V = a * a * a;
                Console.WriteLine("Площадь грани\t{0}:", S);
                Console.WriteLine("Площадь полной поверхности:\t{0}", S_point);
                Console.WriteLine("Обьём\t{0}:", V);

            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }
        }


        static public void Triangle2_8()
        {
            try
            {
                double S, h, R, r;

                Console.Write("Введите первое число:");
                double a = Convert.ToInt32(Console.ReadLine());


                h = Math.Sqrt(3) / 2 * a;
                S = Math.Sqrt(3) / 4 * a * a;
                R = Math.Sqrt(3) / 3 * a;
                r = Math.Sqrt(3) / 6 * a;

                Console.WriteLine("Высота:{0}\t", h);
                Console.WriteLine("Площадь:{0}\t", S);
                Console.WriteLine("r=:{0}\t", r);
                Console.WriteLine("R=:{0}\t", R);






            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }
        }


        static public void Circle1_9()
        {
            try
            {
                const double pi = 3.1415926535;
                double S;
                Console.Write("Радиус:");
                double R = Convert.ToInt32(Console.ReadLine());
                S = Convert.ToInt32(pi * R * R);
                Console.WriteLine("Площадь:\t {0}", S);
            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }
        }

        static public void Triangle3_10()
        {
            try
            {



                const double pi = 3.1415926535;


                Console.Write("Введите первое число:");
                double a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число:");
                double b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите третие число:");
                double alpha = Convert.ToInt32(Console.ReadLine());

                double S;
                alpha = (alpha * pi) / 180.0;
                S = (1.0 / 2.0) * (Math.Sqrt(b) - Math.Sqrt(a)) * Math.Tan(alpha);
                Console.WriteLine("Площадь: {0}\t", S);
            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }


        }


        static public void Triangle5_11()
        {
            try
            {
                
                Console.Write("Введите сторону (a):");
                double a = Convert.ToInt32(Console.ReadLine());


                Console.Write("Введите сторону (b):");
                double b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите угол между ними (j):");
                double j = Convert.ToInt32(Console.ReadLine());


                if(a == b)
                    Console.WriteLine("Площадь:\t {0}", 1.0 / 2.0 * a * b * Math.Sin(j));
                
                else
                    Console.WriteLine("Некоретный ввод !");




              


            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }


        }


        static public void Pairing_12()
        {
            try
            {

                Console.Write("Введите первое сопротивление:");
                double R1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе сопротивление:");
                double R2 = Convert.ToInt32(Console.ReadLine());


                Console.Write("Введите третие сопротивление:");
                double R3 = Convert.ToInt32(Console.ReadLine());

                double R;

                R = (R1 * R2 * R3) / ((R1 * R2) + (R2 * R3) + (R3 * R1));

                Console.WriteLine("Сопротивление соединение:{0}\t", R);
            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }

        }


        static public void Conus_13()
        {
            try
            {
                const double pi = 3.1415926535;

                double R, H, Vcilcnder, Vconus;

                Console.Write("Радиус:");
                 R = Convert.ToDouble(Console.ReadLine());

                Console.Write("Высота:");
                H = Convert.ToDouble(Console.ReadLine());

                if(R == H)
                {
                    Vcilcnder = pi * Math.Sqrt(R) * H;
                    Vconus = (1.0 / 3.0) * pi * Math.Sqrt(R) * H;
                    Console.WriteLine("Обьём конуса:\t {0}", Vconus);
                    Console.WriteLine("Обьём цилиндра:\t {0}", Vcilcnder);

                }
                else
                {
                    Console.WriteLine("Введите одинакую высоту и радиус !");
                }



            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }
        }


        static public void Numbers_14()
        {
            try
            {
                double C, C1;

                Console.Write("Введите первое число:");
                double A = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите первое число:");
                double B = Convert.ToInt32(Console.ReadLine());

                 C = (A * A) + (B * B) / 2.0;
                 C1 = Math.Sqrt(Math.Abs(A) * Math.Abs(B));

                Console.WriteLine("Средние арифметическое:\t {0}", C);
                Console.WriteLine("Средние геометрическое:\t {0}", C1);



            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }
        }

        static public void Time_15()
        {
            try
            {

                const double g = 9.8;

                Console.Write("Введите высоту:");
                double h = Convert.ToInt32(Console.ReadLine());

                double t = Math.Sqrt(2.0 * h / g);

                Console.WriteLine("Время падения:\t {0}", t);

            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }


        }



        static public void Triangle4_16()
        {
            try
            {

                Console.Write("Введите сторону:");
                double a = Convert.ToInt32(Console.ReadLine());

                double S = (Math.Sqrt(3.0)/4.0)* Math.Sqrt(a) ;

                Console.WriteLine("Площадь:\t {0}", S);


            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }
        }


        static public void Massa_17()
        {
            try
            {
                 double G = 6.61 * Math.Pow(10, -11);


                Console.Write("Введите массу первую:");
                double m1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите массу вторую:");
                double m2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите радиус:");
                int R = Convert.ToInt32(Console.ReadLine());


                double F = G * (m1 * m2 / R * R);

                Console.WriteLine("Сила придяжения {0}\t:", F);

            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }
        }


        static public void Progression_18()
        {
            try
            {
                Console.Write("Введите  первый член:");
                double a1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите разность:");
                double d = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите число членов прогресси:");
                double n = Convert.ToInt32(Console.ReadLine());


                double S = (2.0 * a1 + d * (n - 1.0)/2.0) * n;

                Console.WriteLine("Прогрессия {0}\t:", S);
            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }
        }

        static public void Days_19()
        {
            try
            {
                int a, b;
                Console.Write("Введите  год рождения:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите  текущий год:");
                b = Convert.ToInt32(Console.ReadLine());

                if (a > b)
                {
                    a = (b - a) * 365;
                    Console.WriteLine("Примерно вы столько прожили дней {0}\t:", a);

                } else if (a > b)
                {
                    Console.WriteLine("Не правильно указаны год рождения и текущий год");
                }
                else
                {
                    a = a * 365;
                    Console.WriteLine("Примерно вы столько прожили дней {0}\t:", a);
                }





            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }
        }

        static public void Electricity_20()
        {
            try
            {


                double P, T, A, S;
                Console.Write("Мощность тока(КВт):");
                P = Convert.ToInt32(Console.ReadLine());

                Console.Write("Тариф (за услугу):");
                T = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите месяц:");
                string month = Convert.ToString(Console.ReadLine());

                switch (month)
                {
                    case "Январь": A = P * 31.0;  S = A * T; Console.WriteLine("Стоимость: {0}\t", S);  break;
                    case "Февраль": A = P * 28.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "Март": A = P * 31.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "Апрель": A = P * 30.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "Май": A = P * 31.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "Июнь": A = P * 30.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "Июль": A = P * 31.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "Август": A = P * 31.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "Сентябрь": A = P * 30.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "Октябрь": A = P * 31.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "Ноябрь": A = P * 30.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "Декабрь": A = P * 31.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;


                    case "январь": A = P * 31.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "февраль": A = P * 28.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "март": A = P * 31.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "апрель": A = P * 30.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "май": A = P * 31.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "июнь": A = P * 30.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "июль": A = P * 31.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "август": A = P * 31.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "сентябрь": A = P * 30.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "октябрь": A = P * 31.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "ноябрь": A = P * 30.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                    case "декабрь": A = P * 31.0; S = A * T; Console.WriteLine("Стоимость: {0}\t", S); break;
                }



            }
            catch (Exception)
            {
                Console.WriteLine("Ввод не удался!");
            }







        }






    }



}
