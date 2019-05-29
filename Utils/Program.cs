using System;
using Utils.DataTypes;
using System.Xml;
using System.Collections.Generic;

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

            string path = @"C:\Users\Michael\source\repos\OregonLoader\OregonLoader\input.xml";

            XMLParty xmp = new XMLParty(path);
           string s= xmp.getValue("purchasePrice");
            List<string> l = new List<string>();
            l.Add("saveForLater");
            l.Add("register");
            l.Add("vehicleId");
            l.Add("userId");
            l.Add("terminalId");
            l.Add("rental");
            l.Add("saleTypidId");
            l.Add("saleDate");
            l.Add("purchasePrice");
            l.Add("owner1Type");
            l.Add("owner1Number");
            l.Add("owner1FirstName");
            l.Add("owner1LastName");
            l.Add("owner1MiddleName");
            l.Add("owner1AddrStree");
            l.Add("owner1AddrCity");
            l.Add("owner1AddrCountyId");
            l.Add("owner1AddrStateId");
            l.Add("owner1AddrZip");
            l.Add("deliveryType");
            l.Add("sih1");
            l.Add("sih2");
            l.Add("sih3");
            l.Add("eesFromCustomer");
            l.Add("deqCertDate");
            l.Add("deqCertStatus");
            l.Add("useExpediteInventory");
            l.Add("ria");
            l.Add("dealerNumber");
            l.Add("useTaxPaid");
            l.Add("useTaxExemptionId");
            l.Add("titlingDocumentId");
            l.Add("registrationActionId");
            l.Add("useTypeId");
          


            Dictionary<string, string> dct = xmp.getManyValues(l);

                
            


            
           


        }





        /*
        static void Main(string[] args)
        {

            string str = "He said to me, \"Hello, World\" , How are you?";

            str = "DEBIT,03 / 11 / 2019,\"BEST BUY #313, EVANSTON IL                    03/11\",-21.99,DEBIT_CARD,381.06,,";
            Stringer s = new Stringer();

          string s2=  s.removeCommaFromDoubleQuotes(str, "!@#");
            Console.WriteLine(str);
            Console.Write(s2);

            Console.ReadLine();
           
          

        }
        */
    }
}
