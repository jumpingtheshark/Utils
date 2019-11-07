using System.Text;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System;




namespace Utils
{

    // todo: unit tests
public     class CSVHelper
    {
   
        
        //todo
        public DataTable csv2DT(string path)
        {
            return new DataTable();

        }
        //strings inside double quotes don't get parsed in this function
       




        public static List<string[]> csv2ListStringArray(string path)
        {

            


            string[] file = Filer.readAllLines(path);

            var l = new List<string[]>();

			int i = 0;
			string line2;
			string[] line2arr;
            foreach (string line in file)
            {

            if (line.IndexOf("\"") == -1)
				l.Add(line.Split(','));
			else
				{
					line2 = Stringer.removeCharFromInterval(line, ',', '^');
					line2arr = line2.Split(',');
					for (i=0; i< line2arr.Length; i++)
						line2arr[i] = Stringer.removeCharFromInterval(line2arr[i], '^', ',');
					l.Add(line2arr);

					

				}

            }


            return l;
        }

        
        //todo
        public List<List<string>> csv2ListList(string path)
        {
            return new List<List<string>>();

        }



    }
}
