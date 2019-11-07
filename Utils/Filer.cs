using System.Text;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System;
using System.Xml;


namespace Utils
{
	public class Filer
	{
		public static void writeAllText(string path, string text)
		{
			File.WriteAllText(path, text);

		}

        public static string readAllText(string path)
        {
            string s = File.ReadAllText(path);
            return s;
        }

        public static string[] readAllLines(string path)
        {

            string[] lines = File.ReadAllLines(path);
            return lines;
        }


        


    }
}
