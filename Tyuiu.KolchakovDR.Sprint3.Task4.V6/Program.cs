using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint3.Task4.V6.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint3.Task4.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskHG thg = new TaskHG(
                3,
                "Колчаков Д. Р.",
                "ИИПб-23-2",
                "Использование операторов continue и break в циклах",
                4,
                6,
                "На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=x/(cos(x)-sin(x)). При х = 0 прервать цикл.Полученные значения суммировать.");
            thg.printHeader();

            DataService ds = new DataService(); 

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);

            Console.WriteLine("Конец шага = " + stopValue);

            thg.printFooter();
            Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
