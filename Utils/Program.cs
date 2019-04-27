using System;
using Utils.DataTypes;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "He said to me, \"Hello, World\" , How are you?";

            str = "DEBIT,03 / 11 / 2019,\"BEST BUY #313, EVANSTON IL                    03/11\",-21.99,DEBIT_CARD,381.06,,";
            Stringer s = new Stringer();

          string s2=  s.removeCommaFromDoubleQuotes(str, "!@#");
            Console.WriteLine(str);
            Console.Write(s2);

            Console.ReadLine();
           
            

        }
    }
}
