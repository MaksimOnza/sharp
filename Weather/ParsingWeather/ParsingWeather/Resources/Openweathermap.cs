using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

public class OpenweathermapResource: Resources
{
	private string accessKey;
	private string url ;

	string response;
	StreamReader reader;
	Stream streamResponse;
	HttpWebResponse HttpWResp;

	public OpenweathermapResource(string accessKey)
	{
		this.accessKey = accessKey;
	}

	public int GetTemperature(string city)
	{
		url = $"https://api.openweathermap.org/data/2.5/weather?APPID={accessKey}&q={city}";
		var request = (HttpWebRequest)WebRequest.Create(url);
		HttpWResp = (HttpWebResponse)request.GetResponse();
		streamResponse = HttpWResp.GetResponseStream();

		reader = new StreamReader(streamResponse);
		response = reader.ReadToEnd();
		reader.Close();
		reader.Dispose();
		JToken responseJson = JToken.Parse(response);
		JToken parse = responseJson.SelectToken("$..temp");
		return (int)parse-273;
	}
}
