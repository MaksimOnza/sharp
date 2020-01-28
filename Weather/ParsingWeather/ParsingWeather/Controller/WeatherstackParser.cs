using Newtonsoft.Json.Linq;
using System;

public class WeatherstackParser:ParserWeb
{
	public WeatherstackParser()
	{
	}

	public JToken start(string response)
	{
		JToken responseJson = JToken.Parse(response);
		JToken parse = responseJson.SelectToken("$..temperature");

		return parse;
	}
}
