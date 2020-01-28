using System;
using System.Collections.Generic;

public class OpenweathermapData: WebData
{
	private string name = "openweathermap.org";
	private string key = "55fc030a936d5e205ca578d8a03011ba";
	private string addLink = "data/2.5/weather";
	private List<string> listNameParam = new List<string>() { "main", "temp" };
	private Dictionary<string, string> dictParam = new Dictionary<string, string>(){{ "key", "APPID" },
																							{ "city", "q"}};
	public OpenweathermapData()
	{
	}

	public string getName()
	{
		return name;
	}
	public string getKey()
	{
		return key;
	}
	public string getAddLink()
	{
		return addLink;
	}
	public List<string> getListNameParam()
	{
		return listNameParam;
	}
	public Dictionary<string, string> getDictParam()
	{
		return dictParam;
	}
}
