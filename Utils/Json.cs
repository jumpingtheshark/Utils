using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Utils
{
	class Jsoner
	{


		public static Dictionary<string,string>  dnr(string json)
		{
		
			json = Filer.readAllText(@"C:\a1\Utils\Utils\j1.json");
			//Dictionary<string, string> rv = JsonConvert.SerializeObject()
		return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary <string, string>>(json);


			
		}

	}
}
