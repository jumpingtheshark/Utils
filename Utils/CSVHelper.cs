using System.Text;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System;




namespace Utils
{

    // todo: unit tests
    class CSVHelper
    {
   
        
        //todo
        public DataTable csv2DT(string path)
        {
            return new DataTable();

        }
        //strings inside double quotes don't get parsed in this function
        public List<string[]> csv2ListStringArrayDoubleQuotes(string path)
        {
            //nothing inside double quotes gets parsed.  
            // so, first get part inside double quotes, and then do the rest
            // you need to find this sequence { ," } and then return the substring till the closing {"} as a 
            // whole and keeps its position too... 
            // so you have to go in and count the commas or something.. sounds complicated
            // maybe for now it'll be easier just to get rid of the commas inside the descriptions altogether

            var l = new List<string[]>();
            return l;


        }


        public List<string[]> csv2ListStringArray(string path)
        {

            Filer f = new Filer();


            string[] file = f.readAllLines(path);

            var l = new List<string[]>();


            foreach (string line in file)
            {

                l.Add(line.Split(','));

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
