using System;
using System.Collections.Generic;

public static class TransitData
{
	public static string temperature = " not respons";
	public static string webName = "web not selected";
	public static string cityName = "city not selected";
	public static string key;
	public static string addLink;
	public static List<string> listNameOutputParam = new List<string>();
	public static Dictionary<string, string> dictRequestParam = new Dictionary<string, string>();
	public static string gettWeb()
    {
        return webName;
    }
    public static string getCity()
    {
        return cityName;
    }
    public static string getKey()
    {
        return key;
    }
    public static string getAddLink()
    {
        return addLink;
    }
    public static List<string> getListNameOutputParam()
    {
        return listNameOutputParam;
    }
    public static string getNameQueryCity()
    {
        return dictRequestParam["city"];
    }
    public static string getNameQueryKey()
    {
        return dictRequestParam["key"];
    }
 }
