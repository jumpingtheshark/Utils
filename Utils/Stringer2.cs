using System;
using System.Collections.Generic;
using System.Text;
using Utils.DataTypes;

namespace Utils
{

    // stuff left on the cutting room floor
    // the noise that gets chaffed off 
    // but becuase I am a hoarder I am not chucking it yet
    class Stringer2
    {


        public Interval quotesInterval(string s)
        {
            Interval xy = new Interval();
            int i = s.IndexOf('"');
            int j = s.IndexOf('"', i + 1);
            xy.x = i;
            xy.y = j;
            return xy;

        }




        // todo write a good description otherwise it will be confusing as fuck
        public Interval delimIntervalLengthRight(string s, string left, string right, int offset, string right2)
        {
            Interval xy = new Interval();

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

        public Interval delimIntervalLength(string s, string left, string right, int offset)
        {

            Interval xy = new Interval();
            int i = s.IndexOf(left);
            int j = s.IndexOf(right, i + offset);
            int length = (j - i) + 1;
            xy.x = i;
            xy.y = length;



            return xy;

        }




        public Interval delimInterval(string s, string left, string right, int offset)
        {
            Interval xy = new Interval();
            int i = s.IndexOf(left);
            int j = s.IndexOf(right, i + offset);
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
        public string RemoveInsideInterval(string s, int left, int right)
        {
            return "todo";

        }


        // only one double quoted part
        // this is a very weak and a very non generic function
        // written mostly just to parse a chase line
        public List<string> isolateDoubleQuotedPart(string s)
        {
            List<string> l = new List<string>();
            int i, j;



            return l;

        }



    }
}
