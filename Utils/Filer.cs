using System.Text;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System;


namespace Utils
{
    class Filer
    {

        public string readAllText(string path)
        {
            string s = File.ReadAllText(path);
            return s;
        }

        public string[] readAllLines(string path)
        {

            string[] lines = File.ReadAllLines(path);
            return lines;
        }


    }
}
