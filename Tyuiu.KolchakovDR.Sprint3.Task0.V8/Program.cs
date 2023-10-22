using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint3.Task0.V8.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint3.Task0.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskHG thg = new TaskHG(
                3,
                "Колчаков Д. Р.",
                "ИИПб-23-2",
                "Оператор цикла for",
                0,
                8,
                "Написать программу используя цикл for, которая вычисляет произведение ряда по формуле, при a = 0,25");
            thg.printHeader();

            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("Переменная Х = " + value);

            Console.WriteLine("Старт шага = " + startValue);

            Console.WriteLine("Конец шага = " + stopValue);

            thg.printFooter();
            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }


    }
    
}
