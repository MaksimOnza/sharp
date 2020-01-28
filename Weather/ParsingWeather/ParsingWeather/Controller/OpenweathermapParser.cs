using Newtonsoft.Json.Linq;
using System;

public class OpenweathermapParser:ParserWeb
{
	public OpenweathermapParser()
	{
	}

	public JToken start(string response)
	{
		JToken responseJson = JToken.Parse(response);
		JToken parse = responseJson.SelectToken("$.main.temp");
		return parse;
	}
}
