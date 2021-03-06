﻿using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

public class WeatherstackResource: Resources
{
	private string accessKey;
	private string url ;

	string response;
	StreamReader reader;
	Stream streamResponse;
	HttpWebResponse HttpWResp;

	public WeatherstackResource(string accessKey)
	{
		this.accessKey = accessKey;
	}

	public int GetTemperature(string city)
	{
		url = $"http://api.weatherstack.com/current?access_key={accessKey}&query={city}";
		var request = (HttpWebRequest)WebRequest.Create(url);
		HttpWResp = (HttpWebResponse)request.GetResponse();
		streamResponse = HttpWResp.GetResponseStream();

		reader = new StreamReader(streamResponse);
		response = reader.ReadToEnd();
		reader.Close();
		reader.Dispose();
		JToken responseJson = JToken.Parse(response);
		JToken parse = responseJson.SelectToken("$..temperature");
		return (int)parse;
	}
}
