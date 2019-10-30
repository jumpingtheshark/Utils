using System;
using Utils.DataTypes;
using System.Xml;
using System.Collections.Generic;
using System.Text;

/*
 * 		node.Attributes[0].Name	"xsinil"	string
		node.Attributes[0].Value	"true"	string

 */

namespace Utils
{
    class Program
    {


        static void Main(string[] args)


		        {
			string charge = "DEBIT,3 / 11 / 2019,\"NUTELLA CAFE, CHI 001 CHICAGO IL             03/10\",-46.4,DEBIT_CARD,440.05,";

			string charge2=Stringer.removeCharFromInterval(charge, ',', '^');



			CSVHelper.csv2ListStringArray(@"c:\a2\f.csv");

   /*
   //char c1 = ',';
			char c2 = '^';

			string charge = "DEBIT,3 / 11 / 2019,\"NUTELLA CAFE, CHI 001 CHICAGO IL             03/10\",-46.4,DEBIT_CARD,440.05,";

			int p1 = charge.IndexOf("\"");
			int p2 = charge.IndexOf("\"", p1+1);
			var charge2 = charge.ToCharArray();
			for (int i =0; i<charge2.Length; i++)
			{

				if (i > p1 && i < p2 && charge[i] == c1)
					charge2[i] = c2;
					
			}
			charge = new string(charge2);


	*/		
            
           


		        }


    }
}
