using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KolchakovDR.Sprint3.Task3.V19.Lib
{
    public class DataService : ISprint3Task3V19
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            char[] charArray = value.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == replaceable)
                {
                    charArray[i] = replacement;
                }
            }
            return new string(charArray);
        }
    }
}
