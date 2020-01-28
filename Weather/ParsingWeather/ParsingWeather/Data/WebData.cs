using System;
using System.Collections.Generic;

public interface WebData
{
	//public string webName;
	//public string cityName;
	//public string key;
	//public string addLink;
	public static List<string> listNameParam = new List<string>();
	public static Dictionary<string, string> dictParam = new Dictionary<string, string>();

	public string getName();

	public string getKey();
	
	public string getAddLink();
	
	public List<string> getListNameParam();
	
	public Dictionary<string, string> getDictParam();
	
}
