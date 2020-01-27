using System;
using System.Collections.Generic;

public class DataLink
{
	private static string web1 = "weatherstack.com";
	private static string web2 = "openweathermap.org";
	private static string web3 = "worldweatheronline.com";

	public static List<string> dicWebKey = new List<string>() { web1, web2, web3};
	public static Dictionary<string, Dictionary<string, string>> queryLink = new Dictionary<string, Dictionary<string, string>>(){
	{ "after_web", new Dictionary<string, string> { [web1] = "current", [web2] = "data/2.5/weather", [web3] = "premium/v1/weather.ashx"}},
	{ "query_key_name", new Dictionary<string, string> { [web1] = "access_key", [web2] = "APPID", [web3] = "format=json&key"}},
	{ "query_city_name", new Dictionary<string, string> { [web1] = "query", [web2] = "q", [web3] = "q"}},
	{ "key", new Dictionary<string, string> { [web1] = "719d3fe6203f73509524e0bca348cb53", [web2] = "55fc030a936d5e205ca578d8a03011ba", [web3] = "d48ab845d78e492081b192620202001"}},
	{ "first_level", new Dictionary<string, string> { [web1] = "current", [web2] = "main", [web3] = "data"}},
	{ "second_level", new Dictionary<string, string> { [web1] = "temperature", [web2] = "temp", [web3] = "current_condition"}},
	{ "third_level", new Dictionary<string, string> { [web1] = "", [web2] = "", [web3] = "0"}},
	{ "fourth_level", new Dictionary<string, string> { [web1] = "", [web2] = "", [web3] = "temp_C"}}};
	
	void s()
	{
		//Console.WriteLine(dicWebKey[web1][""]);
	}
}
