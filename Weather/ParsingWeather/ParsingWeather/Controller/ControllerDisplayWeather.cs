using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using ThirdParty.Json.LitJson;

public class ControllerDisplayWeather
{
	public ControllerDisplayWeather()
	{
		
	}
	public void start()
	{
		string city = getCitybName();
		string webName = getWebName();
		string url = $"http://api.{webName}/{TransitData.getAddLink()}?{TransitData.getNameQueryKey()}={TransitData.getKey()}&{TransitData.getNameQueryCity()}={city}";
		//Connect connect = new Connect(webName, city);
		connectToWeb(url);
	}
	
	 string getWebName()
	{
		return TransitData.webName;
	}
	 string getCitybName()
	{
		return TransitData.cityName;
	}
	void connectToWeb(string url)
	{
		var request = (HttpWebRequest)WebRequest.Create(url);
		HttpWebResponse HttpWResp = (HttpWebResponse)request.GetResponse();
		Stream streamResponse = HttpWResp.GetResponseStream();

		StreamReader reader = new StreamReader(streamResponse);
		string response = reader.ReadToEnd();
		reader.Close();
		reader.Dispose();

		string jsonStringsign = response;
		JsonData json = JsonMapper.ToObject(jsonStringsign);
		foreach (var item in TransitData.listNameOutputParam)
		{
			if (json != null)
			{
				var temp = json[item];
				json = temp;
			}
			else
			{
				Console.WriteLine(" -> json is null");
			}
		}		
		Console.WriteLine(json.ToString());
		Console.ReadKey();
	}
}
	


