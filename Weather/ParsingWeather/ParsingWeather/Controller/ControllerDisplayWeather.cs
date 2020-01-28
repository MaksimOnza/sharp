using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using ThirdParty.Json.LitJson;

public class ControllerDisplayWeather
{
	DisplayWeather displayWeather;
	ParserWeb parse;
	public ControllerDisplayWeather()
	{
		
	}
	public void start()
	{
		string city = getCitybName();
		string webName = getWebName();
		string url = $"http://api.{webName}/{TransitData.getAddLink()}?{TransitData.getNameQueryKey()}={TransitData.getKey()}&{TransitData.getNameQueryCity()}={city}";
		Connect connect = new Connect(webName, city, url);
		string response = connect.GetResponse();
		ParserWeb parser = TransitData.Parser(webName);
		JToken temp = parser.start(response);
		Console.WriteLine(temp);
		Console.ReadKey();
		//displayWeather.start(city);
	}
	
	 string getWebName()
	{
		return TransitData.webName;
	}
	 string getCitybName()
	{
		return TransitData.cityName;
	}
	
}
	


