using System;
using System.Collections.Generic;
using System.Text;
using Utils.DataTypes;

namespace Utils
{

    // todo: unit tests
    class Stringer
    {

        
        public string removeCommaFromDoubleQuotes(string s)
        {
            //get the index of the first double quote
            // get the index of the secon double quote
            // and remove commas from between the two
            // only works with a single set of quotes

            int i = s.IndexOf('"');
            int j = s.LastIndexOf('"');
            //go through all the characters inside string and get the 

            return "todo";

        }


       
        // todo write a good description otherwise it will be confusing as fuck
        public XY_int delimIntervalLengthRight(string s, string left, string right, int offset, string right2)
        {
            XY_int xy = new XY_int();


            int i = s.IndexOf(left);
            int j = s.IndexOf(right, i + offset);
            int k = s.IndexOf(right2, j);

            if (k > 0)
                j = k;

            int length = (j - i) + 1;
            xy.x = i;
            xy.y = length;



            return xy;

        }

        public XY_int delimIntervalLength(string s, string left, string right, int offset)
        {
            XY_int xy = new XY_int();
           

            int i = s.IndexOf(left);
            int j = s.IndexOf(right, i + offset);
            int length = (j - i)+1;
            xy.x = i;
            xy.y = length;



            return xy;

        }

        public XY_int delimInterval (string s, string left, string right, int offset)
        {
            XY_int xy = new XY_int();

            int i = s.IndexOf(left);
            int j = s.IndexOf(right, i+ offset);

            xy.x = i;
            xy.y = j;

            return xy;



        }


        // todo
        // probably an easier way of going ahead than trying to preserve the stupid comma
        // might make user of all the other functionaltiy
        // break up the string into three
        // incisve the quoted part
        // remove all the commas (or replace with "")
        // and then rebuild the string
        // that is probably easier because I don't have to worry about the commas on teh left or the right side. 
        // so I think I will do it this way..
        // too bad this only came to me on shabbos!
        public string RemoveInsideInterval (string s, int left, int right)
        {
            return "todo";

        }


        // only one double quoted part
        // this is a very weak and a very non generic function
        // written mostly just to parse a chase line
        public List<string> isolateDoubleQuotedPart (string s)
        {
            List<string> l = new List<string>();
            int i, j;



            return l;

        }
    }


}
