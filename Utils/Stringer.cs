using System;
using System.Collections.Generic;
using System.Text;
using Utils.DataTypes;

namespace Utils
{

    // todo: unit tests
    class Stringer
    {


      
		public static string removeCharFromInterval(string line, char c1, char c2)
		{


			
			int p1 = line.IndexOf("\"");
			int p2 = line.IndexOf("\"", p1 + 1);
			var line2 = line.ToCharArray();
			for (int i = 0; i < line2.Length; i++)
			{

				if (i > p1 && i < p2 && line2[i] == c1)
					line2[i] = c2;

			}
			line = new string(line2);
			return line;
		}



		//get the index of the first double quote
		// get the index of the secon double quote
		// and remove commas from between the two
		// only works with a single set of quotes
		// assuming that there  is only one set of double quotes in the line
		public string removeCommaFromDoubleQuotes
            (
            string s,  
            string tempcomma
            )
        {

            Interval l = new Interval();
            l.x = s.IndexOf('"');
            l.y = s.LastIndexOf('"');

            //go through all the characters inside string and get the 

            Char[] carray = s.ToCharArray();
            int i = 0;
            StringBuilder sb = new StringBuilder();
            foreach (char c in carray)
            {
                // if we are in the red zone baby, do this
                if (i > l.x && i < l.y && c == ',')
                    sb.Append(tempcomma);
                else
                    sb.Append(c);
                i++;
            }

         
            return sb.ToString();
        }


    }


}
