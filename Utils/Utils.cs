using System.Text;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System;

// TODO: Unit testing

namespace Utils
{
   public class UtilsClass
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


       

        // takes mm/dd/yyyy and gives back yyyymmdd
        public  string datestring2string (string s)
        {

            string[] sarray = s.Split('/');
            string month, date, year;
            month = sarray[0].PadLeft(2, '0');
            date = sarray[1].PadLeft(2, '0');
            year = sarray[2].PadLeft(4, '0');

            string sdate = year + month + date;
            return sdate;
            
        }

        public DateTime datestring2DateTime (string s)
        {
            string[] sarray = s.Split('/');
           int month, date, year;
            month =   Convert.ToInt16(sarray[0]);
            date = Convert.ToInt16(sarray[1]);
            year = Convert.ToInt16(sarray[2]);

            DateTime dt = new DateTime(year, month, date);
            return dt;
         

        }

        //todo
        public string removeCommaFromDoubleQuotes (string s)
        {
            //get the index of the first double quote
            // get the index of the secon double quote
            // and remove commas from between the two
            // only works with a single set of quotes

            int s1 = s.IndexOf('"');
            int s2 = s.LastIndexOf('"');
            //go through all the characters inside string and get the 

            

            return "";

        }
    }
}
