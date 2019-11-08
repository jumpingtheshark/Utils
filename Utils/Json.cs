using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Utils
{
	public class Jsoner
	{


		public static Dictionary<string,string>  dnr(string path)
		{
		
			var json = Filer.readAllText(path);
			//Dictionary<string, string> rv = JsonConvert.SerializeObject()
		return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary <string, string>>(json);


			
		}

	}
}
