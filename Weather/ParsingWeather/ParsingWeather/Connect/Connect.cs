using System;
using System.IO;
using System.Net;

public class Connect
{
	private string web;
	private string city;
	private string queryCityName;
	private string queryKeyName;
	private string key;
	private string afterWeb;
	public Connect(string web, string city)
	{
		var webObj = DataLink.dicWebKey;
		var dataJson= DataLink.queryLink;
		if (webObj.Contains(web))
		{
			this.web = web;
			this.city = city;
			this.queryCityName = dataJson["query_city_name"][web];
			this.queryKeyName = dataJson["query_key_name"][web];
			this.key = dataJson["key"][web];
			this.afterWeb = dataJson["after_web"][web];
			connectingAsync();
		}
	}
	private static void connectingAsync()
	{
		WebRequest request = WebRequest.Create("http:weatherstack.com/current");
		request.Method = "POST";
		string sName = "query=moscow access_key&age=719d3fe6203f73509524e0bca348cb53";
		byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(sName);
		request.ContentType = "application/x-www-form-urlencoded";
		request.ContentLength = byteArray.Length;

		using (System.IO.Stream dataStream = request.GetRequestStream())
		{
			dataStream.Write(byteArray, 0, byteArray.Length);
		}
		/*WebResponse response =  request.GetResponseAsync();
		using (System.IO.Stream stream = response.GetResponseStream())
		{
			using (StreamReader reader = new StreamReader(stream))
			{
				Console.WriteLine(reader.ReadToEnd());
			}
		}
		response.Close();
		Console.WriteLine("Запрос выполнен...");*/

	}

}
