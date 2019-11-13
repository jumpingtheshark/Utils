using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{

    //todo unit tests
   public class Dater
    {


		public static bool BetweenInclusive (DateTime sdate, DateTime edate,  DateTime target )
		{
			if (
				(edate.Year >= target.Year && edate.Month >= target.Month && edate.Day >= target.Day)
				&&
				(sdate.Year <= target.Year && sdate.Month <= target.Month && sdate.Day <= target.Day)
				)
				return true;
			else
				return false;



		}

        // takes mm/dd/yyyy and gives back yyyymmdd
        public static string datestring2string(string s)
        {

            string[] sarray = s.Split('/');
            string month, date, year;
            month = sarray[0].PadLeft(2, '0');
            date = sarray[1].PadLeft(2, '0');
            year = sarray[2].PadLeft(4, '0');

            string sdate = year + month + date;
            return sdate;

        }

        public static DateTime datestring2DateTime(string s)
        {
            string[] sarray = s.Split('/');
            int month, date, year;
            month = Convert.ToInt16(sarray[0]);
            date = Convert.ToInt16(sarray[1]);
            year = Convert.ToInt16(sarray[2]);
			// let's make all the purchases happen at noon if we don't have the exact hour

			DateTime dt = new DateTime(year, month, date, 12, 15, 0);
            return dt;


        }

		public static string TimeStamp()
		{
			var sb = new StringBuilder();
			string s;
			sb.Append(DateTime.Now.Year.ToString());
			
			sb.Append(DateTime.Now.Month.ToString().PadLeft(2, '0'));
			sb.Append(DateTime.Now.Day.ToString().PadLeft(2, '0'));
			s =DateTime.Now.ToString("%h");
			sb.Append("_");
			sb.Append(s);
			sb.Append(DateTime.Now.Minute.ToString().PadLeft(2, '0'));
			



			return sb.ToString();


		}

    }
}
