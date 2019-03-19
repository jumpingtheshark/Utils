using System.Text;
using System.IO;
using System.Data;
using System.Collections.Generic;


namespace Utils
{
    class Utils
    {


        public string readAllText(string path)
        {
            string s= File.ReadAllText(path);
            return s;
        }

        public string[] readAllLines(string path)
        {

            string[] lines = File.ReadAllLines(path);
            return lines;
        }


        //todo
        public DataTable csv2DT(string path)
        {
            return new DataTable();

        }
       
        //todo 

        public List<string[]> csv2List1(string path)
        {
            return new List<string[]>();

        }


        public List<List<string>> csv2List2 (string path)
        {
            return new List<List<string>>();

        }


    }
}
