using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint3.Task2.V25.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint3.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskHG thg = new TaskHG(
                3,
                "Колчаков Д. Р.",
                "ИИПб-23-2",
                "Оператор цикла do-while",
                2,
                25,
                "Написать программу используя цикл do...while, которая вычисляет сумму ряда по формуле, при n=5");
            thg.printHeader();

            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 13;
            int value = 5;
            Console.WriteLine("Переменная N = " + value);

            Console.WriteLine("Старт шага = " + startValue);

            Console.WriteLine("Конец шага = " + stopValue);

            thg.printFooter();
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
