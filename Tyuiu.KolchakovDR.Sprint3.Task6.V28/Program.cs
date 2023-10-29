using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint3.Task6.V28.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint3.Task6.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskHG thg = new TaskHG(
                3,
                "Колчаков Д. Р.",
                "ИИПб-23-2",
                "Обработка целочисленной информации",
                6,
                28,
                "Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [13, 19] количество всех делителей меньше 7."); 
            thg.printHeader();

            DataService ds = new DataService();

            int startValue = 13;
            int stopValue = 19;

            Console.WriteLine("Начало отрезка = " + startValue);

            Console.WriteLine("Конец отрезка = " + stopValue);

            thg.printFooter();
            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
