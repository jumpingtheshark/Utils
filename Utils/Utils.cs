using System.Text;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System;


namespace Utils
{
   public class Utils
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

        public List<string[]> csv2ListStringArray(string path)
        {

            string[] file = readAllLines(path);

             var l = new List<string[]>();
         

            foreach (string line in file )
            {

                l.Add(line.Split(','));

            }


            return l;
        }


        public List<List<string>> csv2ListList (string path)
        {
            return new List<List<string>>();

        }


        // todo 
        public  string datestring2string (string s)
        {

            return "";
        }

        public DateTime datestring2DateTime (string s)
        {

            return new DateTime();

        }
    }
}
