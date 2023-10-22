using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint3.Task1.V10.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint3.Task1.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskHG thg = new TaskHG(
                3,
                "Колчаков Д. Р.",
                "ИИПб-23-2",
                "Оператор цикла while",
                1,
                10,
                "Написать программу используя цикл while, которая вычисляет сумму ряда по формуле, при х=5");
            thg.printHeader();

            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 17;
            int value = 5;
            Console.WriteLine("Переменная Х = " + value);

            Console.WriteLine("Старт шага = " + startValue);

            Console.WriteLine("Конец шага = " + stopValue);

            thg.printFooter();
            Console.WriteLine("Произведение ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
