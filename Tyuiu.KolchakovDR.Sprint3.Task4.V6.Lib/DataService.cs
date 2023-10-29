using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KolchakovDR.Sprint3.Task4.V6.Lib
{
    public class DataService : ISprint3Task4V6
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x<=stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    //y=x/(cos(x)-sin(x))
                    res = res + x / (Math.Cos(x) - Math.Sin(x));
                }
            }
            return Math.Round(res,3); 
        }
    }
}
