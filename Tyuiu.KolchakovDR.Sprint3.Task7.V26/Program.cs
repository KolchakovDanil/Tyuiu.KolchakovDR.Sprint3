using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint3.Task7.V26.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint3.Task7.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskHG thg = new TaskHG(
                3,
                "Колчаков Д. Р.",
                "ИИПб-23-2",
                "Добавление к решению итоговых проектов по спринту",
                7,
                26,
                "Напиcсать программу, которая выводит таблицу значений функции: F(x) = 5 - 3x + (1 + sin(x))/(2x - 0.5");
            thg.printHeader();

            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);


            thg.printFooter();

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    f(x)  |");
            Console.WriteLine("+----------+----------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     | {1, 7:f2}  |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
