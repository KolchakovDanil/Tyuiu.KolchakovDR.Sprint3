using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint3.Task5.V16.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint3.Task5.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskHG thg = new TaskHG(
                3,
                "Колчаков Д. Р.",
                "ИИПб-23-2",
                "Вложенные циклы",
                5,
                16,
                "Написать программу используя формулу 'y = 3Σ(i=1) 10Σ(k=1) cos(k) + x^2'");
            thg.printHeader();

            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine("Переменная N = " + x);

            Console.WriteLine("Старт шага первой суммы = " + startValue1);

            Console.WriteLine("Конец шага первой суммы = " + stopValue1);

            Console.WriteLine("Старт шага второй суммы = " + startValue2);

            Console.WriteLine("Конец шага второй суммы = " + stopValue2);

            thg.printFooter();
            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2));
            Console.ReadKey();
        }
    }
}
