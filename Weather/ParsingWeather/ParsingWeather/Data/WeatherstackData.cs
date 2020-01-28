using System;
using System.Collections.Generic;

public class WeatherstackData : WebData
{
	private string name = "weatherstack.com";
	private string key = "719d3fe6203f73509524e0bca348cb53";
	private string addLink = "current";
	private List<string> listNameParam = new List<string>() { "current", "temperature" };
	private Dictionary<string, string> dictParam = new Dictionary<string, string>(){{ "key", "access_key" },
																					{ "city", "query"}};
	public WeatherstackData()
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
