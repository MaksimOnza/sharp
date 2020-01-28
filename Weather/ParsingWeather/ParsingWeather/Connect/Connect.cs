using System;
using System.IO;
using System.Net;

public class Connect
{
	string response;
	StreamReader reader;
	Stream streamResponse;
	HttpWebResponse HttpWResp;
		public Connect(string web, string city, string url)
	{
		var request = (HttpWebRequest)WebRequest.Create(url);
		HttpWResp = (HttpWebResponse)request.GetResponse();
		streamResponse = HttpWResp.GetResponseStream();

		reader = new StreamReader(streamResponse);
		response = reader.ReadToEnd();
		reader.Close();
		reader.Dispose();
	}

	public string GetResponse()
	{
		return response;
	}
	

}
