using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint3.Task3.V19.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint3.Task3.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskHG thg = new TaskHG(
                3,
                "Колчаков Д. Р.",
                "ИИПб-23-2",
                "Оператор цикла foreach",
                3,
                19,
                "Используя цикл foreach заменить буквы x на цифру 2 в строке: sxxrrg x vfrx");
            thg.printHeader();

            DataService ds = new DataService();

            string value = "sxxrrg x vfrx";
            char replaceable = 'x';
            char replacement = '2';

            Console.WriteLine("Заданная строка = " + value);

            Console.WriteLine("Заменяемый символ = " + replaceable);

            Console.WriteLine("Символ замены = " + replacement);

            thg.printFooter();
            Console.WriteLine("Итоговая строка = " + ds.ReplaceCharOnNum(value, replaceable, replacement));
            Console.ReadKey();
        }
    }
}
