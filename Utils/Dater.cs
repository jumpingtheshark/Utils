using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{

    //todo unit tests
    class Dater
    {


        // takes mm/dd/yyyy and gives back yyyymmdd
        public string datestring2string(string s)
        {

            string[] sarray = s.Split('/');
            string month, date, year;
            month = sarray[0].PadLeft(2, '0');
            date = sarray[1].PadLeft(2, '0');
            year = sarray[2].PadLeft(4, '0');

            string sdate = year + month + date;
            return sdate;

        }

        public DateTime datestring2DateTime(string s)
        {
            string[] sarray = s.Split('/');
            int month, date, year;
            month = Convert.ToInt16(sarray[0]);
            date = Convert.ToInt16(sarray[1]);
            year = Convert.ToInt16(sarray[2]);

            DateTime dt = new DateTime(year, month, date);
            return dt;


        }


    }
}
