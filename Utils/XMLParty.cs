using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;



namespace Utils
{
    class XMLParty
    {
        //for now we'll work with one file at a time
        public string XML;
        public XmlDocument doc;       

        // you have to use the same stretch of text
        // and if you want something else, just make a new class
     public   XMLParty (string targetPath)
        {
         
            Filer f = new Filer();
            string s = f.readAllText(targetPath);
            XML = s;
            doc = new XmlDocument();
            doc.LoadXml(XML);


        }


        public string getValue (string tagName )
        {
             XmlNodeList list = doc.GetElementsByTagName(tagName);
            string value="";
            foreach (XmlNode node in list)
                value = node.InnerText;
            return value;


        }


        public Dictionary <string, string> getManyValues (List<string> l)
        {

            Dictionary<string, string> dct = new Dictionary<string, string>();
            foreach (string s in l)
            {
                dct.Add(s, getValue(s));

            }

            return dct;

        }



    }
}
