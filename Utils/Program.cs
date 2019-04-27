using System;
using Utils.DataTypes;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "He said to me, \"Hello World\" , How are you?";
            Stringer s = new Stringer();
            XY_int xy = s.delimIntervalLengthRight(str, "\"", "\"", 2, ",");
            string str2 = str.Substring(xy.x, xy.y);
            string str3 = str.Remove(xy.x, xy.y);
            Console.WriteLine("{"+str2+ "}");
            Console.WriteLine(str3);

            string[] arr = str3.Split(',');
            Console.ReadLine();
           
            

        }
    }
}
